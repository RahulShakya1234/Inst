namespace ERP.Utilities
{
    partial class ImportDateFormExcel
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
            this.txtType = new WinControlLibrary.BTextBox();
            this.btnPrintExcel = new WinControlLibrary.BButton();
            this.txtExcelFilePath = new WinControlLibrary.BTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkSheetName = new WinControlLibrary.BTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new WinControlLibrary.BButton();
            this.btnConnect = new WinControlLibrary.BButton();
            this.btnImport = new WinControlLibrary.BButton();
            this.grdImportDateFormExcel = new WinControlLibrary.BGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdImportDateFormExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtType.IsMendatory = false;
            this.txtType.Location = new System.Drawing.Point(173, 24);
            this.txtType.MaxLength = 50;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(199, 20);
            this.txtType.TabIndex = 1;
            this.txtType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // btnPrintExcel
            // 
            this.btnPrintExcel.Location = new System.Drawing.Point(97, 264);
            this.btnPrintExcel.Name = "btnPrintExcel";
            this.btnPrintExcel.Size = new System.Drawing.Size(75, 23);
            this.btnPrintExcel.TabIndex = 5;
            this.btnPrintExcel.Text = "Print Excel Format";
            this.btnPrintExcel.UseVisualStyleBackColor = true;
            // 
            // txtExcelFilePath
            // 
            this.txtExcelFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtExcelFilePath.IsMendatory = false;
            this.txtExcelFilePath.Location = new System.Drawing.Point(441, 249);
            this.txtExcelFilePath.MaxLength = 50;
            this.txtExcelFilePath.Name = "txtExcelFilePath";
            this.txtExcelFilePath.Size = new System.Drawing.Size(158, 20);
            this.txtExcelFilePath.TabIndex = 3;
            this.txtExcelFilePath.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Excel File Path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtWorkSheetName
            // 
            this.txtWorkSheetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtWorkSheetName.IsMendatory = false;
            this.txtWorkSheetName.Location = new System.Drawing.Point(441, 275);
            this.txtWorkSheetName.MaxLength = 50;
            this.txtWorkSheetName.Name = "txtWorkSheetName";
            this.txtWorkSheetName.Size = new System.Drawing.Size(158, 20);
            this.txtWorkSheetName.TabIndex = 4;
            this.txtWorkSheetName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Work Sheet Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(360, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(279, 308);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(198, 308);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // grdImportDateFormExcel
            // 
            this.grdImportDateFormExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdImportDateFormExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdImportDateFormExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grdImportDateFormExcel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdImportDateFormExcel.Index = 0;
            this.grdImportDateFormExcel.Location = new System.Drawing.Point(88, 93);
            this.grdImportDateFormExcel.Name = "grdImportDateFormExcel";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdImportDateFormExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdImportDateFormExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdImportDateFormExcel.Size = new System.Drawing.Size(495, 150);
            this.grdImportDateFormExcel.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Accepted value";
            this.Column2.Name = "Column2";
            // 
            // ImportDateFormExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 339);
            this.Controls.Add(this.grdImportDateFormExcel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWorkSheetName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExcelFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrintExcel);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label1);
            this.Name = "ImportDateFormExcel";
            this.Text = "ImportDateFormExcel";
            ((System.ComponentModel.ISupportInitialize)(this.grdImportDateFormExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControlLibrary.BTextBox txtType;
        private WinControlLibrary.BTextBox txtExcelFilePath;
        private System.Windows.Forms.Label label2;
        private WinControlLibrary.BTextBox txtWorkSheetName;
        private System.Windows.Forms.Label label3;
        private WinControlLibrary.BGrid grdImportDateFormExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private WinControlLibrary.BButton btnPrintExcel;
        private WinControlLibrary.BButton btnExit;
        private WinControlLibrary.BButton btnConnect;
        private WinControlLibrary.BButton btnImport;
    }
}