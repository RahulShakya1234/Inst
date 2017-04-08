namespace ERP.A_CVoucher
{
    partial class ContraVoucherAdd
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
            this.btnSave = new WinControlLibrary.BButton();
            this.btnCancel = new WinControlLibrary.BButton();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtCreditTo = new WinControlLibrary.BTextBox();
            this.txtDebitTo = new WinControlLibrary.BTextBox();
            this.txtVoucherNo = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtVoucherDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtNarration = new WinControlLibrary.BTextBox();
            this.txtAmount = new WinControlLibrary.BTextBox();
            this.btnDebitTo = new WinControlLibrary.BButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Location = new System.Drawing.Point(21, 108);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(50, 13);
            this.bLabel8.TabIndex = 23;
            this.bLabel8.Text = "Credit To";
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(21, 82);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(48, 13);
            this.bLabel7.TabIndex = 22;
            this.bLabel7.Text = "Debit To";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(21, 56);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(67, 13);
            this.bLabel6.TabIndex = 21;
            this.bLabel6.Text = "Voucher No.";
            // 
            // txtCreditTo
            // 
            this.txtCreditTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtCreditTo.IsMendatory = false;
            this.txtCreditTo.Location = new System.Drawing.Point(143, 108);
            this.txtCreditTo.MaxLength = 50;
            this.txtCreditTo.Name = "txtCreditTo";
            this.txtCreditTo.Size = new System.Drawing.Size(199, 20);
            this.txtCreditTo.TabIndex = 5;
            this.txtCreditTo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtDebitTo
            // 
            this.txtDebitTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDebitTo.IsMendatory = false;
            this.txtDebitTo.Location = new System.Drawing.Point(143, 82);
            this.txtDebitTo.MaxLength = 50;
            this.txtDebitTo.Name = "txtDebitTo";
            this.txtDebitTo.Size = new System.Drawing.Size(199, 20);
            this.txtDebitTo.TabIndex = 3;
            this.txtDebitTo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtVoucherNo.IsMendatory = false;
            this.txtVoucherNo.Location = new System.Drawing.Point(143, 56);
            this.txtVoucherNo.MaxLength = 50;
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(127, 20);
            this.txtVoucherNo.TabIndex = 2;
            this.txtVoucherNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(21, 33);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(73, 13);
            this.bLabel5.TabIndex = 16;
            this.bLabel5.Text = "Voucher Date";
            // 
            // txtVoucherDate
            // 
            this.txtVoucherDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtVoucherDate.IsMendatory = false;
            this.txtVoucherDate.Location = new System.Drawing.Point(143, 30);
            this.txtVoucherDate.MaxLength = 50;
            this.txtVoucherDate.Name = "txtVoucherDate";
            this.txtVoucherDate.Size = new System.Drawing.Size(127, 20);
            this.txtVoucherDate.TabIndex = 1;
            this.txtVoucherDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(21, 161);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(50, 13);
            this.bLabel1.TabIndex = 27;
            this.bLabel1.Text = "Narration";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(21, 135);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(43, 13);
            this.bLabel2.TabIndex = 26;
            this.bLabel2.Text = "Amount";
            // 
            // txtNarration
            // 
            this.txtNarration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNarration.IsMendatory = false;
            this.txtNarration.Location = new System.Drawing.Point(143, 161);
            this.txtNarration.MaxLength = 50;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(199, 20);
            this.txtNarration.TabIndex = 7;
            this.txtNarration.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmount.IsMendatory = false;
            this.txtAmount.Location = new System.Drawing.Point(143, 135);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(199, 20);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // btnDebitTo
            // 
            this.btnDebitTo.Location = new System.Drawing.Point(360, 80);
            this.btnDebitTo.Name = "btnDebitTo";
            this.btnDebitTo.Size = new System.Drawing.Size(46, 22);
            this.btnDebitTo.TabIndex = 4;
            this.btnDebitTo.Text = "....";
            this.btnDebitTo.UseVisualStyleBackColor = true;
            // 
            // ContraVoucherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 233);
            this.Controls.Add(this.btnDebitTo);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.bLabel8);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.txtCreditTo);
            this.Controls.Add(this.txtDebitTo);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.txtVoucherDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "ContraVoucherAdd";
            this.Text = "ContraVoucher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BButton btnSave;
        private WinControlLibrary.BButton btnCancel;
        private WinControlLibrary.BLabel bLabel8;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BTextBox txtCreditTo;
        private WinControlLibrary.BTextBox txtDebitTo;
        private WinControlLibrary.BTextBox txtVoucherNo;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtVoucherDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtNarration;
        private WinControlLibrary.BTextBox txtAmount;
        private WinControlLibrary.BButton btnDebitTo;
    }
}