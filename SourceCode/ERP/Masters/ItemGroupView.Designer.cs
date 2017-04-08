namespace ERP.SalePurchase
{
    partial class ItemGroupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemGroupView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new WinControlLibrary.BAllButton();
            this.btnRefresh = new WinControlLibrary.BAllButton();
            this.txtSearch = new WinControlLibrary.BTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new WinControlLibrary.BAllButton();
            this.btnDelete = new WinControlLibrary.BAllButton();
            this.btnEdit = new WinControlLibrary.BAllButton();
            this.btnADD = new WinControlLibrary.BAllButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grdItemGroupView = new WinControlLibrary.BGrid();
            this.ItemGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGroupMasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperGroup1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalableItemGrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutomaticQC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoAssemblyFromRGP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoMrn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POReqInMRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowInWorkerOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeAutoProdEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleNoRequiredinMRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemGroupView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 43);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFind.Location = new System.Drawing.Point(290, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 25);
            this.btnFind.TabIndex = 154;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Location = new System.Drawing.Point(366, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(70, 35);
            this.btnRefresh.TabIndex = 153;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.IsMendatory = true;
            this.txtSearch.Location = new System.Drawing.Point(105, 10);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 151;
            this.txtSearch.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(52, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 152;
            this.label3.Text = "Search :";
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
            this.btnExit.Location = new System.Drawing.Point(431, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 149;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
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
            this.btnDelete.Location = new System.Drawing.Point(338, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 148;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
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
            this.btnEdit.Location = new System.Drawing.Point(247, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 147;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Transparent;
            this.btnADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADD.BackgroundImage")));
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnADD.Location = new System.Drawing.Point(154, 267);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 25);
            this.btnADD.TabIndex = 146;
            this.btnADD.Text = "&Add";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 315);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(515, 22);
            this.statusStrip1.TabIndex = 133;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(120, 17);
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
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(90, 17);
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(150, 17);
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
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel5.Text = "Esc => Exit";
            // 
            // grdItemGroupView
            // 
            this.grdItemGroupView.AllowUserToAddRows = false;
            this.grdItemGroupView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.grdItemGroupView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdItemGroupView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItemGroupView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdItemGroupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItemGroupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemGroupName,
            this.ItemGroupMasId,
            this.UpperGroup,
            this.UpperGroup1,
            this.Prefix,
            this.SalableItemGrp,
            this.AutomaticQC,
            this.AutoAssemblyFromRGP,
            this.AutoMrn,
            this.POReqInMRN,
            this.ShowInWorkerOrder,
            this.MakeAutoProdEntry,
            this.ScheduleNoRequiredinMRN});
            this.grdItemGroupView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdItemGroupView.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdItemGroupView.GridColor = System.Drawing.Color.DarkGray;
            this.grdItemGroupView.Index = 0;
            this.grdItemGroupView.Location = new System.Drawing.Point(9, 67);
            this.grdItemGroupView.Margin = new System.Windows.Forms.Padding(0);
            this.grdItemGroupView.MultiSelect = false;
            this.grdItemGroupView.Name = "grdItemGroupView";
            this.grdItemGroupView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItemGroupView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdItemGroupView.RowHeadersWidth = 15;
            this.grdItemGroupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItemGroupView.Size = new System.Drawing.Size(494, 188);
            this.grdItemGroupView.TabIndex = 3;
            this.grdItemGroupView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItemGroupView_CellContentClick);
            this.grdItemGroupView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItemGroupView_CellMouseEnter);
            this.grdItemGroupView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItemGroupView_CellMouseLeave);
            this.grdItemGroupView.MouseEnter += new System.EventHandler(this.grdItemGroupView_MouseEnter);
            // 
            // ItemGroupName
            // 
            this.ItemGroupName.DataPropertyName = "ItemGroupName";
            this.ItemGroupName.HeaderText = "GroupName";
            this.ItemGroupName.Name = "ItemGroupName";
            this.ItemGroupName.ReadOnly = true;
            this.ItemGroupName.Width = 200;
            // 
            // ItemGroupMasId
            // 
            this.ItemGroupMasId.DataPropertyName = "ItemGroupMasId";
            this.ItemGroupMasId.HeaderText = "ItemGroupMasId";
            this.ItemGroupMasId.Name = "ItemGroupMasId";
            this.ItemGroupMasId.ReadOnly = true;
            this.ItemGroupMasId.Visible = false;
            this.ItemGroupMasId.Width = 5;
            // 
            // UpperGroup
            // 
            this.UpperGroup.DataPropertyName = "UpperGroup";
            this.UpperGroup.HeaderText = "UpperGroup";
            this.UpperGroup.Name = "UpperGroup";
            this.UpperGroup.ReadOnly = true;
            this.UpperGroup.Visible = false;
            this.UpperGroup.Width = 5;
            // 
            // UpperGroup1
            // 
            this.UpperGroup1.DataPropertyName = "UpperGroup1";
            this.UpperGroup1.HeaderText = "UpperGroup1";
            this.UpperGroup1.Name = "UpperGroup1";
            this.UpperGroup1.ReadOnly = true;
            this.UpperGroup1.Visible = false;
            // 
            // Prefix
            // 
            this.Prefix.DataPropertyName = "Prefix";
            this.Prefix.HeaderText = "Prefix";
            this.Prefix.Name = "Prefix";
            this.Prefix.ReadOnly = true;
            this.Prefix.Visible = false;
            this.Prefix.Width = 5;
            // 
            // SalableItemGrp
            // 
            this.SalableItemGrp.DataPropertyName = "SalableItemGrp";
            this.SalableItemGrp.HeaderText = "SalableItemGrp";
            this.SalableItemGrp.Name = "SalableItemGrp";
            this.SalableItemGrp.ReadOnly = true;
            this.SalableItemGrp.Visible = false;
            this.SalableItemGrp.Width = 5;
            // 
            // AutomaticQC
            // 
            this.AutomaticQC.DataPropertyName = "AutomaticQC";
            this.AutomaticQC.HeaderText = "AutomaticQC";
            this.AutomaticQC.Name = "AutomaticQC";
            this.AutomaticQC.ReadOnly = true;
            this.AutomaticQC.Visible = false;
            this.AutomaticQC.Width = 5;
            // 
            // AutoAssemblyFromRGP
            // 
            this.AutoAssemblyFromRGP.DataPropertyName = "AutoAssemblyFromRGP";
            this.AutoAssemblyFromRGP.HeaderText = "AutoAssemblyFromRGP";
            this.AutoAssemblyFromRGP.Name = "AutoAssemblyFromRGP";
            this.AutoAssemblyFromRGP.ReadOnly = true;
            this.AutoAssemblyFromRGP.Visible = false;
            this.AutoAssemblyFromRGP.Width = 5;
            // 
            // AutoMrn
            // 
            this.AutoMrn.DataPropertyName = "AutoMrn";
            this.AutoMrn.HeaderText = "AutoMrn";
            this.AutoMrn.Name = "AutoMrn";
            this.AutoMrn.ReadOnly = true;
            this.AutoMrn.Visible = false;
            this.AutoMrn.Width = 5;
            // 
            // POReqInMRN
            // 
            this.POReqInMRN.DataPropertyName = "POReqInMRN";
            this.POReqInMRN.HeaderText = "POReqInMRN";
            this.POReqInMRN.Name = "POReqInMRN";
            this.POReqInMRN.ReadOnly = true;
            this.POReqInMRN.Visible = false;
            this.POReqInMRN.Width = 5;
            // 
            // ShowInWorkerOrder
            // 
            this.ShowInWorkerOrder.DataPropertyName = "ShowInWorkerOrder";
            this.ShowInWorkerOrder.HeaderText = "ShowInWorkerOrder";
            this.ShowInWorkerOrder.Name = "ShowInWorkerOrder";
            this.ShowInWorkerOrder.ReadOnly = true;
            this.ShowInWorkerOrder.Visible = false;
            this.ShowInWorkerOrder.Width = 5;
            // 
            // MakeAutoProdEntry
            // 
            this.MakeAutoProdEntry.DataPropertyName = "MakeAutoProdEntry";
            this.MakeAutoProdEntry.HeaderText = "MakeAutoProdEntry";
            this.MakeAutoProdEntry.Name = "MakeAutoProdEntry";
            this.MakeAutoProdEntry.ReadOnly = true;
            this.MakeAutoProdEntry.Visible = false;
            this.MakeAutoProdEntry.Width = 5;
            // 
            // ScheduleNoRequiredinMRN
            // 
            this.ScheduleNoRequiredinMRN.DataPropertyName = "ScheduleNoRequiredinMRN";
            this.ScheduleNoRequiredinMRN.HeaderText = "ScheduleNoRequiredinMRN";
            this.ScheduleNoRequiredinMRN.Name = "ScheduleNoRequiredinMRN";
            this.ScheduleNoRequiredinMRN.ReadOnly = true;
            this.ScheduleNoRequiredinMRN.Visible = false;
            this.ScheduleNoRequiredinMRN.Width = 5;
            // 
            // ItemGroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grdItemGroupView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemGroupView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Group View";
            this.Load += new System.EventHandler(this.ItemGroupView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemGroupView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public WinControlLibrary.BGrid grdItemGroupView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGroupMasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperGroup1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalableItemGrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutomaticQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoAssemblyFromRGP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoMrn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POReqInMRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowInWorkerOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakeAutoProdEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleNoRequiredinMRN;
        private WinControlLibrary.BAllButton btnExit;
        private WinControlLibrary.BAllButton btnDelete;
        private WinControlLibrary.BAllButton btnEdit;
        private WinControlLibrary.BAllButton btnADD;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BAllButton btnFind;
        private WinControlLibrary.BAllButton btnRefresh;
        private WinControlLibrary.BTextBox txtSearch;
        private System.Windows.Forms.Label label3;
    }
}