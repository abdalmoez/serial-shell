namespace SerialShell
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Acceptbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.defaultbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Acceptbtn
            // 
            this.Acceptbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Acceptbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Acceptbtn.Location = new System.Drawing.Point(216, 276);
            this.Acceptbtn.Name = "Acceptbtn";
            this.Acceptbtn.Size = new System.Drawing.Size(75, 23);
            this.Acceptbtn.TabIndex = 0;
            this.Acceptbtn.Text = "Ok";
            this.Acceptbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(297, 276);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 1;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(12, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propertyGrid1.Size = new System.Drawing.Size(360, 258);
            this.propertyGrid1.TabIndex = 2;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // defaultbtn
            // 
            this.defaultbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.defaultbtn.Location = new System.Drawing.Point(12, 276);
            this.defaultbtn.Name = "defaultbtn";
            this.defaultbtn.Size = new System.Drawing.Size(75, 23);
            this.defaultbtn.TabIndex = 3;
            this.defaultbtn.Text = "Default";
            this.defaultbtn.UseVisualStyleBackColor = true;
            this.defaultbtn.Click += new System.EventHandler(this.defaultbtn_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.Acceptbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbtn;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.defaultbtn);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Acceptbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Acceptbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button defaultbtn;
    }
}