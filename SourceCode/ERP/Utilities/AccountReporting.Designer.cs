namespace ERP.Utilities
{
    partial class AccountReporting
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
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.btnOk = new WinControlLibrary.BButton();
            this.btnCancel = new WinControlLibrary.BButton();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bDateTxtFromDate = new WinControlLibrary.BDateTextBox();
            this.bDateTxtToDate = new WinControlLibrary.BDateTextBox();
            this.txtType = new WinControlLibrary.BTextBox();
            this.SuspendLayout();
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(12, 35);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(46, 13);
            this.bLabel7.TabIndex = 44;
            this.bLabel7.Text = "To Date";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(12, 9);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(56, 13);
            this.bLabel6.TabIndex = 43;
            this.bLabel6.Text = "From Date";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(65, 87);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 36);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(12, 64);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(31, 13);
            this.bLabel1.TabIndex = 46;
            this.bLabel1.Text = "Type";
            // 
            // bDateTxtFromDate
            // 
            this.bDateTxtFromDate.AllowBlank = false;
            this.bDateTxtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bDateTxtFromDate.Location = new System.Drawing.Point(90, 6);
            this.bDateTxtFromDate.Name = "bDateTxtFromDate";
            this.bDateTxtFromDate.Size = new System.Drawing.Size(127, 20);
            this.bDateTxtFromDate.TabIndex = 1;
            // 
            // bDateTxtToDate
            // 
            this.bDateTxtToDate.AllowBlank = false;
            this.bDateTxtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bDateTxtToDate.Location = new System.Drawing.Point(90, 35);
            this.bDateTxtToDate.Name = "bDateTxtToDate";
            this.bDateTxtToDate.Size = new System.Drawing.Size(127, 20);
            this.bDateTxtToDate.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtType.IsMendatory = false;
            this.txtType.Location = new System.Drawing.Point(90, 61);
            this.txtType.MaxLength = 50;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(127, 20);
            this.txtType.TabIndex = 3;
            this.txtType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // AccountReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 311);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.bDateTxtToDate);
            this.Controls.Add(this.bDateTxtFromDate);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "AccountReporting";
            this.Text = "AccountReporting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BButton btnOk;
        private WinControlLibrary.BButton btnCancel;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BDateTextBox bDateTxtFromDate;
        private WinControlLibrary.BDateTextBox bDateTxtToDate;
        private WinControlLibrary.BTextBox txtType;
    }
}