namespace ERP.SalePurchase
{
    partial class AccountView
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
            sForm = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountView));
            this.grdAccountDetails = new WinControlLibrary.BGrid();
            this.AccountMasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountGroupMasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistratnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACodeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commodity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collectorate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSTNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinSTNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdjBillWise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDSCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDSRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LockAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeofTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NatureofPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeofCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new WinControlLibrary.BAllButton();
            this.btnDelete = new WinControlLibrary.BAllButton();
            this.btnEdit = new WinControlLibrary.BAllButton();
            this.btnAdd = new WinControlLibrary.BAllButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlState = new WinControlLibrary.BCombo();
            this.ddlPrimaryGroup = new WinControlLibrary.BCombo();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new WinControlLibrary.BAllButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtByName = new WinControlLibrary.BTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccountDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdAccountDetails
            // 
            this.grdAccountDetails.AllowUserToAddRows = false;
            this.grdAccountDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.grdAccountDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAccountDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccountDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAccountDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountMasId,
            this.AccountName,
            this.State1,
            this.State,
            this.Address,
            this.MobileNo,
            this.Fax,
            this.AccountGroupMasId,
            this.AccountGroupName,
            this.Balance,
            this.BalanceType,
            this.BalanceTypeName,
            this.AccType,
            this.AccTypeName,
            this.ECCNo,
            this.STypeCode,
            this.PTypeCode,
            this.EMail,
            this.RegistratnNo,
            this.PLACodeNo,
            this.Commodity,
            this.Range,
            this.Division,
            this.Collectorate,
            this.PanNo,
            this.CSTNo,
            this.TinSTNo,
            this.CreditDays,
            this.AdjBillWise,
            this.TDSCategory,
            this.TDSRate,
            this.LockAccount,
            this.ModeofTransport,
            this.NatureofPay,
            this.typeOfSupplier,
            this.Country,
            this.Destination,
            this.CodeNo,
            this.Discount,
            this.TypeofCustomer,
            this.Location,
            this.InterestRate,
            this.Active,
            this.VenderCode});
            this.grdAccountDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAccountDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdAccountDetails.GridColor = System.Drawing.Color.DarkGray;
            this.grdAccountDetails.Index = 0;
            this.grdAccountDetails.Location = new System.Drawing.Point(12, 79);
            this.grdAccountDetails.MultiSelect = false;
            this.grdAccountDetails.Name = "grdAccountDetails";
            this.grdAccountDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccountDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAccountDetails.RowHeadersWidth = 19;
            this.grdAccountDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccountDetails.Size = new System.Drawing.Size(786, 280);
            this.grdAccountDetails.TabIndex = 3;
            this.grdAccountDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccountDetails_CellContentClick_2);
            this.grdAccountDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccountDetails_CellMouseEnter);
            this.grdAccountDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccountDetails_CellMouseLeave);
            // 
            // AccountMasId
            // 
            this.AccountMasId.DataPropertyName = "AccountMasId";
            this.AccountMasId.HeaderText = "AccountMasId";
            this.AccountMasId.Name = "AccountMasId";
            this.AccountMasId.ReadOnly = true;
            this.AccountMasId.Visible = false;
            this.AccountMasId.Width = 5;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "Account ";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            this.AccountName.Width = 130;
            // 
            // State1
            // 
            this.State1.DataPropertyName = "State1";
            this.State1.HeaderText = "State";
            this.State1.Name = "State1";
            this.State1.ReadOnly = true;
            this.State1.Width = 70;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State2";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Visible = false;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            // 
            // AccountGroupMasId
            // 
            this.AccountGroupMasId.DataPropertyName = "AccountGroupMasId";
            this.AccountGroupMasId.HeaderText = "Account Group";
            this.AccountGroupMasId.Name = "AccountGroupMasId";
            this.AccountGroupMasId.ReadOnly = true;
            this.AccountGroupMasId.Visible = false;
            this.AccountGroupMasId.Width = 5;
            // 
            // AccountGroupName
            // 
            this.AccountGroupName.DataPropertyName = "AccountGroupName";
            this.AccountGroupName.HeaderText = " Group";
            this.AccountGroupName.Name = "AccountGroupName";
            this.AccountGroupName.ReadOnly = true;
            this.AccountGroupName.Width = 140;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // BalanceType
            // 
            this.BalanceType.DataPropertyName = "BalanceType";
            this.BalanceType.HeaderText = "BalanceType";
            this.BalanceType.Name = "BalanceType";
            this.BalanceType.ReadOnly = true;
            this.BalanceType.Visible = false;
            this.BalanceType.Width = 5;
            // 
            // BalanceTypeName
            // 
            this.BalanceTypeName.DataPropertyName = "BalanceTypeName";
            this.BalanceTypeName.HeaderText = "Balance Type ";
            this.BalanceTypeName.Name = "BalanceTypeName";
            this.BalanceTypeName.ReadOnly = true;
            this.BalanceTypeName.Width = 120;
            // 
            // AccType
            // 
            this.AccType.DataPropertyName = "AccType";
            this.AccType.HeaderText = "AccType";
            this.AccType.Name = "AccType";
            this.AccType.ReadOnly = true;
            this.AccType.Visible = false;
            this.AccType.Width = 5;
            // 
            // AccTypeName
            // 
            this.AccTypeName.DataPropertyName = "AccTypeName";
            this.AccTypeName.HeaderText = "Acc Type";
            this.AccTypeName.Name = "AccTypeName";
            this.AccTypeName.ReadOnly = true;
            // 
            // ECCNo
            // 
            this.ECCNo.DataPropertyName = "ECCNo";
            this.ECCNo.HeaderText = "ECC No";
            this.ECCNo.Name = "ECCNo";
            this.ECCNo.ReadOnly = true;
            // 
            // STypeCode
            // 
            this.STypeCode.DataPropertyName = "STypeCode";
            this.STypeCode.HeaderText = "STypeCode";
            this.STypeCode.Name = "STypeCode";
            this.STypeCode.ReadOnly = true;
            this.STypeCode.Visible = false;
            this.STypeCode.Width = 5;
            // 
            // PTypeCode
            // 
            this.PTypeCode.DataPropertyName = "PTypeCode";
            this.PTypeCode.HeaderText = "PTypeCode";
            this.PTypeCode.Name = "PTypeCode";
            this.PTypeCode.ReadOnly = true;
            this.PTypeCode.Visible = false;
            this.PTypeCode.Width = 5;
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "EMail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            this.EMail.Visible = false;
            this.EMail.Width = 5;
            // 
            // RegistratnNo
            // 
            this.RegistratnNo.DataPropertyName = "RegistratnNo";
            this.RegistratnNo.HeaderText = "RegistratnNo";
            this.RegistratnNo.Name = "RegistratnNo";
            this.RegistratnNo.ReadOnly = true;
            this.RegistratnNo.Visible = false;
            this.RegistratnNo.Width = 5;
            // 
            // PLACodeNo
            // 
            this.PLACodeNo.DataPropertyName = "PLACodeNo";
            this.PLACodeNo.HeaderText = "PLACodeNo";
            this.PLACodeNo.Name = "PLACodeNo";
            this.PLACodeNo.ReadOnly = true;
            this.PLACodeNo.Visible = false;
            this.PLACodeNo.Width = 5;
            // 
            // Commodity
            // 
            this.Commodity.DataPropertyName = "Commodity";
            this.Commodity.HeaderText = "Commodity";
            this.Commodity.Name = "Commodity";
            this.Commodity.ReadOnly = true;
            this.Commodity.Visible = false;
            this.Commodity.Width = 5;
            // 
            // Range
            // 
            this.Range.DataPropertyName = "Range";
            this.Range.HeaderText = "Range";
            this.Range.Name = "Range";
            this.Range.ReadOnly = true;
            this.Range.Visible = false;
            this.Range.Width = 5;
            // 
            // Division
            // 
            this.Division.DataPropertyName = "Division";
            this.Division.HeaderText = "Division";
            this.Division.Name = "Division";
            this.Division.ReadOnly = true;
            this.Division.Visible = false;
            this.Division.Width = 5;
            // 
            // Collectorate
            // 
            this.Collectorate.DataPropertyName = "Collectorate";
            this.Collectorate.HeaderText = "Collectorate";
            this.Collectorate.Name = "Collectorate";
            this.Collectorate.ReadOnly = true;
            this.Collectorate.Visible = false;
            this.Collectorate.Width = 5;
            // 
            // PanNo
            // 
            this.PanNo.DataPropertyName = "PanNo";
            this.PanNo.HeaderText = "PanNo";
            this.PanNo.Name = "PanNo";
            this.PanNo.ReadOnly = true;
            this.PanNo.Visible = false;
            this.PanNo.Width = 5;
            // 
            // CSTNo
            // 
            this.CSTNo.DataPropertyName = "CSTNo";
            this.CSTNo.HeaderText = "CSTNo";
            this.CSTNo.Name = "CSTNo";
            this.CSTNo.ReadOnly = true;
            this.CSTNo.Visible = false;
            this.CSTNo.Width = 5;
            // 
            // TinSTNo
            // 
            this.TinSTNo.DataPropertyName = "TinSTNo";
            this.TinSTNo.HeaderText = "TinSTNo";
            this.TinSTNo.Name = "TinSTNo";
            this.TinSTNo.ReadOnly = true;
            this.TinSTNo.Visible = false;
            this.TinSTNo.Width = 5;
            // 
            // CreditDays
            // 
            this.CreditDays.DataPropertyName = "CreditDays";
            this.CreditDays.HeaderText = "CreditDays";
            this.CreditDays.Name = "CreditDays";
            this.CreditDays.ReadOnly = true;
            this.CreditDays.Visible = false;
            this.CreditDays.Width = 5;
            // 
            // AdjBillWise
            // 
            this.AdjBillWise.DataPropertyName = "AdjBillWise";
            this.AdjBillWise.HeaderText = "AdjBillWise";
            this.AdjBillWise.Name = "AdjBillWise";
            this.AdjBillWise.ReadOnly = true;
            this.AdjBillWise.Visible = false;
            this.AdjBillWise.Width = 5;
            // 
            // TDSCategory
            // 
            this.TDSCategory.DataPropertyName = "TDSCategory";
            this.TDSCategory.HeaderText = "TDSCategory";
            this.TDSCategory.Name = "TDSCategory";
            this.TDSCategory.ReadOnly = true;
            this.TDSCategory.Visible = false;
            this.TDSCategory.Width = 5;
            // 
            // TDSRate
            // 
            this.TDSRate.DataPropertyName = "TDSRate";
            this.TDSRate.HeaderText = "TDSRate";
            this.TDSRate.Name = "TDSRate";
            this.TDSRate.ReadOnly = true;
            this.TDSRate.Visible = false;
            this.TDSRate.Width = 5;
            // 
            // LockAccount
            // 
            this.LockAccount.DataPropertyName = "LockAccount";
            this.LockAccount.HeaderText = "LockAccount";
            this.LockAccount.Name = "LockAccount";
            this.LockAccount.ReadOnly = true;
            this.LockAccount.Visible = false;
            this.LockAccount.Width = 5;
            // 
            // ModeofTransport
            // 
            this.ModeofTransport.DataPropertyName = "ModeofTransport";
            this.ModeofTransport.HeaderText = "ModeofTransport";
            this.ModeofTransport.Name = "ModeofTransport";
            this.ModeofTransport.ReadOnly = true;
            this.ModeofTransport.Visible = false;
            this.ModeofTransport.Width = 5;
            // 
            // NatureofPay
            // 
            this.NatureofPay.DataPropertyName = "NatureofPay";
            this.NatureofPay.HeaderText = "NatureofPay";
            this.NatureofPay.Name = "NatureofPay";
            this.NatureofPay.ReadOnly = true;
            this.NatureofPay.Visible = false;
            this.NatureofPay.Width = 5;
            // 
            // typeOfSupplier
            // 
            this.typeOfSupplier.DataPropertyName = "typeOfSupplier";
            this.typeOfSupplier.HeaderText = "typeOfSupplier";
            this.typeOfSupplier.Name = "typeOfSupplier";
            this.typeOfSupplier.ReadOnly = true;
            this.typeOfSupplier.Visible = false;
            this.typeOfSupplier.Width = 5;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Visible = false;
            this.Country.Width = 5;
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Visible = false;
            this.Destination.Width = 5;
            // 
            // CodeNo
            // 
            this.CodeNo.DataPropertyName = "CodeNo";
            this.CodeNo.HeaderText = "CodeNo";
            this.CodeNo.Name = "CodeNo";
            this.CodeNo.ReadOnly = true;
            this.CodeNo.Visible = false;
            this.CodeNo.Width = 5;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Visible = false;
            this.Discount.Width = 5;
            // 
            // TypeofCustomer
            // 
            this.TypeofCustomer.DataPropertyName = "TypeofCustomer";
            this.TypeofCustomer.HeaderText = "TypeofCustomer";
            this.TypeofCustomer.Name = "TypeofCustomer";
            this.TypeofCustomer.ReadOnly = true;
            this.TypeofCustomer.Visible = false;
            this.TypeofCustomer.Width = 5;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Visible = false;
            this.Location.Width = 5;
            // 
            // InterestRate
            // 
            this.InterestRate.DataPropertyName = "InterestRate";
            this.InterestRate.HeaderText = "InterestRate";
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.ReadOnly = true;
            this.InterestRate.Visible = false;
            this.InterestRate.Width = 5;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            this.Active.Width = 5;
            // 
            // VenderCode
            // 
            this.VenderCode.DataPropertyName = "VenderCode";
            this.VenderCode.HeaderText = "VenderCode";
            this.VenderCode.Name = "VenderCode";
            this.VenderCode.ReadOnly = true;
            this.VenderCode.Visible = false;
            this.VenderCode.Width = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(708, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(629, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(550, 364);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 29);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(471, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ddlState);
            this.groupBox1.Controls.Add(this.ddlPrimaryGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtByName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 61);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(433, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "State/City";
            // 
            // ddlState
            // 
            this.ddlState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlState.DisplayMember = "Value";
            this.ddlState.FormattingEnabled = true;
            this.ddlState.Location = new System.Drawing.Point(506, 12);
            this.ddlState.Name = "ddlState";
            this.ddlState.Size = new System.Drawing.Size(121, 23);
            this.ddlState.TabIndex = 0;
            this.ddlState.ValueMember = "Code";
            // 
            // ddlPrimaryGroup
            // 
            this.ddlPrimaryGroup.BackColor = System.Drawing.SystemColors.Control;
            this.ddlPrimaryGroup.DisplayMember = "Value";
            this.ddlPrimaryGroup.FormattingEnabled = true;
            this.ddlPrimaryGroup.Location = new System.Drawing.Point(153, 12);
            this.ddlPrimaryGroup.Name = "ddlPrimaryGroup";
            this.ddlPrimaryGroup.Size = new System.Drawing.Size(217, 23);
            this.ddlPrimaryGroup.TabIndex = 0;
            this.ddlPrimaryGroup.ValueMember = "Code";
            this.ddlPrimaryGroup.SelectedIndexChanged += new System.EventHandler(this.ddlGroupName_onload);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Account  Group Type";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFind.Location = new System.Drawing.Point(648, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFind.Size = new System.Drawing.Size(57, 29);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = " Search Account Name";
            this.label2.Visible = false;
            // 
            // txtByName
            // 
            this.txtByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.txtByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByName.IsMendatory = true;
            this.txtByName.Location = new System.Drawing.Point(198, 38);
            this.txtByName.MaxLength = 50;
            this.txtByName.Name = "txtByName";
            this.txtByName.Size = new System.Drawing.Size(153, 20);
            this.txtByName.TabIndex = 28;
            this.txtByName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtByName.Visible = false;
            this.txtByName.TabIndexChanged += new System.EventHandler(this.txtByName_TabIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(806, 24);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(150, 19);
            this.toolStripStatusLabel4.Text = " F2 => Add";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(150, 19);
            this.toolStripStatusLabel3.Text = " F3=>Edit";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(150, 19);
            this.toolStripStatusLabel2.Text = "Alt+D=>Delete";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(150, 19);
            this.toolStripStatusLabel5.Text = "Esc => Exit";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(150, 19);
            this.toolStripStatusLabel1.Text = "Rec1/27";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 424);
            this.Controls.Add(this.grdAccountDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Setup";
            this.Load += new System.EventHandler(this.AccountView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAccountDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public WinControlLibrary.BCombo ddlPrimaryGroup;
        public System.Windows.Forms.Label label3;
        public WinControlLibrary.BAllButton btnFind;
        public WinControlLibrary.BTextBox txtByName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public WinControlLibrary.BCombo ddlState;
        public WinControlLibrary.BGrid grdAccountDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountMasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn State1;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountGroupMasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistratnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACodeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commodity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collectorate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSTNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinSTNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjBillWise;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDSCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDSRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LockAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeofTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatureofPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeofCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenderCode;
        private WinControlLibrary.BAllButton btnExit;
        private WinControlLibrary.BAllButton btnDelete;
        private WinControlLibrary.BAllButton btnEdit;
        public WinControlLibrary.BAllButton btnAdd;
    }
}