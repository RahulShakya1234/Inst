namespace ERP.SalePurchase
{
    partial class VoucherSeriesSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoucherSeriesSetup));
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.bTextBox1 = new WinControlLibrary.BTextBox();
            this.bGrid1 = new WinControlLibrary.BGrid();
            this.Voucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAllButton1 = new WinControlLibrary.BAllButton();
            this.bAllButton2 = new WinControlLibrary.BAllButton();
            this.bAllButton3 = new WinControlLibrary.BAllButton();
            this.bAllButton4 = new WinControlLibrary.BAllButton();
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(37, 27);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(47, 13);
            this.bLabel1.TabIndex = 0;
            this.bLabel1.Text = "Search :";
            // 
            // bTextBox1
            // 
            this.bTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.bTextBox1.IsMendatory = false;
            this.bTextBox1.Location = new System.Drawing.Point(105, 24);
            this.bTextBox1.MaxLength = 50;
            this.bTextBox1.Name = "bTextBox1";
            this.bTextBox1.Size = new System.Drawing.Size(230, 20);
            this.bTextBox1.TabIndex = 0;
            this.bTextBox1.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bGrid1
            // 
            this.bGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.bGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Voucher,
            this.Series});
            this.bGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bGrid1.Index = 0;
            this.bGrid1.Location = new System.Drawing.Point(12, 50);
            this.bGrid1.Name = "bGrid1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bGrid1.Size = new System.Drawing.Size(571, 325);
            this.bGrid1.TabIndex = 1;
            // 
            // Voucher
            // 
            this.Voucher.HeaderText = "Voucher";
            this.Voucher.Name = "Voucher";
            this.Voucher.Width = 150;
            // 
            // Series
            // 
            this.Series.HeaderText = "Series";
            this.Series.Name = "Series";
            this.Series.Width = 150;
            // 
            // bAllButton1
            // 
            this.bAllButton1.BackColor = System.Drawing.Color.Transparent;
            this.bAllButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAllButton1.BackgroundImage")));
            this.bAllButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAllButton1.FlatAppearance.BorderSize = 0;
            this.bAllButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bAllButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bAllButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAllButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAllButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAllButton1.Location = new System.Drawing.Point(199, 387);
            this.bAllButton1.Name = "bAllButton1";
            this.bAllButton1.Size = new System.Drawing.Size(76, 24);
            this.bAllButton1.TabIndex = 2;
            this.bAllButton1.Text = "&Add";
            this.bAllButton1.UseVisualStyleBackColor = false;
            // 
            // bAllButton2
            // 
            this.bAllButton2.BackColor = System.Drawing.Color.Transparent;
            this.bAllButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAllButton2.BackgroundImage")));
            this.bAllButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAllButton2.FlatAppearance.BorderSize = 0;
            this.bAllButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bAllButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bAllButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAllButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAllButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAllButton2.Location = new System.Drawing.Point(292, 387);
            this.bAllButton2.Name = "bAllButton2";
            this.bAllButton2.Size = new System.Drawing.Size(76, 24);
            this.bAllButton2.TabIndex = 3;
            this.bAllButton2.Text = "&Edit";
            this.bAllButton2.UseVisualStyleBackColor = false;
            // 
            // bAllButton3
            // 
            this.bAllButton3.BackColor = System.Drawing.Color.Transparent;
            this.bAllButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAllButton3.BackgroundImage")));
            this.bAllButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAllButton3.FlatAppearance.BorderSize = 0;
            this.bAllButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bAllButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bAllButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAllButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAllButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAllButton3.Location = new System.Drawing.Point(383, 387);
            this.bAllButton3.Name = "bAllButton3";
            this.bAllButton3.Size = new System.Drawing.Size(76, 24);
            this.bAllButton3.TabIndex = 4;
            this.bAllButton3.Text = "&Delete";
            this.bAllButton3.UseVisualStyleBackColor = false;
            // 
            // bAllButton4
            // 
            this.bAllButton4.BackColor = System.Drawing.Color.Transparent;
            this.bAllButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAllButton4.BackgroundImage")));
            this.bAllButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAllButton4.FlatAppearance.BorderSize = 0;
            this.bAllButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bAllButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bAllButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAllButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAllButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAllButton4.Location = new System.Drawing.Point(476, 387);
            this.bAllButton4.Name = "bAllButton4";
            this.bAllButton4.Size = new System.Drawing.Size(76, 24);
            this.bAllButton4.TabIndex = 5;
            this.bAllButton4.Text = "&Exit";
            this.bAllButton4.UseVisualStyleBackColor = false;
            // 
            // VoucherSeriesSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 423);
            this.Controls.Add(this.bAllButton4);
            this.Controls.Add(this.bAllButton3);
            this.Controls.Add(this.bAllButton2);
            this.Controls.Add(this.bAllButton1);
            this.Controls.Add(this.bGrid1);
            this.Controls.Add(this.bTextBox1);
            this.Controls.Add(this.bLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoucherSeriesSetup";
            this.Text = "VoucherSeriesSetup";
            this.Load += new System.EventHandler(this.VoucherSeriesSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox bTextBox1;
        private WinControlLibrary.BGrid bGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private WinControlLibrary.BAllButton bAllButton1;
        private WinControlLibrary.BAllButton bAllButton2;
        private WinControlLibrary.BAllButton bAllButton3;
        private WinControlLibrary.BAllButton bAllButton4;
    }
}