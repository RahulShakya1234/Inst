namespace ERP.SalePurchase
{
    partial class SalePurchaseRegisterSetUpAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalePurchaseRegisterSetUpAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.grdSalePurchaseReg = new WinControlLibrary.BGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adsolute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegisterName = new WinControlLibrary.BTextBox();
            this.txtVoucherType = new WinControlLibrary.BTextBox();
            this.btnSave = new WinControlLibrary.BAllButton();
            this.btnClose = new WinControlLibrary.BAllButton();
            this.txtHeading1 = new WinControlLibrary.BTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeading2 = new WinControlLibrary.BTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeading3 = new WinControlLibrary.BTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalePurchaseReg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register Name";
            // 
            // grdSalePurchaseReg
            // 
            this.grdSalePurchaseReg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdSalePurchaseReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalePurchaseReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Type,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.column7,
            this.Format,
            this.Adsolute});
            this.grdSalePurchaseReg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdSalePurchaseReg.Index = 0;
            this.grdSalePurchaseReg.Location = new System.Drawing.Point(12, 87);
            this.grdSalePurchaseReg.Name = "grdSalePurchaseReg";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSalePurchaseReg.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSalePurchaseReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSalePurchaseReg.Size = new System.Drawing.Size(826, 150);
            this.grdSalePurchaseReg.TabIndex = 3;
            this.grdSalePurchaseReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bGrid1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "C.No.";
            this.Column1.Name = "Column1";
            // 
            // Type
            // 
            this.Type.HeaderText = "Column2";
            this.Type.Name = "Type";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Account/Fields";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Width";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Alignment";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Heading";
            this.Column6.Name = "Column6";
            // 
            // column7
            // 
            this.column7.HeaderText = "Total(Y/N)";
            this.column7.Name = "column7";
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Name = "Format";
            // 
            // Adsolute
            // 
            this.Adsolute.HeaderText = "Adsolute(Y/N)";
            this.Adsolute.Name = "Adsolute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Voucher Type";
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtRegisterName.IsMendatory = false;
            this.txtRegisterName.Location = new System.Drawing.Point(169, 35);
            this.txtRegisterName.MaxLength = 50;
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(161, 20);
            this.txtRegisterName.TabIndex = 0;
            this.txtRegisterName.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtVoucherType
            // 
            this.txtVoucherType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtVoucherType.IsMendatory = false;
            this.txtVoucherType.Location = new System.Drawing.Point(496, 31);
            this.txtVoucherType.MaxLength = 50;
            this.txtVoucherType.Name = "txtVoucherType";
            this.txtVoucherType.Size = new System.Drawing.Size(161, 20);
            this.txtVoucherType.TabIndex = 2;
            this.txtVoucherType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(571, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(652, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtHeading1
            // 
            this.txtHeading1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtHeading1.IsMendatory = false;
            this.txtHeading1.Location = new System.Drawing.Point(141, 313);
            this.txtHeading1.MaxLength = 50;
            this.txtHeading1.Name = "txtHeading1";
            this.txtHeading1.Size = new System.Drawing.Size(161, 20);
            this.txtHeading1.TabIndex = 6;
            this.txtHeading1.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Heading1";
            // 
            // txtHeading2
            // 
            this.txtHeading2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtHeading2.IsMendatory = false;
            this.txtHeading2.Location = new System.Drawing.Point(141, 344);
            this.txtHeading2.MaxLength = 50;
            this.txtHeading2.Name = "txtHeading2";
            this.txtHeading2.Size = new System.Drawing.Size(161, 20);
            this.txtHeading2.TabIndex = 7;
            this.txtHeading2.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Heading 2";
            // 
            // txtHeading3
            // 
            this.txtHeading3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtHeading3.IsMendatory = false;
            this.txtHeading3.Location = new System.Drawing.Point(141, 378);
            this.txtHeading3.MaxLength = 50;
            this.txtHeading3.Name = "txtHeading3";
            this.txtHeading3.Size = new System.Drawing.Size(161, 20);
            this.txtHeading3.TabIndex = 8;
            this.txtHeading3.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Heading 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(55, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(55, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // SalePurchaseRegisterSetUpAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 440);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHeading3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHeading2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeading1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVoucherType);
            this.Controls.Add(this.txtRegisterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdSalePurchaseReg);
            this.Controls.Add(this.label1);
            this.Name = "SalePurchaseRegisterSetUpAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalePurchaseRegisterSetUpAdd";
            this.Load += new System.EventHandler(this.SalePurchaseRegisterSetUpAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalePurchaseReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WinControlLibrary.BGrid grdSalePurchaseReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adsolute;
        private System.Windows.Forms.Label label2;
        private WinControlLibrary.BTextBox txtRegisterName;
        private WinControlLibrary.BTextBox txtVoucherType;
        private WinControlLibrary.BTextBox txtHeading1;
        private System.Windows.Forms.Label label3;
        private WinControlLibrary.BTextBox txtHeading2;
        private System.Windows.Forms.Label label4;
        private WinControlLibrary.BTextBox txtHeading3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private WinControlLibrary.BAllButton btnSave;
        private WinControlLibrary.BAllButton btnClose;
    }
}