using System;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Collections.Generic;
using Common;
using ERP;
using ERP.PurelifeErpClient;
using System.Drawing;

namespace ERP.SalePurchase
{

    public partial class AccountGroupView : Global.BaseClass
    {

        DataTable dtList = null;
        int SelectedRow = 0;

        public AccountGroupView()
        {
            InitializeComponent();
        }

        private static AccountGroupView sForm = null;

        public static AccountGroupView Instance()
        {
            if (sForm == null) { sForm = new AccountGroupView(); }

            return sForm;
           
        }

        public void BindDropDown()
        {
            //fill the account group combo
           
            FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup,"All");
        }


        private void AccountGroupView_Load(object sender, EventArgs e)
        {
            BindDropDown();
            SetButtons();
          // BindData();
            grdAccountGroupDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            // grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
            grdAccountGroupDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            //this.BackColor = Color.FromArgb(240, 248, 255);
            
        }

        private void SetButtons()
        {
            btnAdd.SetBackGroundImage();
            btnEdit.SetBackGroundImage();
            btnDelete.SetBackGroundImage();
            btnExit.SetBackGroundImage();
            btnFind.SetBackGroundImage();
        }

        public void BindData()
        {

            BindDropDown();
            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {

                    BindingSource bs = new BindingSource();
                     grdAccountGroupDetails.DataSource  = clientObj.DataListing(PurelifeErpClient.PageName.AccountGroup);
                     bs.DataSource = grdAccountGroupDetails.DataSource;
                     if (grdAccountGroupDetails.DataSource == null) return;
                     if (txtSearch.Text != null)
                     {
                         bs.Filter = string.Format("AccountGroupName LIKE '%{0}%'", txtSearch.Text);
                     }

                     if (ddlPrimaryGroup.SelectedValue.ToInt() > 0)
                     {
                         bs.Filter = string.Format("AccountGroupMasId= {0}", ddlPrimaryGroup.SelectedValue);
                         //bs.Filter = string.Format("AccountGroupMasId", ddlGroupName.SelectedValue);
                     }
                     if (ddlPrimaryGroup.SelectedValue.ToString() == "0")
                     {
                         grdAccountGroupDetails.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.AccountGroup);
                         bs.DataSource = grdAccountGroupDetails.DataSource;
                     }
                    new DgvFilterManager(grdAccountGroupDetails);


                    //clientObj.Close();ddlPrimaryGroup
                }
            }
            //dt.Columns.Add("date", typeof(string), tbdate.Text);
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            new AccountGroupAdd(this, 0).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
            SelectedRow = grdAccountGroupDetails.CurrentRow.Index;
            int codeValue = grdAccountGroupDetails.Rows[SelectedRow].Cells["AccountGroupMasId"].Value.ToInt();
            EditMaster(SelectedRow, codeValue);
        }

        #region Edit Master

        /// <summary>
        /// Edit Master
        /// </summary>
        /// <param name="rowIndex"></param>
        private void EditMaster(int rowIndex, int codeValue)
        {
            try
            {
                
                AccountGroupAdd addForm = new AccountGroupAdd(this, codeValue);

                //if (addForm.ddlPrimaryGroup.SelectedValue.ToInt() > 0)
                //{
                //    addForm.ddlPrimaryGroup.Enabled = false;

                //}

                addForm.ddlPrimaryGroup.Enabled = false;
                addForm.txtGrpName.Text = grdAccountGroupDetails.Rows[rowIndex].Cells["AccountGroupName"].Value.ToString();
                addForm.ddlPrimaryGroup.SelectedValue = grdAccountGroupDetails.Rows[rowIndex].Cells["PrimaryAccountGroup"].Value.ToString();
                addForm.ddlType.SelectedValue = grdAccountGroupDetails.Rows[rowIndex].Cells["Type"].Value.ToString();
                addForm.txtReferenceNumber.Text = Convert.ToString(grdAccountGroupDetails.Rows[rowIndex].Cells["RefrenceNo"].Value.ToInt());
                addForm.ddlBType.SelectedValue = grdAccountGroupDetails.Rows[rowIndex].Cells["BType"].Value.ToString();
                addForm.ddlPrintSummaryTrialBal.SelectedValue = grdAccountGroupDetails.Rows[rowIndex].Cells["PrintSummaryBalType"].Value.ToString();
                addForm.ShowDialog();
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                SelectedRow = grdAccountGroupDetails.CurrentRow.Index;
                int id = GetInt(grdAccountGroupDetails.Rows[SelectedRow].Cells["AccountGroupMasId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.AccountGroup, id);
                    purelifeErpClient.Close();
                }
                if (id > 0)
                {


                    var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                       "Confirm Delete!!",
                       MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Successfully Deleted");
                        // this.Close();
                    }

                    else
                    {
                        return;
                    }
                }


                BindData();
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }


      
        #endregion


        private void btnFind_Click(object sender, EventArgs e)
         {
             //if (txtSearch.Text != null)
                BindData();
                 //this.BackgroundImage = Image.FromFile("I:\\Working Project\\ERP-Code\\SourceCode\\ERP\\Resources\\btn1.png");
               
         }

        private void grdAccountGroupDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdAccountGroupDetails_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void grdAccountGroupDetails_MouseMove(object sender, MouseEventArgs e)
        {
           
         
        

        }

        private void grdAccountGroupDetails_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void grdAccountGroupDetails_MouseLeave(object sender, EventArgs e)
        {


        }

        private void grdAccountGroupDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
          

        }

       

        private void grdAccountGroupDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (grdAccountGroupDetails[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    if (grdAccountGroupDetails[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.SkyBlue)
                    {

                    }
                    else
                    {
                        this.grdAccountGroupDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(211, 211, 211);
                    }
                }
            }
        }

        private void grdAccountGroupDetails_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (grdAccountGroupDetails[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    if (grdAccountGroupDetails[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.SkyBlue)
                    {

                    }
                    else
                    {
                        this.grdAccountGroupDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                    }
                }
            }

        }
        //int lastindex = -1;
        private void grdAccountGroupDetails_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdAccountGroupDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

        private void grdAccountGroupDetails_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdAccountGroupDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void grdAccountGroupDetails_MouseEnter_1(object sender, EventArgs e)
        {
            grdAccountGroupDetails.DefaultCellStyle.SelectionBackColor = Color.Silver;

        }

        private void groupBox1_Paint(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
            DrawGroupBox(box, p.Graphics, Color.Red, Color.Black);
            ControlPaint.DrawBorder(p.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                //Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 2,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                // g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                // g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                // g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }





    }
}
