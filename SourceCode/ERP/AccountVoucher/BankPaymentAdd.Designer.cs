namespace ERP.ACvoucher
{
    partial class BankPaymentAdd
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
            this.btnAddMore = new WinControlLibrary.BButton();
            this.txtDescpn = new WinControlLibrary.BTextBox();
            this.bLabel13 = new WinControlLibrary.BLabel();
            this.bLabel12 = new WinControlLibrary.BLabel();
            this.txtCrntBal = new WinControlLibrary.BTextBox();
            this.bLabel11 = new WinControlLibrary.BLabel();
            this.btnAcc = new WinControlLibrary.BButton();
            this.txtAcc = new WinControlLibrary.BTextBox();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrCr = new WinControlLibrary.BTextBox();
            this.txtAmount = new WinControlLibrary.BTextBox();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtSNo = new WinControlLibrary.BTextBox();
            this.bLabel16 = new WinControlLibrary.BLabel();
            this.grdBankPaymentadd = new WinControlLibrary.BGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGrid1 = new WinControlLibrary.BGrid();
            this.bLabel15 = new WinControlLibrary.BLabel();
            this.bLabel14 = new WinControlLibrary.BLabel();
            this.ddlAccount = new System.Windows.Forms.ComboBox();
            this.bLabel10 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.btnAccount = new WinControlLibrary.BButton();
            this.btnExit = new WinControlLibrary.BButton();
            this.btnSave = new WinControlLibrary.BButton();
            this.btnDeleteRaw = new WinControlLibrary.BButton();
            this.txtTtlCredit = new WinControlLibrary.BTextBox();
            this.txtTotlDebit = new WinControlLibrary.BTextBox();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.txtBalance = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtNarration = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtVoucherNo = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdBankPaymentadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(721, 219);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(56, 23);
            this.btnAddMore.TabIndex = 14;
            this.btnAddMore.Text = "+";
            this.btnAddMore.UseVisualStyleBackColor = true;
            // 
            // txtDescpn
            // 
            this.txtDescpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDescpn.IsMendatory = false;
            this.txtDescpn.Location = new System.Drawing.Point(349, 222);
            this.txtDescpn.MaxLength = 50;
            this.txtDescpn.Name = "txtDescpn";
            this.txtDescpn.Size = new System.Drawing.Size(366, 20);
            this.txtDescpn.TabIndex = 13;
            this.txtDescpn.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel13
            // 
            this.bLabel13.AutoSize = true;
            this.bLabel13.Location = new System.Drawing.Point(289, 224);
            this.bLabel13.Name = "bLabel13";
            this.bLabel13.Size = new System.Drawing.Size(60, 13);
            this.bLabel13.TabIndex = 186;
            this.bLabel13.Text = "Description";
            // 
            // bLabel12
            // 
            this.bLabel12.AutoSize = true;
            this.bLabel12.Location = new System.Drawing.Point(289, 162);
            this.bLabel12.Name = "bLabel12";
            this.bLabel12.Size = new System.Drawing.Size(59, 13);
            this.bLabel12.TabIndex = 184;
            this.bLabel12.Text = "Current Bal";
            // 
            // txtCrntBal
            // 
            this.txtCrntBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtCrntBal.IsMendatory = false;
            this.txtCrntBal.Location = new System.Drawing.Point(262, 178);
            this.txtCrntBal.MaxLength = 50;
            this.txtCrntBal.Name = "txtCrntBal";
            this.txtCrntBal.Size = new System.Drawing.Size(82, 20);
            this.txtCrntBal.TabIndex = 10;
            this.txtCrntBal.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel11
            // 
            this.bLabel11.AutoSize = true;
            this.bLabel11.Location = new System.Drawing.Point(21, 126);
            this.bLabel11.Name = "bLabel11";
            this.bLabel11.Size = new System.Drawing.Size(84, 13);
            this.bLabel11.TabIndex = 182;
            this.bLabel11.Text = "CASH IN HAND";
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(169, 154);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(33, 23);
            this.btnAcc.TabIndex = 9;
            this.btnAcc.Text = "...";
            this.btnAcc.UseVisualStyleBackColor = true;
            // 
            // txtAcc
            // 
            this.txtAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAcc.IsMendatory = false;
            this.txtAcc.Location = new System.Drawing.Point(81, 180);
            this.txtAcc.MaxLength = 50;
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(159, 20);
            this.txtAcc.TabIndex = 8;
            this.txtAcc.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Location = new System.Drawing.Point(555, 162);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(33, 13);
            this.bLabel8.TabIndex = 178;
            this.bLabel8.Text = "Dr/Cr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 179;
            this.label1.Text = "Account";
            // 
            // txtDrCr
            // 
            this.txtDrCr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDrCr.IsMendatory = false;
            this.txtDrCr.Location = new System.Drawing.Point(526, 178);
            this.txtDrCr.MaxLength = 50;
            this.txtDrCr.Name = "txtDrCr";
            this.txtDrCr.Size = new System.Drawing.Size(92, 20);
            this.txtDrCr.TabIndex = 12;
            this.txtDrCr.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmount.IsMendatory = false;
            this.txtAmount.Location = new System.Drawing.Point(432, 178);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(82, 20);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(451, 162);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(43, 13);
            this.bLabel7.TabIndex = 175;
            this.bLabel7.Text = "Amount";
            // 
            // txtSNo
            // 
            this.txtSNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSNo.IsMendatory = false;
            this.txtSNo.Location = new System.Drawing.Point(42, 180);
            this.txtSNo.MaxLength = 50;
            this.txtSNo.Name = "txtSNo";
            this.txtSNo.Size = new System.Drawing.Size(26, 20);
            this.txtSNo.TabIndex = 7;
            this.txtSNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel16
            // 
            this.bLabel16.AutoSize = true;
            this.bLabel16.Location = new System.Drawing.Point(39, 164);
            this.bLabel16.Name = "bLabel16";
            this.bLabel16.Size = new System.Drawing.Size(31, 13);
            this.bLabel16.TabIndex = 174;
            this.bLabel16.Text = "SNo.";
            // 
            // grdBankPaymentadd
            // 
            this.grdBankPaymentadd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdBankPaymentadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBankPaymentadd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.grdBankPaymentadd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdBankPaymentadd.Index = 0;
            this.grdBankPaymentadd.Location = new System.Drawing.Point(41, 252);
            this.grdBankPaymentadd.Name = "grdBankPaymentadd";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBankPaymentadd.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBankPaymentadd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBankPaymentadd.Size = new System.Drawing.Size(736, 110);
            this.grdBankPaymentadd.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S No.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Account";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Debit";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Credit";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Check No";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Check Date";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Bill No.";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bill date";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "TDS %";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "TDS Amount";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Check Clearence Date";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Description";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Cost Center ";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Cost Center Code";
            this.Column14.Name = "Column14";
            // 
            // bGrid1
            // 
            this.bGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.bGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bGrid1.Index = 0;
            this.bGrid1.Location = new System.Drawing.Point(18, 151);
            this.bGrid1.Name = "bGrid1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bGrid1.Size = new System.Drawing.Size(779, 220);
            this.bGrid1.TabIndex = 172;
            // 
            // bLabel15
            // 
            this.bLabel15.AutoSize = true;
            this.bLabel15.Location = new System.Drawing.Point(547, 411);
            this.bLabel15.Name = "bLabel15";
            this.bLabel15.Size = new System.Drawing.Size(61, 13);
            this.bLabel15.TabIndex = 169;
            this.bLabel15.Text = "Total Credit";
            // 
            // bLabel14
            // 
            this.bLabel14.AutoSize = true;
            this.bLabel14.Location = new System.Drawing.Point(242, 5);
            this.bLabel14.Name = "bLabel14";
            this.bLabel14.Size = new System.Drawing.Size(26, 13);
            this.bLabel14.TabIndex = 168;
            this.bLabel14.Text = "Day";
            // 
            // ddlAccount
            // 
            this.ddlAccount.FormattingEnabled = true;
            this.ddlAccount.Location = new System.Drawing.Point(115, 52);
            this.ddlAccount.Name = "ddlAccount";
            this.ddlAccount.Size = new System.Drawing.Size(132, 21);
            this.ddlAccount.TabIndex = 3;
            // 
            // bLabel10
            // 
            this.bLabel10.AutoSize = true;
            this.bLabel10.Location = new System.Drawing.Point(292, 56);
            this.bLabel10.Name = "bLabel10";
            this.bLabel10.Size = new System.Drawing.Size(17, 13);
            this.bLabel10.TabIndex = 166;
            this.bLabel10.Text = "Cr";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(115, 2);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(108, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(21, 9);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(76, 13);
            this.bLabel1.TabIndex = 153;
            this.bLabel1.Text = "Voucher  Date";
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(253, 51);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(33, 23);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "...";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(715, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(657, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRaw
            // 
            this.btnDeleteRaw.Location = new System.Drawing.Point(24, 421);
            this.btnDeleteRaw.Name = "btnDeleteRaw";
            this.btnDeleteRaw.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteRaw.TabIndex = 18;
            this.btnDeleteRaw.Text = "Delete  Rows";
            this.btnDeleteRaw.UseVisualStyleBackColor = true;
            // 
            // txtTtlCredit
            // 
            this.txtTtlCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTtlCredit.IsMendatory = false;
            this.txtTtlCredit.Location = new System.Drawing.Point(612, 413);
            this.txtTtlCredit.MaxLength = 50;
            this.txtTtlCredit.Name = "txtTtlCredit";
            this.txtTtlCredit.Size = new System.Drawing.Size(142, 20);
            this.txtTtlCredit.TabIndex = 17;
            this.txtTtlCredit.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtTotlDebit
            // 
            this.txtTotlDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTotlDebit.IsMendatory = false;
            this.txtTotlDebit.Location = new System.Drawing.Point(611, 387);
            this.txtTotlDebit.MaxLength = 50;
            this.txtTotlDebit.Name = "txtTotlDebit";
            this.txtTotlDebit.Size = new System.Drawing.Size(143, 20);
            this.txtTotlDebit.TabIndex = 16;
            this.txtTotlDebit.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Location = new System.Drawing.Point(549, 387);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(59, 13);
            this.bLabel9.TabIndex = 161;
            this.bLabel9.Text = "Total Debit";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtBalance.IsMendatory = false;
            this.txtBalance.Location = new System.Drawing.Point(483, 56);
            this.txtBalance.MaxLength = 50;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(118, 20);
            this.txtBalance.TabIndex = 5;
            this.txtBalance.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(431, 60);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(46, 13);
            this.bLabel4.TabIndex = 159;
            this.bLabel4.Text = "Balance";
            // 
            // txtNarration
            // 
            this.txtNarration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNarration.IsMendatory = false;
            this.txtNarration.Location = new System.Drawing.Point(116, 78);
            this.txtNarration.MaxLength = 50;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(485, 20);
            this.txtNarration.TabIndex = 6;
            this.txtNarration.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(47, 78);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(50, 13);
            this.bLabel3.TabIndex = 157;
            this.bLabel3.Text = "Narration";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(50, 50);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(47, 13);
            this.bLabel5.TabIndex = 155;
            this.bLabel5.Text = "Account";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtVoucherNo.IsMendatory = false;
            this.txtVoucherNo.Location = new System.Drawing.Point(116, 28);
            this.txtVoucherNo.MaxLength = 50;
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(107, 20);
            this.txtVoucherNo.TabIndex = 2;
            this.txtVoucherNo.Text = "01/04/2014";
            this.txtVoucherNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(30, 28);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(67, 13);
            this.bLabel2.TabIndex = 154;
            this.bLabel2.Text = "Voucher No.";
            // 
            // BankPaymentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 466);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.txtDescpn);
            this.Controls.Add(this.bLabel13);
            this.Controls.Add(this.bLabel12);
            this.Controls.Add(this.txtCrntBal);
            this.Controls.Add(this.bLabel11);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.bLabel8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDrCr);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.txtSNo);
            this.Controls.Add(this.bLabel16);
            this.Controls.Add(this.grdBankPaymentadd);
            this.Controls.Add(this.bGrid1);
            this.Controls.Add(this.bLabel15);
            this.Controls.Add(this.bLabel14);
            this.Controls.Add(this.ddlAccount);
            this.Controls.Add(this.bLabel10);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteRaw);
            this.Controls.Add(this.txtTtlCredit);
            this.Controls.Add(this.txtTotlDebit);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.bLabel2);
            this.Name = "BankPaymentAdd";
            this.Text = "BankPaymentAdd";
            ((System.ComponentModel.ISupportInitialize)(this.grdBankPaymentadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BTextBox txtDescpn;
        private WinControlLibrary.BLabel bLabel13;
        private WinControlLibrary.BLabel bLabel12;
        private WinControlLibrary.BTextBox txtCrntBal;
        private WinControlLibrary.BLabel bLabel11;
        private WinControlLibrary.BTextBox txtAcc;
        private WinControlLibrary.BLabel bLabel8;
        private System.Windows.Forms.Label label1;
        private WinControlLibrary.BTextBox txtDrCr;
        private WinControlLibrary.BTextBox txtAmount;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BTextBox txtSNo;
        private WinControlLibrary.BLabel bLabel16;
        private WinControlLibrary.BGrid grdBankPaymentadd;
        private WinControlLibrary.BGrid bGrid1;
        private WinControlLibrary.BLabel bLabel15;
        private WinControlLibrary.BLabel bLabel14;
        private System.Windows.Forms.ComboBox ddlAccount;
        private WinControlLibrary.BLabel bLabel10;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtTtlCredit;
        private WinControlLibrary.BTextBox txtTotlDebit;
        private WinControlLibrary.BLabel bLabel9;
        private WinControlLibrary.BTextBox txtBalance;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BTextBox txtNarration;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtVoucherNo;
        private WinControlLibrary.BLabel bLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private WinControlLibrary.BButton btnAddMore;
        private WinControlLibrary.BButton btnAcc;
        private WinControlLibrary.BButton btnAccount;
        private WinControlLibrary.BButton btnExit;
        private WinControlLibrary.BButton btnSave;
        private WinControlLibrary.BButton btnDeleteRaw;
    }
}