using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Linq;

using Common;
using ERP;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System;

namespace ERP.Masters
{
    public partial class UserView : Global.BaseClass
    {
        int SelectedRow = 0;
        public UserView()
        {
            InitializeComponent();
        }
        private static UserView sForm = null;
        public static UserView Instance()
        {

            if (sForm == null) { sForm = new UserView(); }
            return sForm;
        }

        public void BindData()
        {

            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    BindingSource bs = new BindingSource();
                    grdUserView.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.UserDetails);
                    bs.DataSource = grdUserView.DataSource;
                    
                    if (grdUserView.DataSource == null) return;
                    if (txtUserName != null)
                    {
                        bs.Filter = string.Format("UserName LIKE '%{0}%'", txtUserName.Text);
                    }

                    new DgvFilterManager(grdUserView);
                }
            }
            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
                throw exception;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new User(this, 0).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdUserView.CurrentRow.Index;
                int codeValue = grdUserView.Rows[SelectedRow].Cells["UserCode"].Value.ToInt();
                EditMaster(SelectedRow, codeValue);
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message);
            }
        }


        private void EditMaster(int rowIndex, int codeValue)
        {
            try
            {


                User addForm = new User(this, codeValue);

                addForm.txtUserName.Text = grdUserView.Rows[rowIndex].Cells["UserName"].Value.ToString();
                addForm.txtPassword.Text = grdUserView.Rows[rowIndex].Cells["Password"].Value.ToString();
                addForm.ddlGender.SelectedValue = grdUserView.Rows[rowIndex].Cells["Gender"].Value.ToString();
                addForm.txtDOB.Text = grdUserView.Rows[rowIndex].Cells["DOB"].Value.ToString();
                addForm.txtDOJ.Text = grdUserView.Rows[rowIndex].Cells["DOJ"].Value.ToString();
                addForm.txtDOL.Text = grdUserView.Rows[rowIndex].Cells["DOL"].Value.ToString();
                addForm.ddlDept.SelectedValue = grdUserView.Rows[rowIndex].Cells["Department"].Value.ToString();
                addForm.ddlLocation.SelectedValue = grdUserView.Rows[rowIndex].Cells["Location"].Value.ToString();
                addForm.ddlDesig.SelectedValue = grdUserView.Rows[rowIndex].Cells["Designation"].Value.ToString();
                addForm.ddlSoftwareRole.SelectedValue = grdUserView.Rows[rowIndex].Cells["SoftwareRole"].Value.ToString();

                addForm.ShowDialog();
            }
            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
                throw exception;
            }
        }
            
                //  addForm.ddlDrCr.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["BalanceTypeName"].Value.ToString(
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdUserView.CurrentRow.Index;
                int id = GetInt(grdUserView.Rows[SelectedRow].Cells["UserCode"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.UserDetails, id);
                    //purelifeErpClient.Close();
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
                throw exception;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void grdUserView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdUserView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            } 
        }

        private void grdUserView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdUserView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            grdUserView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
        }

        private void grdUserView_MouseEnter(object sender, EventArgs e)
        {
            grdUserView.DefaultCellStyle.SelectionBackColor = Color.Silver;
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
