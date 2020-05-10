namespace SerialShell.Base
{
    partial class KeyboardReader
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
            this.desc = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // desc
            // 
            this.desc.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.desc.Location = new System.Drawing.Point(12, 24);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(349, 36);
            this.desc.TabIndex = 0;
            this.desc.Text = "Press a key";
            this.desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyboardReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(376, 75);
            this.Controls.Add(this.desc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyboardReader";
            this.Resizable = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardReader_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyboardReader_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel desc;
    }
}