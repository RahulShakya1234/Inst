namespace ERP.SalePurchase
{
    partial class SaleOrderPendingReport_Party_wise_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleOrderPendingReport_Party_wise_));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new WinControlLibrary.BAllButton();
            this.bntPreview = new WinControlLibrary.BAllButton();
            this.txtZeroBalance = new WinControlLibrary.BTextBox();
            this.txtReportType = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.grdSaleOrderPendingReportPartyWise = new WinControlLibrary.BGrid();
            this.txtAccount = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bGrid1 = new WinControlLibrary.BGrid();
            this.btnCancel = new WinControlLibrary.BAllButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleOrderPendingReportPartyWise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Location = new System.Drawing.Point(432, 91);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 25);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // bntPreview
            // 
            this.bntPreview.BackColor = System.Drawing.Color.Transparent;
            this.bntPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntPreview.BackgroundImage")));
            this.bntPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntPreview.Location = new System.Drawing.Point(432, 39);
            this.bntPreview.Name = "bntPreview";
            this.bntPreview.Size = new System.Drawing.Size(75, 25);
            this.bntPreview.TabIndex = 7;
            this.bntPreview.Text = "Preview";
            this.bntPreview.UseVisualStyleBackColor = true;
            // 
            // txtZeroBalance
            // 
            this.txtZeroBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtZeroBalance.IsMendatory = false;
            this.txtZeroBalance.Location = new System.Drawing.Point(105, 303);
            this.txtZeroBalance.MaxLength = 50;
            this.txtZeroBalance.Name = "txtZeroBalance";
            this.txtZeroBalance.Size = new System.Drawing.Size(164, 20);
            this.txtZeroBalance.TabIndex = 6;
            this.txtZeroBalance.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtReportType
            // 
            this.txtReportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtReportType.IsMendatory = false;
            this.txtReportType.Location = new System.Drawing.Point(105, 268);
            this.txtReportType.MaxLength = 50;
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.Size = new System.Drawing.Size(164, 20);
            this.txtReportType.TabIndex = 5;
            this.txtReportType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(23, 306);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(71, 13);
            this.bLabel5.TabIndex = 23;
            this.bLabel5.Text = "Zero Balance";
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(23, 275);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(72, 13);
            this.bLabel4.TabIndex = 22;
            this.bLabel4.Text = "Report Type  ";
            // 
            // grdSaleOrderPendingReportPartyWise
            // 
            this.grdSaleOrderPendingReportPartyWise.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdSaleOrderPendingReportPartyWise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaleOrderPendingReportPartyWise.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdSaleOrderPendingReportPartyWise.Index = 0;
            this.grdSaleOrderPendingReportPartyWise.Location = new System.Drawing.Point(105, 111);
            this.grdSaleOrderPendingReportPartyWise.Name = "grdSaleOrderPendingReportPartyWise";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSaleOrderPendingReportPartyWise.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSaleOrderPendingReportPartyWise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaleOrderPendingReportPartyWise.Size = new System.Drawing.Size(274, 135);
            this.grdSaleOrderPendingReportPartyWise.TabIndex = 4;
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAccount.IsMendatory = false;
            this.txtAccount.Location = new System.Drawing.Point(105, 85);
            this.txtAccount.MaxLength = 50;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(164, 20);
            this.txtAccount.TabIndex = 3;
            this.txtAccount.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(34, 88);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(47, 13);
            this.bLabel3.TabIndex = 19;
            this.bLabel3.Text = "Account";
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(293, 49);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(113, 20);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(226, 53);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(52, 13);
            this.bLabel2.TabIndex = 17;
            this.bLabel2.Text = "To Date :";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(105, 49);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(106, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(23, 53);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(62, 13);
            this.bLabel1.TabIndex = 15;
            this.bLabel1.Text = "From Date :";
            // 
            // bGrid1
            // 
            this.bGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.bGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bGrid1.Index = 0;
            this.bGrid1.Location = new System.Drawing.Point(14, 29);
            this.bGrid1.Name = "bGrid1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bGrid1.Size = new System.Drawing.Size(412, 321);
            this.bGrid1.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(432, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SaleOrderPendingReport_Party_wise_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 440);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.bntPreview);
            this.Controls.Add(this.txtZeroBalance);
            this.Controls.Add(this.txtReportType);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.grdSaleOrderPendingReportPartyWise);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.bGrid1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleOrderPendingReport_Party_wise_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleOrderPendingReport(Party wise)";
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleOrderPendingReportPartyWise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BAllButton btnPrint;
        private WinControlLibrary.BAllButton bntPreview;
        private WinControlLibrary.BTextBox txtZeroBalance;
        private WinControlLibrary.BTextBox txtReportType;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BGrid grdSaleOrderPendingReportPartyWise;
        private WinControlLibrary.BTextBox txtAccount;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BGrid bGrid1;
        private WinControlLibrary.BAllButton btnCancel;
    }
}