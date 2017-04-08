namespace ERP.SalePurchase
{
    partial class SalePurcahseRegisterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalePurcahseRegisterView));
            this.grdSalePurchaseReg = new WinControlLibrary.BGrid();
            this.Adsolute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new WinControlLibrary.BAllButton();
            this.btnDelete = new WinControlLibrary.BAllButton();
            this.btnEdit = new WinControlLibrary.BAllButton();
            this.btnExit = new WinControlLibrary.BAllButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new WinControlLibrary.BTextBox();
            this.btnExportFormat = new WinControlLibrary.BAllButton();
            this.btnCopyFormat = new WinControlLibrary.BAllButton();
            this.btnImportFormat = new WinControlLibrary.BAllButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalePurchaseReg)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSalePurchaseReg
            // 
            this.grdSalePurchaseReg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdSalePurchaseReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalePurchaseReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adsolute});
            this.grdSalePurchaseReg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdSalePurchaseReg.Index = 0;
            this.grdSalePurchaseReg.Location = new System.Drawing.Point(81, 70);
            this.grdSalePurchaseReg.Name = "grdSalePurchaseReg";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSalePurchaseReg.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSalePurchaseReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSalePurchaseReg.Size = new System.Drawing.Size(532, 150);
            this.grdSalePurchaseReg.TabIndex = 4;
            // 
            // Adsolute
            // 
            this.Adsolute.HeaderText = "Register Name";
            this.Adsolute.Name = "Adsolute";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(268, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(430, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(349, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(511, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSearch.IsMendatory = false;
            this.txtSearch.Location = new System.Drawing.Point(176, 36);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // btnExportFormat
            // 
            this.btnExportFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnExportFormat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportFormat.BackgroundImage")));
            this.btnExportFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportFormat.Location = new System.Drawing.Point(12, -2);
            this.btnExportFormat.Name = "btnExportFormat";
            this.btnExportFormat.Size = new System.Drawing.Size(88, 23);
            this.btnExportFormat.TabIndex = 0;
            this.btnExportFormat.Text = "Export Format";
            this.btnExportFormat.UseVisualStyleBackColor = true;
            // 
            // btnCopyFormat
            // 
            this.btnCopyFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyFormat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyFormat.BackgroundImage")));
            this.btnCopyFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopyFormat.Location = new System.Drawing.Point(95, -2);
            this.btnCopyFormat.Name = "btnCopyFormat";
            this.btnCopyFormat.Size = new System.Drawing.Size(75, 23);
            this.btnCopyFormat.TabIndex = 1;
            this.btnCopyFormat.Text = "Copy Format";
            this.btnCopyFormat.UseVisualStyleBackColor = true;
            // 
            // btnImportFormat
            // 
            this.btnImportFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnImportFormat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportFormat.BackgroundImage")));
            this.btnImportFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImportFormat.Location = new System.Drawing.Point(166, -2);
            this.btnImportFormat.Name = "btnImportFormat";
            this.btnImportFormat.Size = new System.Drawing.Size(85, 23);
            this.btnImportFormat.TabIndex = 3;
            this.btnImportFormat.Text = "Import Format";
            this.btnImportFormat.UseVisualStyleBackColor = true;
            // 
            // SalePurcahseRegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 339);
            this.Controls.Add(this.btnImportFormat);
            this.Controls.Add(this.btnCopyFormat);
            this.Controls.Add(this.btnExportFormat);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdSalePurchaseReg);
            this.Name = "SalePurcahseRegisterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalePurcahseRegisterView";
            ((System.ComponentModel.ISupportInitialize)(this.grdSalePurchaseReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BGrid grdSalePurchaseReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adsolute;
        private System.Windows.Forms.Label label1;
        private WinControlLibrary.BTextBox txtSearch;
        private WinControlLibrary.BAllButton btnAdd;
        private WinControlLibrary.BAllButton btnDelete;
        private WinControlLibrary.BAllButton btnEdit;
        private WinControlLibrary.BAllButton btnExit;
        private WinControlLibrary.BAllButton btnExportFormat;
        private WinControlLibrary.BAllButton btnCopyFormat;
        private WinControlLibrary.BAllButton btnImportFormat;
    }
}