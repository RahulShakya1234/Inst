namespace ERP.SalePurchase
{
    partial class ItemRateSetupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemRateSetupAdd));
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.ddlPartyName = new WinControlLibrary.BCombo();
            this.btnPartyNames = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.btnExit = new WinControlLibrary.BAllButton();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.ddlItemName = new WinControlLibrary.BCombo();
            this.btnItemNames = new WinControlLibrary.BAllButton();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.txtCode = new WinControlLibrary.BTextBox();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtRate = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtPoNo = new WinControlLibrary.BTextBox();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtPackingRate = new WinControlLibrary.BTextBox();
            this.txtAmendmentNo = new WinControlLibrary.BTextBox();
            this.bLabel8 = new WinControlLibrary.BLabel();
            this.bLabel9 = new WinControlLibrary.BLabel();
            this.bLabel10 = new WinControlLibrary.BLabel();
            this.txtPartNo = new WinControlLibrary.BTextBox();
            this.bLabel11 = new WinControlLibrary.BLabel();
            this.txtToolSuppyForQty = new WinControlLibrary.BTextBox();
            this.bLabel12 = new WinControlLibrary.BLabel();
            this.txtToolRate = new WinControlLibrary.BTextBox();
            this.bLabel13 = new WinControlLibrary.BLabel();
            this.txtTax = new WinControlLibrary.BTextBox();
            this.bLabel14 = new WinControlLibrary.BLabel();
            this.bLabel15 = new WinControlLibrary.BLabel();
            this.txtToolNarr = new WinControlLibrary.BTextBox();
            this.txtProcessName = new WinControlLibrary.BTextBox();
            this.txtPODate = new WinControlLibrary.BDateTextBox();
            this.txtAmendmentDate = new WinControlLibrary.BDateTextBox();
            this.SuspendLayout();
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(21, 35);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(68, 13);
            this.bLabel1.TabIndex = 0;
            this.bLabel1.Text = "Party Name :";
            // 
            // ddlPartyName
            // 
            this.ddlPartyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlPartyName.DisplayMember = "Value";
            this.ddlPartyName.FormattingEnabled = true;
            this.ddlPartyName.Location = new System.Drawing.Point(118, 32);
            this.ddlPartyName.Name = "ddlPartyName";
            this.ddlPartyName.Size = new System.Drawing.Size(305, 21);
            this.ddlPartyName.TabIndex = 1;
            this.ddlPartyName.ValueMember = "Code";
            // 
            // btnPartyNames
            // 
            this.btnPartyNames.BackColor = System.Drawing.Color.Transparent;
            this.btnPartyNames.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPartyNames.BackgroundImage")));
            this.btnPartyNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartyNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartyNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartyNames.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPartyNames.Location = new System.Drawing.Point(440, 30);
            this.btnPartyNames.Name = "btnPartyNames";
            this.btnPartyNames.Size = new System.Drawing.Size(32, 23);
            this.btnPartyNames.TabIndex = 2;
            this.btnPartyNames.Text = "...";
            this.btnPartyNames.UseVisualStyleBackColor = true;
            this.btnPartyNames.Click += new System.EventHandler(this.btnPartyNames_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(411, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 25);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(493, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 25);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(22, 62);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(64, 13);
            this.bLabel2.TabIndex = 5;
            this.bLabel2.Text = "Item Name :";
            // 
            // ddlItemName
            // 
            this.ddlItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlItemName.DisplayMember = "Value";
            this.ddlItemName.FormattingEnabled = true;
            this.ddlItemName.Location = new System.Drawing.Point(118, 59);
            this.ddlItemName.Name = "ddlItemName";
            this.ddlItemName.Size = new System.Drawing.Size(305, 21);
            this.ddlItemName.TabIndex = 3;
            this.ddlItemName.ValueMember = "Code";
            this.ddlItemName.SelectedIndexChanged += new System.EventHandler(this.ddlItemCode_SelectedIndexChanged);
            // 
            // btnItemNames
            // 
            this.btnItemNames.BackColor = System.Drawing.Color.Transparent;
            this.btnItemNames.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemNames.BackgroundImage")));
            this.btnItemNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemNames.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnItemNames.Location = new System.Drawing.Point(441, 59);
            this.btnItemNames.Name = "btnItemNames";
            this.btnItemNames.Size = new System.Drawing.Size(32, 23);
            this.btnItemNames.TabIndex = 4;
            this.btnItemNames.Text = "...";
            this.btnItemNames.UseVisualStyleBackColor = true;
            this.btnItemNames.Click += new System.EventHandler(this.btnItemNames_Click);
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(22, 88);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(61, 13);
            this.bLabel3.TabIndex = 8;
            this.bLabel3.Text = "Item Code :";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtCode.IsMendatory = false;
            this.txtCode.Location = new System.Drawing.Point(119, 86);
            this.txtCode.MaxLength = 50;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(239, 20);
            this.txtCode.TabIndex = 5;
            this.txtCode.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(23, 110);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(59, 13);
            this.bLabel4.TabIndex = 10;
            this.bLabel4.Text = "Item Rate :";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtRate.IsMendatory = false;
            this.txtRate.Location = new System.Drawing.Point(119, 110);
            this.txtRate.MaxLength = 50;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(71, 20);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "0";
            this.txtRate.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(211, 115);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(72, 13);
            this.bLabel5.TabIndex = 12;
            this.bLabel5.Text = "Packing Rate";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(24, 135);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(51, 13);
            this.bLabel6.TabIndex = 14;
            this.bLabel6.Text = "P.O. No :";
            // 
            // txtPoNo
            // 
            this.txtPoNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPoNo.IsMendatory = false;
            this.txtPoNo.Location = new System.Drawing.Point(118, 134);
            this.txtPoNo.MaxLength = 50;
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.Size = new System.Drawing.Size(240, 20);
            this.txtPoNo.TabIndex = 8;
            this.txtPoNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(24, 157);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(86, 13);
            this.bLabel7.TabIndex = 16;
            this.bLabel7.Text = "Amendment No :";
            // 
            // txtPackingRate
            // 
            this.txtPackingRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPackingRate.IsMendatory = false;
            this.txtPackingRate.Location = new System.Drawing.Point(287, 110);
            this.txtPackingRate.MaxLength = 50;
            this.txtPackingRate.Name = "txtPackingRate";
            this.txtPackingRate.Size = new System.Drawing.Size(71, 20);
            this.txtPackingRate.TabIndex = 7;
            this.txtPackingRate.Text = "0";
            this.txtPackingRate.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            // 
            // txtAmendmentNo
            // 
            this.txtAmendmentNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmendmentNo.IsMendatory = false;
            this.txtAmendmentNo.Location = new System.Drawing.Point(118, 160);
            this.txtAmendmentNo.MaxLength = 50;
            this.txtAmendmentNo.Name = "txtAmendmentNo";
            this.txtAmendmentNo.Size = new System.Drawing.Size(240, 20);
            this.txtAmendmentNo.TabIndex = 10;
            this.txtAmendmentNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel8
            // 
            this.bLabel8.AutoSize = true;
            this.bLabel8.Location = new System.Drawing.Point(410, 141);
            this.bLabel8.Name = "bLabel8";
            this.bLabel8.Size = new System.Drawing.Size(63, 13);
            this.bLabel8.TabIndex = 19;
            this.bLabel8.Text = "P.O. Date : ";
            // 
            // bLabel9
            // 
            this.bLabel9.AutoSize = true;
            this.bLabel9.Location = new System.Drawing.Point(377, 163);
            this.bLabel9.Name = "bLabel9";
            this.bLabel9.Size = new System.Drawing.Size(95, 13);
            this.bLabel9.TabIndex = 21;
            this.bLabel9.Text = "Amendment Date :";
            // 
            // bLabel10
            // 
            this.bLabel10.AutoSize = true;
            this.bLabel10.Location = new System.Drawing.Point(21, 296);
            this.bLabel10.Name = "bLabel10";
            this.bLabel10.Size = new System.Drawing.Size(49, 13);
            this.bLabel10.TabIndex = 23;
            this.bLabel10.Text = "Part No :";
            // 
            // txtPartNo
            // 
            this.txtPartNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPartNo.IsMendatory = false;
            this.txtPartNo.Location = new System.Drawing.Point(118, 296);
            this.txtPartNo.MaxLength = 50;
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(240, 20);
            this.txtPartNo.TabIndex = 12;
            this.txtPartNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel11
            // 
            this.bLabel11.AutoSize = true;
            this.bLabel11.Location = new System.Drawing.Point(21, 322);
            this.bLabel11.Name = "bLabel11";
            this.bLabel11.Size = new System.Drawing.Size(96, 13);
            this.bLabel11.TabIndex = 25;
            this.bLabel11.Text = "Tool Supp for Qty :";
            // 
            // txtToolSuppyForQty
            // 
            this.txtToolSuppyForQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToolSuppyForQty.IsMendatory = false;
            this.txtToolSuppyForQty.Location = new System.Drawing.Point(118, 321);
            this.txtToolSuppyForQty.MaxLength = 50;
            this.txtToolSuppyForQty.Name = "txtToolSuppyForQty";
            this.txtToolSuppyForQty.Size = new System.Drawing.Size(72, 20);
            this.txtToolSuppyForQty.TabIndex = 13;
            this.txtToolSuppyForQty.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel12
            // 
            this.bLabel12.AutoSize = true;
            this.bLabel12.Location = new System.Drawing.Point(22, 345);
            this.bLabel12.Name = "bLabel12";
            this.bLabel12.Size = new System.Drawing.Size(60, 13);
            this.bLabel12.TabIndex = 27;
            this.bLabel12.Text = "Tool Rate :";
            // 
            // txtToolRate
            // 
            this.txtToolRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToolRate.IsMendatory = false;
            this.txtToolRate.Location = new System.Drawing.Point(118, 346);
            this.txtToolRate.MaxLength = 50;
            this.txtToolRate.Name = "txtToolRate";
            this.txtToolRate.Size = new System.Drawing.Size(71, 20);
            this.txtToolRate.TabIndex = 14;
            this.txtToolRate.Text = "0";
            this.txtToolRate.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            // 
            // bLabel13
            // 
            this.bLabel13.AutoSize = true;
            this.bLabel13.Location = new System.Drawing.Point(263, 345);
            this.bLabel13.Name = "bLabel13";
            this.bLabel13.Size = new System.Drawing.Size(31, 13);
            this.bLabel13.TabIndex = 29;
            this.bLabel13.Text = "Tax :";
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTax.IsMendatory = false;
            this.txtTax.Location = new System.Drawing.Point(312, 342);
            this.txtTax.MaxLength = 10;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(46, 20);
            this.txtTax.TabIndex = 15;
            this.txtTax.Text = "0";
            this.txtTax.TextType = WinControlLibrary.BTextBox.TextBoxType.IntegerType;
            // 
            // bLabel14
            // 
            this.bLabel14.AutoSize = true;
            this.bLabel14.Location = new System.Drawing.Point(21, 371);
            this.bLabel14.Name = "bLabel14";
            this.bLabel14.Size = new System.Drawing.Size(57, 13);
            this.bLabel14.TabIndex = 31;
            this.bLabel14.Text = "Tool Narr :";
            // 
            // bLabel15
            // 
            this.bLabel15.AutoSize = true;
            this.bLabel15.Location = new System.Drawing.Point(24, 393);
            this.bLabel15.Name = "bLabel15";
            this.bLabel15.Size = new System.Drawing.Size(82, 13);
            this.bLabel15.TabIndex = 32;
            this.bLabel15.Text = "Process Name :";
            // 
            // txtToolNarr
            // 
            this.txtToolNarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToolNarr.IsMendatory = false;
            this.txtToolNarr.Location = new System.Drawing.Point(118, 371);
            this.txtToolNarr.MaxLength = 50;
            this.txtToolNarr.Name = "txtToolNarr";
            this.txtToolNarr.Size = new System.Drawing.Size(354, 20);
            this.txtToolNarr.TabIndex = 16;
            this.txtToolNarr.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtProcessName
            // 
            this.txtProcessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtProcessName.IsMendatory = false;
            this.txtProcessName.Location = new System.Drawing.Point(119, 397);
            this.txtProcessName.MaxLength = 50;
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(354, 20);
            this.txtProcessName.TabIndex = 17;
            this.txtProcessName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtPODate
            // 
            this.txtPODate.AllowBlank = false;
            this.txtPODate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPODate.Location = new System.Drawing.Point(479, 132);
            this.txtPODate.Name = "txtPODate";
            this.txtPODate.Size = new System.Drawing.Size(100, 20);
            this.txtPODate.TabIndex = 9;
            // 
            // txtAmendmentDate
            // 
            this.txtAmendmentDate.AllowBlank = false;
            this.txtAmendmentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmendmentDate.Location = new System.Drawing.Point(479, 157);
            this.txtAmendmentDate.Name = "txtAmendmentDate";
            this.txtAmendmentDate.Size = new System.Drawing.Size(100, 20);
            this.txtAmendmentDate.TabIndex = 11;
            // 
            // ItemRateSetupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 476);
            this.Controls.Add(this.txtAmendmentDate);
            this.Controls.Add(this.txtPODate);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.txtToolNarr);
            this.Controls.Add(this.bLabel15);
            this.Controls.Add(this.bLabel14);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.bLabel13);
            this.Controls.Add(this.txtToolRate);
            this.Controls.Add(this.bLabel12);
            this.Controls.Add(this.txtToolSuppyForQty);
            this.Controls.Add(this.bLabel11);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.bLabel10);
            this.Controls.Add(this.bLabel9);
            this.Controls.Add(this.bLabel8);
            this.Controls.Add(this.txtAmendmentNo);
            this.Controls.Add(this.txtPackingRate);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.txtPoNo);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.btnItemNames);
            this.Controls.Add(this.ddlItemName);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPartyNames);
            this.Controls.Add(this.ddlPartyName);
            this.Controls.Add(this.bLabel1);
            this.Name = "ItemRateSetupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemRateSetupAdd";
            this.Load += new System.EventHandler(this.ItemRateSetupAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BCombo ddlPartyName;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BCombo ddlItemName;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BTextBox txtCode;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BTextBox txtRate;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BTextBox txtPoNo;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BTextBox txtPackingRate;
        private WinControlLibrary.BTextBox txtAmendmentNo;
        private WinControlLibrary.BLabel bLabel8;
        private WinControlLibrary.BLabel bLabel9;
        private WinControlLibrary.BLabel bLabel10;
        private WinControlLibrary.BTextBox txtPartNo;
        private WinControlLibrary.BLabel bLabel11;
        private WinControlLibrary.BTextBox txtToolSuppyForQty;
        private WinControlLibrary.BLabel bLabel12;
        private WinControlLibrary.BTextBox txtToolRate;
        private WinControlLibrary.BLabel bLabel13;
        private WinControlLibrary.BTextBox txtTax;
        private WinControlLibrary.BLabel bLabel14;
        private WinControlLibrary.BLabel bLabel15;
        private WinControlLibrary.BTextBox txtToolNarr;
        private WinControlLibrary.BTextBox txtProcessName;
        private WinControlLibrary.BDateTextBox txtPODate;
        private WinControlLibrary.BDateTextBox txtAmendmentDate;
        private WinControlLibrary.BAllButton btnPartyNames;
        private WinControlLibrary.BAllButton btnSave;
        private WinControlLibrary.BAllButton btnExit;
        private WinControlLibrary.BAllButton btnItemNames;
    }
}