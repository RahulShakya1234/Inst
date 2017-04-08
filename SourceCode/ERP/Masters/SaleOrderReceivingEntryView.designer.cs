namespace ERP.SalePurchase
{
    partial class SaleOrderReceivingEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleOrderReceivingEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtToDate = new WinControlLibrary.BDateTextBox();
            this.txtFromDate = new WinControlLibrary.BDateTextBox();
            this.bCombo1 = new WinControlLibrary.BCombo();
            this.ddlPrimaryGroup = new WinControlLibrary.BCombo();
            this.btnFind = new WinControlLibrary.BAllButton();
            this.btnExit = new WinControlLibrary.BAllButton();
            this.btnDelete = new WinControlLibrary.BAllButton();
            this.btnEdit = new WinControlLibrary.BAllButton();
            this.btnAdd = new WinControlLibrary.BAllButton();
            this.txtSearch = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.btnRefresh = new WinControlLibrary.BAllButton();
            this.txtActive = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.grdSaleOrderDetail2 = new WinControlLibrary.BGrid();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleOrderReceivingEntryDetailId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdSaleOrderDetial1 = new WinControlLibrary.BGrid();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGrid2 = new WinControlLibrary.BGrid();
            this.bGrid1 = new WinControlLibrary.BGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleOrderDetail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleOrderDetial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtToDate
            // 
            this.txtToDate.AllowBlank = false;
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.Location = new System.Drawing.Point(134, 72);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(100, 20);
            this.txtToDate.TabIndex = 37;
            // 
            // txtFromDate
            // 
            this.txtFromDate.AllowBlank = false;
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.Location = new System.Drawing.Point(134, 34);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(100, 20);
            this.txtFromDate.TabIndex = 36;
            // 
            // bCombo1
            // 
            this.bCombo1.BackColor = System.Drawing.SystemColors.Control;
            this.bCombo1.DisplayMember = "Value";
            this.bCombo1.FormattingEnabled = true;
            this.bCombo1.Location = new System.Drawing.Point(83, 114);
            this.bCombo1.Name = "bCombo1";
            this.bCombo1.Size = new System.Drawing.Size(217, 21);
            this.bCombo1.TabIndex = 33;
            this.bCombo1.ValueMember = "Code";
            // 
            // ddlPrimaryGroup
            // 
            this.ddlPrimaryGroup.BackColor = System.Drawing.SystemColors.Control;
            this.ddlPrimaryGroup.DisplayMember = "Value";
            this.ddlPrimaryGroup.FormattingEnabled = true;
            this.ddlPrimaryGroup.Location = new System.Drawing.Point(292, 29);
            this.ddlPrimaryGroup.Name = "ddlPrimaryGroup";
            this.ddlPrimaryGroup.Size = new System.Drawing.Size(217, 21);
            this.ddlPrimaryGroup.TabIndex = 32;
            this.ddlPrimaryGroup.ValueMember = "Code";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFind.Location = new System.Drawing.Point(306, 115);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 25);
            this.btnFind.TabIndex = 23;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(693, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(600, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(509, 393);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(416, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSearch.IsMendatory = false;
            this.txtSearch.Location = new System.Drawing.Point(398, 117);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtSearch.Visible = false;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel5.Location = new System.Drawing.Point(27, 117);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(52, 15);
            this.bLabel5.TabIndex = 22;
            this.bLabel5.Text = "Search :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Location = new System.Drawing.Point(641, 60);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtActive
            // 
            this.txtActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtActive.IsMendatory = false;
            this.txtActive.Location = new System.Drawing.Point(641, 34);
            this.txtActive.MaxLength = 50;
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(108, 20);
            this.txtActive.TabIndex = 2;
            this.txtActive.Text = "All";
            this.txtActive.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel4.Location = new System.Drawing.Point(598, 37);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(38, 15);
            this.bLabel4.TabIndex = 19;
            this.bLabel4.Text = "Active";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel3.Location = new System.Drawing.Point(255, 32);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(34, 15);
            this.bLabel3.TabIndex = 17;
            this.bLabel3.Text = "Party";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel2.Location = new System.Drawing.Point(37, 75);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(56, 15);
            this.bLabel2.TabIndex = 15;
            this.bLabel2.Text = "To Date :";
            this.bLabel2.Click += new System.EventHandler(this.bLabel2_Click);
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel1.Location = new System.Drawing.Point(27, 37);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(71, 15);
            this.bLabel1.TabIndex = 13;
            this.bLabel1.Text = "From Date :";
            // 
            // grdSaleOrderDetail2
            // 
            this.grdSaleOrderDetail2.AllowUserToAddRows = false;
            this.grdSaleOrderDetail2.AllowUserToDeleteRows = false;
            this.grdSaleOrderDetail2.AllowUserToOrderColumns = true;
            this.grdSaleOrderDetail2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdSaleOrderDetail2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaleOrderDetail2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemDescription,
            this.Qty,
            this.Rate,
            this.Amount,
            this.SaleOrderReceivingEntryDetailId2});
            this.grdSaleOrderDetail2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdSaleOrderDetail2.Index = 0;
            this.grdSaleOrderDetail2.Location = new System.Drawing.Point(30, 268);
            this.grdSaleOrderDetail2.Name = "grdSaleOrderDetail2";
            this.grdSaleOrderDetail2.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleOrderDetail2.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSaleOrderDetail2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaleOrderDetail2.Size = new System.Drawing.Size(736, 95);
            this.grdSaleOrderDetail2.TabIndex = 7;
            this.grdSaleOrderDetail2.Visible = false;
            this.grdSaleOrderDetail2.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSaleOrderDetail2_CellMouseEnter);
            this.grdSaleOrderDetail2.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSaleOrderDetail2_CellMouseLeave);
            this.grdSaleOrderDetail2.MouseEnter += new System.EventHandler(this.grdSaleOrderDetail2_MouseEnter);
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "ItemDescription";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // SaleOrderReceivingEntryDetailId2
            // 
            this.SaleOrderReceivingEntryDetailId2.DataPropertyName = "SaleOrderReceivingEntryDetailId2";
            this.SaleOrderReceivingEntryDetailId2.HeaderText = "SaleOrderReceivingEntryDetailId";
            this.SaleOrderReceivingEntryDetailId2.Name = "SaleOrderReceivingEntryDetailId2";
            this.SaleOrderReceivingEntryDetailId2.ReadOnly = true;
            this.SaleOrderReceivingEntryDetailId2.Visible = false;
            // 
            // grdSaleOrderDetial1
            // 
            this.grdSaleOrderDetial1.AllowUserToAddRows = false;
            this.grdSaleOrderDetial1.AllowUserToDeleteRows = false;
            this.grdSaleOrderDetial1.AllowUserToOrderColumns = true;
            this.grdSaleOrderDetial1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleOrderDetial1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdSaleOrderDetial1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaleOrderDetial1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNo,
            this.OrderDate,
            this.Party,
            this.Remarks,
            this.Active,
            this.Total,
            this.Id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSaleOrderDetial1.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdSaleOrderDetial1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdSaleOrderDetial1.Index = 0;
            this.grdSaleOrderDetial1.Location = new System.Drawing.Point(32, 165);
            this.grdSaleOrderDetial1.Name = "grdSaleOrderDetial1";
            this.grdSaleOrderDetial1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleOrderDetial1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdSaleOrderDetial1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaleOrderDetial1.Size = new System.Drawing.Size(736, 97);
            this.grdSaleOrderDetial1.TabIndex = 6;
            this.grdSaleOrderDetial1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSaleOrderDetial1_CellMouseEnter);
            this.grdSaleOrderDetial1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSaleOrderDetial1_CellMouseLeave);
            this.grdSaleOrderDetial1.MouseEnter += new System.EventHandler(this.grdSaleOrderDetial1_MouseEnter);
            // 
            // OrderNo
            // 
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.HeaderText = "Order No.";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // Party
            // 
            this.Party.DataPropertyName = "Party";
            this.Party.HeaderText = "Party Name";
            this.Party.Name = "Party";
            this.Party.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
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
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "SaleOrderReceivingEntryDetailId2";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // bGrid2
            // 
            this.bGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.bGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bGrid2.Index = 0;
            this.bGrid2.Location = new System.Drawing.Point(12, 20);
            this.bGrid2.Name = "bGrid2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bGrid2.Size = new System.Drawing.Size(758, 85);
            this.bGrid2.TabIndex = 10;
            // 
            // bGrid1
            // 
            this.bGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.bGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bGrid1.Index = 0;
            this.bGrid1.Location = new System.Drawing.Point(12, 20);
            this.bGrid1.Name = "bGrid1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bGrid1.Size = new System.Drawing.Size(759, 367);
            this.bGrid1.TabIndex = 9;
            // 
            // SaleOrderReceivingEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 424);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.bCombo1);
            this.Controls.Add(this.ddlPrimaryGroup);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtActive);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.grdSaleOrderDetail2);
            this.Controls.Add(this.grdSaleOrderDetial1);
            this.Controls.Add(this.bGrid2);
            this.Controls.Add(this.bGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleOrderReceivingEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleOrderReceivingEntry";
            this.Load += new System.EventHandler(this.SaleOrderReceivingEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleOrderDetail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleOrderDetial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BGrid bGrid1;
        private WinControlLibrary.BGrid bGrid2;
        private WinControlLibrary.BGrid grdSaleOrderDetial1;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BTextBox txtActive;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtSearch;
        private WinControlLibrary.BAllButton btnExit;
        private WinControlLibrary.BAllButton btnDelete;
        private WinControlLibrary.BAllButton btnEdit;
        private WinControlLibrary.BAllButton btnAdd;
        private WinControlLibrary.BGrid grdSaleOrderDetail2;
        private WinControlLibrary.BAllButton btnRefresh;
        public WinControlLibrary.BAllButton btnFind;
        public WinControlLibrary.BCombo ddlPrimaryGroup;
        public WinControlLibrary.BCombo bCombo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleOrderReceivingEntryDetailId2;
        private WinControlLibrary.BDateTextBox txtFromDate;
        private WinControlLibrary.BDateTextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}