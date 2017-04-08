namespace ERP.SalePurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContraVoucherAdd));
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtVoucherDate = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.txtVoucherNo = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtDebitTo = new WinControlLibrary.BTextBox();
            this.txtCreditTo = new WinControlLibrary.BTextBox();
            this.txtAmount = new WinControlLibrary.BTextBox();
            this.txtNarration = new WinControlLibrary.BTextBox();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.btnDebitTo = new WinControlLibrary.BAllButton();
            this.SuspendLayout();
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(40, 34);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(79, 13);
            this.bLabel1.TabIndex = 0;
            this.bLabel1.Text = "Voucher Date :";
            // 
            // txtVoucherDate
            // 
            this.txtVoucherDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtVoucherDate.IsMendatory = false;
            this.txtVoucherDate.Location = new System.Drawing.Point(125, 31);
            this.txtVoucherDate.MaxLength = 50;
            this.txtVoucherDate.Name = "txtVoucherDate";
            this.txtVoucherDate.Size = new System.Drawing.Size(151, 20);
            this.txtVoucherDate.TabIndex = 0;
            this.txtVoucherDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(282, 34);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(48, 13);
            this.bLabel2.TabIndex = 2;
            this.bLabel2.Text = "Tuesday";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(40, 64);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(70, 13);
            this.bLabel3.TabIndex = 3;
            this.bLabel3.Text = "Voucher No :";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtVoucherNo.IsMendatory = false;
            this.txtVoucherNo.Location = new System.Drawing.Point(125, 59);
            this.txtVoucherNo.MaxLength = 50;
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(68, 20);
            this.txtVoucherNo.TabIndex = 1;
            this.txtVoucherNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(40, 93);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(54, 13);
            this.bLabel4.TabIndex = 5;
            this.bLabel4.Text = "Debit To :";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(40, 115);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(56, 13);
            this.bLabel5.TabIndex = 6;
            this.bLabel5.Text = "Credit To :";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(44, 138);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(49, 13);
            this.bLabel6.TabIndex = 7;
            this.bLabel6.Text = "Amount :";
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(40, 163);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(56, 13);
            this.bLabel7.TabIndex = 8;
            this.bLabel7.Text = "Narration :";
            // 
            // txtDebitTo
            // 
            this.txtDebitTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDebitTo.IsMendatory = false;
            this.txtDebitTo.Location = new System.Drawing.Point(125, 87);
            this.txtDebitTo.MaxLength = 50;
            this.txtDebitTo.Name = "txtDebitTo";
            this.txtDebitTo.Size = new System.Drawing.Size(287, 20);
            this.txtDebitTo.TabIndex = 2;
            this.txtDebitTo.Text = "CASH IN HAND";
            this.txtDebitTo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtCreditTo
            // 
            this.txtCreditTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtCreditTo.IsMendatory = false;
            this.txtCreditTo.Location = new System.Drawing.Point(125, 113);
            this.txtCreditTo.MaxLength = 50;
            this.txtCreditTo.Name = "txtCreditTo";
            this.txtCreditTo.Size = new System.Drawing.Size(287, 20);
            this.txtCreditTo.TabIndex = 4;
            this.txtCreditTo.Text = "CASH IN HAND";
            this.txtCreditTo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmount.IsMendatory = false;
            this.txtAmount.Location = new System.Drawing.Point(125, 138);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(91, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtNarration
            // 
            this.txtNarration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNarration.IsMendatory = false;
            this.txtNarration.Location = new System.Drawing.Point(125, 164);
            this.txtNarration.MaxLength = 50;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(390, 20);
            this.txtNarration.TabIndex = 6;
            this.txtNarration.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(261, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(427, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDebitTo
            // 
            this.btnDebitTo.BackColor = System.Drawing.Color.Transparent;
            this.btnDebitTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDebitTo.BackgroundImage")));
            this.btnDebitTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebitTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebitTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebitTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDebitTo.Location = new System.Drawing.Point(427, 85);
            this.btnDebitTo.Name = "btnDebitTo";
            this.btnDebitTo.Size = new System.Drawing.Size(37, 23);
            this.btnDebitTo.TabIndex = 3;
            this.btnDebitTo.Text = "...";
            this.btnDebitTo.UseVisualStyleBackColor = true;
            // 
            // ContraVoucherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 283);
            this.Controls.Add(this.btnDebitTo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCreditTo);
            this.Controls.Add(this.txtDebitTo);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtVoucherDate);
            this.Controls.Add(this.bLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContraVoucherAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContraVoucherAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtVoucherDate;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BTextBox txtVoucherNo;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BTextBox txtDebitTo;
        private WinControlLibrary.BTextBox txtCreditTo;
        private WinControlLibrary.BTextBox txtAmount;
        private WinControlLibrary.BTextBox txtNarration;
        private WinControlLibrary.BAllButton btnSave;
        private WinControlLibrary.BAllButton btnCancel;
        private WinControlLibrary.BAllButton btnDebitTo;
    }
}