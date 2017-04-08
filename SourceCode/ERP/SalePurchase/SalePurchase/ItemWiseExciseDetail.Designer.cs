namespace ERP.SalePurchase
{
    partial class ItemWiseExciseDetail
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
            this.btnCancel =new WinControlLibrary.BAllButton();
            this.btnPreview =new WinControlLibrary.BAllButton();
            this.btnPrint =new WinControlLibrary.BAllButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtItem = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtItemGroup = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.txtReportType = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(245, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(74, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(245, 48);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.bLabel1);
            this.groupBox1.Controls.Add(this.txtItemGroup);
            this.groupBox1.Controls.Add(this.bLabel4);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.bLabel2);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.bLabel3);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.txtReportType);
            this.groupBox1.Controls.Add(this.bLabel5);
            this.groupBox1.Location = new System.Drawing.Point(53, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report cretria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItem.IsMendatory = false;
            this.txtItem.Location = new System.Drawing.Point(83, 129);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(101, 20);
            this.txtItem.TabIndex = 5;
            this.txtItem.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtItem.TextChanged += new System.EventHandler(this.bTextBox1_TextChanged);
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(12, 129);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(27, 13);
            this.bLabel1.TabIndex = 172;
            this.bLabel1.Text = "Item";
            this.bLabel1.Click += new System.EventHandler(this.bLabel1_Click);
            // 
            // txtItemGroup
            // 
            this.txtItemGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItemGroup.IsMendatory = false;
            this.txtItemGroup.Location = new System.Drawing.Point(83, 100);
            this.txtItemGroup.MaxLength = 50;
            this.txtItemGroup.Name = "txtItemGroup";
            this.txtItemGroup.Size = new System.Drawing.Size(101, 20);
            this.txtItemGroup.TabIndex = 4;
            this.txtItemGroup.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtItemGroup.TextChanged += new System.EventHandler(this.bTextBox4_TextChanged);
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(10, 100);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(59, 13);
            this.bLabel4.TabIndex = 170;
            this.bLabel4.Text = "Item Group";
            this.bLabel4.Click += new System.EventHandler(this.bLabel4_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(83, 74);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(101, 20);
            this.txtToDate.TabIndex = 3;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtToDate.TextChanged += new System.EventHandler(this.bTextBox2_TextChanged);
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(10, 74);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(52, 13);
            this.bLabel2.TabIndex = 168;
            this.bLabel2.Text = " To Date ";
            this.bLabel2.Click += new System.EventHandler(this.bLabel2_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(83, 48);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(101, 20);
            this.txtFromDate.TabIndex = 2;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtFromDate.TextChanged += new System.EventHandler(this.bTextBox3_TextChanged);
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(12, 48);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(56, 13);
            this.bLabel3.TabIndex = 166;
            this.bLabel3.Text = "From Date";
            this.bLabel3.Click += new System.EventHandler(this.bLabel3_Click);
            // 
            // txtReportType
            // 
            this.txtReportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtReportType.IsMendatory = false;
            this.txtReportType.Location = new System.Drawing.Point(83, 19);
            this.txtReportType.MaxLength = 50;
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.Size = new System.Drawing.Size(101, 20);
            this.txtReportType.TabIndex = 1;
            this.txtReportType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtReportType.TextChanged += new System.EventHandler(this.bTextBox5_TextChanged);
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(9, 22);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(66, 13);
            this.bLabel5.TabIndex = 106;
            this.bLabel5.Text = "Report Type";
            this.bLabel5.Click += new System.EventHandler(this.bLabel5_Click);
            // 
            // ItemWiseExciseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemWiseExciseDetail";
            this.Text = "ItemWiseExciseDetail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private WinControlLibrary.BTextBox txtReportType;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtItem;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtItemGroup;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BLabel bLabel3;
    }
}