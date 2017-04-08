namespace ERP.SalePurchase
{
    partial class AccountGroupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountGroupAdd));
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.ddlPrimaryGroup = new WinControlLibrary.BCombo();
            this.txtGrpName = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtReferenceNumber = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.ddlPrintSummaryTrialBal = new WinControlLibrary.BCombo();
            this.btnClose = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.ShowError = new WinControlLibrary.BErrorProvider();
            this.ddlBType = new WinControlLibrary.BCombo();
            this.ddlType = new WinControlLibrary.BCombo();
            this.bLabel6 = new WinControlLibrary.BLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ShowError)).BeginInit();
            this.SuspendLayout();
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel4.Location = new System.Drawing.Point(39, 64);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(92, 15);
            this.bLabel4.TabIndex = 10;
            this.bLabel4.Text = "Primary Group :";
            // 
            // ddlPrimaryGroup
            // 
            this.ddlPrimaryGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlPrimaryGroup.DisplayMember = "Value";
            this.ddlPrimaryGroup.FormattingEnabled = true;
            this.ddlPrimaryGroup.Location = new System.Drawing.Point(135, 61);
            this.ddlPrimaryGroup.Name = "ddlPrimaryGroup";
            this.ddlPrimaryGroup.Size = new System.Drawing.Size(260, 21);
            this.ddlPrimaryGroup.TabIndex = 2;
            this.ddlPrimaryGroup.ValueMember = "Code";
            this.ddlPrimaryGroup.SelectedIndexChanged += new System.EventHandler(this.ddlPrimaryGroup_SelectedIndexChanged);
            // 
            // txtGrpName
            // 
            this.txtGrpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.txtGrpName.IsMendatory = false;
            this.txtGrpName.Location = new System.Drawing.Point(135, 25);
            this.txtGrpName.MaxLength = 50;
            this.txtGrpName.Name = "txtGrpName";
            this.txtGrpName.Size = new System.Drawing.Size(260, 20);
            this.txtGrpName.TabIndex = 1;
            this.txtGrpName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel1.Location = new System.Drawing.Point(39, 28);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(84, 15);
            this.bLabel1.TabIndex = 7;
            this.bLabel1.Text = "Group Name :";
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.txtReferenceNumber.IsMendatory = false;
            this.txtReferenceNumber.Location = new System.Drawing.Point(135, 100);
            this.txtReferenceNumber.MaxLength = 10;
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(74, 20);
            this.txtReferenceNumber.TabIndex = 3;
            this.txtReferenceNumber.Text = "0";
            this.txtReferenceNumber.TextType = WinControlLibrary.BTextBox.TextBoxType.IntegerType;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel2.Location = new System.Drawing.Point(39, 103);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(82, 15);
            this.bLabel2.TabIndex = 11;
            this.bLabel2.Text = "Refrence No :";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel3.Location = new System.Drawing.Point(253, 103);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(51, 15);
            this.bLabel3.TabIndex = 13;
            this.bLabel3.Text = "B-Type :";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel5.Location = new System.Drawing.Point(8, 135);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(212, 15);
            this.bLabel5.TabIndex = 16;
            this.bLabel5.Text = "Print Summary Only in Trial Balance  :";
            this.bLabel5.Click += new System.EventHandler(this.bLabel5_Click);
            // 
            // ddlPrintSummaryTrialBal
            // 
            this.ddlPrintSummaryTrialBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlPrintSummaryTrialBal.DisplayMember = "Value";
            this.ddlPrintSummaryTrialBal.FormattingEnabled = true;
            this.ddlPrintSummaryTrialBal.Location = new System.Drawing.Point(131, 153);
            this.ddlPrintSummaryTrialBal.Name = "ddlPrintSummaryTrialBal";
            this.ddlPrintSummaryTrialBal.Size = new System.Drawing.Size(78, 21);
            this.ddlPrintSummaryTrialBal.TabIndex = 5;
            this.ddlPrintSummaryTrialBal.ValueMember = "Code";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(325, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(249, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ShowError
            // 
            this.ShowError.ContainerControl = this;
            // 
            // ddlBType
            // 
            this.ddlBType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlBType.DisplayMember = "Value";
            this.ddlBType.FormattingEnabled = true;
            this.ddlBType.Location = new System.Drawing.Point(301, 100);
            this.ddlBType.Name = "ddlBType";
            this.ddlBType.Size = new System.Drawing.Size(94, 21);
            this.ddlBType.TabIndex = 4;
            this.ddlBType.ValueMember = "Code";
            // 
            // ddlType
            // 
            this.ddlType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlType.DisplayMember = "Value";
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Location = new System.Drawing.Point(301, 146);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(94, 21);
            this.ddlType.TabIndex = 6;
            this.ddlType.ValueMember = "Code";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel6.Location = new System.Drawing.Point(226, 147);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(75, 15);
            this.bLabel6.TabIndex = 18;
            this.bLabel6.Text = " Type(Cr/Dr) ";
            // 
            // AccountGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 251);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.ddlType);
            this.Controls.Add(this.ddlBType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.ddlPrintSummaryTrialBal);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.txtReferenceNumber);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.ddlPrimaryGroup);
            this.Controls.Add(this.txtGrpName);
            this.Controls.Add(this.bLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountGroupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Group Master";
            this.Load += new System.EventHandler(this.AccountGroupMasterAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BAllButton btnClose;
        private WinControlLibrary.BAllButton btnSave;
        private WinControlLibrary.BErrorProvider ShowError;
        public WinControlLibrary.BCombo ddlPrimaryGroup;
        public WinControlLibrary.BTextBox txtGrpName;
        public WinControlLibrary.BTextBox txtReferenceNumber;
        public WinControlLibrary.BCombo ddlPrintSummaryTrialBal;
        public WinControlLibrary.BCombo ddlBType;
        public WinControlLibrary.BLabel bLabel3;
        public WinControlLibrary.BLabel bLabel6;
        public WinControlLibrary.BCombo ddlType;
    }
}