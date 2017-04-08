namespace ERP.SalePurchase
{
    partial class DirectEntryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectEntryView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new WinControlLibrary.BAllButton();
            this.btnAdd = new WinControlLibrary.BAllButton();
            this.btnDelete = new WinControlLibrary.BAllButton();
            this.btnEdit = new WinControlLibrary.BAllButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlPrimaryGroup = new WinControlLibrary.BCombo();
            this.btnFind = new WinControlLibrary.BAllButton();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.grdPurchaseBillDetails = new WinControlLibrary.BGrid();
            this.Entrydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseCategyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseCategyText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTypeText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPurchaseBillDetailsDET = new WinControlLibrary.BGrid();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AliasItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDecsText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSTPurchaseBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseBillDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseBillDetailsDET)).BeginInit();
            this.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 24);
            this.statusStrip1.TabIndex = 358;
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(745, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 347;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(464, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 344;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(651, 355);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 346;
            this.btnDelete.Text = "  Delete";
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
            this.btnEdit.Location = new System.Drawing.Point(558, 355);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 345;
            this.btnEdit.Text = "     Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlPrimaryGroup);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.bLabel5);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 62);
            this.groupBox1.TabIndex = 359;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // ddlPrimaryGroup
            // 
            this.ddlPrimaryGroup.BackColor = System.Drawing.Color.White;
            this.ddlPrimaryGroup.DisplayMember = "Value";
            this.ddlPrimaryGroup.FormattingEnabled = true;
            this.ddlPrimaryGroup.Location = new System.Drawing.Point(22, 35);
            this.ddlPrimaryGroup.Name = "ddlPrimaryGroup";
            this.ddlPrimaryGroup.Size = new System.Drawing.Size(161, 21);
            this.ddlPrimaryGroup.TabIndex = 364;
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
            this.btnFind.Location = new System.Drawing.Point(189, 36);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 362;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bLabel5.Location = new System.Drawing.Point(19, 15);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(36, 15);
            this.bLabel5.TabIndex = 363;
            this.bLabel5.Text = "Party";
            // 
            // grdPurchaseBillDetails
            // 
            this.grdPurchaseBillDetails.AllowUserToAddRows = false;
            this.grdPurchaseBillDetails.AllowUserToDeleteRows = false;
            this.grdPurchaseBillDetails.AllowUserToOrderColumns = true;
            this.grdPurchaseBillDetails.AllowUserToResizeColumns = false;
            this.grdPurchaseBillDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPurchaseBillDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPurchaseBillDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPurchaseBillDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPurchaseBillDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entrydate,
            this.PurchaseBillId,
            this.BillNo,
            this.BillDate,
            this.AccountGroupName,
            this.BillAmount,
            this.SerialBillNo,
            this.Narration,
            this.PurchaseCategyId,
            this.PurchaseCategyText,
            this.PurchaseTypeText,
            this.PurchaseTypeId,
            this.TotalAmount,
            this.PurchaseAccountId});
            this.grdPurchaseBillDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPurchaseBillDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdPurchaseBillDetails.GridColor = System.Drawing.Color.DarkGray;
            this.grdPurchaseBillDetails.Index = 0;
            this.grdPurchaseBillDetails.Location = new System.Drawing.Point(14, 83);
            this.grdPurchaseBillDetails.MultiSelect = false;
            this.grdPurchaseBillDetails.Name = "grdPurchaseBillDetails";
            this.grdPurchaseBillDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPurchaseBillDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPurchaseBillDetails.RowHeadersWidth = 20;
            this.grdPurchaseBillDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPurchaseBillDetails.Size = new System.Drawing.Size(804, 125);
            this.grdPurchaseBillDetails.TabIndex = 360;
            this.grdPurchaseBillDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPurchaseBillDetails_CellContentClick_1);
            // 
            // Entrydate
            // 
            this.Entrydate.DataPropertyName = "Entrydate";
            this.Entrydate.HeaderText = "Entry Date";
            this.Entrydate.Name = "Entrydate";
            this.Entrydate.ReadOnly = true;
            // 
            // PurchaseBillId
            // 
            this.PurchaseBillId.DataPropertyName = "PurchaseBillId";
            this.PurchaseBillId.HeaderText = "PurchaseBillId";
            this.PurchaseBillId.Name = "PurchaseBillId";
            this.PurchaseBillId.ReadOnly = true;
            this.PurchaseBillId.Visible = false;
            this.PurchaseBillId.Width = 5;
            // 
            // BillNo
            // 
            this.BillNo.DataPropertyName = "BillNo";
            this.BillNo.HeaderText = "Bill.No.";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // BillDate
            // 
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "Bill Date";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // AccountGroupName
            // 
            this.AccountGroupName.DataPropertyName = "AccountGroupName";
            this.AccountGroupName.HeaderText = " Group Name";
            this.AccountGroupName.Name = "AccountGroupName";
            this.AccountGroupName.ReadOnly = true;
            this.AccountGroupName.Width = 140;
            // 
            // BillAmount
            // 
            this.BillAmount.DataPropertyName = "BillAmount";
            this.BillAmount.HeaderText = " Bill Amount";
            this.BillAmount.Name = "BillAmount";
            this.BillAmount.ReadOnly = true;
            this.BillAmount.Width = 120;
            // 
            // SerialBillNo
            // 
            this.SerialBillNo.DataPropertyName = "SerialBillNo";
            this.SerialBillNo.HeaderText = "Serial Bill No";
            this.SerialBillNo.Name = "SerialBillNo";
            this.SerialBillNo.ReadOnly = true;
            this.SerialBillNo.Width = 130;
            // 
            // Narration
            // 
            this.Narration.DataPropertyName = "Narration";
            this.Narration.HeaderText = "Narration";
            this.Narration.Name = "Narration";
            this.Narration.ReadOnly = true;
            // 
            // PurchaseCategyId
            // 
            this.PurchaseCategyId.DataPropertyName = "PurchaseCategyId";
            this.PurchaseCategyId.HeaderText = "Purchase Categy Id";
            this.PurchaseCategyId.Name = "PurchaseCategyId";
            this.PurchaseCategyId.ReadOnly = true;
            this.PurchaseCategyId.Width = 5;
            // 
            // PurchaseCategyText
            // 
            this.PurchaseCategyText.DataPropertyName = "PurchaseCategyText";
            this.PurchaseCategyText.HeaderText = "Purchase Category ";
            this.PurchaseCategyText.Name = "PurchaseCategyText";
            this.PurchaseCategyText.ReadOnly = true;
            this.PurchaseCategyText.Width = 140;
            // 
            // PurchaseTypeText
            // 
            this.PurchaseTypeText.DataPropertyName = "PurchaseTypeText";
            this.PurchaseTypeText.HeaderText = "Purchase -Type";
            this.PurchaseTypeText.Name = "PurchaseTypeText";
            this.PurchaseTypeText.ReadOnly = true;
            this.PurchaseTypeText.Width = 130;
            // 
            // PurchaseTypeId
            // 
            this.PurchaseTypeId.DataPropertyName = "PurchaseTypeId";
            this.PurchaseTypeId.HeaderText = "Purchase Type Id";
            this.PurchaseTypeId.Name = "PurchaseTypeId";
            this.PurchaseTypeId.ReadOnly = true;
            this.PurchaseTypeId.Width = 5;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // PurchaseAccountId
            // 
            this.PurchaseAccountId.DataPropertyName = "PurchaseAccountId";
            this.PurchaseAccountId.HeaderText = "PurchaseAccountId";
            this.PurchaseAccountId.Name = "PurchaseAccountId";
            this.PurchaseAccountId.ReadOnly = true;
            this.PurchaseAccountId.Width = 5;
            // 
            // grdPurchaseBillDetailsDET
            // 
            this.grdPurchaseBillDetailsDET.AllowUserToAddRows = false;
            this.grdPurchaseBillDetailsDET.AllowUserToDeleteRows = false;
            this.grdPurchaseBillDetailsDET.AllowUserToOrderColumns = true;
            this.grdPurchaseBillDetailsDET.AllowUserToResizeColumns = false;
            this.grdPurchaseBillDetailsDET.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.grdPurchaseBillDetailsDET.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdPurchaseBillDetailsDET.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPurchaseBillDetailsDET.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdPurchaseBillDetailsDET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.AliasItemCode,
            this.ItemDecsId,
            this.ItemDecsText,
            this.UOMId,
            this.UOMText,
            this.Qty,
            this.Rate,
            this.dataGridViewTextBoxColumn2,
            this.MSTPurchaseBillId});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPurchaseBillDetailsDET.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdPurchaseBillDetailsDET.GridColor = System.Drawing.Color.DarkGray;
            this.grdPurchaseBillDetailsDET.Index = 0;
            this.grdPurchaseBillDetailsDET.Location = new System.Drawing.Point(14, 214);
            this.grdPurchaseBillDetailsDET.MultiSelect = false;
            this.grdPurchaseBillDetailsDET.Name = "grdPurchaseBillDetailsDET";
            this.grdPurchaseBillDetailsDET.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPurchaseBillDetailsDET.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdPurchaseBillDetailsDET.RowHeadersWidth = 20;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.grdPurchaseBillDetailsDET.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grdPurchaseBillDetailsDET.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPurchaseBillDetailsDET.Size = new System.Drawing.Size(804, 135);
            this.grdPurchaseBillDetailsDET.TabIndex = 361;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "S.No.";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 70;
            // 
            // AliasItemCode
            // 
            this.AliasItemCode.DataPropertyName = "AliasItemCode";
            this.AliasItemCode.HeaderText = " Item Code";
            this.AliasItemCode.Name = "AliasItemCode";
            this.AliasItemCode.ReadOnly = true;
            // 
            // ItemDecsId
            // 
            this.ItemDecsId.DataPropertyName = "ItemDecsId";
            this.ItemDecsId.HeaderText = "Item DescId";
            this.ItemDecsId.Name = "ItemDecsId";
            this.ItemDecsId.ReadOnly = true;
            this.ItemDecsId.Visible = false;
            this.ItemDecsId.Width = 5;
            // 
            // ItemDecsText
            // 
            this.ItemDecsText.DataPropertyName = "ItemDecsText";
            this.ItemDecsText.HeaderText = "Item Decs ";
            this.ItemDecsText.Name = "ItemDecsText";
            this.ItemDecsText.ReadOnly = true;
            this.ItemDecsText.Width = 120;
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
            // UOMText
            // 
            this.UOMText.DataPropertyName = "UOMText";
            this.UOMText.HeaderText = "UOM ";
            this.UOMText.Name = "UOMText";
            this.UOMText.ReadOnly = true;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
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
            // DirectEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 406);
            this.Controls.Add(this.grdPurchaseBillDetailsDET);
            this.Controls.Add(this.grdPurchaseBillDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            //this.Name = "DirectEntryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direct Entry";
            this.Load += new System.EventHandler(this.DirectEntryView_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseBillDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseBillDetailsDET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BAllButton btnExit;
        private WinControlLibrary.BAllButton btnAdd;
        private WinControlLibrary.BAllButton btnDelete;
        private WinControlLibrary.BAllButton btnEdit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public WinControlLibrary.BCombo ddlPrimaryGroup;
        private WinControlLibrary.BAllButton btnFind;
        private WinControlLibrary.BLabel bLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        public WinControlLibrary.BGrid grdPurchaseBillDetails;
        public WinControlLibrary.BGrid grdPurchaseBillDetailsDET;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseBillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Narration;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseCategyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseCategyText;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTypeText;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AliasItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDecsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDecsText;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSTPurchaseBillId;
    }
}