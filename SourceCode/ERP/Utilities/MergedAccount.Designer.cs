namespace ERP.Utilities
{
    partial class MergedAccount
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
            this.btnClose = new WinControlLibrary.BButton();
            this.btnMerge = new WinControlLibrary.BButton();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtDeleteOldAcc = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtNewAcc = new WinControlLibrary.BTextBox();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtOldAccClosingbal = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(247, 105);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(149, 105);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(92, 36);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(6, 82);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(103, 13);
            this.bLabel2.TabIndex = 70;
            this.bLabel2.Text = " Delete Old Account";
            // 
            // txtDeleteOldAcc
            // 
            this.txtDeleteOldAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDeleteOldAcc.IsMendatory = false;
            this.txtDeleteOldAcc.Location = new System.Drawing.Point(114, 79);
            this.txtDeleteOldAcc.MaxLength = 50;
            this.txtDeleteOldAcc.Name = "txtDeleteOldAcc";
            this.txtDeleteOldAcc.Size = new System.Drawing.Size(127, 20);
            this.txtDeleteOldAcc.TabIndex = 3;
            this.txtDeleteOldAcc.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(37, 42);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(72, 13);
            this.bLabel1.TabIndex = 68;
            this.bLabel1.Text = "New Account";
            // 
            // txtNewAcc
            // 
            this.txtNewAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNewAcc.IsMendatory = false;
            this.txtNewAcc.Location = new System.Drawing.Point(114, 39);
            this.txtNewAcc.MaxLength = 50;
            this.txtNewAcc.Name = "txtNewAcc";
            this.txtNewAcc.Size = new System.Drawing.Size(256, 20);
            this.txtNewAcc.TabIndex = 2;
            this.txtNewAcc.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(37, 9);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(66, 13);
            this.bLabel7.TabIndex = 66;
            this.bLabel7.Text = "Old Account";
            // 
            // txtOldAccClosingbal
            // 
            this.txtOldAccClosingbal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtOldAccClosingbal.IsMendatory = false;
            this.txtOldAccClosingbal.Location = new System.Drawing.Point(114, 5);
            this.txtOldAccClosingbal.MaxLength = 50;
            this.txtOldAccClosingbal.Name = "txtOldAccClosingbal";
            this.txtOldAccClosingbal.Size = new System.Drawing.Size(256, 20);
            this.txtOldAccClosingbal.TabIndex = 1;
            this.txtOldAccClosingbal.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(23, 22);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(82, 13);
            this.bLabel3.TabIndex = 73;
            this.bLabel3.Text = "Closing balance";
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(27, 55);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(82, 13);
            this.bLabel4.TabIndex = 74;
            this.bLabel4.Text = "Closing balance";
            // 
            // MergedAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 146);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtDeleteOldAcc);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.txtNewAcc);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.txtOldAccClosingbal);
            this.Name = "MergedAccount";
            this.Text = "MergedAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BButton btnClose;
        private WinControlLibrary.BButton btnMerge;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtDeleteOldAcc;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtNewAcc;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BTextBox txtOldAccClosingbal;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel4;
    }
}