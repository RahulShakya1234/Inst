namespace ERP.SalePurchase
{
    partial class SaleOrderListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleOrderListing));
            this.btnGenerate = new WinControlLibrary.BAllButton();
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtF4 = new WinControlLibrary.BAllButton();
            this.txtSaleOrder = new WinControlLibrary.BTextBox();
            this.txtAccount = new WinControlLibrary.BTextBox();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.BackgroundImage")));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerate.Location = new System.Drawing.Point(248, 255);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnGenerate.Size = new System.Drawing.Size(75, 25);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(346, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bLabel8);
            this.groupBox1.Controls.Add(this.bLabel7);
            this.groupBox1.Controls.Add(this.bLabel6);
            this.groupBox1.Controls.Add(this.txtF4);
            this.groupBox1.Controls.Add(this.txtSaleOrder);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.bLabel5);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Criteria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Location = new System.Drawing.Point(31, 109);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(74, 13);
            this.bLabel8.TabIndex = 14;
            this.bLabel8.Text = "Sale Order No";
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(31, 83);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(47, 13);
            this.bLabel7.TabIndex = 13;
            this.bLabel7.Text = "Account";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(31, 57);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(52, 13);
            this.bLabel6.TabIndex = 12;
            this.bLabel6.Text = "To Date :";
            this.bLabel6.Click += new System.EventHandler(this.bLabel6_Click);
            // 
            // txtF4
            // 
            this.txtF4.BackColor = System.Drawing.Color.Transparent;
            this.txtF4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtF4.BackgroundImage")));
            this.txtF4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtF4.Location = new System.Drawing.Point(358, 109);
            this.txtF4.Name = "txtF4";
            this.txtF4.Size = new System.Drawing.Size(75, 25);
            this.txtF4.TabIndex = 5;
            this.txtF4.Text = "F4";
            this.txtF4.UseVisualStyleBackColor = true;
            // 
            // txtSaleOrder
            // 
            this.txtSaleOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSaleOrder.IsMendatory = false;
            this.txtSaleOrder.Location = new System.Drawing.Point(153, 109);
            this.txtSaleOrder.MaxLength = 50;
            this.txtSaleOrder.Name = "txtSaleOrder";
            this.txtSaleOrder.Size = new System.Drawing.Size(199, 20);
            this.txtSaleOrder.TabIndex = 4;
            this.txtSaleOrder.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAccount.IsMendatory = false;
            this.txtAccount.Location = new System.Drawing.Point(153, 83);
            this.txtAccount.MaxLength = 50;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(199, 20);
            this.txtAccount.TabIndex = 3;
            this.txtAccount.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(153, 57);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(127, 20);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(31, 22);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(62, 13);
            this.bLabel5.TabIndex = 7;
            this.bLabel5.Text = "From Date :";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(153, 19);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(127, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.Text = "\r\n";
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // SaleOrderListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleOrderListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleOrderListing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControlLibrary.BAllButton btnGenerate;
        private WinControlLibrary.BAllButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BLabel bLabel8;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BAllButton txtF4;
        private WinControlLibrary.BTextBox txtSaleOrder;
        private WinControlLibrary.BTextBox txtAccount;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtFromDate;
    }
}