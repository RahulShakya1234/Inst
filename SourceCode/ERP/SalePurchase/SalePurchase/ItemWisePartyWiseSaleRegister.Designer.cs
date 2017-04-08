namespace ERP.SalePurchase
{
    partial class ItemWisePartyWiseSaleRegister
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
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.txtItem = new WinControlLibrary.BTextBox();
            this.txtItemGroup = new WinControlLibrary.BTextBox();
            this.txtParty = new WinControlLibrary.BTextBox();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.btnFromDate = new WinControlLibrary.BTextBox();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.txtShowDetails = new WinControlLibrary.BTextBox();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtShowQty = new WinControlLibrary.BTextBox();
            this.txtReportType = new WinControlLibrary.BTextBox();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(318, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(399, 196);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(45, 130);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(27, 13);
            this.bLabel2.TabIndex = 186;
            this.bLabel2.Text = "Item";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(35, 95);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(59, 13);
            this.bLabel6.TabIndex = 185;
            this.bLabel6.Text = "Item Group";
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(35, 69);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(31, 13);
            this.bLabel4.TabIndex = 184;
            this.bLabel4.Text = "Party";
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(38, 9);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(56, 13);
            this.bLabel5.TabIndex = 183;
            this.bLabel5.Text = "From Date";
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItem.IsMendatory = false;
            this.txtItem.Location = new System.Drawing.Point(116, 130);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(101, 20);
            this.txtItem.TabIndex = 6;
            this.txtItem.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtItemGroup
            // 
            this.txtItemGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItemGroup.IsMendatory = false;
            this.txtItemGroup.Location = new System.Drawing.Point(117, 95);
            this.txtItemGroup.MaxLength = 50;
            this.txtItemGroup.Name = "txtItemGroup";
            this.txtItemGroup.Size = new System.Drawing.Size(371, 20);
            this.txtItemGroup.TabIndex = 5;
            this.txtItemGroup.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtParty
            // 
            this.txtParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtParty.IsMendatory = false;
            this.txtParty.Location = new System.Drawing.Point(116, 66);
            this.txtParty.MaxLength = 50;
            this.txtParty.Name = "txtParty";
            this.txtParty.Size = new System.Drawing.Size(372, 20);
            this.txtParty.TabIndex = 4;
            this.txtParty.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(298, 6);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(123, 20);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(231, 9);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(52, 13);
            this.bLabel1.TabIndex = 179;
            this.bLabel1.Text = " To Date ";
            // 
            // btnFromDate
            // 
            this.btnFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.btnFromDate.IsMendatory = false;
            this.btnFromDate.Location = new System.Drawing.Point(120, 6);
            this.btnFromDate.MaxLength = 50;
            this.btnFromDate.Name = "btnFromDate";
            this.btnFromDate.Size = new System.Drawing.Size(101, 20);
            this.btnFromDate.TabIndex = 1;
            this.btnFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(35, 170);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(69, 13);
            this.bLabel3.TabIndex = 190;
            this.bLabel3.Text = "Show Details";
            // 
            // txtShowDetails
            // 
            this.txtShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtShowDetails.IsMendatory = false;
            this.txtShowDetails.Location = new System.Drawing.Point(117, 170);
            this.txtShowDetails.MaxLength = 50;
            this.txtShowDetails.Name = "txtShowDetails";
            this.txtShowDetails.Size = new System.Drawing.Size(101, 20);
            this.txtShowDetails.TabIndex = 7;
            this.txtShowDetails.Text = "Show Details";
            this.txtShowDetails.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(236, 170);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(53, 13);
            this.bLabel7.TabIndex = 192;
            this.bLabel7.Text = "Show Qty";
            // 
            // txtShowQty
            // 
            this.txtShowQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtShowQty.IsMendatory = false;
            this.txtShowQty.Location = new System.Drawing.Point(318, 170);
            this.txtShowQty.MaxLength = 50;
            this.txtShowQty.Name = "txtShowQty";
            this.txtShowQty.Size = new System.Drawing.Size(101, 20);
            this.txtShowQty.TabIndex = 8;
            this.txtShowQty.Text = "Show Qty";
            this.txtShowQty.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtReportType
            // 
            this.txtReportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtReportType.IsMendatory = false;
            this.txtReportType.Location = new System.Drawing.Point(296, 40);
            this.txtReportType.MaxLength = 50;
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.Size = new System.Drawing.Size(123, 20);
            this.txtReportType.TabIndex = 3;
            this.txtReportType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Location = new System.Drawing.Point(229, 43);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(62, 13);
            this.bLabel8.TabIndex = 194;
            this.bLabel8.Text = "Report type";
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Location = new System.Drawing.Point(32, 43);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(89, 13);
            this.bLabel9.TabIndex = 195;
            this.bLabel9.Text = "Report Based On";
            // 
            // ItemWisePartyWiseSaleRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 252);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.txtReportType);
            this.Controls.Add(this.bLabel8);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.txtShowQty);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.txtShowDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtItemGroup);
            this.Controls.Add(this.txtParty);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.btnFromDate);
            this.Name = "ItemWisePartyWiseSaleRegister";
            this.Text = "ItemWisePartyWiseSaleRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BTextBox txtItem;
        private WinControlLibrary.BTextBox txtItemGroup;
        private WinControlLibrary.BTextBox txtParty;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox btnFromDate;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BTextBox txtShowDetails;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BTextBox txtShowQty;
        private WinControlLibrary.BTextBox txtReportType;
        private WinControlLibrary.BLabel bLabel8;
        private WinControlLibrary.BLabel bLabel9;
    }
}