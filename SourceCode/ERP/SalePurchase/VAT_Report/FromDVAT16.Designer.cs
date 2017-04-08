namespace ERP.VAT_Report
{
    partial class FromDVAT16
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
            this.bTextBox8 = new WinControlLibrary.BTextBox();
            this.bTextBox7 = new WinControlLibrary.BTextBox();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bTextBox1 = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.button3 =new WinControlLibrary.BButton();
            this.button1 =new WinControlLibrary.BButton();
            this.SuspendLayout();
            // 
            // bTextBox8
            // 
            this.bTextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox8.IsMendatory = false;
            this.bTextBox8.Location = new System.Drawing.Point(112, 27);
            this.bTextBox8.MaxLength = 50;
            this.bTextBox8.Name = "bTextBox8";
            this.bTextBox8.Size = new System.Drawing.Size(100, 20);
            this.bTextBox8.TabIndex = 255;
            this.bTextBox8.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bTextBox7
            // 
            this.bTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox7.IsMendatory = false;
            this.bTextBox7.Location = new System.Drawing.Point(296, 27);
            this.bTextBox7.MaxLength = 50;
            this.bTextBox7.Name = "bTextBox7";
            this.bTextBox7.Size = new System.Drawing.Size(100, 20);
            this.bTextBox7.TabIndex = 254;
            this.bTextBox7.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Location = new System.Drawing.Point(243, 30);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(49, 13);
            this.bLabel9.TabIndex = 253;
            this.bLabel9.Text = "To Date:";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(44, 30);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(59, 13);
            this.bLabel2.TabIndex = 252;
            this.bLabel2.Text = "Form Date:";
            // 
            // bTextBox1
            // 
            this.bTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox1.IsMendatory = false;
            this.bTextBox1.Location = new System.Drawing.Point(112, 68);
            this.bTextBox1.MaxLength = 50;
            this.bTextBox1.Name = "bTextBox1";
            this.bTextBox1.Size = new System.Drawing.Size(100, 20);
            this.bTextBox1.TabIndex = 257;
            this.bTextBox1.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(44, 71);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(66, 13);
            this.bLabel1.TabIndex = 256;
            this.bLabel1.Text = "Report Type";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 258;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 259;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FromDVAT16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bTextBox1);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.bTextBox8);
            this.Controls.Add(this.bTextBox7);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.bLabel2);
            this.Name = "FromDVAT16";
            this.Text = "FromDVAT16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BTextBox bTextBox8;
        private WinControlLibrary.BTextBox bTextBox7;
        private WinControlLibrary.BLabel bLabel9;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox bTextBox1;
        private WinControlLibrary.BLabel bLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}