namespace ERP.SalePurchase
{
    partial class voucherSeriesSetupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(voucherSeriesSetupAdd));
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.txtSeriesNumbering = new WinControlLibrary.BTextBox();
            this.txtSeriesName = new WinControlLibrary.BTextBox();
            this.txtSelectVoucher = new WinControlLibrary.BTextBox();
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.bTextBox4 = new WinControlLibrary.BTextBox();
            this.SuspendLayout();
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(12, 26);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(86, 13);
            this.bLabel1.TabIndex = 1;
            this.bLabel1.Text = "Select Voucher :";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(12, 61);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(73, 13);
            this.bLabel2.TabIndex = 2;
            this.bLabel2.Text = "Series Name :";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(12, 97);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(96, 13);
            this.bLabel3.TabIndex = 3;
            this.bLabel3.Text = "Series Numbering :";
            // 
            // txtSeriesNumbering
            // 
            this.txtSeriesNumbering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSeriesNumbering.IsMendatory = false;
            this.txtSeriesNumbering.Location = new System.Drawing.Point(131, 94);
            this.txtSeriesNumbering.MaxLength = 50;
            this.txtSeriesNumbering.Name = "txtSeriesNumbering";
            this.txtSeriesNumbering.Size = new System.Drawing.Size(230, 20);
            this.txtSeriesNumbering.TabIndex = 2;
            this.txtSeriesNumbering.Text = "Yearly";
            this.txtSeriesNumbering.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSeriesName.IsMendatory = false;
            this.txtSeriesName.Location = new System.Drawing.Point(131, 61);
            this.txtSeriesName.MaxLength = 50;
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(230, 20);
            this.txtSeriesName.TabIndex = 1;
            this.txtSeriesName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtSelectVoucher
            // 
            this.txtSelectVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSelectVoucher.IsMendatory = false;
            this.txtSelectVoucher.Location = new System.Drawing.Point(131, 23);
            this.txtSelectVoucher.MaxLength = 50;
            this.txtSelectVoucher.Name = "txtSelectVoucher";
            this.txtSelectVoucher.Size = new System.Drawing.Size(230, 20);
            this.txtSelectVoucher.TabIndex = 0;
            this.txtSelectVoucher.Text = "Sale";
            this.txtSelectVoucher.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
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
            this.btnCancel.Location = new System.Drawing.Point(285, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
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
            this.btnSave.Location = new System.Drawing.Point(131, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // bTextBox4
            // 
            this.bTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox4.IsMendatory = false;
            this.bTextBox4.Location = new System.Drawing.Point(4, -223);
            this.bTextBox4.MaxLength = 50;
            this.bTextBox4.Name = "bTextBox4";
            this.bTextBox4.Size = new System.Drawing.Size(230, 20);
            this.bTextBox4.TabIndex = 12;
            this.bTextBox4.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // voucherSeriesSetupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 194);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bTextBox4);
            this.Controls.Add(this.txtSelectVoucher);
            this.Controls.Add(this.txtSeriesName);
            this.Controls.Add(this.txtSeriesNumbering);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.bLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "voucherSeriesSetupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoucherSeriesSetupAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BTextBox txtSeriesNumbering;
        private WinControlLibrary.BTextBox txtSeriesName;
        private WinControlLibrary.BTextBox txtSelectVoucher;
        private WinControlLibrary.BAllButton btnCancel;
        private WinControlLibrary.BAllButton btnSave;
        private WinControlLibrary.BTextBox bTextBox4;
    }
}