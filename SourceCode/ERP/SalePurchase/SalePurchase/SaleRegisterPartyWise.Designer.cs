namespace ERP.SalePurchase
{
    partial class SaleRegisterPartyWise
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
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtNameOfColn = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtPartyName = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.btnPreview =new WinControlLibrary.BAllButton();
            this.btnPrint =new WinControlLibrary.BAllButton();
            this.btnCancel =new WinControlLibrary.BAllButton();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bLabel5);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.bLabel1);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.bLabel4);
            this.groupBox1.Controls.Add(this.txtNameOfColn);
            this.groupBox1.Controls.Add(this.bLabel2);
            this.groupBox1.Controls.Add(this.txtPartyName);
            this.groupBox1.Controls.Add(this.bLabel3);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Book Pary Wise";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(11, 103);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(85, 13);
            this.bLabel4.TabIndex = 115;
            this.bLabel4.Text = "Name of Column";
            // 
            // txtNameOfColn
            // 
            this.txtNameOfColn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNameOfColn.IsMendatory = false;
            this.txtNameOfColn.Location = new System.Drawing.Point(119, 103);
            this.txtNameOfColn.MaxLength = 50;
            this.txtNameOfColn.Name = "txtNameOfColn";
            this.txtNameOfColn.Size = new System.Drawing.Size(159, 20);
            this.txtNameOfColn.TabIndex = 4;
            this.txtNameOfColn.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(5, 106);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(0, 13);
            this.bLabel2.TabIndex = 114;
            // 
            // txtPartyName
            // 
            this.txtPartyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPartyName.IsMendatory = false;
            this.txtPartyName.Location = new System.Drawing.Point(72, 54);
            this.txtPartyName.MaxLength = 50;
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(101, 20);
            this.txtPartyName.TabIndex = 3;
            this.txtPartyName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(7, 57);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(65, 13);
            this.bLabel3.TabIndex = 110;
            this.bLabel3.Text = "Party  Name";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(45, 178);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(74, 23);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(154, 178);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(57, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(6, 27);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(56, 13);
            this.bLabel5.TabIndex = 214;
            this.bLabel5.Text = "From Date";
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(243, 28);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(123, 20);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(185, 27);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(52, 13);
            this.bLabel1.TabIndex = 213;
            this.bLabel1.Text = " To Date ";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(68, 27);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(101, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // SaleRegisterPartyWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 223);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleRegisterPartyWise";
            this.Text = "SaleRegisterPartyWise";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BTextBox txtNameOfColn;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtPartyName;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel4;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtFromDate;
    }
}