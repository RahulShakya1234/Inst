namespace ERP.Utilities
{
    partial class BackUp
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
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtFolder = new WinControlLibrary.BTextBox();
            this.ddlDrive = new System.Windows.Forms.ComboBox();
            this.btnBackUp = new WinControlLibrary.BButton();
            this.btnClose = new WinControlLibrary.BButton();
            this.SuspendLayout();
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(28, 64);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(36, 13);
            this.bLabel7.TabIndex = 48;
            this.bLabel7.Text = "Folder";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(28, 41);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(32, 13);
            this.bLabel6.TabIndex = 47;
            this.bLabel6.Text = "Drive";
            // 
            // txtFolder
            // 
            this.txtFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFolder.IsMendatory = false;
            this.txtFolder.Location = new System.Drawing.Point(82, 64);
            this.txtFolder.MaxLength = 50;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(127, 20);
            this.txtFolder.TabIndex = 2;
            this.txtFolder.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // ddlDrive
            // 
            this.ddlDrive.FormattingEnabled = true;
            this.ddlDrive.Location = new System.Drawing.Point(82, 38);
            this.ddlDrive.Name = "ddlDrive";
            this.ddlDrive.Size = new System.Drawing.Size(121, 21);
            this.ddlDrive.TabIndex = 1;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(43, 101);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(73, 36);
            this.btnBackUp.TabIndex = 3;
            this.btnBackUp.Text = "Back Up";
            this.btnBackUp.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(122, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 168);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.ddlDrive);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.txtFolder);
            this.Name = "BackUp";
            this.Text = "BackUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BTextBox txtFolder;
        private System.Windows.Forms.ComboBox ddlDrive;
        private WinControlLibrary.BButton btnBackUp;
        private WinControlLibrary.BButton btnClose;
    }
}