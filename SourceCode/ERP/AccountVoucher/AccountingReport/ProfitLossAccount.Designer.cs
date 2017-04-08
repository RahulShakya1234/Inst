namespace ERP.A_CVoucher.AccountingReport
{
    partial class ProfitLossAccount
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
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtYoDate = new WinControlLibrary.BTextBox();
            this.txtFromdate = new WinControlLibrary.BTextBox();
            this.btnCancel = new WinControlLibrary.BButton();
            this.btnPrint = new WinControlLibrary.BButton();
            this.btnPreview = new WinControlLibrary.BButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bLabel7);
            this.groupBox1.Controls.Add(this.bLabel6);
            this.groupBox1.Controls.Add(this.txtYoDate);
            this.groupBox1.Controls.Add(this.txtFromdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 113);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Criteria";
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(29, 57);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(49, 13);
            this.bLabel7.TabIndex = 37;
            this.bLabel7.Text = "To  Date";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(29, 31);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(56, 13);
            this.bLabel6.TabIndex = 36;
            this.bLabel6.Text = "From Date";
            // 
            // txtYoDate
            // 
            this.txtYoDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtYoDate.IsMendatory = false;
            this.txtYoDate.Location = new System.Drawing.Point(114, 53);
            this.txtYoDate.MaxLength = 50;
            this.txtYoDate.Name = "txtYoDate";
            this.txtYoDate.Size = new System.Drawing.Size(127, 20);
            this.txtYoDate.TabIndex = 2;
            this.txtYoDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtFromdate
            // 
            this.txtFromdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromdate.IsMendatory = false;
            this.txtFromdate.Location = new System.Drawing.Point(114, 27);
            this.txtFromdate.MaxLength = 50;
            this.txtFromdate.Name = "txtFromdate";
            this.txtFromdate.Size = new System.Drawing.Size(127, 20);
            this.txtFromdate.TabIndex = 1;
            this.txtFromdate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(403, 67);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 36);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(403, 22);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 36);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // ProfitLossAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 146);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Name = "ProfitLossAccount";
            this.Text = "ProfitLossAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BTextBox txtYoDate;
        private WinControlLibrary.BTextBox txtFromdate;
        private WinControlLibrary.BButton btnCancel;
        private WinControlLibrary.BButton btnPrint;
        private WinControlLibrary.BButton btnPreview;
    }
}