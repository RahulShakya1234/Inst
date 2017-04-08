namespace ERP
{
    partial class ExitForm
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
            this.btnDoNothing = new System.Windows.Forms.Button();
            this.btnChangeCompany = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bLabel1 = new WinControlLibrary.BLabel();
            this.SuspendLayout();
            // 
            // btnDoNothing
            // 
            this.btnDoNothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoNothing.Location = new System.Drawing.Point(132, 52);
            this.btnDoNothing.Name = "btnDoNothing";
            this.btnDoNothing.Size = new System.Drawing.Size(99, 31);
            this.btnDoNothing.TabIndex = 1;
            this.btnDoNothing.Text = "&Cancel";
            this.btnDoNothing.UseVisualStyleBackColor = true;
            this.btnDoNothing.Click += new System.EventHandler(this.btnDoNothing_Click);
            // 
            // btnChangeCompany
            // 
            this.btnChangeCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCompany.Location = new System.Drawing.Point(237, 52);
            this.btnChangeCompany.Name = "btnChangeCompany";
            this.btnChangeCompany.Size = new System.Drawing.Size(99, 31);
            this.btnChangeCompany.TabIndex = 2;
            this.btnChangeCompany.Text = "&Logoff";
            this.btnChangeCompany.UseVisualStyleBackColor = true;
            this.btnChangeCompany.Click += new System.EventHandler(this.btnChangeCompany_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(27, 52);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bLabel1
            // 
            this.bLabel1.AutoSize = true;
            this.bLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bLabel1.Location = new System.Drawing.Point(136, 24);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(95, 13);
            this.bLabel1.TabIndex = 8;
            this.bLabel1.Text = "What To Do...?";
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 106);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeCompany);
            this.Controls.Add(this.btnDoNothing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit?";
            this.Load += new System.EventHandler(this.ExitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoNothing;
        private System.Windows.Forms.Button btnChangeCompany;
        private System.Windows.Forms.Button btnExit;
        private WinControlLibrary.BLabel bLabel1;

    }
}