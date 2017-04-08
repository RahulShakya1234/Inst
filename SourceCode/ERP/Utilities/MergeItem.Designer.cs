namespace ERP.Utilities
{
    partial class MergeItem
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
            this.bLabel2 = new WinControlLibrary.BLabel();
            this.txtOldItem1 = new WinControlLibrary.BTextBox();
            this.txtNewItem = new WinControlLibrary.BTextBox();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.txtDeletedItem = new WinControlLibrary.BTextBox();
            this.bLabel7 = new WinControlLibrary.BLabel();
            this.btnClose = new WinControlLibrary.BButton();
            this.btnMerge = new WinControlLibrary.BButton();
            this.txtOldItem2 = new WinControlLibrary.BTextBox();
            this.SuspendLayout();
            // 
            // bLabel2
            // 
            this.bLabel2.AutoSize = true;
            this.bLabel2.Location = new System.Drawing.Point(17, 99);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(80, 13);
            this.bLabel2.TabIndex = 50;
            this.bLabel2.Text = "Delete Old Item";
            // 
            // txtOldItem1
            // 
            this.txtOldItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtOldItem1.IsMendatory = false;
            this.txtOldItem1.Location = new System.Drawing.Point(98, 5);
            this.txtOldItem1.MaxLength = 50;
            this.txtOldItem1.Name = "txtOldItem1";
            this.txtOldItem1.Size = new System.Drawing.Size(256, 20);
            this.txtOldItem1.TabIndex = 1;
            this.txtOldItem1.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // txtNewItem
            // 
            this.txtNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtNewItem.IsMendatory = false;
            this.txtNewItem.Location = new System.Drawing.Point(98, 64);
            this.txtNewItem.MaxLength = 50;
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(210, 20);
            this.txtNewItem.TabIndex = 3;
            this.txtNewItem.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Location = new System.Drawing.Point(21, 68);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(51, 13);
            this.bLabel1.TabIndex = 48;
            this.bLabel1.Text = "New item";
            // 
            // txtDeletedItem
            // 
            this.txtDeletedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtDeletedItem.IsMendatory = false;
            this.txtDeletedItem.Location = new System.Drawing.Point(98, 96);
            this.txtDeletedItem.MaxLength = 50;
            this.txtDeletedItem.Name = "txtDeletedItem";
            this.txtDeletedItem.Size = new System.Drawing.Size(127, 20);
            this.txtDeletedItem.TabIndex = 4;
            this.txtDeletedItem.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // bLabel7
            // 
            this.bLabel7.AutoSize = true;
            this.bLabel7.Location = new System.Drawing.Point(21, 9);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(46, 13);
            this.bLabel7.TabIndex = 46;
            this.bLabel7.Text = "Old Item";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(143, 122);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(92, 36);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.bButton2_Click);
            // 
            // txtOldItem2
            // 
            this.txtOldItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtOldItem2.IsMendatory = false;
            this.txtOldItem2.Location = new System.Drawing.Point(98, 31);
            this.txtOldItem2.MaxLength = 50;
            this.txtOldItem2.Name = "txtOldItem2";
            this.txtOldItem2.Size = new System.Drawing.Size(127, 20);
            this.txtOldItem2.TabIndex = 2;
            this.txtOldItem2.TextType = WinControlLibrary.BTextBox.TextBoxType.StringType;
            // 
            // MergeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 165);
            this.Controls.Add(this.txtOldItem2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.txtDeletedItem);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.txtNewItem);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.txtOldItem1);
            this.Name = "MergeItem";
            this.Text = "MergeItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControlLibrary.BLabel bLabel2;
        private WinControlLibrary.BTextBox txtOldItem1;
        private WinControlLibrary.BTextBox txtNewItem;
        private WinControlLibrary.BLabel bLabel1;
        private WinControlLibrary.BTextBox txtDeletedItem;
        private WinControlLibrary.BLabel bLabel7;
        private WinControlLibrary.BButton btnClose;
        private WinControlLibrary.BButton btnMerge;
        private WinControlLibrary.BTextBox txtOldItem2;
    }
}