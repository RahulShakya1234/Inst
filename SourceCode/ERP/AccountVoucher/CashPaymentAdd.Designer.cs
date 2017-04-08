namespace ERP.ACvoucher
{
    partial class CashPaymentAdd
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
            this.txtAccount = new WinControlLibrary.BTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.txtDCr = new WinControlLibrary.BTextBox();
            this.txtAmt = new WinControlLibrary.BTextBox();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtSno = new WinControlLibrary.BTextBox();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.grdCashPaymentAdd = new WinControlLibrary.BGrid();
            this.bGrid1 = new WinControlLibrary.BGrid();
            this.btnAccount2 = new WinControlLibrary.BButton();
            this.bLabel11 = new WinControlLibrary.BLabel();
            this.txtCurentBal = new WinControlLibrary.BTextBox();
            this.bLabel12 = new WinControlLibrary.BLabel();
            this.txtDescrp = new WinControlLibrary.BTextBox();
            this.bLabel13 = new WinControlLibrary.BLabel();
            this.btnAddMoreDesc = new WinControlLibrary.BButton();
            this.bLabel14 = new WinControlLibrary.BLabel();
            this.ddlAccount = new System.Windows.Forms.ComboBox();
            this.bLabel10 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.btnAccount = new WinControlLibrary.BButton();
            this.txtBalance = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtNarration = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtVoucherNo = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel15 = new WinControlLibrary.BLabel();
            this.btnExit = new WinControlLibrary.BButton();
            this.btnSave = new WinControlLibrary.BButton();
            this.btnDeleteRaw = new WinControlLibrary.BButton();
            this.txtTtlCredit = new WinControlLibrary.BTextBox();
            this.txtTotlDebit = new WinControlLibrary.BTextBox();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashPaymentAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAccount.IsMendatory = false;
            this.txtAccount.Location = new System.Drawing.Point(72, 183);
            this.txtAccount.MaxLength = 50;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(159, 20);
            this.txtAccount.TabIndex = 8;
            this.txtAccount.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Account";
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Location = new System.Drawing.Point(546, 165);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(33, 13);
            this.bLabel8.TabIndex = 73;
            this.bLabel8.Text = "Dr/Cr";
            // 
            // txtDCr
            // 
            this.txtDCr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDCr.IsMendatory = false;
            this.txtDCr.Location = new System.Drawing.Point(517, 181);
            this.txtDCr.MaxLength = 50;
            this.txtDCr.Name = "txtDCr";
            this.txtDCr.Size = new System.Drawing.Size(92, 20);
            this.txtDCr.TabIndex = 12;
            this.txtDCr.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtAmt
            // 
            this.txtAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmt.IsMendatory = false;
            this.txtAmt.Location = new System.Drawing.Point(423, 181);
            this.txtAmt.MaxLength = 50;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(82, 20);
            this.txtAmt.TabIndex = 11;
            this.txtAmt.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(442, 165);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(43, 13);
            this.bLabel7.TabIndex = 70;
            this.bLabel7.Text = "Amount";
            this.bLabel7.Click += new System.EventHandler(this.bLabel7_Click);
            // 
            // txtSno
            // 
            this.txtSno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSno.IsMendatory = false;
            this.txtSno.Location = new System.Drawing.Point(33, 183);
            this.txtSno.MaxLength = 50;
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(26, 20);
            this.txtSno.TabIndex = 7;
            this.txtSno.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(30, 167);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(31, 13);
            this.bLabel6.TabIndex = 69;
            this.bLabel6.Text = "SNo.";
            // 
            // grdCashPaymentAdd
            // 
            this.grdCashPaymentAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdCashPaymentAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCashPaymentAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNo,
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grdCashPaymentAdd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdCashPaymentAdd.Index = 0;
            this.grdCashPaymentAdd.Location = new System.Drawing.Point(32, 255);
            this.grdCashPaymentAdd.Name = "grdCashPaymentAdd";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCashPaymentAdd.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCashPaymentAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCashPaymentAdd.Size = new System.Drawing.Size(736, 110);
            this.grdCashPaymentAdd.TabIndex = 15;
            // 
            // bGrid1
            // 
            this.bGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.bGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bGrid1.Index = 0;
            this.bGrid1.Location = new System.Drawing.Point(9, 154);
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
            this.bGrid1.TabIndex = 60;
            // 
            // btnAccount2
            // 
            this.btnAccount2.Location = new System.Drawing.Point(160, 157);
            this.btnAccount2.Name = "btnAccount2";
            this.btnAccount2.Size = new System.Drawing.Size(33, 23);
            this.btnAccount2.TabIndex = 9;
            this.btnAccount2.Text = "...";
            this.btnAccount2.UseVisualStyleBackColor = true;
            // 
            // bLabel11
            // 
            this.bLabel11.AutoSize = true;
            this.bLabel11.Location = new System.Drawing.Point(12, 129);
            this.bLabel11.Name = "bLabel11";
            this.bLabel11.Size = new System.Drawing.Size(84, 13);
            this.bLabel11.TabIndex = 86;
            this.bLabel11.Text = "CASH IN HAND";
            // 
            // txtCurentBal
            // 
            this.txtCurentBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtCurentBal.IsMendatory = false;
            this.txtCurentBal.Location = new System.Drawing.Point(253, 181);
            this.txtCurentBal.MaxLength = 50;
            this.txtCurentBal.Name = "txtCurentBal";
            this.txtCurentBal.Size = new System.Drawing.Size(82, 20);
            this.txtCurentBal.TabIndex = 10;
            this.txtCurentBal.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel12
            // 
            this.bLabel12.AutoSize = true;
            this.bLabel12.Location = new System.Drawing.Point(280, 165);
            this.bLabel12.Name = "bLabel12";
            this.bLabel12.Size = new System.Drawing.Size(59, 13);
            this.bLabel12.TabIndex = 88;
            this.bLabel12.Text = "Current Bal";
            // 
            // txtDescrp
            // 
            this.txtDescrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDescrp.IsMendatory = false;
            this.txtDescrp.Location = new System.Drawing.Point(340, 225);
            this.txtDescrp.MaxLength = 50;
            this.txtDescrp.Name = "txtDescrp";
            this.txtDescrp.Size = new System.Drawing.Size(366, 20);
            this.txtDescrp.TabIndex = 13;
            this.txtDescrp.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel13
            // 
            this.bLabel13.AutoSize = true;
            this.bLabel13.Location = new System.Drawing.Point(280, 227);
            this.bLabel13.Name = "bLabel13";
            this.bLabel13.Size = new System.Drawing.Size(60, 13);
            this.bLabel13.TabIndex = 90;
            this.bLabel13.Text = "Description";
            // 
            // btnAddMoreDesc
            // 
            this.btnAddMoreDesc.Location = new System.Drawing.Point(712, 222);
            this.btnAddMoreDesc.Name = "btnAddMoreDesc";
            this.btnAddMoreDesc.Size = new System.Drawing.Size(56, 23);
            this.btnAddMoreDesc.TabIndex = 14;
            this.btnAddMoreDesc.Text = "+";
            this.btnAddMoreDesc.UseVisualStyleBackColor = true;
            // 
            // bLabel14
            // 
            this.bLabel14.AutoSize = true;
            this.bLabel14.Location = new System.Drawing.Point(251, 23);
            this.bLabel14.Name = "bLabel14";
            this.bLabel14.Size = new System.Drawing.Size(26, 13);
            this.bLabel14.TabIndex = 181;
            this.bLabel14.Text = "Day";
            // 
            // ddlAccount
            // 
            this.ddlAccount.FormattingEnabled = true;
            this.ddlAccount.Location = new System.Drawing.Point(124, 70);
            this.ddlAccount.Name = "ddlAccount";
            this.ddlAccount.Size = new System.Drawing.Size(132, 21);
            this.ddlAccount.TabIndex = 3;
            // 
            // bLabel10
            // 
            this.bLabel10.AutoSize = true;
            this.bLabel10.Location = new System.Drawing.Point(301, 74);
            this.bLabel10.Name = "bLabel10";
            this.bLabel10.Size = new System.Drawing.Size(17, 13);
            this.bLabel10.TabIndex = 180;
            this.bLabel10.Text = "Cr";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(124, 20);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(108, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(30, 27);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(76, 13);
            this.bLabel1.TabIndex = 175;
            this.bLabel1.Text = "Voucher  Date";
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(262, 69);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(33, 23);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "...";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtBalance.IsMendatory = false;
            this.txtBalance.Location = new System.Drawing.Point(492, 74);
            this.txtBalance.MaxLength = 50;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(118, 20);
            this.txtBalance.TabIndex = 5;
            this.txtBalance.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(440, 78);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(46, 13);
            this.bLabel4.TabIndex = 179;
            this.bLabel4.Text = "Balance";
            // 
            // txtNarration
            // 
            this.txtNarration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNarration.IsMendatory = false;
            this.txtNarration.Location = new System.Drawing.Point(125, 96);
            this.txtNarration.MaxLength = 50;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(485, 20);
            this.txtNarration.TabIndex = 6;
            this.txtNarration.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(56, 96);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(50, 13);
            this.bLabel3.TabIndex = 178;
            this.bLabel3.Text = "Narration";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(59, 68);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(47, 13);
            this.bLabel5.TabIndex = 177;
            this.bLabel5.Text = "Account";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtVoucherNo.IsMendatory = false;
            this.txtVoucherNo.Location = new System.Drawing.Point(125, 46);
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
            this.bLabel2.Location = new System.Drawing.Point(39, 46);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(67, 13);
            this.bLabel2.TabIndex = 176;
            this.bLabel2.Text = "Voucher No.";
            // 
            // bLabel15
            // 
            this.bLabel15.AutoSize = true;
            this.bLabel15.Location = new System.Drawing.Point(535, 401);
            this.bLabel15.Name = "bLabel15";
            this.bLabel15.Size = new System.Drawing.Size(61, 13);
            this.bLabel15.TabIndex = 187;
            this.bLabel15.Text = "Total Credit";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(703, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(645, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRaw
            // 
            this.btnDeleteRaw.Location = new System.Drawing.Point(12, 411);
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
            this.txtTtlCredit.Location = new System.Drawing.Point(600, 403);
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
            this.txtTotlDebit.Location = new System.Drawing.Point(599, 377);
            this.txtTotlDebit.MaxLength = 50;
            this.txtTotlDebit.Name = "txtTotlDebit";
            this.txtTotlDebit.Size = new System.Drawing.Size(143, 20);
            this.txtTotlDebit.TabIndex = 16;
            this.txtTotlDebit.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Location = new System.Drawing.Point(532, 380);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(59, 13);
            this.bLabel9.TabIndex = 188;
            this.bLabel9.Text = "Total Debit";
            // 
            // OrderNo
            // 
            this.OrderNo.HeaderText = "S.No.";
            this.OrderNo.Name = "OrderNo";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Account";
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Debit";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Credit";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BillNo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "BillDate";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TDS%";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TDS Amount";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Narration";
            this.Column7.Name = "Column7";
            // 
            // CashPaymentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 456);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.bLabel15);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteRaw);
            this.Controls.Add(this.txtTtlCredit);
            this.Controls.Add(this.txtTotlDebit);
            this.Controls.Add(this.bLabel14);
            this.Controls.Add(this.ddlAccount);
            this.Controls.Add(this.bLabel10);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.btnAddMoreDesc);
            this.Controls.Add(this.txtDescrp);
            this.Controls.Add(this.bLabel13);
            this.Controls.Add(this.bLabel12);
            this.Controls.Add(this.txtCurentBal);
            this.Controls.Add(this.bLabel11);
            this.Controls.Add(this.btnAccount2);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLabel8);
            this.Controls.Add(this.txtDCr);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.grdCashPaymentAdd);
            this.Controls.Add(this.bGrid1);
            this.Name = "CashPaymentAdd";
            this.Text = "CashPaymentAdd";
            this.Load += new System.EventHandler(this.CashPaymentAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCashPaymentAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BTextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private WinControlLibrary.BLabel bLabel8;
        private WinControlLibrary.BTextBox txtDCr;
        private WinControlLibrary.BTextBox txtAmt;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BTextBox txtSno;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BGrid grdCashPaymentAdd;
        private WinControlLibrary.BGrid bGrid1;
        private WinControlLibrary.BLabel bLabel11;
        private WinControlLibrary.BTextBox txtCurentBal;
        private WinControlLibrary.BLabel bLabel12;
        private WinControlLibrary.BTextBox txtDescrp;
        private WinControlLibrary.BLabel bLabel13;
        private WinControlLibrary.BButton btnAccount2;
        private WinControlLibrary.BButton btnAddMoreDesc;
        private WinControlLibrary.BLabel bLabel14;
        private System.Windows.Forms.ComboBox ddlAccount;
        private WinControlLibrary.BLabel bLabel10;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BButton btnAccount;
        private WinControlLibrary.BTextBox txtBalance;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BTextBox txtNarration;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtVoucherNo;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel15;
        private WinControlLibrary.BButton btnExit;
        private WinControlLibrary.BButton btnSave;
        private WinControlLibrary.BButton btnDeleteRaw;
        private WinControlLibrary.BTextBox txtTtlCredit;
        private WinControlLibrary.BTextBox txtTotlDebit;
        private WinControlLibrary.BLabel bLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}