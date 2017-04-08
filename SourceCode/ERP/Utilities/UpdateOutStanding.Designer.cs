namespace ERP.Utilities
{
    partial class UpdateOutStanding
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
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.txtSearchAcc = new WinControlLibrary.BTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.btnoK = new WinControlLibrary.BButton();
            this.btnCancel = new WinControlLibrary.BButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(29, 18);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(89, 13);
            this.bLabel7.TabIndex = 78;
            this.bLabel7.Text = "Search Accounts";
            // 
            // txtSearchAcc
            // 
            this.txtSearchAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtSearchAcc.IsMendatory = false;
            this.txtSearchAcc.Location = new System.Drawing.Point(136, 15);
            this.txtSearchAcc.MaxLength = 50;
            this.txtSearchAcc.Name = "txtSearchAcc";
            this.txtSearchAcc.Size = new System.Drawing.Size(167, 20);
            this.txtSearchAcc.TabIndex = 1;
            this.txtSearchAcc.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bLabel1);
            this.panel1.Location = new System.Drawing.Point(60, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 79;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(27, 14);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(104, 13);
            this.bLabel1.TabIndex = 79;
            this.bLabel1.Text = "Update OutStanding";
            this.bLabel1.Click += new System.EventHandler(this.bLabel1_Click);
            // 
            // btnoK
            // 
            this.btnoK.Location = new System.Drawing.Point(60, 199);
            this.btnoK.Name = "btnoK";
            this.btnoK.Size = new System.Drawing.Size(75, 23);
            this.btnoK.TabIndex = 2;
            this.btnoK.Text = "OK";
            this.btnoK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(141, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // UpdateOutStanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnoK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.txtSearchAcc);
            this.Name = "UpdateOutStanding";
            this.Text = "UPDateOutStanding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BTextBox txtSearchAcc;
        private System.Windows.Forms.Panel panel1;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BButton btnoK;
        private WinControlLibrary.BButton btnCancel;

    }
}