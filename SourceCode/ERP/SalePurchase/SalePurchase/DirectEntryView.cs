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
using ERP.SalePurchase.SalePurchase;

namespace ERP.SalePurchase
{
    public partial class DirectEntryView : Global.BaseClass
    {
        int SelectedRow = 0;
        public DirectEntryView()
        {
            InitializeComponent();
        }

        private static DirectEntryView sForm = null;
        public static DirectEntryView Instance()
        {

            if (sForm == null) { sForm = new DirectEntryView(); }
            return sForm;
        }
        private void BindDropDown()
        {
            //fill the account group combo
            //BindDDLDefaultValue();
            //FillCombo(ddlState, 18);
            //FillCombo(ddlPurchaseType, 11);
            //FillCombo(ddlPurchaseBill, 20);
            FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup, "All");

        }
        private void DirectEntryView_Load(object sender, EventArgs e)
        {
            BindDropDown();

            //  BindData();
            grdPurchaseBillDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            grdPurchaseBillDetailsDET.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            grdPurchaseBillDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        public void BindData()
        {

            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.Search oSearch = new PurelifeErpClient.Search();
                    oSearch.Type = 2;
                    BindingSource bs = new BindingSource();
                    grdPurchaseBillDetails.DataSource = clientObj.DataListingWithSearch(PurelifeErpClient.PageName.MSTPurchaseBill, oSearch);

                    bs.DataSource = grdPurchaseBillDetails.DataSource;
                    new DgvFilterManager(grdPurchaseBillDetails);

                    if (grdPurchaseBillDetails.DataSource == null) return;
                    bs = null;
                    //if (ddlPrimaryGroup.SelectedValue.ToString() == "0")
                    //{
                    //    grdPurchaseBillDetails.DataSource = clientObj.grdDataListing(PurelifeErpClient.PageName.MSTPurchaseBill,2);
                    //    bs.DataSource = grdPurchaseBillDetails.DataSource;
                    //}
                    
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
                //throw exception;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new DirectEntryAdd(this, 0).ShowDialog();
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdPurchaseBillDetails.CurrentRow.Index;
                int codeValue = grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value.ToInt();
                EditMaster(SelectedRow, codeValue);
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
                MessageBox.Show("Please select one row");
                //MessageBox.Show(ex.Message);
            }
        }

        #region Edit Master


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


        /// <summary>
        /// Edit Master
        /// </summary>
        /// <param name="rowIndex"></param>
        private void EditMaster(int rowIndex, int codeValue)
        {
            try
            {
                DirectEntryAdd addForm = new DirectEntryAdd(this, codeValue);
                if (grdPurchaseBillDetailsDET.DataSource == null)
                {
                    MessageBox.Show("Please select details entry");
                    return;
                }
                ////addForm.grdPurchaseBillDetailsDET.DataSource = grdPurchaseBillDetailsDET.DataSource;

                CopyAll(grdPurchaseBillDetailsDET, addForm.grdPurchaseBillDetailsDET);

                addForm.txtSerialBillNo.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["SerialBillNo"].Value.ToString();
                addForm.txtEntryDate.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["Entrydate"].Value.ToDateTime().ToString("dd/MM/yyyy");
                addForm.txtBillNo.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["BillNo"].Value.ToString();
                addForm.txtBillDate.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["BillDate"].Value.ToDateTime().ToString("dd/MM/yyyy");
                addForm.txtNarration.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["Narration"].Value.ToString();
                addForm.ddlPurchaseCategory.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["PurchaseCategyId"].Value.ToString();
                addForm.ddlPurchaseType.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["PurchaseTypeId"].Value.ToString();
                addForm.ddlPurchaseAccount.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["PurchaseAccountId"].Value.ToString();
                addForm.txtTotalAmount.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["TotalAmount"].Value.ToString();
                addForm.txtDSno.Text = Convert.ToString(addForm.grdPurchaseBillDetailsDET.RowCount.ToInt()+1);


                addForm.ShowDialog();

            }
            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
                throw exception;
            }

        }
        #endregion

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdPurchaseBillDetails.CurrentRow.Index;
                int id = GetInt(grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.MSTDirectEntry, id);
                    //purelifeErpClient.Close();
                }
                BindData();
                if (id > 0)
                {
                    ShowMessage("Deleted successfully");
                    // Close();

                }
                else
                {
                    ShowMessage("Error Please Try Later");

                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        private void grdPurchaseBillDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdPurchaseBillDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdPurchaseBillDetails_MouseEnter(object sender, EventArgs e)
        {
            grdPurchaseBillDetails.DefaultCellStyle.SelectionBackColor = Color.Silver;
            grdPurchaseBillDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            BindData();
        }


        private void grdPurchaseBillDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void grdPurchaseBillDetailsDET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = grdPurchaseBillDetails.CurrentRow.Index;
            int codeValue = grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value.ToInt();
            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {

                    PurelifeErpClient.Search search = new PurelifeErpClient.Search();
                    search.Id = GetInt(grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value);
                    BindingSource bs = new BindingSource();
                    grdPurchaseBillDetailsDET.DataSource = clientObj.DETDataListing(PurelifeErpClient.PageName.DETDirectEntry, search);
                    //bs.DataSource = grdPurchaseBillDetailsDET.DataSource;
                    //purelifeErpClient.Delete(PurelifeErpClient.PageName.MSTPurchaseBill, id);PurelifeErpClient.PageName.MSTPurchaseBill, id

                    //new DgvFilterManager(grdPurchaseBillDetailsDET);
                }
            }
            catch (Exception exception)
            {
                // ErrorLog.LogErrorInTxtFormat(exception);
                throw exception;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            new DirectEntryAdd(this, 0).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdPurchaseBillDetails.CurrentRow.Index;
                int id = GetInt(grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value);
                if (id > 0)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                       "Confirm Delete!!",
                       MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                        {
                            purelifeErpClient.Delete(PurelifeErpClient.PageName.MSTDirectEntry, id);
                            //purelifeErpClient.Close();
                        }
                        MessageBox.Show("Successfully Deleted");
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

        private void grdPurchaseBillDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = grdPurchaseBillDetails.CurrentRow.Index;
            int codeValue = grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value.ToInt();
            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.Search search = new PurelifeErpClient.Search();
                    search.Id = GetInt(grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value);
                    BindingSource bs = new BindingSource();
                    grdPurchaseBillDetailsDET.DataSource = clientObj.DETDataListing(PurelifeErpClient.PageName.DETPurchaseBill, search);
                    //grdPurchaseBillDetailsDET.DataSource = dtDetails;
                }
            }
            catch (Exception exception)
            {
                // ErrorLog.LogErrorInTxtFormat(exception);
                throw exception;
            }

        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            BindData();
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
        //private void btnEdit_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnDelete_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnExit_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
