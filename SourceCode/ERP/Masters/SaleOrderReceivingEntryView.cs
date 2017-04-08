using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;

using Common;
using ERP;

namespace ERP.SalePurchase
{
    public partial class SaleOrderReceivingEntry : Global.BaseClass
    {
         int SelectedRow = 0;

        public SaleOrderReceivingEntry()
        {
            InitializeComponent();
        }

        private static SaleOrderReceivingEntry sForm = null;
        public static SaleOrderReceivingEntry Instance()
        {

            if (sForm == null) { sForm = new SaleOrderReceivingEntry(); }
            return sForm;
        }


        private void bLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new SaleOrderReceivingEntryAdd(this, 0).ShowDialog();   

        }

        private void SaleOrderReceivingEntry_Load(object sender, EventArgs e)
        {
            BindData();
           // BindData2();
            grdSaleOrderDetial1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            // grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
            grdSaleOrderDetial1.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            grdSaleOrderDetail2.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            // grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
            grdSaleOrderDetail2.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            BindDropDown();

        }

        private void BindDropDown()
        {
            //fill the account group combo
            //BindDDLDefaultValue();
          //  FillCombo(ddlState, 18);
            FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup, "All");

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
                    grdSaleOrderDetial1.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.SaleOrderReceivingEntryMST);
                    bs.DataSource = grdSaleOrderDetial1.DataSource;

                    //if (ddlPrimaryGroup.SelectedValue.ToInt() > 0)
                    //{
                    //    bs.Filter = string.Format("AccountGroupMasId= {0}", ddlPrimaryGroup.SelectedValue);
                    //    //bs.Filter = string.Format("AccountGroupMasId", ddlGroupName.SelectedValue);
                    //}

                    //if (ddlPrimaryGroup.SelectedValue.ToString() == "0")
                    //{
                    //    grdSaleOrderDetial1.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.SaleOrderReceivingEntry);
                    //    bs.DataSource = grdSaleOrderDetial1.DataSource;
                    //}

                    new DgvFilterManager(grdSaleOrderDetial1);

                    //grdSaleOrderDetail2.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.SaleOrderReceivingEntry);
                    //new DgvFilterManager(grdSaleOrderDetail2);

                    //BindingSource bs = new BindingSource();
                    //bs.DataSource = grdSaleOrderDetail2.DataSource;
                    //grdSaleOrderDetial1.DataSource = bs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //public void BindData2()
        //{
        //    //grdItemGroupView.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, " SELECT * from ItemsGroupAdd;").Tables[0];
        //    //new DgvFilterManager(grdItemGroupView);

        //    try
        //    {
        //        using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
        //        {
        //            grdSaleOrderDetail2.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.SaleOrderReceivingEntry);
        //            new DgvFilterManager(grdSaleOrderDetail2);

        //            //grdSaleOrderDetail2.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.SaleOrderReceivingEntry);
        //            //new DgvFilterManager(grdSaleOrderDetail2);

        //            //BindingSource bs = new BindingSource();
        //            //bs.DataSource = grdSaleOrderDetail2.DataSource;
        //            //grdSaleOrderDetial1.DataSource = bs;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedRow = grdSaleOrderDetial1.CurrentRow.Index;
            int codeValue = grdSaleOrderDetial1.Rows[SelectedRow].Cells["Id"].Value.ToInt();
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
                SaleOrderReceivingEntryAdd addForm = new SaleOrderReceivingEntryAdd(this, codeValue);
                addForm.txtOrderNo.Text = grdSaleOrderDetial1.Rows[rowIndex].Cells["OrderNo"].Value.ToString();
                addForm.txtOrderDate.Text = grdSaleOrderDetial1.Rows[rowIndex].Cells["OrderDate"].Value.ToString();
                addForm.ddlPartyName.SelectedValue = grdSaleOrderDetial1.Rows[rowIndex].Cells["Party"].Value.ToString();
                addForm.ddlActive.SelectedValue = grdSaleOrderDetial1.Rows[rowIndex].Cells["Active"].Value.ToString();
                addForm.txtRemark.Text = grdSaleOrderDetial1.Rows[rowIndex].Cells["Remarks"].Value.ToString();
                //addForm.txtSNo.Text = grdSaleOrderDetial1.Rows[rowIndex].Cells["SNo"].Value.ToString();
                //addForm.txtItemDescptn.Text = grdSaleOrderDetial1.Rows[rowIndex].Cells["ItemDescription"].Value.ToString();
                //addForm.txtQty.Text = Convert.ToString(grdSaleOrderDetial1.Rows[rowIndex].Cells["Qty"].Value.ToFloat());
                //addForm.txtRate.Text = grdSaleOrderDetial1.Rows[rowIndex].Cells["Rate"].Value.ToString();
                //addForm.txtAmount.Text = grdSaleOrderDetial1.Rows[rowIndex].Cells["Amount"].Value.ToString();
                addForm.txtTotal.Text = grdSaleOrderDetial1.Rows[rowIndex].Cells["Total"].Value.ToString();
             
                addForm.ShowDialog();
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }
        #endregion

        private void btnFind_Click(object sender, EventArgs e)
        {
             BindData();
            //BindingSource bs = new BindingSource();
            //bs.DataSource = grdSaleOrderDetial1.DataSource;
            //bs.Filter = string.Format("PartyName LIKE '%{0}%'", txtSearch.Text);
            //grdSaleOrderDetial1.DataSource = bs;
        }

        private void grdSaleOrderDetial1_MouseEnter(object sender, EventArgs e)
        {
            grdSaleOrderDetial1.DefaultCellStyle.SelectionBackColor = Color.Silver;
        }

        private void grdSaleOrderDetial1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdSaleOrderDetial1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

        private void grdSaleOrderDetial1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdSaleOrderDetial1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void grdSaleOrderDetail2_MouseEnter(object sender, EventArgs e)
        {
            grdSaleOrderDetail2.DefaultCellStyle.SelectionBackColor = Color.Silver;
        }

        private void grdSaleOrderDetail2_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdSaleOrderDetail2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

        private void grdSaleOrderDetail2_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdSaleOrderDetail2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

    }
}
