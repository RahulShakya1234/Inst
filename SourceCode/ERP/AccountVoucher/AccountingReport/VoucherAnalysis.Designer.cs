namespace ERP.A_CVoucher.AccountingReport
{
    partial class VoucherAnalysis
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new WinControlLibrary.BButton();
            this.btnPreview = new WinControlLibrary.BButton();
            this.btnPrint = new WinControlLibrary.BButton();
            this.txtReportType = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtToAmount = new WinControlLibrary.BTextBox();
            this.txtSearchOptin = new WinControlLibrary.BTextBox();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtString = new WinControlLibrary.BTextBox();
            this.txtFromAmont = new WinControlLibrary.BTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(517, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(517, 34);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 36);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(517, 79);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 36);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtReportType
            // 
            this.txtReportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtReportType.IsMendatory = false;
            this.txtReportType.Location = new System.Drawing.Point(104, 134);
            this.txtReportType.MaxLength = 50;
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.Size = new System.Drawing.Size(127, 20);
            this.txtReportType.TabIndex = 7;
            this.txtReportType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(17, 111);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(75, 13);
            this.bLabel1.TabIndex = 41;
            this.bLabel1.Text = "Search Option";
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Location = new System.Drawing.Point(54, 25);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(34, 13);
            this.bLabel8.TabIndex = 38;
            this.bLabel8.Text = "String";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.bLabel2);
            this.groupBox1.Controls.Add(this.bLabel3);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.bLabel5);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.bLabel7);
            this.groupBox1.Controls.Add(this.txtToAmount);
            this.groupBox1.Controls.Add(this.txtReportType);
            this.groupBox1.Controls.Add(this.bLabel1);
            this.groupBox1.Controls.Add(this.txtSearchOptin);
            this.groupBox1.Controls.Add(this.bLabel8);
            this.groupBox1.Controls.Add(this.bLabel6);
            this.groupBox1.Controls.Add(this.txtString);
            this.groupBox1.Controls.Add(this.txtFromAmont);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 224);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Criteria";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(57, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 47);
            this.panel1.TabIndex = 58;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(26, 137);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(66, 13);
            this.bLabel2.TabIndex = 57;
            this.bLabel2.Text = "Report Type";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(258, 79);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(49, 13);
            this.bLabel3.TabIndex = 56;
            this.bLabel3.Text = "To  Date";
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(323, 76);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(127, 20);
            this.txtToDate.TabIndex = 5;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(40, 82);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(56, 13);
            this.bLabel5.TabIndex = 54;
            this.bLabel5.Text = "From Date";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(102, 79);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(127, 20);
            this.txtFromDate.TabIndex = 4;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(258, 53);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(62, 13);
            this.bLabel7.TabIndex = 52;
            this.bLabel7.Text = "To  Amount";
            // 
            // txtToAmount
            // 
            this.txtToAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToAmount.IsMendatory = false;
            this.txtToAmount.Location = new System.Drawing.Point(323, 50);
            this.txtToAmount.MaxLength = 50;
            this.txtToAmount.Name = "txtToAmount";
            this.txtToAmount.Size = new System.Drawing.Size(127, 20);
            this.txtToAmount.TabIndex = 3;
            this.txtToAmount.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtSearchOptin
            // 
            this.txtSearchOptin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSearchOptin.IsMendatory = false;
            this.txtSearchOptin.Location = new System.Drawing.Point(104, 108);
            this.txtSearchOptin.MaxLength = 50;
            this.txtSearchOptin.Name = "txtSearchOptin";
            this.txtSearchOptin.Size = new System.Drawing.Size(127, 20);
            this.txtSearchOptin.TabIndex = 6;
            this.txtSearchOptin.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(32, 50);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(69, 13);
            this.bLabel6.TabIndex = 36;
            this.bLabel6.Text = "From Amount";
            // 
            // txtString
            // 
            this.txtString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtString.IsMendatory = false;
            this.txtString.Location = new System.Drawing.Point(104, 22);
            this.txtString.MaxLength = 50;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(130, 20);
            this.txtString.TabIndex = 1;
            this.txtString.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtFromAmont
            // 
            this.txtFromAmont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromAmont.IsMendatory = false;
            this.txtFromAmont.Location = new System.Drawing.Point(104, 50);
            this.txtFromAmont.MaxLength = 50;
            this.txtFromAmont.Name = "txtFromAmont";
            this.txtFromAmont.Size = new System.Drawing.Size(127, 20);
            this.txtFromAmont.TabIndex = 2;
            this.txtFromAmont.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // VoucherAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Name = "VoucherAnalysis";
            this.Text = "VoucherAnalysis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControlLibrary.BButton btnCancel;
        private WinControlLibrary.BButton btnPreview;
        private WinControlLibrary.BButton btnPrint;
        private WinControlLibrary.BTextBox txtReportType;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BLabel bLabel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BTextBox txtToAmount;
        private WinControlLibrary.BTextBox txtSearchOptin;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BTextBox txtString;
        private WinControlLibrary.BTextBox txtFromAmont;
    }
}