namespace ERP.SalePurchase.SalePurchase
{
    partial class DirectEntryAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectEntryAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemove = new WinControlLibrary.BAllButton();
            this.txtTotalAmount = new WinControlLibrary.BTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDItemCode = new WinControlLibrary.BTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.grdPurchaseBillDetailsDET = new WinControlLibrary.BGrid();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSTPurchaseBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlDUMO = new WinControlLibrary.BCombo();
            this.label24 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.btnReset = new WinControlLibrary.BAllButton();
            this.txtBillDate = new WinControlLibrary.BDateTextBox();
            this.txtEntryDate = new WinControlLibrary.BDateTextBox();
            this.btnAdd = new WinControlLibrary.BAllButton();
            this.ddlDItemDesc = new WinControlLibrary.BCombo();
            this.txtNarration = new WinControlLibrary.BTextBox();
            this.ddlPurchaseAccount = new WinControlLibrary.BCombo();
            this.ddlPurchaseType = new WinControlLibrary.BCombo();
            this.ddlPurchaseCategory = new WinControlLibrary.BCombo();
            this.label39 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDTotalAmt = new WinControlLibrary.BTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnItemDesc = new WinControlLibrary.BAllButton();
            this.txtDRate = new WinControlLibrary.BTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDQuantity = new WinControlLibrary.BTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDSno = new WinControlLibrary.BTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtBillNo = new WinControlLibrary.BTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSerialBillNo = new WinControlLibrary.BTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseBillDetailsDET)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Location = new System.Drawing.Point(745, 155);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.IsMendatory = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(472, 365);
            this.txtTotalAmount.MaxLength = 50;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(64, 20);
            this.txtTotalAmount.TabIndex = 444514;
            this.txtTotalAmount.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 444515;
            this.label8.Text = " Total Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 444513;
            this.label2.UseWaitCursor = true;
            // 
            // txtDItemCode
            // 
            this.txtDItemCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDItemCode.IsMendatory = false;
            this.txtDItemCode.Location = new System.Drawing.Point(61, 157);
            this.txtDItemCode.MaxLength = 50;
            this.txtDItemCode.Name = "txtDItemCode";
            this.txtDItemCode.Size = new System.Drawing.Size(60, 20);
            this.txtDItemCode.TabIndex = 10;
            this.txtDItemCode.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtDItemCode.Leave += new System.EventHandler(this.txtItemCode_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 444512;
            this.label5.Text = "Item Code";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(704, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(623, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // grdPurchaseBillDetailsDET
            // 
            this.grdPurchaseBillDetailsDET.AllowUserToAddRows = false;
            this.grdPurchaseBillDetailsDET.AllowUserToDeleteRows = false;
            this.grdPurchaseBillDetailsDET.AllowUserToOrderColumns = true;
            this.grdPurchaseBillDetailsDET.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPurchaseBillDetailsDET.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPurchaseBillDetailsDET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.ItemCode,
            this.ItemId,
            this.Item,
            this.UOMId,
            this.UOM,
            this.Qty,
            this.Rate,
            this.Amount,
            this.MSTPurchaseBillId});
            this.grdPurchaseBillDetailsDET.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPurchaseBillDetailsDET.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdPurchaseBillDetailsDET.GridColor = System.Drawing.Color.DarkGray;
            this.grdPurchaseBillDetailsDET.Index = 0;
            this.grdPurchaseBillDetailsDET.Location = new System.Drawing.Point(19, 185);
            this.grdPurchaseBillDetailsDET.MultiSelect = false;
            this.grdPurchaseBillDetailsDET.Name = "grdPurchaseBillDetailsDET";
            this.grdPurchaseBillDetailsDET.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPurchaseBillDetailsDET.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdPurchaseBillDetailsDET.RowHeadersWidth = 20;
            this.grdPurchaseBillDetailsDET.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPurchaseBillDetailsDET.Size = new System.Drawing.Size(796, 157);
            this.grdPurchaseBillDetailsDET.TabIndex = 444508;
            this.grdPurchaseBillDetailsDET.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPurchaseBillDetailsDET_CellContentClick);
            this.grdPurchaseBillDetailsDET.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPurchaseBillDetailsDET_CellMouseEnter);
            this.grdPurchaseBillDetailsDET.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPurchaseBillDetailsDET_CellMouseLeave);
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "S.No.";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 70;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "AliasItemCode";
            this.ItemCode.HeaderText = " Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemDecsId";
            this.ItemId.HeaderText = "ItemDescId";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Visible = false;
            this.ItemId.Width = 5;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "ItemDecsText";
            this.Item.HeaderText = "Item Desc";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 140;
            // 
            // UOMId
            // 
            this.UOMId.DataPropertyName = "UOMId";
            this.UOMId.HeaderText = "UMOId";
            this.UOMId.Name = "UOMId";
            this.UOMId.ReadOnly = true;
            this.UOMId.Visible = false;
            this.UOMId.Width = 5;
            // 
            // UOM
            // 
            this.UOM.DataPropertyName = "UOMText";
            this.UOM.HeaderText = " UOM ";
            this.UOM.Name = "UOM";
            this.UOM.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "TotalAmount";
            this.Amount.HeaderText = "Total Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 130;
            // 
            // MSTPurchaseBillId
            // 
            this.MSTPurchaseBillId.DataPropertyName = "MSTPurchaseBillId";
            this.MSTPurchaseBillId.HeaderText = "MSTPurchaseBillId";
            this.MSTPurchaseBillId.Name = "MSTPurchaseBillId";
            this.MSTPurchaseBillId.ReadOnly = true;
            this.MSTPurchaseBillId.Visible = false;
            this.MSTPurchaseBillId.Width = 5;
            // 
            // ddlDUMO
            // 
            this.ddlDUMO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlDUMO.DisplayMember = "Value";
            this.ddlDUMO.FormattingEnabled = true;
            this.ddlDUMO.Location = new System.Drawing.Point(304, 158);
            this.ddlDUMO.Name = "ddlDUMO";
            this.ddlDUMO.Size = new System.Drawing.Size(90, 21);
            this.ddlDUMO.TabIndex = 12;
            this.ddlDUMO.ValueMember = "Code";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(364, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 15);
            this.label24.TabIndex = 444506;
            this.label24.UseWaitCursor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(318, 143);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(33, 15);
            this.label42.TabIndex = 444505;
            this.label42.Text = "UOM";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(744, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBillDate
            // 
            this.txtBillDate.AllowBlank = false;
            this.txtBillDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtBillDate.Location = new System.Drawing.Point(339, 41);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(100, 20);
            this.txtBillDate.TabIndex = 4;
            this.txtBillDate.Leave += new System.EventHandler(this.txtBillDate_Leave);
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.AllowBlank = false;
            this.txtEntryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtEntryDate.Location = new System.Drawing.Point(339, 13);
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.Size = new System.Drawing.Size(100, 20);
            this.txtEntryDate.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(664, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "   +";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ddlDItemDesc
            // 
            this.ddlDItemDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlDItemDesc.DisplayMember = "Value";
            this.ddlDItemDesc.FormattingEnabled = true;
            this.ddlDItemDesc.Location = new System.Drawing.Point(127, 157);
            this.ddlDItemDesc.Name = "ddlDItemDesc";
            this.ddlDItemDesc.Size = new System.Drawing.Size(171, 21);
            this.ddlDItemDesc.TabIndex = 11;
            this.ddlDItemDesc.ValueMember = "Code";
            this.ddlDItemDesc.Leave += new System.EventHandler(this.ddlItemDesc_Leave);
            // 
            // txtNarration
            // 
            this.txtNarration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNarration.IsMendatory = false;
            this.txtNarration.Location = new System.Drawing.Point(127, 75);
            this.txtNarration.MaxLength = 50;
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(350, 35);
            this.txtNarration.TabIndex = 5;
            this.txtNarration.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // ddlPurchaseAccount
            // 
            this.ddlPurchaseAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlPurchaseAccount.DisplayMember = "Value";
            this.ddlPurchaseAccount.FormattingEnabled = true;
            this.ddlPurchaseAccount.Location = new System.Drawing.Point(635, 87);
            this.ddlPurchaseAccount.Name = "ddlPurchaseAccount";
            this.ddlPurchaseAccount.Size = new System.Drawing.Size(124, 21);
            this.ddlPurchaseAccount.TabIndex = 8;
            this.ddlPurchaseAccount.ValueMember = "Code";
            // 
            // ddlPurchaseType
            // 
            this.ddlPurchaseType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlPurchaseType.DisplayMember = "Value";
            this.ddlPurchaseType.FormattingEnabled = true;
            this.ddlPurchaseType.Location = new System.Drawing.Point(634, 62);
            this.ddlPurchaseType.Name = "ddlPurchaseType";
            this.ddlPurchaseType.Size = new System.Drawing.Size(124, 21);
            this.ddlPurchaseType.TabIndex = 7;
            this.ddlPurchaseType.ValueMember = "Code";
            // 
            // ddlPurchaseCategory
            // 
            this.ddlPurchaseCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlPurchaseCategory.DisplayMember = "Value";
            this.ddlPurchaseCategory.FormattingEnabled = true;
            this.ddlPurchaseCategory.Location = new System.Drawing.Point(634, 35);
            this.ddlPurchaseCategory.Name = "ddlPurchaseCategory";
            this.ddlPurchaseCategory.Size = new System.Drawing.Size(124, 21);
            this.ddlPurchaseCategory.TabIndex = 6;
            this.ddlPurchaseCategory.ValueMember = "Code";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(61, 77);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 15);
            this.label39.TabIndex = 444495;
            this.label39.Text = "Narration";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(277, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 444494;
            this.label16.Text = "Bill Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 444491;
            this.label7.UseWaitCursor = true;
            // 
            // txtDTotalAmt
            // 
            this.txtDTotalAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDTotalAmt.IsMendatory = false;
            this.txtDTotalAmt.Location = new System.Drawing.Point(591, 159);
            this.txtDTotalAmt.MaxLength = 50;
            this.txtDTotalAmt.Name = "txtDTotalAmt";
            this.txtDTotalAmt.Size = new System.Drawing.Size(64, 20);
            this.txtDTotalAmt.TabIndex = 15;
            this.txtDTotalAmt.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(591, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 444488;
            this.label13.Text = " Amount";
            // 
            // btnItemDesc
            // 
            this.btnItemDesc.BackColor = System.Drawing.Color.Transparent;
            this.btnItemDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemDesc.BackgroundImage")));
            this.btnItemDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnItemDesc.Location = new System.Drawing.Point(232, 128);
            this.btnItemDesc.Name = "btnItemDesc";
            this.btnItemDesc.Size = new System.Drawing.Size(75, 23);
            this.btnItemDesc.TabIndex = 444487;
            this.btnItemDesc.Text = "...";
            this.btnItemDesc.UseVisualStyleBackColor = true;
            this.btnItemDesc.Click += new System.EventHandler(this.btnItemDesc_Click);
            // 
            // txtDRate
            // 
            this.txtDRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDRate.IsMendatory = false;
            this.txtDRate.Location = new System.Drawing.Point(488, 159);
            this.txtDRate.MaxLength = 50;
            this.txtDRate.Name = "txtDRate";
            this.txtDRate.Size = new System.Drawing.Size(90, 20);
            this.txtDRate.TabIndex = 14;
            this.txtDRate.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            this.txtDRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(494, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 444486;
            this.label12.Text = "Rate";
            // 
            // txtDQuantity
            // 
            this.txtDQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDQuantity.IsMendatory = false;
            this.txtDQuantity.Location = new System.Drawing.Point(400, 159);
            this.txtDQuantity.MaxLength = 50;
            this.txtDQuantity.Name = "txtDQuantity";
            this.txtDQuantity.Size = new System.Drawing.Size(82, 20);
            this.txtDQuantity.TabIndex = 13;
            this.txtDQuantity.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            this.txtDQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 444483;
            this.label9.Text = "Quantity";
            // 
            // txtDSno
            // 
            this.txtDSno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDSno.IsMendatory = false;
            this.txtDSno.Location = new System.Drawing.Point(31, 158);
            this.txtDSno.MaxLength = 10;
            this.txtDSno.Name = "txtDSno";
            this.txtDSno.Size = new System.Drawing.Size(26, 20);
            this.txtDSno.TabIndex = 9;
            this.txtDSno.Text = "1";
            this.txtDSno.TextType = WinControlLibrary.BTextBox.TextBoxType.IntegerType;
            this.txtDSno.Leave += new System.EventHandler(this.txtSno_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 444482;
            this.label6.Text = "Item Description";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(26, 138);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(31, 13);
            this.bLabel6.TabIndex = 444481;
            this.bLabel6.Text = "SNo.";
            // 
            // txtBillNo
            // 
            this.txtBillNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtBillNo.IsMendatory = false;
            this.txtBillNo.Location = new System.Drawing.Point(127, 42);
            this.txtBillNo.MaxLength = 50;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(131, 20);
            this.txtBillNo.TabIndex = 3;
            this.txtBillNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtBillNo.Leave += new System.EventHandler(this.txtBillNo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 444479;
            this.label4.Text = "Bill no.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 444478;
            this.label3.Text = " Entry Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(541, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 15);
            this.label20.TabIndex = 444477;
            this.label20.Text = "Purchase A/c:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(517, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 15);
            this.label21.TabIndex = 444476;
            this.label21.Text = " Purchase Category";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(534, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 15);
            this.label22.TabIndex = 444475;
            this.label22.Text = "Purchase Type";
            // 
            // txtSerialBillNo
            // 
            this.txtSerialBillNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSerialBillNo.Enabled = false;
            this.txtSerialBillNo.IsMendatory = false;
            this.txtSerialBillNo.Location = new System.Drawing.Point(127, 13);
            this.txtSerialBillNo.MaxLength = 50;
            this.txtSerialBillNo.Name = "txtSerialBillNo";
            this.txtSerialBillNo.Size = new System.Drawing.Size(129, 20);
            this.txtSerialBillNo.TabIndex = 1;
            this.txtSerialBillNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 444474;
            this.label1.Text = "Serial Bill No.";
            // 
            // DirectEntryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 395);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDItemCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdPurchaseBillDetailsDET);
            this.Controls.Add(this.ddlDUMO);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBillDate);
            this.Controls.Add(this.txtEntryDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ddlDItemDesc);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.ddlPurchaseAccount);
            this.Controls.Add(this.ddlPurchaseType);
            this.Controls.Add(this.ddlPurchaseCategory);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDTotalAmt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnItemDesc);
            this.Controls.Add(this.txtDRate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDSno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtSerialBillNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DirectEntryAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direct Entry Add";
            this.Load += new System.EventHandler(this.DirectEntryAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseBillDetailsDET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public WinControlLibrary.BCombo ddlDUMO;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label42;
        public WinControlLibrary.BAllButton btnReset;
        public WinControlLibrary.BDateTextBox txtBillDate;
        public WinControlLibrary.BDateTextBox txtEntryDate;
        private WinControlLibrary.BAllButton btnAdd;
        public WinControlLibrary.BCombo ddlDItemDesc;
        public WinControlLibrary.BTextBox txtNarration;
        public WinControlLibrary.BCombo ddlPurchaseAccount;
        public WinControlLibrary.BCombo ddlPurchaseType;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        public WinControlLibrary.BTextBox txtDTotalAmt;
        public System.Windows.Forms.Label label13;
        private WinControlLibrary.BAllButton btnItemDesc;
        public WinControlLibrary.BTextBox txtDRate;
        private System.Windows.Forms.Label label12;
        public WinControlLibrary.BTextBox txtDQuantity;
        private System.Windows.Forms.Label label9;
        public WinControlLibrary.BTextBox txtDSno;
        private System.Windows.Forms.Label label6;
        private WinControlLibrary.BLabel bLabel6;
        public WinControlLibrary.BTextBox txtBillNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        public WinControlLibrary.BTextBox txtSerialBillNo;
        private System.Windows.Forms.Label label1;
        public WinControlLibrary.BGrid grdPurchaseBillDetailsDET;
        public WinControlLibrary.BAllButton btnCancel;
        public WinControlLibrary.BAllButton btnSave;
        private System.Windows.Forms.Label label2;
        public WinControlLibrary.BTextBox txtDItemCode;
        private System.Windows.Forms.Label label5;
        public WinControlLibrary.BCombo ddlPurchaseCategory;
        public WinControlLibrary.BTextBox txtTotalAmount;
        public System.Windows.Forms.Label label8;
        private WinControlLibrary.BAllButton btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSTPurchaseBillId;
    }
}