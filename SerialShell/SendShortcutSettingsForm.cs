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

namespace SerialShell
{
    public partial class SendShortcutSettingsForm : MetroForm
    {
        public SendShortcutSettingsForm()
        {
            InitializeComponent();
            initJostickGrid();
        }

     /*   private void updatecolumntype(int i,string type)
        {
            if (type == joystickGridSettings[3, i].ValueType.ToString())
                return;
            switch (type)
            {
                case "string":
                case "verbatim string":
                    joystickGridSettings[3, i] = new DataGridViewTextBoxCell();
                    break;
                case "float 32bits":
                    break;
                case "byte":
                    break;
                case "signed byte":
                    break;
                case "word":
                    break;
                case "signed word":
                    break;
                case "dword":
                    break;
                case "signed dword":
                    break;
            }

        }*/

        private void initJostickGrid()
        {

            string[] joystickbtnNames = { "Button 1", "Button 2", "Button 3", "Button 4", "L1", "L2", "L3", "R1", "R2", "R3", "Up", "Down", "Left", "Right", "Start", "Select" };
            string[] keyboardbtnNames = { "Ctrl + 0", "Ctrl + 1", "Ctrl + 2", "Ctrl + 3", "Ctrl + 4", "Ctrl + 5", "Ctrl + 6", "Ctrl + 7", "Ctrl + 8", "Ctrl + 9" };
            string[] datatype = { "string", "verbatim string", "float 32bits", "byte", "signed byte", "word", "signed word", "dword", "signed dword" };
            joystickGridSettings.NotifyCurrentCellDirty(false);
            joystickGridSettings.Rows.Add(16);
            for (int i = 0; i < 16; i++)
            {
                joystickGridSettings[0, i].Value = joystickbtnNames[i];
                (joystickGridSettings[1, i] as DataGridViewComboBoxCell).Items.Clear();
                (joystickGridSettings[1, i] as DataGridViewComboBoxCell).Items.AddRange(datatype);
                (joystickGridSettings[1, i] as DataGridViewComboBoxCell).Value = datatype[0];
                (joystickGridSettings[2, i] as DataGridViewCheckBoxCell).Value = "true";
                joystickGridSettings[3, i].Tag = 0;
            }

            keyboardGridSettings.NotifyCurrentCellDirty(false);
            keyboardGridSettings.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                keyboardGridSettings[0, i].Value = keyboardbtnNames[i];
                (keyboardGridSettings[1, i] as DataGridViewComboBoxCell).Items.Clear();
                (keyboardGridSettings[1, i] as DataGridViewComboBoxCell).Items.AddRange(datatype);
                (keyboardGridSettings[1, i] as DataGridViewComboBoxCell).Value = datatype[0];
                keyboardGridSettings[2, i].Tag = 0;
            }

        }

        private void GridSettings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).CurrentCell == null)
                return;

            if ((sender as DataGridView).CurrentCell.ColumnIndex == 1)
                using (var cell = ((sender as DataGridView).CurrentCell as DataGridViewComboBoxCell))
                {

                    int p=cell.Items.IndexOf(cell.Value),t=0;
                    if ((string)(sender as DataGridView).Tag == "JoystickShortcut")
                    {
                        if ((sender as DataGridView)[3, cell.RowIndex].Tag is int)
                            t = (int)((sender as DataGridView)[3, cell.RowIndex].Tag);
                        if (p == t)
                            return;
                        (sender as DataGridView)[3, cell.RowIndex].Tag = p;
                        if (p < 2)
                            (sender as DataGridView)[3, cell.RowIndex].Value = "";
                        else if (p == 2)
                            (sender as DataGridView)[3, cell.RowIndex].Value = "0,0";
                        else (sender as DataGridView)[3, cell.RowIndex].Value = "0";
                        (sender as DataGridView)[4, cell.RowIndex].Value = (sender as DataGridView)[3, cell.RowIndex].Value;
                    }
                    else if ((string)(sender as DataGridView).Tag == "KeyboardShortcut")
                    {
                        if ((sender as DataGridView)[2, cell.RowIndex].Tag is int)
                            t = (int)((sender as DataGridView)[2, cell.RowIndex].Tag);
                        if (p == t)
                            return;
                        (sender as DataGridView)[2, cell.RowIndex].Tag = p;
                        if (p < 2)
                            (sender as DataGridView)[2, cell.RowIndex].Value = "";
                        else if (p == 2)
                            (sender as DataGridView)[2, cell.RowIndex].Value = "0,0";
                        else (sender as DataGridView)[2, cell.RowIndex].Value = "0";
                    }
                }
        }

        private void GridSettings_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (((sender as DataGridView).CurrentCell.ColumnIndex == 3 )|| ((sender as DataGridView).CurrentCell.ColumnIndex == 4))
                if (SerialShell.Base.TypeCheck.isNotType((sender as DataGridView)[1, (sender as DataGridView).CurrentCell.RowIndex].Value as string, e.FormattedValue as string))
                {
                    MetroMessageBox.Show(this, "Error : Unvalid value.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
        }

        private void GridSettings_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (((sender as DataGridView).CurrentCell.ColumnIndex < 3) && ((string)(sender as DataGridView).Tag == "JoystickShortcut"))
                (sender as DataGridView).EndEdit();
            if (((sender as DataGridView).CurrentCell.ColumnIndex < 2) && ((string)(sender as DataGridView).Tag == "KeyboardShortcut"))
                (sender as DataGridView).EndEdit();        
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            joystickGridSettings.EndEdit();
            keyboardGridSettings.EndEdit();
        }

    }
}
