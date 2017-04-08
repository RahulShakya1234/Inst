namespace ERP.Utilities
{
    partial class DataChecking
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
            this.grdDataChecking = new WinControlLibrary.BGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new WinControlLibrary.BButton();
            this.btnClse = new WinControlLibrary.BButton();
            this.btnVoucherAccCodeNotInAccMas = new WinControlLibrary.BButton();
            this.btnAccCode = new WinControlLibrary.BButton();
            this.btnDuplicateEntries = new WinControlLibrary.BButton();
            this.btnAccGrpnOtInGRPMas = new WinControlLibrary.BButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataChecking)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDataChecking
            // 
            this.grdDataChecking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.grdDataChecking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataChecking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.grdDataChecking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.grdDataChecking.Index = 0;
            this.grdDataChecking.Location = new System.Drawing.Point(21, 12);
            this.grdDataChecking.Name = "grdDataChecking";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDataChecking.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDataChecking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDataChecking.Size = new System.Drawing.Size(443, 150);
            this.grdDataChecking.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wrong Entries";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClse
            // 
            this.btnClse.Location = new System.Drawing.Point(438, 251);
            this.btnClse.Name = "btnClse";
            this.btnClse.Size = new System.Drawing.Size(75, 23);
            this.btnClse.TabIndex = 8;
            this.btnClse.Text = "Close";
            this.btnClse.UseVisualStyleBackColor = true;
            // 
            // btnVoucherAccCodeNotInAccMas
            // 
            this.btnVoucherAccCodeNotInAccMas.Location = new System.Drawing.Point(277, 203);
            this.btnVoucherAccCodeNotInAccMas.Name = "btnVoucherAccCodeNotInAccMas";
            this.btnVoucherAccCodeNotInAccMas.Size = new System.Drawing.Size(109, 42);
            this.btnVoucherAccCodeNotInAccMas.TabIndex = 5;
            this.btnVoucherAccCodeNotInAccMas.Text = "Vouchsup Acccode Not In  Accmas";
            this.btnVoucherAccCodeNotInAccMas.UseVisualStyleBackColor = true;
            // 
            // btnAccCode
            // 
            this.btnAccCode.Location = new System.Drawing.Point(174, 203);
            this.btnAccCode.Name = "btnAccCode";
            this.btnAccCode.Size = new System.Drawing.Size(97, 42);
            this.btnAccCode.TabIndex = 4;
            this.btnAccCode.Text = "Account Code=0";
            this.btnAccCode.UseVisualStyleBackColor = true;
            // 
            // btnDuplicateEntries
            // 
            this.btnDuplicateEntries.Location = new System.Drawing.Point(93, 203);
            this.btnDuplicateEntries.Name = "btnDuplicateEntries";
            this.btnDuplicateEntries.Size = new System.Drawing.Size(75, 42);
            this.btnDuplicateEntries.TabIndex = 2;
            this.btnDuplicateEntries.Text = "Duplicate Entries";
            this.btnDuplicateEntries.UseVisualStyleBackColor = true;
            // 
            // btnAccGrpnOtInGRPMas
            // 
            this.btnAccGrpnOtInGRPMas.Location = new System.Drawing.Point(389, 203);
            this.btnAccGrpnOtInGRPMas.Name = "btnAccGrpnOtInGRPMas";
            this.btnAccGrpnOtInGRPMas.Size = new System.Drawing.Size(109, 42);
            this.btnAccGrpnOtInGRPMas.TabIndex = 6;
            this.btnAccGrpnOtInGRPMas.Text = "Account Group Not in  GRP Mas";
            this.btnAccGrpnOtInGRPMas.UseVisualStyleBackColor = true;
            // 
            // DataChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 280);
            this.Controls.Add(this.btnAccGrpnOtInGRPMas);
            this.Controls.Add(this.btnDuplicateEntries);
            this.Controls.Add(this.btnAccCode);
            this.Controls.Add(this.btnVoucherAccCodeNotInAccMas);
            this.Controls.Add(this.btnClse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdDataChecking);
            this.Name = "DataChecking";
            this.Text = "DataChecking";
            ((System.ComponentModel.ISupportInitialize)(this.grdDataChecking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControlLibrary.BGrid grdDataChecking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private WinControlLibrary.BButton button1;
        private WinControlLibrary.BButton btnClse;
        private WinControlLibrary.BButton btnVoucherAccCodeNotInAccMas;
        private WinControlLibrary.BButton btnAccCode;
        private WinControlLibrary.BButton btnDuplicateEntries;
        private WinControlLibrary.BButton btnAccGrpnOtInGRPMas;
    }
}