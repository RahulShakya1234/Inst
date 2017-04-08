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
    public partial class PartyWiseItemRateList : Global.BaseClass
    {
        int SelectedRow = 0;
        public PartyWiseItemRateList()
        {
            InitializeComponent();
        }

        private static PartyWiseItemRateList sForm = null;
        public static PartyWiseItemRateList Instance()
        {

            if (sForm == null) { sForm = new PartyWiseItemRateList(); }
            return sForm;
        }


        private void PartyWiseItemRateAdd_Load(object sender, EventArgs e)
        {
            BindData();
            grdPartWiseRateList.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            // grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
            grdPartWiseRateList.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;

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
                    grdPartWiseRateList.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.PartyWiseItemRate);
                    bs.DataSource = grdPartWiseRateList.DataSource;
                    if (grdPartWiseRateList.DataSource == null) return;
                    if (txtSearch.Text != null)
                    {
                        bs.Filter = string.Format("AccountGroupName LIKE '%{0}%'", txtSearch.Text);
                    }
                    new DgvFilterManager(grdPartWiseRateList);
                    clientObj.Close();

                   
                    //if (txtsearch.text != null)
                    //{
                    //    bindingsource bs = new bindingsource();
                    //    bs.datasource = grdpartwiseratelist.datasource;
                    //    bs.filter = string.format("partyname like '%{0}%'", txtsearch.text);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void grdItemRate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void radioBtnRatelistWise_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRatelistWise.Checked == true)
            {

                this.ItemName.Visible = false;
                this.ItemCode.Visible = false;
                this.PONo.Visible = false;
                this.ToolRate.Visible = false;
                this.Tax.Visible = false;
            }
            else
            {
                this.ItemName.Visible = true;
                this.ItemCode.Visible = true;
                this.PONo.Visible = true;
                this.ToolRate.Visible = true;
                this.Tax.Visible = true;
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedRow = grdPartWiseRateList.CurrentRow.Index;
                int codeValue = grdPartWiseRateList.Rows[SelectedRow].Cells["PartyWiseMasId"].Value.ToInt();
                EditMaster(SelectedRow, codeValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                //AccountAdd addForm = new AccountAdd(this, codeValue);
                //addForm.ShowDialog();

                PartyWiseItemAdd addForm = new PartyWiseItemAdd(this, codeValue);
               // addForm.txtPartyName.Text  = grdPartWiseRateList.Rows[rowIndex].Cells["PartyName"].Value.ToString();
                addForm.ddlGroupName.SelectedValue = grdPartWiseRateList.Rows[rowIndex].Cells["AccountGroupMasId"].Value.ToString();
                addForm.txtItemName.Text = grdPartWiseRateList.Rows[rowIndex].Cells["ItemName"].Value.ToString();
                addForm.txtItemCode.Text = grdPartWiseRateList.Rows[rowIndex].Cells["ItemCode"].Value.ToString();
                addForm.txtItemRate.Text = grdPartWiseRateList.Rows[rowIndex].Cells["PackingRate"].Value.ToString();
                addForm.txtPONo.Text = grdPartWiseRateList.Rows[rowIndex].Cells["PONo"].Value.ToString();
                addForm.txtAmendmentNo.Text = grdPartWiseRateList.Rows[rowIndex].Cells["AmendmentNo"].Value.ToString();
                addForm.txtPOdate.Text = grdPartWiseRateList.Rows[rowIndex].Cells["PODate"].Value.ToString();
                addForm.txtAmendmentDate.Text = grdPartWiseRateList.Rows[rowIndex].Cells["AmendmentDate"].Value.ToString();

                addForm.txtPartno.Text = grdPartWiseRateList.Rows[rowIndex].Cells["PartNo"].Value.ToString();
                addForm.txtToolSupply.Text = grdPartWiseRateList.Rows[rowIndex].Cells["ToolSupplyForQty"].Value.ToString();
                addForm.txtToolRate.Text = grdPartWiseRateList.Rows[rowIndex].Cells["ToolRate"].Value.ToString();
                addForm.txtTax.Text = grdPartWiseRateList.Rows[rowIndex].Cells["Tax"].Value.ToString();
                addForm.txtToolNarr.Text = grdPartWiseRateList.Rows[rowIndex].Cells["ToolNarr"].Value.ToString();
                addForm.txtProcessName.Text = grdPartWiseRateList.Rows[rowIndex].Cells["ProcessName"].Value.ToString();
                addForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new PartyWiseItemAdd(this, 0).ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnFind_Click(object sender, EventArgs e)
        //{
        //    BindData();
        //    //if (txtsearch.text != null)
        //    //{
        //    //    bindingsource bs = new bindingsource();
        //    //    bs.datasource = grdpartwiseratelist.datasource;
        //    //    bs.filter = string.format("partyname like '%{0}%'", txtsearch.text);
        //    //}
        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{

        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                //SelectedRow = grdAccountDetails.CurrentRow.Index;
                //double codeValue = Convert.ToDouble(grdAccountDetails.Rows[SelectedRow].Cells["AccCode"].Value);
                //DeleteMaster(codeValue);
                SelectedRow = grdPartWiseRateList.CurrentRow.Index;
                int id = GetInt(grdPartWiseRateList.Rows[SelectedRow].Cells["PartyWiseMasId"].Value);

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    purelifeErpClient.Delete(PurelifeErpClient.PageName.PartyWiseItemRate, id);

                    purelifeErpClient.Close();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            BindData();

        }

        private void grdPartWiseRateList_MouseEnter(object sender, EventArgs e)
        {

        }

        private void grdPartWiseRateList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdPartWiseRateList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }

        }

        private void grdPartWiseRateList_MouseHover(object sender, EventArgs e)
        {
            grdPartWiseRateList.DefaultCellStyle.SelectionBackColor = Color.Silver;
            grdPartWiseRateList.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void grdPartWiseRateList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdPartWiseRateList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        //private void btnAdd_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
