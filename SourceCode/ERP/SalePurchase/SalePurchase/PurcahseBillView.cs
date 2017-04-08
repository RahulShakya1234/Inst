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

namespace ERP.SalePurchase
{
    public partial class PurcahseBillView : Global.BaseClass
    {
        DataTable dtMaster = null;
        DataTable dtDetails = null;
        int SelectedRow = 0;
        public PurcahseBillView()
        {
            InitializeComponent();
        }


        private static PurcahseBillView sForm = null;
        public static PurcahseBillView Instance()
        {

            if (sForm == null) { sForm = new PurcahseBillView(); }
            return sForm;
        }

        private void BindDropDown()
        {
            //fill the account group combo
            //BindDDLDefaultValue();
            //FillCombo(ddlState, 18);
            FillCombo(ddlPurchaseType, 11);
            FillCombo(ddlPurchaseBill, 20);
            FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup, "All");

        }



        private void PurcahseBillView_Load(object sender, EventArgs e)
        {
            BindDropDown();

            //  BindData();
            grdPurchaseBillDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            grdPurchaseBillDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            grdPurchaseBillDetailsDET.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
        }


        public void BindData()
        {

            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.Search oSearch = new PurelifeErpClient.Search();
                    oSearch.Type = 1;

                    BindingSource bs = new BindingSource();
                    dtMaster = clientObj.DataListingWithSearch(PurelifeErpClient.PageName.MSTPurchaseBill, oSearch);
                    grdPurchaseBillDetails.DataSource = dtMaster;
                    bs.DataSource = grdPurchaseBillDetails.DataSource;
                    new DgvFilterManager(grdPurchaseBillDetails);
                    if (grdPurchaseBillDetails.DataSource == null) return;
                    bs = null;
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
                
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //PurchaseBillAdd addforma = new PurchaseBillAdd();

            //var count=   addforma.txtSerialBillNo.Text = (grdPurchaseBillDetails.Rows.Count + 1).ToString();

            //if (addforma.txtSerialBillNo.Text.ToInt() > grdPurchaseBillDetails.Rows.Count.ToInt())
            //{
            //    addforma.txtSerialBillNo.Text = (grdPurchaseBillDetailsDET.Rows.Count + 1).ToString();
            //}

            //else
            //{
            //    addforma.txtSerialBillNo.Text = (grdPurchaseBillDetailsDET.Rows.Count + 1).ToString();
            //}

            new PurchaseBillAdd(this, 0).ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // int count=0;
                SelectedRow = grdPurchaseBillDetails.CurrentRow.Index;
                int codeValue = grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value.ToInt();
                EditMaster(SelectedRow, codeValue);
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
                //MessageBox.Show(ex.Message);
            }
        }

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




        #region Edit Master

        /// <summary>
        /// Edit Master
        /// </summary>
        /// <param name="rowIndex"></param>
        private void EditMaster(int rowIndex, int codeValue)
        {
            try
            {
                PurchaseBillAdd addForm = new PurchaseBillAdd(this, codeValue);
                if (grdPurchaseBillDetailsDET.DataSource == null)
                {
                    MessageBox.Show("Please select details entry");
                    return;
                }
                CopyAll(grdPurchaseBillDetailsDET, addForm.grdPurchaseBillDetailsDET);


                //  addForm.grdPurchaseBillDetailsDET.DataSource = grdPurchaseBillDetailsDET.DataSource;
                addForm.txtSerialBillNo.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["SerialBillNo"].Value.ToString();
                addForm.txtBillNo.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["BillNo"].Value.ToString();
                addForm.txtNarration.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["Narration"].Value.ToString();
                addForm.txtEntryDate.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["Entrydate"].Value.ToDateTime().ToString("dd/MM/yyyy");
                addForm.txtBillDate.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["BillDate"].Value.ToDateTime().ToString("dd/MM/yyyy");

                addForm.txtCess.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["Cess"].Value.ToString();
                addForm.txtHECess.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["HECess"].Value.ToString();
                addForm.txtExciseReg.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["ExciseReg"].Value.ToString();
                addForm.txtExciseNo.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["ExciseNo"].Value.ToString();
                addForm.txtTransport.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["Transport"].Value.ToString();
                addForm.txtCarrier.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["Carrier"].Value.ToString();
                addForm.txtPackingForword.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["PackingForwarding"].Value.ToString();
                addForm.txtFrieghtInsurance.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["friegthInsurance"].Value.ToString();
                addForm.txtRemark.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["Remarks"].Value.ToString();
                addForm.txtSaleTax.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["SaleTax"].Value.ToString();
                addForm.txtSurchargeTax.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["SurchargeTax"].Value.ToString();
                addForm.txtBillAmount.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["BillAmount"].Value.ToString();
                addForm.txtMSTTotalAmount.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["TotalAmount"].Value.ToString();
                addForm.ddlIssueToProduction.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["MakeIssueToProductionBill"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlAddExcise.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["AddExcise"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.txtExcise.Text = grdPurchaseBillDetails.Rows[rowIndex].Cells["ExciseNo"].Value.ToString();
                addForm.ddlPurchaseType.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["PurchaseType"].Value.ToString();
                addForm.ddlPurchaseCategory.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["PurchaseCategy"].Value.ToString();
                addForm.ddlPurchaseAccount.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["AccountGroupMasId"].Value.ToString();
                addForm.ddlPurchaseType.SelectedValue = grdPurchaseBillDetails.Rows[rowIndex].Cells["PurchaseType"].Value.ToString();
                addForm.txtSno.Text = Convert.ToString(addForm.grdPurchaseBillDetailsDET.RowCount.ToInt() + 1);



                addForm.ShowDialog();


            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
                //throw exception;
            }

        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdPurchaseBillDetails.CurrentRow.Index;
                int id = GetInt(grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.MSTPurchaseBill, id);
                    //purelifeErpClient.Close();
                }
                // BindData();
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

        private void grdPurchaseBillDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdPurchaseBillDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

        private void grdPurchaseBillDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdPurchaseBillDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
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
            SelectedRow = grdPurchaseBillDetails.CurrentRow.Index;
            int codeValue = grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value.ToInt();
            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.Search search = new PurelifeErpClient.Search();
                    search.Id = GetInt(grdPurchaseBillDetails.Rows[SelectedRow].Cells["PurchaseBillId"].Value);
                    BindingSource bs = new BindingSource();
                    dtDetails = clientObj.DETDataListing(PurelifeErpClient.PageName.DETPurchaseBill, search);
                    grdPurchaseBillDetailsDET.DataSource = dtDetails;

                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
                throw exception;
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
