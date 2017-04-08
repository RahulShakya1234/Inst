namespace ERP.Masters
{
    partial class UserDetails
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
            this.txtOrderDate = new WinControlLibrary.BDateTextBox();
            this.ddlActive = new WinControlLibrary.BCombo();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtOrderNo = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.bCombo4 = new WinControlLibrary.BCombo();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.bCombo5 = new WinControlLibrary.BCombo();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.bCombo6 = new WinControlLibrary.BCombo();
            this.bLabel10 = new WinControlLibrary.BLabel();
            this.bCombo7 = new WinControlLibrary.BCombo();
            this.bLabel11 = new WinControlLibrary.BLabel();
            this.bDateTextBox1 = new WinControlLibrary.BDateTextBox();
            this.bDateTextBox2 = new WinControlLibrary.BDateTextBox();
            this.bDateTextBox3 = new WinControlLibrary.BDateTextBox();
            this.bTextBox1 = new WinControlLibrary.BTextBox();
            this.SuspendLayout();
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.AllowBlank = false;
            this.txtOrderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtOrderDate.Location = new System.Drawing.Point(90, 37);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(108, 20);
            this.txtOrderDate.TabIndex = 70;
            // 
            // ddlActive
            // 
            this.ddlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlActive.DisplayMember = "Value";
            this.ddlActive.FormattingEnabled = true;
            this.ddlActive.Location = new System.Drawing.Point(90, 94);
            this.ddlActive.Name = "ddlActive";
            this.ddlActive.Size = new System.Drawing.Size(108, 21);
            this.ddlActive.TabIndex = 68;
            this.ddlActive.ValueMember = "Code";
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel4.Location = new System.Drawing.Point(28, 95);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(48, 15);
            this.bLabel4.TabIndex = 67;
            this.bLabel4.Text = "Gender";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel5.Location = new System.Drawing.Point(15, 68);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(61, 15);
            this.bLabel5.TabIndex = 66;
            this.bLabel5.Text = "Password";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel2.Location = new System.Drawing.Point(15, 42);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(67, 15);
            this.bLabel2.TabIndex = 65;
            this.bLabel2.Text = "UserName";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtOrderNo.IsMendatory = false;
            this.txtOrderNo.Location = new System.Drawing.Point(90, 12);
            this.txtOrderNo.MaxLength = 50;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(108, 20);
            this.txtOrderNo.TabIndex = 63;
            this.txtOrderNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel1.Location = new System.Drawing.Point(24, 17);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(62, 15);
            this.bLabel1.TabIndex = 64;
            this.bLabel1.Text = "UserCode";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel3.Location = new System.Drawing.Point(43, 150);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(31, 15);
            this.bLabel3.TabIndex = 72;
            this.bLabel3.Text = "DOJ";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel6.Location = new System.Drawing.Point(43, 123);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(33, 15);
            this.bLabel6.TabIndex = 71;
            this.bLabel6.Text = "DOB";
            // 
            // bCombo4
            // 
            this.bCombo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bCombo4.DisplayMember = "Value";
            this.bCombo4.FormattingEnabled = true;
            this.bCombo4.Location = new System.Drawing.Point(90, 204);
            this.bCombo4.Name = "bCombo4";
            this.bCombo4.Size = new System.Drawing.Size(108, 21);
            this.bCombo4.TabIndex = 77;
            this.bCombo4.ValueMember = "Code";
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel7.Location = new System.Drawing.Point(4, 205);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(72, 15);
            this.bLabel7.TabIndex = 76;
            this.bLabel7.Text = "Department";
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel8.Location = new System.Drawing.Point(42, 177);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(32, 15);
            this.bLabel8.TabIndex = 75;
            this.bLabel8.Text = "DOL";
            // 
            // bCombo5
            // 
            this.bCombo5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bCombo5.DisplayMember = "Value";
            this.bCombo5.FormattingEnabled = true;
            this.bCombo5.Location = new System.Drawing.Point(90, 231);
            this.bCombo5.Name = "bCombo5";
            this.bCombo5.Size = new System.Drawing.Size(108, 21);
            this.bCombo5.TabIndex = 80;
            this.bCombo5.ValueMember = "Code";
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel9.Location = new System.Drawing.Point(4, 232);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(54, 15);
            this.bLabel9.TabIndex = 79;
            this.bLabel9.Text = "Location";
            // 
            // bCombo6
            // 
            this.bCombo6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bCombo6.DisplayMember = "Value";
            this.bCombo6.FormattingEnabled = true;
            this.bCombo6.Location = new System.Drawing.Point(90, 285);
            this.bCombo6.Name = "bCombo6";
            this.bCombo6.Size = new System.Drawing.Size(108, 21);
            this.bCombo6.TabIndex = 84;
            this.bCombo6.ValueMember = "Code";
            // 
            // bLabel10
            // 
            this.bLabel10.AutoSize = true;
            this.bLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel10.Location = new System.Drawing.Point(4, 286);
            this.bLabel10.Name = "bLabel10";
            this.bLabel10.Size = new System.Drawing.Size(81, 15);
            this.bLabel10.TabIndex = 83;
            this.bLabel10.Text = "SoftwareRole";
            // 
            // bCombo7
            // 
            this.bCombo7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bCombo7.DisplayMember = "Value";
            this.bCombo7.FormattingEnabled = true;
            this.bCombo7.Location = new System.Drawing.Point(90, 258);
            this.bCombo7.Name = "bCombo7";
            this.bCombo7.Size = new System.Drawing.Size(108, 21);
            this.bCombo7.TabIndex = 82;
            this.bCombo7.ValueMember = "Code";
            // 
            // bLabel11
            // 
            this.bLabel11.AutoSize = true;
            this.bLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel11.Location = new System.Drawing.Point(4, 259);
            this.bLabel11.Name = "bLabel11";
            this.bLabel11.Size = new System.Drawing.Size(73, 15);
            this.bLabel11.TabIndex = 81;
            this.bLabel11.Text = "Designation";
            // 
            // bDateTextBox1
            // 
            this.bDateTextBox1.AllowBlank = false;
            this.bDateTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bDateTextBox1.Location = new System.Drawing.Point(90, 63);
            this.bDateTextBox1.Name = "bDateTextBox1";
            this.bDateTextBox1.Size = new System.Drawing.Size(108, 20);
            this.bDateTextBox1.TabIndex = 85;
            // 
            // bDateTextBox2
            // 
            this.bDateTextBox2.AllowBlank = false;
            this.bDateTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bDateTextBox2.Location = new System.Drawing.Point(90, 174);
            this.bDateTextBox2.Name = "bDateTextBox2";
            this.bDateTextBox2.Size = new System.Drawing.Size(108, 20);
            this.bDateTextBox2.TabIndex = 88;
            // 
            // bDateTextBox3
            // 
            this.bDateTextBox3.AllowBlank = false;
            this.bDateTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bDateTextBox3.Location = new System.Drawing.Point(90, 148);
            this.bDateTextBox3.Name = "bDateTextBox3";
            this.bDateTextBox3.Size = new System.Drawing.Size(108, 20);
            this.bDateTextBox3.TabIndex = 87;
            // 
            // bTextBox1
            // 
            this.bTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox1.IsMendatory = false;
            this.bTextBox1.Location = new System.Drawing.Point(90, 123);
            this.bTextBox1.MaxLength = 50;
            this.bTextBox1.Name = "bTextBox1";
            this.bTextBox1.Size = new System.Drawing.Size(108, 20);
            this.bTextBox1.TabIndex = 86;
            this.bTextBox1.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 406);
            this.Controls.Add(this.bDateTextBox2);
            this.Controls.Add(this.bDateTextBox3);
            this.Controls.Add(this.bTextBox1);
            this.Controls.Add(this.bDateTextBox1);
            this.Controls.Add(this.bCombo6);
            this.Controls.Add(this.bLabel10);
            this.Controls.Add(this.bCombo7);
            this.Controls.Add(this.bLabel11);
            this.Controls.Add(this.bCombo5);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.bCombo4);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.bLabel8);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.ddlActive);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.bLabel1);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public WinControlLibrary.BDateTextBox txtOrderDate;
        public WinControlLibrary.BCombo ddlActive;
        public WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BLabel bLabel2;
        public WinControlLibrary.BTextBox txtOrderNo;
        private WinControlLibrary.BLabel bLabel1;
        public WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel6;
        public WinControlLibrary.BCombo bCombo4;
        public WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel8;
        public WinControlLibrary.BCombo bCombo5;
        public WinControlLibrary.BLabel bLabel9;
        public WinControlLibrary.BCombo bCombo6;
        public WinControlLibrary.BLabel bLabel10;
        public WinControlLibrary.BCombo bCombo7;
        public WinControlLibrary.BLabel bLabel11;
        public WinControlLibrary.BDateTextBox bDateTextBox1;
        public WinControlLibrary.BDateTextBox bDateTextBox2;
        public WinControlLibrary.BDateTextBox bDateTextBox3;
        public WinControlLibrary.BTextBox bTextBox1;
    }
}