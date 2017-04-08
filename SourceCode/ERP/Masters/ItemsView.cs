using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;
using Common;
using System.Linq;
using ERP.Global;

using Common;
using ERP;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ERP.SalePurchase
{
    public partial class ItemsView : Global.BaseClass
    {
        private static ItemsView sForm = null;
        int SelectedRow = 0;

        public ItemsView()
        {
            InitializeComponent();
            //BindDropDown();
            //window.location.reload();
        }
        private void BindDropDown()
        {
            FillCombo(ddlActiveItems, 1);
            FillCombo(ddlGrps, 1);
            FillCombo(ddlRTCode, 1);
            FillCombo(ddlExciseReg, 1);
            //FillCombo(ddlGroupName, 1);

            //FillCombo(ddlActiveItems, 1);ddlGroupName



            // FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup);    
        }
        public static ItemsView Instance()
        {
            if (sForm == null) { sForm = new ItemsView(); }
            return sForm;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            new ItemsAdd(this, 0).ShowDialog();
        }

        private void SetButtons()
        {
            btnADD.SetBackGroundImage();
            btnEdit.SetBackGroundImage();
            btnDelete.SetBackGroundImage();
            btnExit.SetBackGroundImage();
            btnFind.SetBackGroundImage();
            //btnRefresh.SetBackGroundImage();
        }
        private void ItemsView_Load(object sender, EventArgs e)
        {
            // BindData();
            // grdItemMaster.FirstDisplayedScrollingRowIndex = this.grdItemMaster.FirstDisplayedScrollingRowIndex + 1;
            //grdItemMaster.FirstDisplayedScrollingRowIndex = grdItemMaster.RowCount - 1;
            // this.grdItemMaster.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;e.RowIndex >= 0

            //foreach (Control ctl in this.grdItemMaster.Controls)
            //{
            //    if (ctl is VScrollBar)
            //    {
            //        VScrollBar scroll = (VScrollBar)ctl;
            //        if (scroll.Visible)
            //        {
            //            this.grdItemMaster.FirstDisplayedScrollingRowIndex = this.grdItemMaster.FirstDisplayedScrollingRowIndex + 1;
            //        }
            //    }
            //}
            // this.grdItemMaster.TableElement.ScrollTo(5, 4);
            //this.grdItemMaster.ScrollTo(5, 4);
            //int rowIndex = grdItemMaster.FirstDisplayedScrollingRowIndex;

            //// Refresh your DGV.

            //grdItemMaster.FirstDisplayedScrollingRowIndex = rowIndex;
            BindDropDown();
            grdItemMaster.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            // grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
            grdItemMaster.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;


        }
        public void BindData()
        {
            //grdItemGroupView.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, " SELECT * from ItemsGroupAdd;").Tables[0];
            //new DgvFilterManager(grdItemGroupView);

            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    BindingSource bs = new BindingSource();
                    grdItemMaster.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.Item);
                    bs.DataSource = grdItemMaster.DataSource;
                    if (grdItemMaster.DataSource == null) return;
                    if (txtSearch.Text != null)
                    {
                        bs.Filter = string.Format("DisplayName LIKE '%{0}%'", txtSearch.Text);
                    }

                    new DgvFilterManager(grdItemMaster);
                    // clientObj.Close();

                    //BindingSource bs = new BindingSource();
                    //bs.DataSource = grdItemMaster.DataSource;
                    //bs.Filter = string.Format("DisplayName LIKE '%{0}%'", txtSearch.Text);
                    //grdItemMaster.DataSource = bs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region For Exit
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region For Edit

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedRow = grdItemMaster.CurrentRow.Index;
            double codeValue = grdItemMaster.Rows[SelectedRow].Cells["ItemMasId"].Value.ToInt();
            EditData(SelectedRow, codeValue);
            //BindData();
        }
        #endregion



        #region Edit Master

        /// <summary>
        /// Edit Master
        /// </summary>
        /// <param name="rowIndex"></param>
        private void EditData(int rowIndex, double codeValue)
        {
            try
            {
                //AccountAdd addForm = new AccountAdd(this, codeValue);
                //addForm.ShowDialog();

                ItemsAdd addForm = new ItemsAdd(this, codeValue);
               

                addForm.txtDisplayName.Text = grdItemMaster.Rows[rowIndex].Cells["DisplayName"].Value.ToString();
                addForm.txtAliasItemCode.Text = grdItemMaster.Rows[rowIndex].Cells["AliasItemCode"].Value.ToString();
                addForm.txtPrintDescription.Text = grdItemMaster.Rows[rowIndex].Cells["PrintDescription"].Value.ToString();
                addForm.txtBasicUnit.Text = grdItemMaster.Rows[rowIndex].Cells["BasicUnit"].Value.ToString();
                addForm.txtPackage.Text = grdItemMaster.Rows[rowIndex].Cells["Package"].Value.ToString();
                addForm.ddlGroupName.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["GroupName"].Value.ToString();
                addForm.txtSaleRate.Text = grdItemMaster.Rows[rowIndex].Cells["SaleRate"].Value.ToString();
                addForm.txtPurchaseRate.Text = grdItemMaster.Rows[rowIndex].Cells["PurchaseRate"].Value.ToString();
                addForm.txtExportRate.Text = grdItemMaster.Rows[rowIndex].Cells["ExportRate"].Value.ToString();
                addForm.txtStockRate.Text = grdItemMaster.Rows[rowIndex].Cells["StockRate"].Value.ToString();
                addForm.ddlRT12Code.Text = grdItemMaster.Rows[rowIndex].Cells["RT12Code"].Value.ToString();
                addForm.txtMRP.Text = grdItemMaster.Rows[rowIndex].Cells["MRP"].Value.ToString();
                addForm.txtMRPRate.Text = grdItemMaster.Rows[rowIndex].Cells["MRPRate"].Value.ToString();
                addForm.txtPlatingRate.Text = grdItemMaster.Rows[rowIndex].Cells["PlatingRate"].Value.ToString();
                addForm.txtValue.Text = grdItemMaster.Rows[rowIndex].Cells["Value"].Value.ToString();
                addForm.txtTraiffNo.Text = grdItemMaster.Rows[rowIndex].Cells["TraiffNo"].Value.ToString();
                addForm.ddlActive.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["Active"].Value.ToString().ToLower() == "true" ? "1" : "0";

                addForm.ddlTaxableItem.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["TaxableItem"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.ddlExciseRegister.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["ExciseRegister"].Value.ToString();
                addForm.ddlItemType.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["ItemType"].Value.ToString();

                addForm.txtNonExciseStock.Text = grdItemMaster.Rows[rowIndex].Cells["NonExciseStock"].Value.ToString();
                addForm.txtExciseRG1Stock.Text = grdItemMaster.Rows[rowIndex].Cells["ExciseRG1Stock"].Value.ToString();
                addForm.txtExciseRG23AStock.Text = grdItemMaster.Rows[rowIndex].Cells["ExciseRG23AStock"].Value.ToString();
                addForm.txtExciseRG23CStock.Text = grdItemMaster.Rows[rowIndex].Cells["ExciseRG23CStock"].Value.ToString();

                addForm.txtTotalStock.Text = grdItemMaster.Rows[rowIndex].Cells["TotalStock"].Value.ToString();
                addForm.txtMinQuantity.Text = grdItemMaster.Rows[rowIndex].Cells["MinQuantity"].Value.ToString();
                addForm.txtMaxQty.Text = grdItemMaster.Rows[rowIndex].Cells["MaxQty"].Value.ToString();
                addForm.txtReOrderLevel.Text = grdItemMaster.Rows[rowIndex].Cells["ReOrderLevel"].Value.ToString();
                addForm.txtNetWeight.Text = grdItemMaster.Rows[rowIndex].Cells["NetWeight"].Value.ToString();
                addForm.txtCutWeight.Text = grdItemMaster.Rows[rowIndex].Cells["CutWeight"].Value.ToString();
                addForm.txtGrossWeight.Text = grdItemMaster.Rows[rowIndex].Cells["GrossWeight"].Value.ToString();
                addForm.txtLength.Text = grdItemMaster.Rows[rowIndex].Cells["Length"].Value.ToString();

                addForm.txtWidth.Text = grdItemMaster.Rows[rowIndex].Cells["Width"].Value.ToString();
                addForm.txtBinPackageQty.Text = grdItemMaster.Rows[rowIndex].Cells["BinPackageQty"].Value.ToString();
                addForm.txtFreeQtyBin.Text = grdItemMaster.Rows[rowIndex].Cells["FreeQtyBin"].Value.ToString();
                addForm.txtAlternateUnit.Text = grdItemMaster.Rows[rowIndex].Cells["AlternateUnit"].Value.ToString();
                addForm.txtConversionFormule1.Text = grdItemMaster.Rows[rowIndex].Cells["ConversionFormule1"].Value.ToString();
                addForm.txtConversionFormule2.Text = grdItemMaster.Rows[rowIndex].Cells["ConversionFormule2"].Value.ToString();
                addForm.ddlItemSpecCode.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["ItemSpecificationCode"].Value.ToString();
                addForm.txtDescriptionForInvoice.Text = grdItemMaster.Rows[rowIndex].Cells["DescriptionForInvoice"].Value.ToString();

                addForm.txtRackNo.Text = grdItemMaster.Rows[rowIndex].Cells["RackNo"].Value.ToString();
                addForm.ddlMakeMRNJwAuto.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["MakeMRNJwAuto"].Value.ToString().ToLower() == "true" ? "1" : "0";
                addForm.txtItemArea.Text = grdItemMaster.Rows[rowIndex].Cells["ItemArea"].Value.ToString();
                addForm.txtFileName.Text = grdItemMaster.Rows[rowIndex].Cells["FileName"].Value.ToString();
                addForm.txtMinOrderQty.Text = grdItemMaster.Rows[rowIndex].Cells["MinOrderQty"].Value.ToString();
                addForm.txtLeadTime.Text = grdItemMaster.Rows[rowIndex].Cells["LeadTime"].Value.ToString();
                addForm.ddlPackageType.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["PackageType"].Value.ToString();

                addForm.txtCode.Text = grdItemMaster.Rows[rowIndex].Cells["Code"].Value.ToString();
                addForm.ddlRawMaterialUsed.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["RawMaterialUsed"].Value.ToString();
                addForm.ddlPriceListName.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["PriceListName"].Value.ToString();
                addForm.txtRateFactor1.Text = grdItemMaster.Rows[rowIndex].Cells["RateFactor1"].Value.ToString();
                addForm.txtRateFactor2.Text = grdItemMaster.Rows[rowIndex].Cells["RateFactor2"].Value.ToString();
                addForm.txtRateFactor3.Text = grdItemMaster.Rows[rowIndex].Cells["RateFactor3"].Value.ToString();
                addForm.txtRateFactor4.Text = grdItemMaster.Rows[rowIndex].Cells["RateFactor4"].Value.ToString();
                addForm.ddlProcessName.SelectedValue = grdItemMaster.Rows[rowIndex].Cells["ProcessName"].Value.ToString();
                addForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        //private void DeleteMaster(Double codeValue)
        //{
        //    try
        //    {

        //        //base.Delete("AccMas", "AccCode", codeValue.ToString());

        //        BindData();

        //    }
        //    catch (Exception exception)
        //    {
        //        //ErrorLog.LogErrorInTxtFormat(exception);
        //    }

        //}


        #region For Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                //SelectedRow = grdAccountDetails.CurrentRow.Index;
                //double codeValue = Convert.ToDouble(grdAccountDetails.Rows[SelectedRow].Cells["AccCode"].Value);
                //DeleteMaster(codeValue);
                SelectedRow = grdItemMaster.CurrentRow.Index;
                int id = GetInt(grdItemMaster.Rows[SelectedRow].Cells["ItemMasId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.Item, id);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion


        private void btnCopyAccount_Click(object sender, EventArgs e)
        {

        }

        //private void btnFind_Click(object sender, EventArgs e)
        //{
        //    BindData();
        //    //this.BackgroundImage = Image.FromFile("I:\\Working Project\\ERP-Code\\SourceCode\\ERP\\Resources\\btn1.png");
        //    //BindingSource bs = new BindingSource();
        //    //bs.DataSource = grdItemMaster.DataSource;
        //    //bs.Filter = string.Format("DisplayName LIKE '%{0}%'", txtSearch.Text);
        //    //grdItemMaster.DataSource = bs;
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //BindData();
            //this.Refresh();
            //ItemsView frm = new ItemsView();
            //frm.Refresh();
            //this.Update();
        }

        private void grdItemMaster_CellMouseEnter(object sender, EventArgs e)
        {
            grdItemMaster.DefaultCellStyle.SelectionBackColor = Color.Silver;

        }

        private void grdItemMaster_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdItemMaster.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }

        }

        private void grdItemMaster_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdItemMaster.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void grdItemMaster_Scroll(object sender, ScrollEventArgs e)
        {
            //grdItemMaster.FirstDisplayedScrollingRowIndex = grdItemMaster.RowCount - 1;


        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            BindData();
        }

        private void grdItemMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnFind_Click(object sender, EventArgs e)
        {
            BindData();
        }

        //private void btnADD_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnExit_Click_1(object sender, EventArgs e)
        //{

        //}


    }
}
