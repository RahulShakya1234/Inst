using System;

using Common;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;

namespace ERP.SalePurchase
{
    public partial class SaleOrderReceivingEntryAdd : Global.BaseClass
    {

        private SaleOrderReceivingEntry viewForm;
        int Code = 0;
        public SaleOrderReceivingEntryAdd()
        {
            InitializeComponent();
        }

        //private static SaleOrderReceivingEntryAdd sForm = null;
        //public static SaleOrderReceivingEntryAdd Instance()
        //{

        //    if (sForm == null) { sForm = new SaleOrderReceivingEntryAdd(); }
        //    return sForm;
        //}
        public SaleOrderReceivingEntryAdd(SaleOrderReceivingEntry view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
            BindDropDown();
        }

        public SaleOrderReceivingEntryAdd(SaleOrderReceivingEntry view, int code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            this.Text = this.Text + " (Edit)";
            BindDropDown();
        }
        private void BindDropDown()
        {
            //fill the account group combo


            FillCombo(ddlActive, 1);
            FillCombo(ddlPartyName, Common.Masters.SaleOrderReceivgEntry, "Please Select");
            FillCombo(ddlItemDesb, Common.Masters.ItemGroup, "Please Select");    


        }
        public void SetButtons()
        {
            btnSave.SetBackGroundImage();
            btnCancel.SetBackGroundImage();
        }
        private void SaleOrderReceivingEntryAdd_Load(object sender, EventArgs e)
        {
            BindData1();
            SetButtons();

        }

        private void bLabel8_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(txtOrderNo))
                {
                    return;
                }


                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.MSTSaleOrderReceivingEntryDTO objSaleOrderReceivingEntryDO = new PurelifeErpClient.MSTSaleOrderReceivingEntryDTO();
                    objSaleOrderReceivingEntryDO.Id = Code;

                    objSaleOrderReceivingEntryDO.OrderNo = txtOrderNo.Text.Trim();
                    objSaleOrderReceivingEntryDO.OrderDate = txtOrderDate.Text.ToDateTime();

                    objSaleOrderReceivingEntryDO.PartyName = GetInt(ddlPartyName.SelectedValue);//AccountGroupMasId
                    //objSaleOrderReceivingEntryDO.Active = ddlActive.SelectedValue.ToString() == "0" ? false : true;
                    objSaleOrderReceivingEntryDO.Remarks = txtRemark.Text.Trim();
                    //objSaleOrderReceivingEntryDO.SNo = txtSNo.Text.ToInt();
                    
                    //objSaleOrderReceivingEntryDO.Qty = txtQty.Text.ToFloat();
                    //objSaleOrderReceivingEntryDO.Rate = txtRate.Text.ToFloat();
                    //objSaleOrderReceivingEntryDO.Amount = txtAmount.Text.ToFloat();
                    objSaleOrderReceivingEntryDO.Total = txtTotal.Text.ToFloat();

                    PurelifeErpClient.ERPDTOBase objERPDOBase = objSaleOrderReceivingEntryDO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.SaleOrderReceivingEntryMST, objERPDOBase);
                    purelifeErpClient.Close();
                }

                viewForm.BindData();

                if (Code > 0)
                {
                    ShowMessage("Updated successfully");
                    Close();
                }
                else
                {
                    ShowMessage("Saved successfully");
                    ResetControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ResetControls()
        {
            txtOrderNo.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
           // ddlPartyName.SelectedIndex = 0;
            //ddlActive.SelectedIndex = 0;
            txtRemark.Text = string.Empty;
            //txtSNo.Text = string.Empty;
            //txtItemDescptn.Text = string.Empty;
            //txtQty.Text = string.Empty;
            //txtRate.Text = string.Empty;
            //txtAmount.Text = string.Empty;
            //txtTotal.Text = string.Empty;

        }

        //private DataTable GetDataTable()
        //{
        //    try
        //    {
        //        DataTable tableGrid = new DataTable();
        //        tableGrid.Columns.Add("SNo");
        //        tableGrid.Columns.Add("ItemDescription");

        //        tableGrid.Columns.Add("Qty");
        //        tableGrid.Columns.Add("Rate");

              
        //        tableGrid.Columns.Add("Amount");

                
        //        return tableGrid;

        //    }
        //    catch (Exception exception)
        //    {

        //        throw exception;
        //    }
        //}
        //private DataTable Items
        //{
        //    get;
        //    set;
        //}

        private SaleOrderReceivingEntryAdd viewForm1;
        public SaleOrderReceivingEntryAdd(SaleOrderReceivingEntryAdd view)
        {
            viewForm1 = view;
            Code = 0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
            BindDropDown();
        }
     //   public SaleOrderReceivingEntryAdd(SaleOrderReceivingEntryAdd view, int code)
        //{
        //    viewForm1 = view;
        //    Code = code;
        //    InitializeComponent();
        //    this.Text = this.Text + " (Edit)";
        //    BindDropDown();
        //}


        public void BindData1()
        {
            //grdItemGroupView.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, " SELECT * from ItemsGroupAdd;").Tables[0];
            //new DgvFilterManager(grdItemGroupView);

            try
            {
                using (PurelifeErpClient.PurelifeErpClient clientObj = new PurelifeErpClient.PurelifeErpClient())
                {
                    grdSaleOrderReceivingEntry.DataSource = clientObj.DataListing(PurelifeErpClient.PageName.SaleOrderReceivingEntryMST);
                    new DgvFilterManager(grdSaleOrderReceivingEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls1();

        }

        public void ResetControls1()
        {
            txtSNo.Text = string.Empty;
            //txtItemDescptn.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtSNo.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtAmount.Text = string.Empty;
            //txtTotal.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {


            try
            {
                //if (CheckRequiredField(txtOrderNo))
                //{
                //    return;
                //}
                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.SaleOrderReceivingEntryDTO objSaleOrderReceivingEntryDO = new PurelifeErpClient.SaleOrderReceivingEntryDTO();
                    objSaleOrderReceivingEntryDO.Id = Code;

                    objSaleOrderReceivingEntryDO.SNo = txtSNo.Text.ToInt();
                    // objSaleOrderReceivingEntryDO.ItemDescription = txtItemDescptn.Text.Trim();
                    objSaleOrderReceivingEntryDO.ItemDescription = GetInt(ddlItemDesb.SelectedValue);//txtItemDescptn.Text.Trim();
                    objSaleOrderReceivingEntryDO.Qty = txtQty.Text.ToFloat();
                    objSaleOrderReceivingEntryDO.Rate = txtRate.Text.ToFloat();
                    objSaleOrderReceivingEntryDO.Amount = txtAmount.Text.ToFloat();
                    // objSaleOrderReceivingEntryDO.Total = txtTotal.Text.ToFloat();



                    PurelifeErpClient.ERPDTOBase objERPDOBase = objSaleOrderReceivingEntryDO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.SaleOrderReceivingEntryDET, objERPDOBase);
                    purelifeErpClient.Close();
                }

                viewForm1.BindData1();

                if (Code > 0)
                {
                    ShowMessage("Updated successfully");
                    Close();
                }
                else
                {
                    ShowMessage("Saved successfully");
                    ResetControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        
        }
      
    }
}


////new SaleOrderReceivingEntryAdd(this, 0).ShowDialog();

//    DataTable dt;

//    if (Items == null)
//        dt = GetDataTable();
//    else
//        dt = Items;

//     BindingSource bs = new BindingSource();
//     bs.DataSource = grdSaleOrderReceivingEntry.DataSource;

//DataRow dr;
//dr["SNo"] = txtSNo.Text;
//dr["ItemDescription"] = txtItemDescptn.Text;
//dr["Qty"] = txtQty.Text;
//dr["Rate"] = txtRate.Text;
//dr["Amount"] = txtAmount.Text;