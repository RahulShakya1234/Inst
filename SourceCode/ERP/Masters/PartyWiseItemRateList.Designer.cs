namespace ERP.SalePurchase
{
    partial class PartyWiseItemRateList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyWiseItemRateList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFind = new WinControlLibrary.BAllButton();
            this.btnExit = new WinControlLibrary.BAllButton();
            this.btnDelete = new WinControlLibrary.BAllButton();
            this.btnEdit = new WinControlLibrary.BAllButton();
            this.btnAdd = new WinControlLibrary.BAllButton();
            this.radioBtnRatelistWise = new System.Windows.Forms.RadioButton();
            this.radiobtnItemWise = new System.Windows.Forms.RadioButton();
            this.grdPartWiseRateList = new WinControlLibrary.BGrid();
            this.txtItem = new WinControlLibrary.BTextBox();
            this.txtParty = new WinControlLibrary.BTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new WinControlLibrary.BTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountGroupMasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PONo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyWiseMasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmendmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PODate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmendmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolSupplyForQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolNarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartWiseRateList)).BeginInit();
            this.SuspendLayout();
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
            this.btnFind.Location = new System.Drawing.Point(238, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 25);
            this.btnFind.TabIndex = 150;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
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
            this.btnExit.Location = new System.Drawing.Point(659, 328);
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
            this.btnDelete.Location = new System.Drawing.Point(566, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 148;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(475, 328);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 147;
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
            this.btnAdd.Location = new System.Drawing.Point(382, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 146;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radioBtnRatelistWise
            // 
            this.radioBtnRatelistWise.AutoSize = true;
            this.radioBtnRatelistWise.Location = new System.Drawing.Point(139, 71);
            this.radioBtnRatelistWise.Name = "radioBtnRatelistWise";
            this.radioBtnRatelistWise.Size = new System.Drawing.Size(94, 17);
            this.radioBtnRatelistWise.TabIndex = 14;
            this.radioBtnRatelistWise.Text = "Rate List Wise";
            this.radioBtnRatelistWise.UseVisualStyleBackColor = true;
            this.radioBtnRatelistWise.CheckedChanged += new System.EventHandler(this.radioBtnRatelistWise_CheckedChanged);
            // 
            // radiobtnItemWise
            // 
            this.radiobtnItemWise.AutoSize = true;
            this.radiobtnItemWise.Checked = true;
            this.radiobtnItemWise.Location = new System.Drawing.Point(61, 71);
            this.radiobtnItemWise.Name = "radiobtnItemWise";
            this.radiobtnItemWise.Size = new System.Drawing.Size(72, 17);
            this.radiobtnItemWise.TabIndex = 13;
            this.radiobtnItemWise.TabStop = true;
            this.radiobtnItemWise.Text = "Item Wise";
            this.radiobtnItemWise.UseVisualStyleBackColor = true;
            // 
            // grdPartWiseRateList
            // 
            this.grdPartWiseRateList.AllowUserToAddRows = false;
            this.grdPartWiseRateList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdPartWiseRateList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPartWiseRateList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPartWiseRateList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPartWiseRateList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPartWiseRateList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountGroupName,
            this.AccountGroupMasId,
            this.ItemName,
            this.ItemCode,
            this.PackingRate,
            this.PONo,
            this.ToolRate,
            this.Tax,
            this.PartyWiseMasId,
            this.AmendmentNo,
            this.PODate,
            this.AmendmentDate,
            this.PartNo,
            this.ToolSupplyForQty,
            this.ToolNarr,
            this.ProcessName});
            this.grdPartWiseRateList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPartWiseRateList.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdPartWiseRateList.GridColor = System.Drawing.Color.DarkGray;
            this.grdPartWiseRateList.Index = 0;
            this.grdPartWiseRateList.Location = new System.Drawing.Point(18, 94);
            this.grdPartWiseRateList.MultiSelect = false;
            this.grdPartWiseRateList.Name = "grdPartWiseRateList";
            this.grdPartWiseRateList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPartWiseRateList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPartWiseRateList.RowHeadersWidth = 21;
            this.grdPartWiseRateList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPartWiseRateList.Size = new System.Drawing.Size(721, 228);
            this.grdPartWiseRateList.TabIndex = 9;
            this.grdPartWiseRateList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItemRate_CellContentClick);
            this.grdPartWiseRateList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPartWiseRateList_CellMouseEnter);
            this.grdPartWiseRateList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPartWiseRateList_CellMouseLeave);
            this.grdPartWiseRateList.MouseEnter += new System.EventHandler(this.grdPartWiseRateList_MouseEnter);
            this.grdPartWiseRateList.MouseHover += new System.EventHandler(this.grdPartWiseRateList_MouseHover);
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItem.IsMendatory = false;
            this.txtItem.Location = new System.Drawing.Point(588, 29);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(146, 20);
            this.txtItem.TabIndex = 4;
            this.txtItem.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtItem.Visible = false;
            this.txtItem.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtParty
            // 
            this.txtParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtParty.IsMendatory = false;
            this.txtParty.Location = new System.Drawing.Point(372, 28);
            this.txtParty.MaxLength = 50;
            this.txtParty.Name = "txtParty";
            this.txtParty.Size = new System.Drawing.Size(146, 20);
            this.txtParty.TabIndex = 2;
            this.txtParty.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtParty.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Party";
            this.label3.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.IsMendatory = false;
            this.txtSearch.Location = new System.Drawing.Point(86, 29);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // AccountGroupName
            // 
            this.AccountGroupName.DataPropertyName = "AccountGroupName";
            this.AccountGroupName.HeaderText = "Party";
            this.AccountGroupName.Name = "AccountGroupName";
            this.AccountGroupName.ReadOnly = true;
            // 
            // AccountGroupMasId
            // 
            this.AccountGroupMasId.DataPropertyName = "AccountGroupMasId";
            this.AccountGroupMasId.HeaderText = "AccountGroupMasId";
            this.AccountGroupMasId.Name = "AccountGroupMasId";
            this.AccountGroupMasId.ReadOnly = true;
            this.AccountGroupMasId.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item ";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "Alias/Part-Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // PackingRate
            // 
            this.PackingRate.DataPropertyName = "PackingRate";
            this.PackingRate.HeaderText = "OE Rate";
            this.PackingRate.Name = "PackingRate";
            this.PackingRate.ReadOnly = true;
            // 
            // PONo
            // 
            this.PONo.DataPropertyName = "PONo";
            this.PONo.HeaderText = "PO No.";
            this.PONo.Name = "PONo";
            this.PONo.ReadOnly = true;
            // 
            // ToolRate
            // 
            this.ToolRate.DataPropertyName = "ToolRate";
            this.ToolRate.HeaderText = "Tool Rate";
            this.ToolRate.Name = "ToolRate";
            this.ToolRate.ReadOnly = true;
            // 
            // Tax
            // 
            this.Tax.DataPropertyName = "Tax";
            this.Tax.HeaderText = "Tax %";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            // 
            // PartyWiseMasId
            // 
            this.PartyWiseMasId.DataPropertyName = "PartyWiseMasId";
            this.PartyWiseMasId.HeaderText = "PartyWiseMasId";
            this.PartyWiseMasId.Name = "PartyWiseMasId";
            this.PartyWiseMasId.ReadOnly = true;
            this.PartyWiseMasId.Visible = false;
            // 
            // AmendmentNo
            // 
            this.AmendmentNo.DataPropertyName = "AmendmentNo";
            this.AmendmentNo.HeaderText = "AmendmentNo";
            this.AmendmentNo.Name = "AmendmentNo";
            this.AmendmentNo.ReadOnly = true;
            this.AmendmentNo.Visible = false;
            // 
            // PODate
            // 
            this.PODate.DataPropertyName = "PODate";
            this.PODate.HeaderText = "PODate";
            this.PODate.Name = "PODate";
            this.PODate.ReadOnly = true;
            this.PODate.Visible = false;
            // 
            // AmendmentDate
            // 
            this.AmendmentDate.DataPropertyName = "AmendmentDate";
            this.AmendmentDate.HeaderText = "AmendmentDate";
            this.AmendmentDate.Name = "AmendmentDate";
            this.AmendmentDate.ReadOnly = true;
            this.AmendmentDate.Visible = false;
            // 
            // PartNo
            // 
            this.PartNo.DataPropertyName = "PartNo";
            this.PartNo.HeaderText = "PartNo";
            this.PartNo.Name = "PartNo";
            this.PartNo.ReadOnly = true;
            this.PartNo.Visible = false;
            // 
            // ToolSupplyForQty
            // 
            this.ToolSupplyForQty.DataPropertyName = "ToolSupplyForQty";
            this.ToolSupplyForQty.HeaderText = "ToolSupplyForQty";
            this.ToolSupplyForQty.Name = "ToolSupplyForQty";
            this.ToolSupplyForQty.ReadOnly = true;
            this.ToolSupplyForQty.Visible = false;
            // 
            // ToolNarr
            // 
            this.ToolNarr.DataPropertyName = "ToolNarr";
            this.ToolNarr.HeaderText = "ToolNarr";
            this.ToolNarr.Name = "ToolNarr";
            this.ToolNarr.ReadOnly = true;
            this.ToolNarr.Visible = false;
            // 
            // ProcessName
            // 
            this.ProcessName.DataPropertyName = "ProcessName";
            this.ProcessName.HeaderText = "ProcessName";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Visible = false;
            // 
            // PartyWiseItemRateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 362);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radioBtnRatelistWise);
            this.Controls.Add(this.radiobtnItemWise);
            this.Controls.Add(this.grdPartWiseRateList);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtParty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PartyWiseItemRateList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartyWise Item Rate";
            this.Load += new System.EventHandler(this.PartyWiseItemRateAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartWiseRateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControlLibrary.BTextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WinControlLibrary.BTextBox txtParty;
        private WinControlLibrary.BTextBox txtItem;
        public System.Windows.Forms.RadioButton radiobtnItemWise;
        public System.Windows.Forms.RadioButton radioBtnRatelistWise;
        private WinControlLibrary.BAllButton btnExit;
        private WinControlLibrary.BAllButton btnDelete;
        private WinControlLibrary.BAllButton btnEdit;
        private WinControlLibrary.BAllButton btnAdd;
        private WinControlLibrary.BAllButton btnFind;
        public WinControlLibrary.BGrid grdPartWiseRateList;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountGroupMasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PONo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyWiseMasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmendmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PODate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmendmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolSupplyForQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolNarr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
    }
}