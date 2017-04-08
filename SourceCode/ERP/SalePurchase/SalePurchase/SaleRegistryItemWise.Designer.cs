namespace ERP.SalePurchase
{
    partial class SaleRegistryItemWise
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
            this.btnPreview =new WinControlLibrary.BAllButton();
            this.btnPrint =new WinControlLibrary.BAllButton();
            this.btnCancel =new WinControlLibrary.BAllButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtNoOfColumns = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtItemName = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtGroupName = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(24, 199);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(74, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(133, 199);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(57, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bLabel5);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.bLabel1);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.bLabel6);
            this.groupBox1.Controls.Add(this.txtNoOfColumns);
            this.groupBox1.Controls.Add(this.bLabel4);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.bLabel2);
            this.groupBox1.Controls.Add(this.txtGroupName);
            this.groupBox1.Controls.Add(this.bLabel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 148);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Criteria";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(9, 109);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(76, 13);
            this.bLabel6.TabIndex = 117;
            this.bLabel6.Text = "No of Columns";
            // 
            // txtNoOfColumns
            // 
            this.txtNoOfColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNoOfColumns.IsMendatory = false;
            this.txtNoOfColumns.Location = new System.Drawing.Point(91, 106);
            this.txtNoOfColumns.MaxLength = 50;
            this.txtNoOfColumns.Name = "txtNoOfColumns";
            this.txtNoOfColumns.Size = new System.Drawing.Size(141, 20);
            this.txtNoOfColumns.TabIndex = 5;
            this.txtNoOfColumns.Text = "No of Columns";
            this.txtNoOfColumns.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(9, 83);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(58, 13);
            this.bLabel4.TabIndex = 115;
            this.bLabel4.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItemName.IsMendatory = false;
            this.txtItemName.Location = new System.Drawing.Point(73, 80);
            this.txtItemName.MaxLength = 50;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(159, 20);
            this.txtItemName.TabIndex = 4;
            this.txtItemName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(5, 106);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(0, 13);
            this.bLabel2.TabIndex = 114;
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtGroupName.IsMendatory = false;
            this.txtGroupName.Location = new System.Drawing.Point(72, 54);
            this.txtGroupName.MaxLength = 50;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(101, 20);
            this.txtGroupName.TabIndex = 3;
            this.txtGroupName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(7, 57);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(67, 13);
            this.bLabel3.TabIndex = 110;
            this.bLabel3.Text = "Group Name";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(9, 22);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(56, 13);
            this.bLabel5.TabIndex = 206;
            this.bLabel5.Text = "From Date";
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(247, 19);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(123, 20);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(189, 22);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(52, 13);
            this.bLabel1.TabIndex = 205;
            this.bLabel1.Text = " To Date ";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(71, 22);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(101, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // SaleRegistryItemWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 376);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleRegistryItemWise";
            this.Text = "SaleRegistryItemWise";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BTextBox txtNoOfColumns;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BTextBox txtItemName;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtGroupName;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtFromDate;
    }
}