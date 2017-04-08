namespace ERP.Masters
{
    partial class PartyWiseItemRateView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new WinControlLibrary.BTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderBy = new WinControlLibrary.BTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParty = new WinControlLibrary.BTextBox();
            this.txtItem = new WinControlLibrary.BTextBox();
            this.btnRefresh = new WinControlLibrary.BButton();
            this.rbtItemWise = new System.Windows.Forms.RadioButton();
            this.rbtRateListWise = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new WinControlLibrary.BButton();
            this.btnDelete = new WinControlLibrary.BButton();
            this.btnEdit = new WinControlLibrary.BButton();
            this.btnExit = new WinControlLibrary.BButton();
            this.grdItemRate = new WinControlLibrary.BGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OERate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExportToExcel = new WinControlLibrary.BButton();
            this.btnCopySameRate = new WinControlLibrary.BButton();
            this.btnCopyPartyRate = new WinControlLibrary.BButton();
            this.btnDeleteParty = new WinControlLibrary.BButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order By";
            // 
            // txtOrderBy
            // 
            this.txtOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtOrderBy.IsMendatory = false;
            this.txtOrderBy.Location = new System.Drawing.Point(86, 70);
            this.txtOrderBy.MaxLength = 50;
            this.txtOrderBy.Name = "txtOrderBy";
            this.txtOrderBy.Size = new System.Drawing.Size(146, 20);
            this.txtOrderBy.TabIndex = 3;
            this.txtOrderBy.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtOrderBy.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Party";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item";
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
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItem.IsMendatory = false;
            this.txtItem.Location = new System.Drawing.Point(372, 70);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(146, 20);
            this.txtItem.TabIndex = 4;
            this.txtItem.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtItem.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(698, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 40);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // rbtItemWise
            // 
            this.rbtItemWise.AutoSize = true;
            this.rbtItemWise.Location = new System.Drawing.Point(44, 18);
            this.rbtItemWise.Name = "rbtItemWise";
            this.rbtItemWise.Size = new System.Drawing.Size(72, 17);
            this.rbtItemWise.TabIndex = 5;
            this.rbtItemWise.TabStop = true;
            this.rbtItemWise.Text = "Item Wise";
            this.rbtItemWise.UseVisualStyleBackColor = true;
            // 
            // rbtRateListWise
            // 
            this.rbtRateListWise.AutoSize = true;
            this.rbtRateListWise.Location = new System.Drawing.Point(180, 18);
            this.rbtRateListWise.Name = "rbtRateListWise";
            this.rbtRateListWise.Size = new System.Drawing.Size(90, 17);
            this.rbtRateListWise.TabIndex = 6;
            this.rbtRateListWise.TabStop = true;
            this.rbtRateListWise.Text = "Rate list Wise";
            this.rbtRateListWise.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.rbtRateListWise);
            this.panel1.Controls.Add(this.rbtItemWise);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 52);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(489, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 20);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(683, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 20);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(586, 370);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 20);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(778, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 20);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grdItemRate
            // 
            this.grdItemRate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdItemRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItemRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.OERate,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.grdItemRate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdItemRate.Index = 0;
            this.grdItemRate.Location = new System.Drawing.Point(31, 171);
            this.grdItemRate.Name = "grdItemRate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItemRate.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdItemRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItemRate.Size = new System.Drawing.Size(826, 150);
            this.grdItemRate.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Party Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Alias/PartCode";
            this.Column3.Name = "Column3";
            // 
            // OERate
            // 
            this.OERate.HeaderText = "OE Rate";
            this.OERate.Name = "OERate";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PO No.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rate List Name";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Spd. Rate";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tool Rate";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tax %";
            this.Column8.Name = "Column8";
            // 
            // txtExportToExcel
            // 
            this.txtExportToExcel.Location = new System.Drawing.Point(12, 0);
            this.txtExportToExcel.Name = "txtExportToExcel";
            this.txtExportToExcel.Size = new System.Drawing.Size(107, 23);
            this.txtExportToExcel.TabIndex = 13;
            this.txtExportToExcel.Text = "Export To Exel";
            this.txtExportToExcel.UseVisualStyleBackColor = true;
            // 
            // btnCopySameRate
            // 
            this.btnCopySameRate.Location = new System.Drawing.Point(125, 0);
            this.btnCopySameRate.Name = "btnCopySameRate";
            this.btnCopySameRate.Size = new System.Drawing.Size(104, 23);
            this.btnCopySameRate.TabIndex = 14;
            this.btnCopySameRate.Text = "Copy Same Rate";
            this.btnCopySameRate.UseVisualStyleBackColor = true;
            // 
            // btnCopyPartyRate
            // 
            this.btnCopyPartyRate.Location = new System.Drawing.Point(235, 0);
            this.btnCopyPartyRate.Name = "btnCopyPartyRate";
            this.btnCopyPartyRate.Size = new System.Drawing.Size(92, 23);
            this.btnCopyPartyRate.TabIndex = 15;
            this.btnCopyPartyRate.Text = "Copy Party Rate";
            this.btnCopyPartyRate.UseVisualStyleBackColor = true;
            // 
            // btnDeleteParty
            // 
            this.btnDeleteParty.Location = new System.Drawing.Point(333, 0);
            this.btnDeleteParty.Name = "btnDeleteParty";
            this.btnDeleteParty.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteParty.TabIndex = 16;
            this.btnDeleteParty.Text = "Delete Party Rate";
            this.btnDeleteParty.UseVisualStyleBackColor = true;
            // 
            // PartyWiseItemRateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 402);
            this.Controls.Add(this.btnDeleteParty);
            this.Controls.Add(this.btnCopyPartyRate);
            this.Controls.Add(this.btnCopySameRate);
            this.Controls.Add(this.txtExportToExcel);
            this.Controls.Add(this.grdItemRate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtParty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "PartyWiseItemRateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Rate Add";
            this.Load += new System.EventHandler(this.PartyWiseItemRateAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControlLibrary.BTextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private WinControlLibrary.BTextBox txtOrderBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WinControlLibrary.BTextBox txtParty;
        private WinControlLibrary.BTextBox txtItem;
        private System.Windows.Forms.RadioButton rbtItemWise;
        private System.Windows.Forms.RadioButton rbtRateListWise;
        private System.Windows.Forms.Panel panel1;
        private WinControlLibrary.BButton btnAdd;
        private WinControlLibrary.BButton btnDelete;
        private WinControlLibrary.BButton btnEdit;
        private WinControlLibrary.BButton btnExit;
        private WinControlLibrary.BGrid grdItemRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OERate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private WinControlLibrary.BButton txtExportToExcel;
        private WinControlLibrary.BButton btnCopySameRate;
        private WinControlLibrary.BButton btnCopyPartyRate;
        private WinControlLibrary.BButton btnDeleteParty;
        private WinControlLibrary.BButton btnRefresh;
    }
}