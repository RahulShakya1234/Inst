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
    public partial class IssueMasterView : Global.BaseClass
    {
        int SelectedRow = 0;
        public IssueMasterView()
        {
            InitializeComponent();
        }

        private static IssueMasterView sForm = null;
        public static IssueMasterView Instance()
        {

            if (sForm == null) { sForm = new IssueMasterView(); }
            return sForm;
        }
        public void BindData()
        {

            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    BindingSource bs = new BindingSource();
                    grdIssuemaster.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.MSTIssueMaster);
                    grdIssueDetails.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.DETIssueMaster);

                    bs.DataSource = grdIssuemaster.DataSource;
                    bs.DataSource = grdIssueDetails.DataSource;

                    if (grdIssuemaster.DataSource == null) return;
                    if (grdIssueDetails.DataSource == null) return;
                    if (txtUserName != null)
                    {
                        bs.Filter = string.Format("OrderNo LIKE '%{0}%'", txtUserName.Text);
                    }

                    new DgvFilterManager(grdIssuemaster);
                    new DgvFilterManager(grdIssueDetails);
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
            new IssueMaster(this, 0).ShowDialog();

        }

        #region  Edit
        private void CopyAll(DataGridView from, DataGridView to)
        {
            if (to.Columns.Count == 0)
            {
                foreach (DataGridViewColumn dgvc in from.Columns)
                {
                    to.Columns.Add(dgvc.Name, dgvc.HeaderText);
                }
            }

            to.Rows.Clear();

            foreach (DataGridViewRow dgvr in from.Rows)
            {
                List<string> cells = new List<string>();

                foreach (DataGridViewCell dgvc in dgvr.Cells)
                {
                    cells.Add(dgvc.Value.ToString());
                }

                to.Rows.Add(cells.ToArray());
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdIssuemaster.CurrentRow.Index;
                int codeValue = grdIssuemaster.Rows[SelectedRow].Cells["OrderId"].Value.ToInt();
                EditMaster(SelectedRow, codeValue);
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
                //MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Edit Master
        /// </summary>
        /// <param name="rowIndex"></param>
        private void EditMaster(int rowIndex, int codeValue)
        {
            try
            {
                IssueMaster addForm = new IssueMaster(this, codeValue);
                if (grdIssueDetails.DataSource == null)
                {
                    MessageBox.Show("Please select details entry");
                    return;
                }


                CopyAll(grdIssueDetails, addForm.grdIssueMaster);

                //addForm.grdIssueMaster.DataSource = grdIssueDetails.DataSource;
                addForm.txtOrderNo.Text = grdIssuemaster.Rows[rowIndex].Cells["OrderNo"].Value.ToString();
                addForm.txtOrderDate.Text = grdIssuemaster.Rows[rowIndex].Cells["Orderdate"].Value.ToDateTime().ToString("dd/MM/yyyy");
                addForm.txtRemarks.Text = grdIssuemaster.Rows[rowIndex].Cells["Remarks"].Value.ToString();
                addForm.ddlIssueTo.SelectedValue = grdIssuemaster.Rows[rowIndex].Cells["IssueTo"].Value.ToString();

                addForm.ShowDialog();
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdIssuemaster.CurrentRow.Index;
                int id = GetInt(grdIssuemaster.Rows[SelectedRow].Cells["OrderId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.MSTIssueMaster, id);
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

        private void grdIssuemaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = grdIssuemaster.CurrentRow.Index;
            int codeValue = grdIssuemaster.Rows[SelectedRow].Cells["OrderId"].Value.ToInt();
            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {

                    PurelifeErpClient.Search search = new PurelifeErpClient.Search();
                    search.Id = GetInt(grdIssuemaster.Rows[SelectedRow].Cells["OrderId"].Value);
                    BindingSource bs = new BindingSource();
                    grdIssueDetails.DataSource = clientObj.DETDataListing(PurelifeErpClient.PageName.DETIssueMaster, search);
                    //bs.DataSource = grdPurchaseBillDetailsDET.DataSource;
                    //purelifeErpClient.Delete(PurelifeErpClient.PageName.MSTPurchaseBill, id);PurelifeErpClient.PageName.MSTPurchaseBill, id

                    //new DgvFilterManager(grdPurchaseBillDetailsDET);
                }
            }

            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
                //throw exception;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            BindData();

        }

        private void IssueMasterView_Load(object sender, EventArgs e)
        {
            grdIssueDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            grdIssuemaster.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
        }

        private void grdIssuemaster_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdIssuemaster.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

        private void grdIssuemaster_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdIssuemaster.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
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
