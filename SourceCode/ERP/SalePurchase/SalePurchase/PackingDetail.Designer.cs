namespace ERP.SalePurchase
{
    partial class PackingDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPrintTtlWeight = new System.Windows.Forms.CheckBox();
            this.chkPrintWeight = new System.Windows.Forms.CheckBox();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtToBillNo = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtFromBillNo = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.btnCancel =new WinControlLibrary.BAllButton();
            this.btnPrint =new WinControlLibrary.BAllButton();
            this.btnPreview =new WinControlLibrary.BAllButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPrintTtlWeight);
            this.groupBox1.Controls.Add(this.chkPrintWeight);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.bLabel1);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.bLabel4);
            this.groupBox1.Controls.Add(this.txtToBillNo);
            this.groupBox1.Controls.Add(this.bLabel2);
            this.groupBox1.Controls.Add(this.txtFromBillNo);
            this.groupBox1.Controls.Add(this.bLabel3);
            this.groupBox1.Location = new System.Drawing.Point(57, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report criteria";
            // 
            // chkPrintTtlWeight
            // 
            this.chkPrintTtlWeight.AutoSize = true;
            this.chkPrintTtlWeight.Location = new System.Drawing.Point(89, 161);
            this.chkPrintTtlWeight.Name = "chkPrintTtlWeight";
            this.chkPrintTtlWeight.Size = new System.Drawing.Size(114, 17);
            this.chkPrintTtlWeight.TabIndex = 6;
            this.chkPrintTtlWeight.Text = "Print  Total Weight";
            this.chkPrintTtlWeight.UseVisualStyleBackColor = true;
            // 
            // chkPrintWeight
            // 
            this.chkPrintWeight.AutoSize = true;
            this.chkPrintWeight.Location = new System.Drawing.Point(89, 138);
            this.chkPrintWeight.Name = "chkPrintWeight";
            this.chkPrintWeight.Size = new System.Drawing.Size(84, 17);
            this.chkPrintWeight.TabIndex = 5;
            this.chkPrintWeight.Text = "Print Weight";
            this.chkPrintWeight.UseVisualStyleBackColor = true;
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(78, 103);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(101, 20);
            this.txtToDate.TabIndex = 4;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(5, 103);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(52, 13);
            this.bLabel1.TabIndex = 172;
            this.bLabel1.Text = " To Date ";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(78, 77);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(101, 20);
            this.txtFromDate.TabIndex = 3;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(7, 77);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(56, 13);
            this.bLabel4.TabIndex = 170;
            this.bLabel4.Text = "From Date";
            // 
            // txtToBillNo
            // 
            this.txtToBillNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToBillNo.IsMendatory = false;
            this.txtToBillNo.Location = new System.Drawing.Point(77, 48);
            this.txtToBillNo.MaxLength = 50;
            this.txtToBillNo.Name = "txtToBillNo";
            this.txtToBillNo.Size = new System.Drawing.Size(101, 20);
            this.txtToBillNo.TabIndex = 2;
            this.txtToBillNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(4, 48);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(59, 13);
            this.bLabel2.TabIndex = 168;
            this.bLabel2.Text = " To Bill No.";
            // 
            // txtFromBillNo
            // 
            this.txtFromBillNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromBillNo.IsMendatory = false;
            this.txtFromBillNo.Location = new System.Drawing.Point(77, 22);
            this.txtFromBillNo.MaxLength = 50;
            this.txtFromBillNo.Name = "txtFromBillNo";
            this.txtFromBillNo.Size = new System.Drawing.Size(101, 20);
            this.txtFromBillNo.TabIndex = 1;
            this.txtFromBillNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(6, 22);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(63, 13);
            this.bLabel3.TabIndex = 166;
            this.bLabel3.Text = "From Bill No";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(311, 113);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(311, 77);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(74, 23);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // PackingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Name = "PackingDetail";
            this.Text = "PackingDetail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BTextBox txtToBillNo;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtFromBillNo;
        private WinControlLibrary.BLabel bLabel3;
        private System.Windows.Forms.CheckBox chkPrintWeight;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BLabel bLabel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox chkPrintTtlWeight;
    }
}