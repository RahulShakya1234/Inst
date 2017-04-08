namespace ERP.SalePurchase
{
    partial class ItemGroupAdd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemGroupAdd));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ddlSalableItemGrp = new WinControlLibrary.BCombo();
            this.ddlUpperGroup = new WinControlLibrary.BCombo();
            this.txtGroupName = new WinControlLibrary.BTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrefix = new WinControlLibrary.BTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ddlAutomaticQC = new WinControlLibrary.BCombo();
            this.ddlAutoAssemlyfromRGP = new WinControlLibrary.BCombo();
            this.ddlScheduleNoRequiredinMRN = new WinControlLibrary.BCombo();
            this.ddlMakeAutoProductionEntry = new WinControlLibrary.BCombo();
            this.ddlAutoMRN = new WinControlLibrary.BCombo();
            this.ddlShowinWorkerOrder = new WinControlLibrary.BCombo();
            this.ddlPORequiredinMRN = new WinControlLibrary.BCombo();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 250);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ddlSalableItemGrp);
            this.tabPage1.Controls.Add(this.ddlUpperGroup);
            this.tabPage1.Controls.Add(this.txtGroupName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPrefix);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(390, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabGeneral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ddlSalableItemGrp
            // 
            this.ddlSalableItemGrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlSalableItemGrp.DisplayMember = "Value";
            this.ddlSalableItemGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSalableItemGrp.FormattingEnabled = true;
            this.ddlSalableItemGrp.Location = new System.Drawing.Point(145, 130);
            this.ddlSalableItemGrp.Name = "ddlSalableItemGrp";
            this.ddlSalableItemGrp.Size = new System.Drawing.Size(201, 21);
            this.ddlSalableItemGrp.TabIndex = 4;
            this.ddlSalableItemGrp.ValueMember = "Code";
            // 
            // ddlUpperGroup
            // 
            this.ddlUpperGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlUpperGroup.DisplayMember = "Value";
            this.ddlUpperGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlUpperGroup.FormattingEnabled = true;
            this.ddlUpperGroup.Location = new System.Drawing.Point(145, 77);
            this.ddlUpperGroup.Name = "ddlUpperGroup";
            this.ddlUpperGroup.Size = new System.Drawing.Size(201, 21);
            this.ddlUpperGroup.TabIndex = 2;
            this.ddlUpperGroup.ValueMember = "Code";
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.White;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.IsMendatory = true;
            this.txtGroupName.Location = new System.Drawing.Point(145, 51);
            this.txtGroupName.MaxLength = 50;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(201, 20);
            this.txtGroupName.TabIndex = 0;
            this.txtGroupName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Upper Group :";
            // 
            // txtPrefix
            // 
            this.txtPrefix.BackColor = System.Drawing.Color.Pink;
            this.txtPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefix.IsMendatory = true;
            this.txtPrefix.Location = new System.Drawing.Point(145, 105);
            this.txtPrefix.MaxLength = 50;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(201, 20);
            this.txtPrefix.TabIndex = 3;
            this.txtPrefix.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Prefix :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Salable Item Group :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Group Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ddlAutomaticQC);
            this.tabPage2.Controls.Add(this.ddlAutoAssemlyfromRGP);
            this.tabPage2.Controls.Add(this.ddlScheduleNoRequiredinMRN);
            this.tabPage2.Controls.Add(this.ddlMakeAutoProductionEntry);
            this.tabPage2.Controls.Add(this.ddlAutoMRN);
            this.tabPage2.Controls.Add(this.ddlShowinWorkerOrder);
            this.tabPage2.Controls.Add(this.ddlPORequiredinMRN);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(390, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabOther";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ddlAutomaticQC
            // 
            this.ddlAutomaticQC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlAutomaticQC.DisplayMember = "Value";
            this.ddlAutomaticQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlAutomaticQC.FormattingEnabled = true;
            this.ddlAutomaticQC.Location = new System.Drawing.Point(172, 25);
            this.ddlAutomaticQC.Name = "ddlAutomaticQC";
            this.ddlAutomaticQC.Size = new System.Drawing.Size(201, 21);
            this.ddlAutomaticQC.TabIndex = 5;
            this.ddlAutomaticQC.ValueMember = "Code";
            // 
            // ddlAutoAssemlyfromRGP
            // 
            this.ddlAutoAssemlyfromRGP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlAutoAssemlyfromRGP.DisplayMember = "Value";
            this.ddlAutoAssemlyfromRGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlAutoAssemlyfromRGP.FormattingEnabled = true;
            this.ddlAutoAssemlyfromRGP.Location = new System.Drawing.Point(172, 51);
            this.ddlAutoAssemlyfromRGP.Name = "ddlAutoAssemlyfromRGP";
            this.ddlAutoAssemlyfromRGP.Size = new System.Drawing.Size(201, 21);
            this.ddlAutoAssemlyfromRGP.TabIndex = 6;
            this.ddlAutoAssemlyfromRGP.ValueMember = "Code";
            // 
            // ddlScheduleNoRequiredinMRN
            // 
            this.ddlScheduleNoRequiredinMRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlScheduleNoRequiredinMRN.DisplayMember = "Value";
            this.ddlScheduleNoRequiredinMRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlScheduleNoRequiredinMRN.FormattingEnabled = true;
            this.ddlScheduleNoRequiredinMRN.Location = new System.Drawing.Point(172, 186);
            this.ddlScheduleNoRequiredinMRN.Name = "ddlScheduleNoRequiredinMRN";
            this.ddlScheduleNoRequiredinMRN.Size = new System.Drawing.Size(201, 21);
            this.ddlScheduleNoRequiredinMRN.TabIndex = 11;
            this.ddlScheduleNoRequiredinMRN.ValueMember = "Code";
            // 
            // ddlMakeAutoProductionEntry
            // 
            this.ddlMakeAutoProductionEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlMakeAutoProductionEntry.DisplayMember = "Value";
            this.ddlMakeAutoProductionEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMakeAutoProductionEntry.FormattingEnabled = true;
            this.ddlMakeAutoProductionEntry.Location = new System.Drawing.Point(172, 159);
            this.ddlMakeAutoProductionEntry.Name = "ddlMakeAutoProductionEntry";
            this.ddlMakeAutoProductionEntry.Size = new System.Drawing.Size(201, 21);
            this.ddlMakeAutoProductionEntry.TabIndex = 10;
            this.ddlMakeAutoProductionEntry.ValueMember = "Code";
            // 
            // ddlAutoMRN
            // 
            this.ddlAutoMRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlAutoMRN.DisplayMember = "Value";
            this.ddlAutoMRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlAutoMRN.FormattingEnabled = true;
            this.ddlAutoMRN.Location = new System.Drawing.Point(172, 78);
            this.ddlAutoMRN.Name = "ddlAutoMRN";
            this.ddlAutoMRN.Size = new System.Drawing.Size(201, 21);
            this.ddlAutoMRN.TabIndex = 7;
            this.ddlAutoMRN.ValueMember = "Code";
            // 
            // ddlShowinWorkerOrder
            // 
            this.ddlShowinWorkerOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ddlShowinWorkerOrder.DisplayMember = "Value";
            this.ddlShowinWorkerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlShowinWorkerOrder.FormattingEnabled = true;
            this.ddlShowinWorkerOrder.Location = new System.Drawing.Point(172, 131);
            this.ddlShowinWorkerOrder.Name = "ddlShowinWorkerOrder";
            this.ddlShowinWorkerOrder.Size = new System.Drawing.Size(201, 21);
            this.ddlShowinWorkerOrder.TabIndex = 9;
            this.ddlShowinWorkerOrder.ValueMember = "Code";
            // 
            // ddlPORequiredinMRN
            // 
            this.ddlPORequiredinMRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlPORequiredinMRN.DisplayMember = "Value";
            this.ddlPORequiredinMRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPORequiredinMRN.FormattingEnabled = true;
            this.ddlPORequiredinMRN.Location = new System.Drawing.Point(172, 105);
            this.ddlPORequiredinMRN.Name = "ddlPORequiredinMRN";
            this.ddlPORequiredinMRN.Size = new System.Drawing.Size(201, 21);
            this.ddlPORequiredinMRN.TabIndex = 8;
            this.ddlPORequiredinMRN.ValueMember = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Make Auto Production Entry :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "Schedule No Required in MRN :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Show in Worker Order :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Auto MRN :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "PO Required in MRN :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Automatic QC :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Auto Assemly from RGP :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(328, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(241, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ItemGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemGroupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Group Add";
            this.Load += new System.EventHandler(this.ItemGroupAdd_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private WinControlLibrary.BAllButton btnCancel;
        private WinControlLibrary.BAllButton btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        public WinControlLibrary.BTextBox txtPrefix;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public WinControlLibrary.BTextBox txtGroupName;
        public WinControlLibrary.BCombo ddlSalableItemGrp;
        public WinControlLibrary.BCombo ddlUpperGroup;
        public WinControlLibrary.BCombo ddlAutomaticQC;
        public WinControlLibrary.BCombo ddlAutoAssemlyfromRGP;
        public WinControlLibrary.BCombo ddlScheduleNoRequiredinMRN;
        public WinControlLibrary.BCombo ddlMakeAutoProductionEntry;
        public WinControlLibrary.BCombo ddlAutoMRN;
        public WinControlLibrary.BCombo ddlShowinWorkerOrder;
        public WinControlLibrary.BCombo ddlPORequiredinMRN;
    }
}