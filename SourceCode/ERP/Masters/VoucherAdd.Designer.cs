namespace ERP.SalePurchase
{
    partial class VoucherAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoucherAdd));
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.txtSelectVoucher = new WinControlLibrary.BTextBox();
            this.txtSeriesName = new WinControlLibrary.BTextBox();
            this.txtSeriesNumbering = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(241, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 24);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Exit";
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
            this.btnSave.Location = new System.Drawing.Point(130, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 24);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtSelectVoucher
            // 
            this.txtSelectVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSelectVoucher.IsMendatory = false;
            this.txtSelectVoucher.Location = new System.Drawing.Point(116, 60);
            this.txtSelectVoucher.MaxLength = 50;
            this.txtSelectVoucher.Name = "txtSelectVoucher";
            this.txtSelectVoucher.Size = new System.Drawing.Size(201, 20);
            this.txtSelectVoucher.TabIndex = 5;
            this.txtSelectVoucher.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSeriesName.IsMendatory = false;
            this.txtSeriesName.Location = new System.Drawing.Point(116, 98);
            this.txtSeriesName.MaxLength = 50;
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(201, 20);
            this.txtSeriesName.TabIndex = 7;
            this.txtSeriesName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtSeriesNumbering
            // 
            this.txtSeriesNumbering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSeriesNumbering.IsMendatory = false;
            this.txtSeriesNumbering.Location = new System.Drawing.Point(190, 131);
            this.txtSeriesNumbering.MaxLength = 50;
            this.txtSeriesNumbering.Name = "txtSeriesNumbering";
            this.txtSeriesNumbering.Size = new System.Drawing.Size(54, 20);
            this.txtSeriesNumbering.TabIndex = 9;
            this.txtSeriesNumbering.Text = "  yes";
            this.txtSeriesNumbering.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtSeriesNumbering.TextChanged += new System.EventHandler(this.txtSeriesNumbering_TextChanged);
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(-3, 134);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(187, 13);
            this.bLabel3.TabIndex = 10;
            this.bLabel3.Text = "Ask For Printing  For Voucher Saving :";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(8, 101);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(84, 13);
            this.bLabel2.TabIndex = 8;
            this.bLabel2.Text = "Voucher Name :";
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(-3, 63);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(84, 13);
            this.bLabel1.TabIndex = 6;
            this.bLabel1.Text = " Voucher  Code:";
            // 
            // VoucherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSelectVoucher);
            this.Controls.Add(this.txtSeriesName);
            this.Controls.Add(this.txtSeriesNumbering);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.bLabel1);
            this.Name = "VoucherAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoucherAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BAllButton btnCancel;
        private WinControlLibrary.BAllButton btnSave;
        private WinControlLibrary.BTextBox txtSelectVoucher;
        private WinControlLibrary.BTextBox txtSeriesName;
        private WinControlLibrary.BTextBox txtSeriesNumbering;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel1;
    }
}