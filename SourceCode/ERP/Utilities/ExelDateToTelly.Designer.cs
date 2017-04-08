namespace ERP.Utilities
{
    partial class ExelDateToTelly
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
            this.bLabel6 = new WinControlLibrary.BLabel();
            this.txtToDate = new WinControlLibrary.BTextBox();
            this.txtFromDate = new WinControlLibrary.BTextBox();
            this.btnExport = new WinControlLibrary.BButton();
            this.btnCancel = new WinControlLibrary.BButton();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtType = new WinControlLibrary.BTextBox();
            this.txtTellPath = new WinControlLibrary.BTextBox();
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.btnBrowse = new WinControlLibrary.BButton();
            this.btnOpenError = new WinControlLibrary.BButton();
            this.btnViewUnPosedData = new WinControlLibrary.BButton();
            this.bLabel3 = new WinControlLibrary.BLabel();
            this.SuspendLayout();
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(66, 72);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(46, 13);
            this.bLabel7.TabIndex = 44;
            this.bLabel7.Text = "To Date";
            // 
            // bLabel6
            // 
            this.bLabel6.AutoSize = true;
            this.bLabel6.Location = new System.Drawing.Point(56, 46);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(56, 13);
            this.bLabel6.TabIndex = 43;
            this.bLabel6.Text = "From Date";
            // 
            // txtToDate
            // 
            this.txtToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtToDate.IsMendatory = false;
            this.txtToDate.Location = new System.Drawing.Point(134, 69);
            this.txtToDate.MaxLength = 50;
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(127, 20);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtFromDate
            // 
            this.txtFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtFromDate.IsMendatory = false;
            this.txtFromDate.Location = new System.Drawing.Point(134, 43);
            this.txtFromDate.MaxLength = 50;
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(127, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(152, 214);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 36);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export ";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(81, 100);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(31, 13);
            this.bLabel1.TabIndex = 45;
            this.bLabel1.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtType.IsMendatory = false;
            this.txtType.Location = new System.Drawing.Point(134, 100);
            this.txtType.MaxLength = 50;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(127, 20);
            this.txtType.TabIndex = 3;
            this.txtType.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtTellPath
            // 
            this.txtTellPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtTellPath.IsMendatory = false;
            this.txtTellPath.Location = new System.Drawing.Point(134, 127);
            this.txtTellPath.MaxLength = 50;
            this.txtTellPath.Name = "txtTellPath";
            this.txtTellPath.Size = new System.Drawing.Size(127, 20);
            this.txtTellPath.TabIndex = 4;
            this.txtTellPath.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(66, 127);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(49, 13);
            this.bLabel2.TabIndex = 47;
            this.bLabel2.Text = "Tell Path";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(288, 118);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 36);
            this.btnBrowse.TabIndex = 49;
            this.btnBrowse.Text = "5";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnOpenError
            // 
            this.btnOpenError.Location = new System.Drawing.Point(288, 160);
            this.btnOpenError.Name = "btnOpenError";
            this.btnOpenError.Size = new System.Drawing.Size(152, 36);
            this.btnOpenError.TabIndex = 6;
            this.btnOpenError.Text = "Open Error File";
            this.btnOpenError.UseVisualStyleBackColor = true;
            // 
            // btnViewUnPosedData
            // 
            this.btnViewUnPosedData.Location = new System.Drawing.Point(348, 214);
            this.btnViewUnPosedData.Name = "btnViewUnPosedData";
            this.btnViewUnPosedData.Size = new System.Drawing.Size(92, 36);
            this.btnViewUnPosedData.TabIndex = 9;
            this.btnViewUnPosedData.Text = "View Unposted Data";
            this.btnViewUnPosedData.UseVisualStyleBackColor = true;
            // 
            // bLabel3
            // 
            this.bLabel3.AutoSize = true;
            this.bLabel3.Location = new System.Drawing.Point(12, 261);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(85, 13);
            this.bLabel3.TabIndex = 52;
            this.bLabel3.Text = "For Telly 7.2/7.0";
            // 
            // ExelDateToTelly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 280);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.btnViewUnPosedData);
            this.Controls.Add(this.btnOpenError);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtTellPath);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCancel);
            this.Name = "ExelDateToTelly";
            this.Text = "ExelDateToTelly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BLabel bLabel6;
        private WinControlLibrary.BTextBox txtToDate;
        private WinControlLibrary.BTextBox txtFromDate;
        private WinControlLibrary.BButton btnExport;
        private WinControlLibrary.BButton btnCancel;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtType;
        private WinControlLibrary.BTextBox txtTellPath;
        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BButton btnBrowse;
        private WinControlLibrary.BButton btnOpenError;
        private WinControlLibrary.BButton btnViewUnPosedData;
        private WinControlLibrary.BLabel bLabel3;
    }
}