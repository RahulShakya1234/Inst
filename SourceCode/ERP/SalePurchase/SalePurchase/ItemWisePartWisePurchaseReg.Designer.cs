namespace ERP.SalePurchase
{
    partial class ItemWisePartWisePurchaseReg
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
            this.btnGenerate =new WinControlLibrary.BAllButton();
            this.txtReportBasedOn = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.txtShowDetails = new WinControlLibrary.BTextBox();
            this.bLabel12 = new WinControlLibrary.BLabel();
            this.txtItem = new WinControlLibrary.BTextBox();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtItemGroup = new WinControlLibrary.BTextBox();
            this.txtParty = new WinControlLibrary.BTextBox();
            this.txtReportType = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(337, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(245, 218);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(60, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // txtReportBasedOn
            // 
            this.txtReportBasedOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtReportBasedOn.IsMendatory = false;
            this.txtReportBasedOn.Location = new System.Drawing.Point(347, 68);
            this.txtReportBasedOn.MaxLength = 50;
            this.txtReportBasedOn.Name = "txtReportBasedOn";
            this.txtReportBasedOn.Size = new System.Drawing.Size(100, 20);
            this.txtReportBasedOn.TabIndex = 4;
            this.txtReportBasedOn.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(48, 37);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(56, 13);
            this.bLabel5.TabIndex = 180;
            this.bLabel5.Text = "From Date";
            this.bLabel5.Click += new System.EventHandler(this.bLabel5_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(279, 34);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(123, 20);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(221, 37);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(52, 13);
            this.bLabel1.TabIndex = 179;
            this.bLabel1.Text = " To Date ";
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(118, 34);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(101, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtShowDetails
            // 
            this.txtShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtShowDetails.IsMendatory = false;
            this.txtShowDetails.Location = new System.Drawing.Point(120, 178);
            this.txtShowDetails.MaxLength = 50;
            this.txtShowDetails.Name = "txtShowDetails";
            this.txtShowDetails.Size = new System.Drawing.Size(100, 20);
            this.txtShowDetails.TabIndex = 8;
            this.txtShowDetails.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel12
            // 
            this.bLabel12.AutoSize = true;
            this.bLabel12.Location = new System.Drawing.Point(45, 178);
            this.bLabel12.Name = "bLabel12";
            this.bLabel12.Size = new System.Drawing.Size(69, 13);
            this.bLabel12.TabIndex = 173;
            this.bLabel12.Text = "Show Details";
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItem.IsMendatory = false;
            this.txtItem.Location = new System.Drawing.Point(118, 148);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(329, 20);
            this.txtItem.TabIndex = 7;
            this.txtItem.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Location = new System.Drawing.Point(252, 74);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(89, 13);
            this.bLabel9.TabIndex = 171;
            this.bLabel9.Text = "Report Based On";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(76, 148);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(27, 13);
            this.bLabel2.TabIndex = 170;
            this.bLabel2.Text = "Item";
            // 
            // txtItemGroup
            // 
            this.txtItemGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItemGroup.IsMendatory = false;
            this.txtItemGroup.Location = new System.Drawing.Point(118, 121);
            this.txtItemGroup.MaxLength = 50;
            this.txtItemGroup.Name = "txtItemGroup";
            this.txtItemGroup.Size = new System.Drawing.Size(329, 20);
            this.txtItemGroup.TabIndex = 6;
            this.txtItemGroup.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtParty
            // 
            this.txtParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtParty.IsMendatory = false;
            this.txtParty.Location = new System.Drawing.Point(118, 95);
            this.txtParty.MaxLength = 50;
            this.txtParty.Name = "txtParty";
            this.txtParty.Size = new System.Drawing.Size(329, 20);
            this.txtParty.TabIndex = 5;
            this.txtParty.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtReportType
            // 
            this.txtReportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtReportType.IsMendatory = false;
            this.txtReportType.Location = new System.Drawing.Point(118, 71);
            this.txtReportType.MaxLength = 50;
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.Size = new System.Drawing.Size(100, 20);
            this.txtReportType.TabIndex = 3;
            this.txtReportType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(52, 121);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(58, 13);
            this.bLabel4.TabIndex = 168;
            this.bLabel4.Text = "item Group";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(74, 102);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(30, 13);
            this.bLabel3.TabIndex = 166;
            this.bLabel3.Text = "party";
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(48, 75);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(69, 13);
            this.bLabel7.TabIndex = 165;
            this.bLabel7.Text = " Report Type";
            // 
            // ItemWisePartWisePurchaseReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 302);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtReportBasedOn);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.txtShowDetails);
            this.Controls.Add(this.bLabel12);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtItemGroup);
            this.Controls.Add(this.txtParty);
            this.Controls.Add(this.txtReportType);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel7);
            this.Name = "ItemWisePartWisePurchaseReg";
            this.Text = "ItemWisePartWisePurchaseReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private WinControlLibrary.BTextBox txtReportBasedOn;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BTextBox txtShowDetails;
        private WinControlLibrary.BLabel bLabel12;
        private WinControlLibrary.BTextBox txtItem;
        private WinControlLibrary.BLabel bLabel9;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtItemGroup;
        private WinControlLibrary.BTextBox txtParty;
        private WinControlLibrary.BTextBox txtReportType;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel7;
    }
}