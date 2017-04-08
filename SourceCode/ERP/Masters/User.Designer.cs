namespace ERP.Masters
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.txtPassword = new WinControlLibrary.BTextBox();
            this.txtUserName = new WinControlLibrary.BTextBox();
            this.txtDOB = new WinControlLibrary.BDateTextBox();
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.txtDOL = new WinControlLibrary.BDateTextBox();
            this.txtDOJ = new WinControlLibrary.BDateTextBox();
            this.ddlSoftwareRole = new WinControlLibrary.BCombo();
            this.bLabel10 = new WinControlLibrary.BLabel();
            this.ddlDesig = new WinControlLibrary.BCombo();
            this.bLabel11 = new WinControlLibrary.BLabel();
            this.ddlLocation = new WinControlLibrary.BCombo();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.ddlDept = new WinControlLibrary.BCombo();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.ddlGender = new WinControlLibrary.BCombo();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPassword.IsMendatory = false;
            this.txtPassword.Location = new System.Drawing.Point(129, 64);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(208, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtUserName.IsMendatory = false;
            this.txtUserName.Location = new System.Drawing.Point(129, 37);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(208, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtDOB
            // 
            this.txtDOB.AllowBlank = false;
            this.txtDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDOB.Location = new System.Drawing.Point(129, 122);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(208, 20);
            this.txtDOB.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(262, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(169, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDOL
            // 
            this.txtDOL.AllowBlank = false;
            this.txtDOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDOL.Location = new System.Drawing.Point(129, 174);
            this.txtDOL.Name = "txtDOL";
            this.txtDOL.Size = new System.Drawing.Size(208, 20);
            this.txtDOL.TabIndex = 5;
            // 
            // txtDOJ
            // 
            this.txtDOJ.AllowBlank = false;
            this.txtDOJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDOJ.Location = new System.Drawing.Point(129, 148);
            this.txtDOJ.Name = "txtDOJ";
            this.txtDOJ.Size = new System.Drawing.Size(208, 20);
            this.txtDOJ.TabIndex = 4;
            // 
            // ddlSoftwareRole
            // 
            this.ddlSoftwareRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlSoftwareRole.DisplayMember = "Value";
            this.ddlSoftwareRole.FormattingEnabled = true;
            this.ddlSoftwareRole.Location = new System.Drawing.Point(129, 285);
            this.ddlSoftwareRole.Name = "ddlSoftwareRole";
            this.ddlSoftwareRole.Size = new System.Drawing.Size(208, 21);
            this.ddlSoftwareRole.TabIndex = 9;
            this.ddlSoftwareRole.ValueMember = "Code";
            // 
            // bLabel10
            // 
            this.bLabel10.AutoSize = true;
            this.bLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel10.Location = new System.Drawing.Point(32, 285);
            this.bLabel10.Name = "bLabel10";
            this.bLabel10.Size = new System.Drawing.Size(81, 15);
            this.bLabel10.TabIndex = 105;
            this.bLabel10.Text = "SoftwareRole";
            // 
            // ddlDesig
            // 
            this.ddlDesig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlDesig.DisplayMember = "Value";
            this.ddlDesig.FormattingEnabled = true;
            this.ddlDesig.Location = new System.Drawing.Point(129, 258);
            this.ddlDesig.Name = "ddlDesig";
            this.ddlDesig.Size = new System.Drawing.Size(208, 21);
            this.ddlDesig.TabIndex = 8;
            this.ddlDesig.ValueMember = "Code";
            // 
            // bLabel11
            // 
            this.bLabel11.AutoSize = true;
            this.bLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel11.Location = new System.Drawing.Point(43, 259);
            this.bLabel11.Name = "bLabel11";
            this.bLabel11.Size = new System.Drawing.Size(73, 15);
            this.bLabel11.TabIndex = 103;
            this.bLabel11.Text = "Designation";
            // 
            // ddlLocation
            // 
            this.ddlLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlLocation.DisplayMember = "Value";
            this.ddlLocation.FormattingEnabled = true;
            this.ddlLocation.Location = new System.Drawing.Point(129, 231);
            this.ddlLocation.Name = "ddlLocation";
            this.ddlLocation.Size = new System.Drawing.Size(208, 21);
            this.ddlLocation.TabIndex = 7;
            this.ddlLocation.ValueMember = "Code";
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel9.Location = new System.Drawing.Point(61, 231);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(54, 15);
            this.bLabel9.TabIndex = 101;
            this.bLabel9.Text = "Location";
            // 
            // ddlDept
            // 
            this.ddlDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlDept.DisplayMember = "Value";
            this.ddlDept.FormattingEnabled = true;
            this.ddlDept.Location = new System.Drawing.Point(129, 204);
            this.ddlDept.Name = "ddlDept";
            this.ddlDept.Size = new System.Drawing.Size(208, 21);
            this.ddlDept.TabIndex = 6;
            this.ddlDept.ValueMember = "Code";
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel7.Location = new System.Drawing.Point(43, 205);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(72, 15);
            this.bLabel7.TabIndex = 99;
            this.bLabel7.Text = "Department";
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel8.Location = new System.Drawing.Point(81, 177);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(32, 15);
            this.bLabel8.TabIndex = 98;
            this.bLabel8.Text = "DOL";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel3.Location = new System.Drawing.Point(82, 150);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(31, 15);
            this.bLabel3.TabIndex = 97;
            this.bLabel3.Text = "DOJ";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel6.Location = new System.Drawing.Point(82, 123);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(33, 15);
            this.bLabel6.TabIndex = 96;
            this.bLabel6.Text = "DOB";
            // 
            // ddlGender
            // 
            this.ddlGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlGender.DisplayMember = "Value";
            this.ddlGender.FormattingEnabled = true;
            this.ddlGender.Location = new System.Drawing.Point(129, 94);
            this.ddlGender.Name = "ddlGender";
            this.ddlGender.Size = new System.Drawing.Size(208, 21);
            this.ddlGender.TabIndex = 2;
            this.ddlGender.ValueMember = "Code";
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel4.Location = new System.Drawing.Point(67, 95);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(48, 15);
            this.bLabel4.TabIndex = 93;
            this.bLabel4.Text = "Gender";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel5.Location = new System.Drawing.Point(54, 68);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(61, 15);
            this.bLabel5.TabIndex = 92;
            this.bLabel5.Text = "Password";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel2.Location = new System.Drawing.Point(54, 42);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(67, 15);
            this.bLabel2.TabIndex = 91;
            this.bLabel2.Text = "UserName";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 376);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDOL);
            this.Controls.Add(this.txtDOJ);
            this.Controls.Add(this.ddlSoftwareRole);
            this.Controls.Add(this.bLabel10);
            this.Controls.Add(this.ddlDesig);
            this.Controls.Add(this.bLabel11);
            this.Controls.Add(this.ddlLocation);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.ddlDept);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.bLabel8);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.ddlGender);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.bLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public WinControlLibrary.BDateTextBox txtDOL;
        public WinControlLibrary.BDateTextBox txtDOJ;
        public WinControlLibrary.BCombo ddlSoftwareRole;
        public WinControlLibrary.BLabel bLabel10;
        public WinControlLibrary.BCombo ddlDesig;
        public WinControlLibrary.BLabel bLabel11;
        public WinControlLibrary.BCombo ddlLocation;
        public WinControlLibrary.BLabel bLabel9;
        public WinControlLibrary.BCombo ddlDept;
        public WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel8;
        public WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel6;
        public WinControlLibrary.BCombo ddlGender;
        public WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BLabel bLabel2;
        public WinControlLibrary.BAllButton btnCancel;
        public WinControlLibrary.BAllButton btnSave;
        public WinControlLibrary.BDateTextBox txtDOB;
        public WinControlLibrary.BTextBox txtUserName;
        public WinControlLibrary.BTextBox txtPassword;

    }
}