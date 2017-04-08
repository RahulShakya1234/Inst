namespace ERP.VAT_Report
{
    partial class ST38PrintNew
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
            this.button1 =new WinControlLibrary.BButton();
            this.button3 =new WinControlLibrary.BButton();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.bTextBox1 = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bTextBox5 = new WinControlLibrary.BTextBox();
            this.button2 =new WinControlLibrary.BButton();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bTextBox2 = new WinControlLibrary.BTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 173;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 172;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(67, 72);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(69, 13);
            this.bLabel5.TabIndex = 169;
            this.bLabel5.Text = "From  Bill No.";
            // 
            // bTextBox1
            // 
            this.bTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox1.IsMendatory = false;
            this.bTextBox1.Location = new System.Drawing.Point(298, 69);
            this.bTextBox1.MaxLength = 50;
            this.bTextBox1.Name = "bTextBox1";
            this.bTextBox1.Size = new System.Drawing.Size(123, 20);
            this.bTextBox1.TabIndex = 167;
            this.bTextBox1.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(240, 72);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(57, 13);
            this.bLabel1.TabIndex = 168;
            this.bLabel1.Text = " To Bill no.";
            // 
            // bTextBox5
            // 
            this.bTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox5.IsMendatory = false;
            this.bTextBox5.Location = new System.Drawing.Point(137, 69);
            this.bTextBox5.MaxLength = 50;
            this.bTextBox5.Name = "bTextBox5";
            this.bTextBox5.Size = new System.Drawing.Size(101, 20);
            this.bTextBox5.TabIndex = 166;
            this.bTextBox5.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 174;
            this.button2.Text = "Preview";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(67, 28);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(62, 13);
            this.bLabel2.TabIndex = 176;
            this.bLabel2.Text = "Party Name";
            // 
            // bTextBox2
            // 
            this.bTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox2.IsMendatory = false;
            this.bTextBox2.Location = new System.Drawing.Point(137, 28);
            this.bTextBox2.MaxLength = 50;
            this.bTextBox2.Name = "bTextBox2";
            this.bTextBox2.Size = new System.Drawing.Size(101, 20);
            this.bTextBox2.TabIndex = 175;
            this.bTextBox2.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // ST38PrintNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 161);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.bTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.bTextBox1);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.bTextBox5);
            this.Name = "ST38PrintNew";
            this.Text = "ST38PrintNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox bTextBox1;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox bTextBox5;
        private System.Windows.Forms.Button button2;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox bTextBox2;
    }
}