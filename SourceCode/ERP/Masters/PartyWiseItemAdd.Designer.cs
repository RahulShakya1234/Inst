namespace ERP.SalePurchase
{
    partial class PartyWiseItemAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyWiseItemAdd));
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.ddlGroupName = new WinControlLibrary.BCombo();
            this.btnItemName = new WinControlLibrary.BButton();
            this.btnPartyName = new WinControlLibrary.BButton();
            this.txtTax = new WinControlLibrary.BTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProcessName = new WinControlLibrary.BTextBox();
            this.txtToolRate = new WinControlLibrary.BTextBox();
            this.txtToolNarr = new WinControlLibrary.BTextBox();
            this.txtToolSupply = new WinControlLibrary.BTextBox();
            this.txtPartno = new WinControlLibrary.BTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmendmentDate = new WinControlLibrary.BTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPOdate = new WinControlLibrary.BTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmendmentNo = new WinControlLibrary.BTextBox();
            this.txtPONo = new WinControlLibrary.BTextBox();
            this.txtItemCode = new WinControlLibrary.BTextBox();
            this.txtItemRate = new WinControlLibrary.BTextBox();
            this.txtItemName = new WinControlLibrary.BTextBox();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.LblItemCode = new System.Windows.Forms.Label();
            this.LblItemRate = new System.Windows.Forms.Label();
            this.lblPONo = new System.Windows.Forms.Label();
            this.lblAmendmentNo = new System.Windows.Forms.Label();
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
            this.btnCancel.Location = new System.Drawing.Point(545, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 147;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(452, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 146;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // ddlGroupName
            // 
            this.ddlGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlGroupName.DisplayMember = "Value";
            this.ddlGroupName.FormattingEnabled = true;
            this.ddlGroupName.Location = new System.Drawing.Point(148, 12);
            this.ddlGroupName.Name = "ddlGroupName";
            this.ddlGroupName.Size = new System.Drawing.Size(206, 21);
            this.ddlGroupName.TabIndex = 35;
            this.ddlGroupName.ValueMember = "Code";
            this.ddlGroupName.SelectedIndexChanged += new System.EventHandler(this.ddlGroupName_SelectedIndexChanged);
            // 
            // btnItemName
            // 
            this.btnItemName.Location = new System.Drawing.Point(403, 45);
            this.btnItemName.Name = "btnItemName";
            this.btnItemName.Size = new System.Drawing.Size(57, 23);
            this.btnItemName.TabIndex = 33;
            this.btnItemName.Text = "......";
            this.btnItemName.UseVisualStyleBackColor = true;
            this.btnItemName.Click += new System.EventHandler(this.btnItemName_Click);
            // 
            // btnPartyName
            // 
            this.btnPartyName.Location = new System.Drawing.Point(403, 3);
            this.btnPartyName.Name = "btnPartyName";
            this.btnPartyName.Size = new System.Drawing.Size(57, 23);
            this.btnPartyName.TabIndex = 32;
            this.btnPartyName.Text = ".....";
            this.btnPartyName.UseVisualStyleBackColor = true;
            this.btnPartyName.Click += new System.EventHandler(this.btnPartyName_Click);
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTax.IsMendatory = false;
            this.txtTax.Location = new System.Drawing.Point(391, 266);
            this.txtTax.MaxLength = 50;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(69, 20);
            this.txtTax.TabIndex = 12;
            this.txtTax.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtTax.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(344, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tax %";
            // 
            // txtProcessName
            // 
            this.txtProcessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtProcessName.IsMendatory = false;
            this.txtProcessName.Location = new System.Drawing.Point(148, 330);
            this.txtProcessName.MaxLength = 50;
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(257, 20);
            this.txtProcessName.TabIndex = 14;
            this.txtProcessName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtToolRate
            // 
            this.txtToolRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToolRate.IsMendatory = false;
            this.txtToolRate.Location = new System.Drawing.Point(148, 268);
            this.txtToolRate.MaxLength = 50;
            this.txtToolRate.Name = "txtToolRate";
            this.txtToolRate.Size = new System.Drawing.Size(81, 20);
            this.txtToolRate.TabIndex = 11;
            this.txtToolRate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtToolNarr
            // 
            this.txtToolNarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToolNarr.IsMendatory = false;
            this.txtToolNarr.Location = new System.Drawing.Point(148, 300);
            this.txtToolNarr.MaxLength = 50;
            this.txtToolNarr.Name = "txtToolNarr";
            this.txtToolNarr.Size = new System.Drawing.Size(257, 20);
            this.txtToolNarr.TabIndex = 13;
            this.txtToolNarr.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtToolSupply
            // 
            this.txtToolSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToolSupply.IsMendatory = false;
            this.txtToolSupply.Location = new System.Drawing.Point(148, 234);
            this.txtToolSupply.MaxLength = 50;
            this.txtToolSupply.Name = "txtToolSupply";
            this.txtToolSupply.Size = new System.Drawing.Size(81, 20);
            this.txtToolSupply.TabIndex = 10;
            this.txtToolSupply.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtPartno
            // 
            this.txtPartno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPartno.IsMendatory = false;
            this.txtPartno.Location = new System.Drawing.Point(148, 203);
            this.txtPartno.MaxLength = 50;
            this.txtPartno.Name = "txtPartno";
            this.txtPartno.Size = new System.Drawing.Size(257, 20);
            this.txtPartno.TabIndex = 9;
            this.txtPartno.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(41, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Part No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(41, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "ToolSupply for Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(41, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tool Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(41, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = " Tool Narr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(41, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Process Name";
            // 
            // txtAmendmentDate
            // 
            this.txtAmendmentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmendmentDate.IsMendatory = false;
            this.txtAmendmentDate.Location = new System.Drawing.Point(533, 169);
            this.txtAmendmentDate.MaxLength = 50;
            this.txtAmendmentDate.Name = "txtAmendmentDate";
            this.txtAmendmentDate.Size = new System.Drawing.Size(113, 20);
            this.txtAmendmentDate.TabIndex = 8;
            this.txtAmendmentDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(427, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amendment Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPOdate
            // 
            this.txtPOdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPOdate.IsMendatory = false;
            this.txtPOdate.Location = new System.Drawing.Point(533, 131);
            this.txtPOdate.MaxLength = 50;
            this.txtPOdate.Name = "txtPOdate";
            this.txtPOdate.Size = new System.Drawing.Size(113, 20);
            this.txtPOdate.TabIndex = 7;
            this.txtPOdate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            this.txtPOdate.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(471, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "P.O Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAmendmentNo
            // 
            this.txtAmendmentNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAmendmentNo.IsMendatory = false;
            this.txtAmendmentNo.Location = new System.Drawing.Point(148, 171);
            this.txtAmendmentNo.MaxLength = 50;
            this.txtAmendmentNo.Name = "txtAmendmentNo";
            this.txtAmendmentNo.Size = new System.Drawing.Size(206, 20);
            this.txtAmendmentNo.TabIndex = 6;
            this.txtAmendmentNo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtPONo
            // 
            this.txtPONo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtPONo.IsMendatory = false;
            this.txtPONo.Location = new System.Drawing.Point(148, 139);
            this.txtPONo.MaxLength = 50;
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(206, 20);
            this.txtPONo.TabIndex = 5;
            this.txtPONo.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtItemCode
            // 
            this.txtItemCode.AcceptsReturn = true;
            this.txtItemCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItemCode.IsMendatory = false;
            this.txtItemCode.Location = new System.Drawing.Point(148, 77);
            this.txtItemCode.MaxLength = 50;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(206, 20);
            this.txtItemCode.TabIndex = 3;
            this.txtItemCode.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            // 
            // txtItemRate
            // 
            this.txtItemRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItemRate.IsMendatory = false;
            this.txtItemRate.Location = new System.Drawing.Point(148, 109);
            this.txtItemRate.MaxLength = 50;
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(206, 20);
            this.txtItemRate.TabIndex = 4;
            this.txtItemRate.TextType = WinControlLibrary.BTextBox.TextBoxType.DoubleType2;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtItemName.IsMendatory = false;
            this.txtItemName.Location = new System.Drawing.Point(148, 43);
            this.txtItemName.MaxLength = 50;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(206, 20);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPartName.Location = new System.Drawing.Point(41, 9);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(71, 15);
            this.lblPartName.TabIndex = 6;
            this.lblPartName.Text = "Party Name";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblItemName.Location = new System.Drawing.Point(41, 44);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(68, 15);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "Item Name";
            // 
            // LblItemCode
            // 
            this.LblItemCode.AutoSize = true;
            this.LblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblItemCode.Location = new System.Drawing.Point(41, 78);
            this.LblItemCode.Name = "LblItemCode";
            this.LblItemCode.Size = new System.Drawing.Size(63, 15);
            this.LblItemCode.TabIndex = 4;
            this.LblItemCode.Text = "Item Code";
            // 
            // LblItemRate
            // 
            this.LblItemRate.AutoSize = true;
            this.LblItemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblItemRate.Location = new System.Drawing.Point(41, 110);
            this.LblItemRate.Name = "LblItemRate";
            this.LblItemRate.Size = new System.Drawing.Size(60, 15);
            this.LblItemRate.TabIndex = 3;
            this.LblItemRate.Text = "Item Rate";
            // 
            // lblPONo
            // 
            this.lblPONo.AutoSize = true;
            this.lblPONo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPONo.Location = new System.Drawing.Point(41, 140);
            this.lblPONo.Name = "lblPONo";
            this.lblPONo.Size = new System.Drawing.Size(49, 15);
            this.lblPONo.TabIndex = 2;
            this.lblPONo.Text = "P.O No.";
            this.lblPONo.Click += new System.EventHandler(this.lblPONo_Click);
            // 
            // lblAmendmentNo
            // 
            this.lblAmendmentNo.AutoSize = true;
            this.lblAmendmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAmendmentNo.Location = new System.Drawing.Point(41, 168);
            this.lblAmendmentNo.Name = "lblAmendmentNo";
            this.lblAmendmentNo.Size = new System.Drawing.Size(96, 15);
            this.lblAmendmentNo.TabIndex = 1;
            this.lblAmendmentNo.Text = "Amendment No.";
            // 
            // PartyWiseItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 398);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ddlGroupName);
            this.Controls.Add(this.btnItemName);
            this.Controls.Add(this.btnPartyName);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.txtToolRate);
            this.Controls.Add(this.txtToolNarr);
            this.Controls.Add(this.txtToolSupply);
            this.Controls.Add(this.txtPartno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmendmentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPOdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmendmentNo);
            this.Controls.Add(this.txtPONo);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtItemRate);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.LblItemCode);
            this.Controls.Add(this.LblItemRate);
            this.Controls.Add(this.lblPONo);
            this.Controls.Add(this.lblAmendmentNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartyWiseItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Wise Item List View";
            this.Load += new System.EventHandler(this.PartyWiseItemListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPartName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblAmendmentNo;
        public System.Windows.Forms.Label lblPONo;
        public System.Windows.Forms.Label LblItemRate;
        public System.Windows.Forms.Label LblItemCode;
        public System.Windows.Forms.Label lblItemName;
        public WinControlLibrary.BTextBox txtItemName;
        public WinControlLibrary.BTextBox txtItemRate;
        public WinControlLibrary.BTextBox txtItemCode;
        public WinControlLibrary.BTextBox txtPONo;
        public WinControlLibrary.BTextBox txtAmendmentNo;
        public System.Windows.Forms.Label label1;
        public WinControlLibrary.BTextBox txtPOdate;
        public WinControlLibrary.BTextBox txtAmendmentDate;
        public System.Windows.Forms.Label label2;
        public WinControlLibrary.BTextBox txtProcessName;
        public WinControlLibrary.BTextBox txtToolRate;
        public WinControlLibrary.BTextBox txtToolNarr;
        public WinControlLibrary.BTextBox txtToolSupply;
        public WinControlLibrary.BTextBox txtPartno;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public WinControlLibrary.BTextBox txtTax;
        public System.Windows.Forms.Label label9;
        public WinControlLibrary.BButton btnPartyName;
        public WinControlLibrary.BButton btnItemName;
        public WinControlLibrary.BCombo ddlGroupName;
        private WinControlLibrary.BAllButton btnCancel;
        private WinControlLibrary.BAllButton btnSave;
    }
}