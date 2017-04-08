namespace ERP.SalePurchase
{
    partial class SaleOrderReceivingEntryAdd
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
            //sForm = null;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleOrderReceivingEntryAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ddlItemDesb = new WinControlLibrary.BCombo();
            this.txtOrderDate = new WinControlLibrary.BDateTextBox();
            this.ddlPartyName = new WinControlLibrary.BCombo();
            this.txtAmount = new WinControlLibrary.BTextBox();
            this.bLabel10 = new WinControlLibrary.BLabel();
            this.ddlActive = new WinControlLibrary.BCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.btnDelete = new WinControlLibrary.BAllButton();
            this.txtTotal2 = new WinControlLibrary.BTextBox();
            this.txtTotal = new WinControlLibrary.BTextBox();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.txtRate = new WinControlLibrary.BTextBox();
            this.txtQty = new WinControlLibrary.BTextBox();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtSNo = new WinControlLibrary.BTextBox();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtRemark = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtOrderNo = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.grdSaleOrderReceivingEntry = new WinControlLibrary.BGrid();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new WinControlLibrary.BAllButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleOrderReceivingEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlItemDesb
            // 
            this.ddlItemDesb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlItemDesb.DisplayMember = "Value";
            this.ddlItemDesb.FormattingEnabled = true;
            this.ddlItemDesb.Location = new System.Drawing.Point(79, 155);
            this.ddlItemDesb.Name = "ddlItemDesb";
            this.ddlItemDesb.Size = new System.Drawing.Size(139, 21);
            this.ddlItemDesb.TabIndex = 63;
            this.ddlItemDesb.ValueMember = "Code";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.AllowBlank = false;
            this.txtOrderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtOrderDate.Location = new System.Drawing.Point(104, 32);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(108, 20);
            this.txtOrderDate.TabIndex = 62;
            // 
            // ddlPartyName
            // 
            this.ddlPartyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlPartyName.DisplayMember = "Value";
            this.ddlPartyName.FormattingEnabled = true;
            this.ddlPartyName.Location = new System.Drawing.Point(104, 62);
            this.ddlPartyName.Name = "ddlPartyName";
            this.ddlPartyName.Size = new System.Drawing.Size(200, 21);
            this.ddlPartyName.TabIndex = 58;
            this.ddlPartyName.ValueMember = "Code";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmount.IsMendatory = false;
            this.txtAmount.Location = new System.Drawing.Point(419, 155);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(108, 20);
            this.txtAmount.TabIndex = 56;
            this.txtAmount.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel10
            // 
            this.bLabel10.AutoSize = true;
            this.bLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel10.Location = new System.Drawing.Point(417, 137);
            this.bLabel10.Name = "bLabel10";
            this.bLabel10.Size = new System.Drawing.Size(49, 15);
            this.bLabel10.TabIndex = 57;
            this.bLabel10.Text = "Amount";
            // 
            // ddlActive
            // 
            this.ddlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlActive.DisplayMember = "Value";
            this.ddlActive.FormattingEnabled = true;
            this.ddlActive.Location = new System.Drawing.Point(406, 62);
            this.ddlActive.Name = "ddlActive";
            this.ddlActive.Size = new System.Drawing.Size(121, 21);
            this.ddlActive.TabIndex = 55;
            this.ddlActive.ValueMember = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(85, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Item Description";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(520, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(427, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(12, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete  Rows";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // txtTotal2
            // 
            this.txtTotal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTotal2.IsMendatory = false;
            this.txtTotal2.Location = new System.Drawing.Point(497, 318);
            this.txtTotal2.MaxLength = 50;
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(142, 20);
            this.txtTotal2.TabIndex = 13;
            this.txtTotal2.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTotal.IsMendatory = false;
            this.txtTotal.Location = new System.Drawing.Point(297, 318);
            this.txtTotal.MaxLength = 50;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(143, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel9.Location = new System.Drawing.Point(257, 323);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(34, 15);
            this.bLabel9.TabIndex = 49;
            this.bLabel9.Text = "Total";
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel8.Location = new System.Drawing.Point(325, 138);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(33, 15);
            this.bLabel8.TabIndex = 47;
            this.bLabel8.Text = "Rate";
            this.bLabel8.Click += new System.EventHandler(this.bLabel8_Click);
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtRate.IsMendatory = false;
            this.txtRate.Location = new System.Drawing.Point(311, 156);
            this.txtRate.MaxLength = 50;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(92, 20);
            this.txtRate.TabIndex = 9;
            this.txtRate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtQty.IsMendatory = false;
            this.txtQty.Location = new System.Drawing.Point(223, 156);
            this.txtQty.MaxLength = 50;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(82, 20);
            this.txtQty.TabIndex = 8;
            this.txtQty.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel7.Location = new System.Drawing.Point(235, 137);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(24, 15);
            this.bLabel7.TabIndex = 44;
            this.bLabel7.Text = "Qty";
            // 
            // txtSNo
            // 
            this.txtSNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSNo.IsMendatory = false;
            this.txtSNo.Location = new System.Drawing.Point(29, 156);
            this.txtSNo.MaxLength = 50;
            this.txtSNo.Name = "txtSNo";
            this.txtSNo.Size = new System.Drawing.Size(26, 20);
            this.txtSNo.TabIndex = 6;
            this.txtSNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel6.Location = new System.Drawing.Point(26, 138);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(34, 15);
            this.bLabel6.TabIndex = 43;
            this.bLabel6.Text = "SNo.";
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel4.Location = new System.Drawing.Point(363, 65);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(38, 15);
            this.bLabel4.TabIndex = 41;
            this.bLabel4.Text = "Active";
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtRemark.IsMendatory = false;
            this.txtRemark.Location = new System.Drawing.Point(104, 94);
            this.txtRemark.MaxLength = 50;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(420, 36);
            this.txtRemark.TabIndex = 5;
            this.txtRemark.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel3.Location = new System.Drawing.Point(39, 95);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(60, 15);
            this.bLabel3.TabIndex = 39;
            this.bLabel3.Text = "Remarks:";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel5.Location = new System.Drawing.Point(56, 63);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(37, 15);
            this.bLabel5.TabIndex = 37;
            this.bLabel5.Text = "Party:";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel2.Location = new System.Drawing.Point(29, 37);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(70, 15);
            this.bLabel2.TabIndex = 34;
            this.bLabel2.Text = "Order Date:";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtOrderNo.IsMendatory = false;
            this.txtOrderNo.Location = new System.Drawing.Point(104, 7);
            this.txtOrderNo.MaxLength = 50;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(108, 20);
            this.txtOrderNo.TabIndex = 1;
            this.txtOrderNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLabel1.Location = new System.Drawing.Point(38, 12);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(60, 15);
            this.bLabel1.TabIndex = 33;
            this.bLabel1.Text = "Order No.";
            // 
            // grdSaleOrderReceivingEntry
            // 
            this.grdSaleOrderReceivingEntry.AllowUserToDeleteRows = false;
            this.grdSaleOrderReceivingEntry.AllowUserToOrderColumns = true;
            this.grdSaleOrderReceivingEntry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdSaleOrderReceivingEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaleOrderReceivingEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.ItemMasId,
            this.ItemGroupName,
            this.Qty,
            this.Rate,
            this.Amount});
            this.grdSaleOrderReceivingEntry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdSaleOrderReceivingEntry.Index = 0;
            this.grdSaleOrderReceivingEntry.Location = new System.Drawing.Point(12, 187);
            this.grdSaleOrderReceivingEntry.Name = "grdSaleOrderReceivingEntry";
            this.grdSaleOrderReceivingEntry.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleOrderReceivingEntry.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSaleOrderReceivingEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaleOrderReceivingEntry.Size = new System.Drawing.Size(626, 125);
            this.grdSaleOrderReceivingEntry.TabIndex = 10;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "S.No.";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // ItemMasId
            // 
            this.ItemMasId.DataPropertyName = "ItemMasId";
            this.ItemMasId.HeaderText = "ItemMasId";
            this.ItemMasId.Name = "ItemMasId";
            this.ItemMasId.ReadOnly = true;
            this.ItemMasId.Visible = false;
            // 
            // ItemGroupName
            // 
            this.ItemGroupName.DataPropertyName = "ItemGroupName";
            this.ItemGroupName.HeaderText = "ItemGroupName";
            this.ItemGroupName.Name = "ItemGroupName";
            this.ItemGroupName.ReadOnly = true;
            this.ItemGroupName.Width = 140;
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
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(533, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // SaleOrderReceivingEntryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 404);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ddlItemDesb);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.ddlPartyName);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.bLabel10);
            this.Controls.Add(this.ddlActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.bLabel8);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.txtSNo);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.grdSaleOrderReceivingEntry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaleOrderReceivingEntryAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Order Receiving Entry Add";
            this.Load += new System.EventHandler(this.SaleOrderReceivingEntryAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleOrderReceivingEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BGrid grdSaleOrderReceivingEntry;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel8;
        private System.Windows.Forms.Label label1;
        private WinControlLibrary.BAllButton btnDelete;
        private WinControlLibrary.BLabel bLabel10;
        public WinControlLibrary.BAllButton btnSave;
        public WinControlLibrary.BAllButton btnCancel;
        public WinControlLibrary.BTextBox txtOrderNo;
        public WinControlLibrary.BTextBox txtRemark;
        public WinControlLibrary.BLabel bLabel4;
        public WinControlLibrary.BCombo ddlActive;
        public WinControlLibrary.BCombo ddlPartyName;
        public WinControlLibrary.BTextBox txtTotal;
        public WinControlLibrary.BLabel bLabel9;
        public WinControlLibrary.BTextBox txtTotal2;
        public WinControlLibrary.BTextBox txtSNo;
        public WinControlLibrary.BTextBox txtQty;
        public WinControlLibrary.BTextBox txtRate;
        public WinControlLibrary.BTextBox txtAmount;
        private WinControlLibrary.BCombo ddlItemDesb;
        public WinControlLibrary.BDateTextBox txtOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        public WinControlLibrary.BAllButton btnAdd;

    }
}