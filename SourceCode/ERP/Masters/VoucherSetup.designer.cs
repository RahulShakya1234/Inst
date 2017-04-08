namespace ERP.SalePurchase
{
    partial class voucherSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(voucherSetup));
            this.grdAccountDetails = new WinControlLibrary.BGrid();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReNum = new WinControlLibrary.BAllButton();
            this.btnEdit = new WinControlLibrary.BAllButton();
            this.btnExit = new WinControlLibrary.BAllButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccountDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAccountDetails
            // 
            this.grdAccountDetails.AllowUserToAddRows = false;
            this.grdAccountDetails.AllowUserToDeleteRows = false;
            this.grdAccountDetails.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            this.grdAccountDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAccountDetails.BackgroundColor = System.Drawing.Color.Ivory;
            this.grdAccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccountDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.Type,
            this.RefNo,
            this.GroupType});
            this.grdAccountDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdAccountDetails.Index = 0;
            this.grdAccountDetails.Location = new System.Drawing.Point(32, 31);
            this.grdAccountDetails.Name = "grdAccountDetails";
            this.grdAccountDetails.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccountDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAccountDetails.RowHeadersWidth = 30;
            this.grdAccountDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccountDetails.Size = new System.Drawing.Size(583, 301);
            this.grdAccountDetails.TabIndex = 0;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Voucher Code";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Voucher Name";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 250;
            // 
            // RefNo
            // 
            this.RefNo.HeaderText = "Series";
            this.RefNo.Name = "RefNo";
            this.RefNo.ReadOnly = true;
            // 
            // GroupType
            // 
            this.GroupType.HeaderText = "Voucher Print";
            this.GroupType.Name = "GroupType";
            this.GroupType.ReadOnly = true;
            // 
            // btnReNum
            // 
            this.btnReNum.BackColor = System.Drawing.Color.Transparent;
            this.btnReNum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReNum.BackgroundImage")));
            this.btnReNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReNum.Location = new System.Drawing.Point(32, 374);
            this.btnReNum.Margin = new System.Windows.Forms.Padding(0);
            this.btnReNum.Name = "btnReNum";
            this.btnReNum.Size = new System.Drawing.Size(75, 25);
            this.btnReNum.TabIndex = 3;
            this.btnReNum.Text = "Re Number";
            this.btnReNum.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(423, 378);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(505, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // voucherSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 467);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grdAccountDetails);
            this.Controls.Add(this.btnReNum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "voucherSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoucherSetup";
            ((System.ComponentModel.ISupportInitialize)(this.grdAccountDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public WinControlLibrary.BGrid grdAccountDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupType;
        private WinControlLibrary.BAllButton btnReNum;
        private WinControlLibrary.BAllButton btnEdit;
        private WinControlLibrary.BAllButton btnExit;
    }
}