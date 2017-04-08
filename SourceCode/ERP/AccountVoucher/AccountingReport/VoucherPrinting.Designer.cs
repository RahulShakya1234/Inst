namespace ERP.A_CVoucher.AccountingReport
{
    partial class VoucherPrinting
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
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtStartingnOOfFromDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtSingleVoucherNo = new WinControlLibrary.BTextBox();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtVoucherType = new WinControlLibrary.BTextBox();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.btnCancel = new WinControlLibrary.BButton();
            this.btnPreview = new WinControlLibrary.BButton();
            this.btnPrint = new WinControlLibrary.BButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(32, 138);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(60, 13);
            this.bLabel2.TabIndex = 47;
            this.bLabel2.Text = "Starting No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bLabel4);
            this.groupBox1.Controls.Add(this.txtStartingnOOfFromDate);
            this.groupBox1.Controls.Add(this.bLabel2);
            this.groupBox1.Controls.Add(this.bLabel1);
            this.groupBox1.Controls.Add(this.txtSingleVoucherNo);
            this.groupBox1.Controls.Add(this.bLabel8);
            this.groupBox1.Controls.Add(this.bLabel7);
            this.groupBox1.Controls.Add(this.bLabel6);
            this.groupBox1.Controls.Add(this.txtVoucherType);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Location = new System.Drawing.Point(42, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 185);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Criteria";
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(27, 151);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(68, 13);
            this.bLabel4.TabIndex = 50;
            this.bLabel4.Text = "of From Date";
            // 
            // txtStartingnOOfFromDate
            // 
            this.txtStartingnOOfFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtStartingnOOfFromDate.IsMendatory = false;
            this.txtStartingnOOfFromDate.Location = new System.Drawing.Point(104, 134);
            this.txtStartingnOOfFromDate.MaxLength = 50;
            this.txtStartingnOOfFromDate.Name = "txtStartingnOOfFromDate";
            this.txtStartingnOOfFromDate.Size = new System.Drawing.Size(127, 20);
            this.txtStartingnOOfFromDate.TabIndex = 5;
            this.txtStartingnOOfFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(-1, 111);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(99, 13);
            this.bLabel1.TabIndex = 41;
            this.bLabel1.Text = "Single Voucher No.";
            // 
            // txtSingleVoucherNo
            // 
            this.txtSingleVoucherNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSingleVoucherNo.IsMendatory = false;
            this.txtSingleVoucherNo.Location = new System.Drawing.Point(104, 108);
            this.txtSingleVoucherNo.MaxLength = 50;
            this.txtSingleVoucherNo.Name = "txtSingleVoucherNo";
            this.txtSingleVoucherNo.Size = new System.Drawing.Size(127, 20);
            this.txtSingleVoucherNo.TabIndex = 4;
            this.txtSingleVoucherNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Location = new System.Drawing.Point(22, 25);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(74, 13);
            this.bLabel8.TabIndex = 38;
            this.bLabel8.Text = "Voucher Type";
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(39, 82);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(49, 13);
            this.bLabel7.TabIndex = 37;
            this.bLabel7.Text = "To  Date";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(32, 50);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(56, 13);
            this.bLabel6.TabIndex = 36;
            this.bLabel6.Text = "From Date";
            // 
            // txtVoucherType
            // 
            this.txtVoucherType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtVoucherType.IsMendatory = false;
            this.txtVoucherType.Location = new System.Drawing.Point(104, 22);
            this.txtVoucherType.MaxLength = 50;
            this.txtVoucherType.Name = "txtVoucherType";
            this.txtVoucherType.Size = new System.Drawing.Size(130, 20);
            this.txtVoucherType.TabIndex = 1;
            this.txtVoucherType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(104, 79);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(127, 20);
            this.txtToDate.TabIndex = 3;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(104, 50);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(127, 20);
            this.txtFromDate.TabIndex = 2;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(307, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(307, 44);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 36);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(307, 89);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 36);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // VoucherPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 218);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Name = "VoucherPrinting";
            this.Text = "VoucherPrinting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControlLibrary.BLabel bLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtSingleVoucherNo;
        private WinControlLibrary.BLabel bLabel8;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BTextBox txtVoucherType;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BButton btnCancel;
        private WinControlLibrary.BButton btnPreview;
        private WinControlLibrary.BButton btnPrint;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BTextBox txtStartingnOOfFromDate;
    }
}