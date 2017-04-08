namespace ERP.SalePurchase
{
    partial class AccountGroupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountGroupView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.ddlPrimaryGroup = new WinControlLibrary.BCombo();
            this.btnFind = new WinControlLibrary.BAllButton();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtSearch = new WinControlLibrary.BTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new WinControlLibrary.BAllButton();
            this.btnDelete = new WinControlLibrary.BAllButton();
            this.btnEdit = new WinControlLibrary.BAllButton();
            this.btnAdd = new WinControlLibrary.BAllButton();
            this.grdAccountGroupDetails = new WinControlLibrary.BGrid();
            this.AccountGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefrenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryAccountGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountGroupMasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintSummaryBalType1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintSummaryBalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccountGroupDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bLabel2);
            this.groupBox1.Controls.Add(this.ddlPrimaryGroup);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.bLabel1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 46);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bLabel2.Location = new System.Drawing.Point(45, 14);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(51, 15);
            this.bLabel2.TabIndex = 123;
            this.bLabel2.Text = "Search  ";
            // 
            // ddlPrimaryGroup
            // 
            this.ddlPrimaryGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlPrimaryGroup.DisplayMember = "Value";
            this.ddlPrimaryGroup.FormattingEnabled = true;
            this.ddlPrimaryGroup.Location = new System.Drawing.Point(98, 10);
            this.ddlPrimaryGroup.Name = "ddlPrimaryGroup";
            this.ddlPrimaryGroup.Size = new System.Drawing.Size(181, 21);
            this.ddlPrimaryGroup.TabIndex = 0;
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
            this.btnFind.Location = new System.Drawing.Point(294, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(55, 30);
            this.btnFind.TabIndex = 121;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(411, 13);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(104, 13);
            this.bLabel1.TabIndex = 120;
            this.bLabel1.Text = "Search Group Name";
            this.bLabel1.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSearch.IsMendatory = false;
            this.txtSearch.Location = new System.Drawing.Point(358, 11);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 20);
            this.txtSearch.TabIndex = 119;
            this.txtSearch.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtSearch.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(592, 24);
            this.statusStrip1.TabIndex = 116;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(130, 19);
            this.toolStripStatusLabel3.Text = " F3=>Add";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(130, 19);
            this.toolStripStatusLabel4.Text = " F2 => Edit";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(130, 19);
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
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(120, 19);
            this.toolStripStatusLabel5.Text = "Esc => Exit";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(500, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 35);
            this.btnExit.TabIndex = 5;
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
            this.btnDelete.Location = new System.Drawing.Point(419, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 35);
            this.btnDelete.TabIndex = 4;
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
            this.btnEdit.Location = new System.Drawing.Point(336, 333);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 35);
            this.btnEdit.TabIndex = 3;
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
            this.btnAdd.Location = new System.Drawing.Point(252, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // grdAccountGroupDetails
            // 
            this.grdAccountGroupDetails.AllowUserToAddRows = false;
            this.grdAccountGroupDetails.AllowUserToDeleteRows = false;
            this.grdAccountGroupDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.grdAccountGroupDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAccountGroupDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAccountGroupDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccountGroupDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAccountGroupDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountGroupName,
            this.TypeName,
            this.RefrenceNo,
            this.GrpType,
            this.BType,
            this.type1,
            this.Type,
            this.PrimaryAccountGroup,
            this.AccountGroupMasId,
            this.PrintSummaryBalType1,
            this.PrintSummaryBalType});
            this.grdAccountGroupDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAccountGroupDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdAccountGroupDetails.GridColor = System.Drawing.Color.DarkGray;
            this.grdAccountGroupDetails.Index = 0;
            this.grdAccountGroupDetails.Location = new System.Drawing.Point(12, 64);
            this.grdAccountGroupDetails.MultiSelect = false;
            this.grdAccountGroupDetails.Name = "grdAccountGroupDetails";
            this.grdAccountGroupDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccountGroupDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAccountGroupDetails.RowHeadersWidth = 20;
            this.grdAccountGroupDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccountGroupDetails.Size = new System.Drawing.Size(568, 252);
            this.grdAccountGroupDetails.TabIndex = 112;
            this.grdAccountGroupDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccountGroupDetails_CellContentClick);
            this.grdAccountGroupDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccountGroupDetails_CellMouseEnter_1);
            this.grdAccountGroupDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccountGroupDetails_CellMouseLeave_1);
            this.grdAccountGroupDetails.MouseEnter += new System.EventHandler(this.grdAccountGroupDetails_MouseEnter_1);
            // 
            // AccountGroupName
            // 
            this.AccountGroupName.DataPropertyName = "AccountGroupName";
            this.AccountGroupName.HeaderText = "Group Name";
            this.AccountGroupName.Name = "AccountGroupName";
            this.AccountGroupName.ReadOnly = true;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "B-Type";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            // 
            // RefrenceNo
            // 
            this.RefrenceNo.DataPropertyName = "RefrenceNo";
            this.RefrenceNo.HeaderText = "Ref No";
            this.RefrenceNo.Name = "RefrenceNo";
            this.RefrenceNo.ReadOnly = true;
            // 
            // GrpType
            // 
            this.GrpType.DataPropertyName = "GrpType";
            this.GrpType.HeaderText = "Group Type";
            this.GrpType.Name = "GrpType";
            this.GrpType.ReadOnly = true;
            this.GrpType.Visible = false;
            // 
            // BType
            // 
            this.BType.DataPropertyName = "BType";
            this.BType.HeaderText = "B Type";
            this.BType.Name = "BType";
            this.BType.ReadOnly = true;
            this.BType.Visible = false;
            // 
            // type1
            // 
            this.type1.DataPropertyName = "type1";
            this.type1.HeaderText = "Type(Debit/Credit)";
            this.type1.Name = "type1";
            this.type1.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type(Br/Cr)";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // PrimaryAccountGroup
            // 
            this.PrimaryAccountGroup.DataPropertyName = "PrimaryAccountGroup";
            this.PrimaryAccountGroup.HeaderText = "Primary Account Group";
            this.PrimaryAccountGroup.Name = "PrimaryAccountGroup";
            this.PrimaryAccountGroup.ReadOnly = true;
            this.PrimaryAccountGroup.Visible = false;
            // 
            // AccountGroupMasId
            // 
            this.AccountGroupMasId.DataPropertyName = "AccountGroupMasId";
            this.AccountGroupMasId.HeaderText = "Account Group MasId";
            this.AccountGroupMasId.Name = "AccountGroupMasId";
            this.AccountGroupMasId.ReadOnly = true;
            this.AccountGroupMasId.Visible = false;
            // 
            // PrintSummaryBalType1
            // 
            this.PrintSummaryBalType1.DataPropertyName = "PrintSummaryBalType1";
            this.PrintSummaryBalType1.HeaderText = "PrintSummaryBalType";
            this.PrintSummaryBalType1.Name = "PrintSummaryBalType1";
            this.PrintSummaryBalType1.ReadOnly = true;
            this.PrintSummaryBalType1.Visible = false;
            // 
            // PrintSummaryBalType
            // 
            this.PrintSummaryBalType.DataPropertyName = "PrintSummaryBalType";
            this.PrintSummaryBalType.HeaderText = "PrintSummaryBalType1";
            this.PrintSummaryBalType.Name = "PrintSummaryBalType";
            this.PrintSummaryBalType.ReadOnly = true;
            this.PrintSummaryBalType.Visible = false;
            // 
            // AccountGroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdAccountGroupDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountGroupView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Group Setup";
            this.Load += new System.EventHandler(this.AccountGroupView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccountGroupDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public WinControlLibrary.BGrid grdAccountGroupDetails;
        private WinControlLibrary.BAllButton btnExit;
        private WinControlLibrary.BAllButton btnDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public WinControlLibrary.BAllButton btnEdit;
        public WinControlLibrary.BAllButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefrenceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BType;
        private System.Windows.Forms.DataGridViewTextBoxColumn type1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryAccountGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountGroupMasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintSummaryBalType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintSummaryBalType;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BCombo ddlPrimaryGroup;
        public WinControlLibrary.BAllButton btnFind;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtSearch;
    }
}