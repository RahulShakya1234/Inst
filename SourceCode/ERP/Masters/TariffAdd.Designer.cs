namespace ERP.SalePurchase
{
    partial class TariffAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariffAdd));
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.bLabel4 = new WinControlLibrary.BLabel();
            this.txtRTCode = new WinControlLibrary.BTextBox();
            this.txtHeading = new WinControlLibrary.BTextBox();
            this.txtTariff = new WinControlLibrary.BTextBox();
            this.txtUnit = new WinControlLibrary.BTextBox();
            this.bLabel5 = new WinControlLibrary.BLabel();
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.btnCancel = new WinControlLibrary.BAllButton();
            this.ddlPrint = new WinControlLibrary.BCombo();
            this.ddlShowInER1 = new WinControlLibrary.BCombo();
            this.SuspendLayout();
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(39, 28);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(56, 13);
            this.bLabel1.TabIndex = 0;
            this.bLabel1.Text = "RT Code :";
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(42, 53);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(53, 13);
            this.bLabel2.TabIndex = 1;
            this.bLabel2.Text = "Heading :";
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(58, 77);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(37, 13);
            this.bLabel3.TabIndex = 2;
            this.bLabel3.Text = "Tariff :";
            // 
            // bLabel4
            // 
            this.bLabel4.AutoSize = true;
            this.bLabel4.Location = new System.Drawing.Point(63, 103);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(32, 13);
            this.bLabel4.TabIndex = 3;
            this.bLabel4.Text = "Unit :";
            // 
            // txtRTCode
            // 
            this.txtRTCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtRTCode.IsMendatory = false;
            this.txtRTCode.Location = new System.Drawing.Point(101, 25);
            this.txtRTCode.MaxLength = 50;
            this.txtRTCode.Name = "txtRTCode";
            this.txtRTCode.Size = new System.Drawing.Size(100, 20);
            this.txtRTCode.TabIndex = 0;
            this.txtRTCode.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtHeading.IsMendatory = false;
            this.txtHeading.Location = new System.Drawing.Point(101, 50);
            this.txtHeading.MaxLength = 50;
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(224, 20);
            this.txtHeading.TabIndex = 1;
            this.txtHeading.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtTariff
            // 
            this.txtTariff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTariff.IsMendatory = false;
            this.txtTariff.Location = new System.Drawing.Point(101, 74);
            this.txtTariff.MaxLength = 50;
            this.txtTariff.Name = "txtTariff";
            this.txtTariff.Size = new System.Drawing.Size(100, 20);
            this.txtTariff.TabIndex = 2;
            this.txtTariff.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtUnit.IsMendatory = false;
            this.txtUnit.Location = new System.Drawing.Point(101, 100);
            this.txtUnit.MaxLength = 50;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 3;
            this.txtUnit.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel5
            // 
            this.bLabel5.AutoSize = true;
            this.bLabel5.Location = new System.Drawing.Point(61, 133);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(34, 13);
            this.bLabel5.TabIndex = 8;
            this.bLabel5.Text = "Print :";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(12, 171);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(179, 13);
            this.bLabel6.TabIndex = 10;
            this.bLabel6.Text = "Show Opening and Mfg Qty in ER1 :";
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
            this.btnSave.Location = new System.Drawing.Point(140, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(230, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ddlPrint
            // 
            this.ddlPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlPrint.DisplayMember = "Value";
            this.ddlPrint.FormattingEnabled = true;
            this.ddlPrint.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ddlPrint.Location = new System.Drawing.Point(101, 130);
            this.ddlPrint.Name = "ddlPrint";
            this.ddlPrint.Size = new System.Drawing.Size(100, 21);
            this.ddlPrint.TabIndex = 11;
            this.ddlPrint.ValueMember = "Code";
            // 
            // ddlShowInER1
            // 
            this.ddlShowInER1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ddlShowInER1.DisplayMember = "Value";
            this.ddlShowInER1.FormattingEnabled = true;
            this.ddlShowInER1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ddlShowInER1.Location = new System.Drawing.Point(206, 163);
            this.ddlShowInER1.Name = "ddlShowInER1";
            this.ddlShowInER1.Size = new System.Drawing.Size(100, 21);
            this.ddlShowInER1.TabIndex = 12;
            this.ddlShowInER1.ValueMember = "Code";
            // 
            // TariffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 270);
            this.Controls.Add(this.ddlShowInER1);
            this.Controls.Add(this.ddlPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtTariff);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.txtRTCode);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.bLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TariffAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TariffAdd";
            this.Load += new System.EventHandler(this.PageLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BLabel bLabel3;
        private WinControlLibrary.BLabel bLabel4;
        private WinControlLibrary.BTextBox txtRTCode;
        private WinControlLibrary.BTextBox txtHeading;
        private WinControlLibrary.BTextBox txtTariff;
        private WinControlLibrary.BTextBox txtUnit;
        private WinControlLibrary.BLabel bLabel5;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BAllButton btnSave;
        private WinControlLibrary.BAllButton btnCancel;
        private WinControlLibrary.BCombo ddlPrint;
        private WinControlLibrary.BCombo ddlShowInER1;
    }
}