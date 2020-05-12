using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using SerialShell.Base;
using FontAwesome.Sharp;
using MetroFramework.Drawing;
using System.Drawing.Text;
using System.IO;

namespace SerialShell
{
    public partial class ShortcutSettingsForm : MetroForm
    {

        SerialShellSettings MySettings;

        string[] joystickbtnNames = { "Button 1", "Button 2", "Button 3", "Button 4", "L1", "L2", "L3", "R1", "R2", "R3", "Up", "Down", "Left", "Right", "Start", "Select" };
        string[] keyboardbtnNames = { "Ctrl + 0", "Ctrl + 1", "Ctrl + 2", "Ctrl + 3", "Ctrl + 4", "Ctrl + 5", "Ctrl + 6", "Ctrl + 7", "Ctrl + 8", "Ctrl + 9" };
        string[] datatype = { "string", "verbatim string", "hex", "float 32bits", "unsigned byte", "signed byte", "unsigned short", "signed short", "unsigned int", "signed int", "unsigned long", "signed long" };

        public ShortcutSettingsForm(SerialShellSettings MySettings)
        {
            InitializeComponent();
            this.MySettings = MySettings;
            InitJostickGrid();
        }

        private void InitJostickGrid()
        {

            joystickGridSettings.NotifyCurrentCellDirty(false);
            joystickGridSettings.Rows.Add(16);
            for (int i = 0; i < 16; i++)
            {
                joystickGridSettings[0, i].Value = MySettings.joystickDataConfig.Keys[i].KeyValue;//KeyValue
                joystickGridSettings[1, i].Value = MySettings.joystickDataConfig.Keys[i].DataType;//DataType
                joystickGridSettings[2, i].Value = MySettings.joystickDataConfig.Keys[i].DataPress;//DataPress
                joystickGridSettings[3, i].Value = MySettings.joystickDataConfig.Keys[i].DataRelease;//Datarelease
                joystickGridSettings[4, i].Value = MySettings.joystickDataConfig.Keys[i].EnableRepeat;//EnableRepeat
                joystickGridSettings[5, i].Value = MySettings.joystickDataConfig.Keys[i].DataRepeat;//DataRepeat
                joystickGridSettings[3, i].Tag = 0;
            }

            #region LoadkeyboardShortcutSettings
            if (MySettings.shortcutkeyboard.Count != 0)
            {
                keyboardGridSettings.NotifyCurrentCellDirty(false);
                keyboardGridSettings.Rows.Add(MySettings.shortcutkeyboard.Count);
                for (int i = 0; i < MySettings.shortcutkeyboard.Count; i++)
                {

                    keyboardGridSettings[0, i].Value = MySettings.shortcutkeyboard[i].KeyValue;//KeyValue
                    keyboardGridSettings[1, i].Value = MySettings.shortcutkeyboard[i].DataType;//DataType
                    keyboardGridSettings[2, i].Value = MySettings.shortcutkeyboard[i].DataPress;//DataPress
                    keyboardGridSettings[3, i].Value = MySettings.shortcutkeyboard[i].DataRelease;//Datarelease
                    keyboardGridSettings[4, i].Value = MySettings.shortcutkeyboard[i].EnableRepeat;//EnableRepeat
                    keyboardGridSettings[5, i].Value = MySettings.shortcutkeyboard[i].DataRepeat;//DataRepeat
                    keyboardGridSettings[3, i].Tag = 0;
                }
            }
            #endregion
            metroTabControl1_SelectedIndexChanged(this, new EventArgs());//Btn refresh
        }


        private void GridSettings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).CurrentCell == null)
                return;

            if ((sender as DataGridView).CurrentCell.ColumnIndex == 1)
                using (var cell = ((sender as DataGridView).CurrentCell as DataGridViewComboBoxCell))
                {

                    int p = cell.Items.IndexOf(cell.Value), t = 0;
                    if ((sender as DataGridView)[3, cell.RowIndex].Tag is int)
                        t = (int)((sender as DataGridView)[3, cell.RowIndex].Tag);
                    if (p == t)
                        return;
                    (sender as DataGridView)[3, cell.RowIndex].Tag = p;
                    if (p < 3)
                        (sender as DataGridView)[3, cell.RowIndex].Value = "";
                    else if (p == 3)
                        (sender as DataGridView)[3, cell.RowIndex].Value = "0,0";
                    else (sender as DataGridView)[3, cell.RowIndex].Value = "0";
                    (sender as DataGridView)[2, cell.RowIndex].Value = (sender as DataGridView)[3, cell.RowIndex].Value;
                    (sender as DataGridView)[5, cell.RowIndex].Value = (sender as DataGridView)[3, cell.RowIndex].Value;
                }
        }

        private void GridSettings_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (((sender as DataGridView).CurrentCell.ColumnIndex == 2) || ((sender as DataGridView).CurrentCell.ColumnIndex == 3) || ((sender as DataGridView).CurrentCell.ColumnIndex == 5))
                if (SerialShell.Base.TypeCheck.isNotType((sender as DataGridView)[1, (sender as DataGridView).CurrentCell.RowIndex].Value as string, e.FormattedValue as string))
                {
                    MetroMessageBox.Show(this, "Error : Unvalid value.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
        }


        private void GridSettings_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).CurrentCell.ColumnIndex < 2)
                (sender as DataGridView).EndEdit();        
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            joystickGridSettings.EndEdit();
            keyboardGridSettings.EndEdit();
            #region update joystick shortcut settings

            for (int i = 0; i < joystickGridSettings.RowCount; i++)
            {
                for (int j = 0; j < MySettings.joystickDataConfig.Keys.Count; j++)//sort of controller affect the order
                    if (MySettings.joystickDataConfig.Keys[j].KeyValue == (string)joystickGridSettings[0, i].Value)
                    {
                        MySettings.joystickDataConfig.Keys[j] = new KeyDataConfig(
                            (string)joystickGridSettings[0, i].Value,//KeyValue
                            (string)joystickGridSettings[1, i].Value,//DataType
                            (string)joystickGridSettings[2, i].Value,//DataPress
                            (string)joystickGridSettings[3, i].Value,//Datarelease
                            (string)joystickGridSettings[4, i].Value.ToString(),//EnableRepeat
                            (string)joystickGridSettings[5, i].Value //DataRepeat
                            );
                    }
            }

            #endregion
            #region update keyboard shortcut settings

            MySettings.shortcutkeyboard.Clear();
            for (int i = 0; i < keyboardGridSettings.RowCount; i++)
            {
                KeyDataConfig k = new KeyDataConfig(
                            (string)keyboardGridSettings[0, i].Value,//KeyValue
                            (string)keyboardGridSettings[1, i].Value,//DataType
                            (string)keyboardGridSettings[2, i].Value,//DataPress
                            (string)keyboardGridSettings[3, i].Value,//Datarelease
                            (string)keyboardGridSettings[4, i].Value.ToString(),//EnableRepeat
                            (string)keyboardGridSettings[5, i].Value //DataRepeat
                            );
                MySettings.shortcutkeyboard.Add(k);
            }

            #endregion
        }

        private void AddKeyBoardShortcutBtn_Click(object sender, EventArgs e)
        {
            KeyboardReader kbr = new KeyboardReader();
            if (kbr.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < keyboardGridSettings.Rows.Count; i++)
                    if (keyboardGridSettings[0, i].Value as String == kbr.keyData.ToString())
                    {
                        MetroMessageBox.Show(this, "Shortcut already exist!");
                        return;
                    }
                keyboardGridSettings.NotifyCurrentCellDirty(false);
                keyboardGridSettings.Rows.Add(1);
                keyboardGridSettings[0, keyboardGridSettings.Rows.Count - 1].Value = kbr.keyData.ToString();
                (keyboardGridSettings[1, keyboardGridSettings.Rows.Count - 1] as DataGridViewComboBoxCell).Items.Clear();
                (keyboardGridSettings[1, keyboardGridSettings.Rows.Count - 1] as DataGridViewComboBoxCell).Items.AddRange(datatype);
                (keyboardGridSettings[1, keyboardGridSettings.Rows.Count - 1] as DataGridViewComboBoxCell).Value = datatype[0];
                (keyboardGridSettings[2, keyboardGridSettings.Rows.Count - 1] as DataGridViewTextBoxCell).Value = "";
                keyboardGridSettings[2, keyboardGridSettings.Rows.Count - 1].Tag = 0;
                (keyboardGridSettings[3, keyboardGridSettings.Rows.Count - 1] as DataGridViewTextBoxCell).Value = "";
                (keyboardGridSettings[4, keyboardGridSettings.Rows.Count - 1] as DataGridViewCheckBoxCell).Value = "True";
                (keyboardGridSettings[5, keyboardGridSettings.Rows.Count - 1] as DataGridViewTextBoxCell).Value = "";
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addKeyBoardShortcutBtn.Visible = (metroTabControl1.SelectedIndex == 1);//Keyboard
            editKeyBoardShortcutBtn.Visible = (metroTabControl1.SelectedIndex == 1);//Keyboard
            deleteKeyBoardShortcutBtn.Visible = (metroTabControl1.SelectedIndex == 1);//Keyboard
        }

        private void IconBtn_MouseEnter(object sender, EventArgs e)
        {
            (sender as IconButton).IconColor = MetroPaint.ForeColor.Button.Hover(this.Theme);
        }

        private void IconBtn_MouseLeave(object sender, EventArgs e)
        {
            (sender as IconButton).IconColor = MetroPaint.GetStyleColor(this.Style);
        }

        private void SendShortcutSettingsForm_StyleChanged(object sender, EventArgs e)
        {
            setButtonAppearance(addKeyBoardShortcutBtn);
            setButtonAppearance(editKeyBoardShortcutBtn);
            setButtonAppearance(deleteKeyBoardShortcutBtn);
        }

        private void setButtonAppearance(IconButton icon_button)
        {
            icon_button.BackColor = MetroPaint.BackColor.Button.Normal(this.Theme);
            icon_button.FlatAppearance.BorderColor = MetroPaint.BorderColor.Button.Normal(this.Theme);
            icon_button.FlatAppearance.MouseOverBackColor = MetroPaint.BackColor.Button.Hover(this.Theme);
            icon_button.FlatAppearance.MouseDownBackColor = MetroPaint.BackColor.Button.Press(this.Theme);

            icon_button.IconColor = MetroPaint.GetStyleColor(this.Style);
        }

        private void editKeyBoardShortcutBtn_Click(object sender, EventArgs e)
        {
            if (keyboardGridSettings.CurrentCell != null)
            {
                KeyboardReader kbr = new KeyboardReader();
                if (kbr.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < keyboardGridSettings.Rows.Count; i++)
                        if (keyboardGridSettings[0, i].Value as string == kbr.keyData.ToString())
                        {
                            MetroMessageBox.Show(this, "Shortcut already exist!");
                            return;
                        }
                    keyboardGridSettings.NotifyCurrentCellDirty(false);
                    keyboardGridSettings[0, keyboardGridSettings.CurrentCell.RowIndex].Value = kbr.keyData.ToString();
                }
            }
        }

        private void deleteKeyBoardShortcutBtn_Click(object sender, EventArgs e)
        {
            if (keyboardGridSettings.CurrentCell != null)
                keyboardGridSettings.Rows.RemoveAt(keyboardGridSettings.CurrentCell.RowIndex);
        }
    }
}
