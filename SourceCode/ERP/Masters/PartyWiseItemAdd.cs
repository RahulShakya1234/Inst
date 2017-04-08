using System;

using Common;
using System.Data;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class PartyWiseItemAdd : Global.BaseClass
    {
        int Code = 0;
        private PartyWiseItemRateList viewForm;
        // private PartyWiseItemRateList partyWiseItemRateList;
        // private double codeValue;
        public PartyWiseItemAdd()
        {
            InitializeComponent();
        }
        private static PartyWiseItemAdd sForm = null;
        public static PartyWiseItemAdd Instance()
        {

            if (sForm == null) { sForm = new PartyWiseItemAdd(); }
            return sForm;

        }
        public PartyWiseItemAdd(PartyWiseItemRateList view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
            BindDropDown();
            this.Text = this.Text + " (Add)";
        }

        public PartyWiseItemAdd(PartyWiseItemRateList view, int code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            BindDropDown();
            this.Text = this.Text + " (Edit)";
        }
        private void BindDropDown()
        {
            //fill the account group combo

            FillCombo(ddlGroupName, Common.Masters.AccountGroup,"Please Select");

        }
        //public PartyWiseItemAdd(PartyWiseItemRateList partyWiseItemRateList, double codeValue)
        //{
        //    // TODO: Complete member initialization
        //    this.partyWiseItemRateList = partyWiseItemRateList;
        //    this.codeValue = codeValue;
        //}

        private void lblPONo_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartyWiseItemListView_Load(object sender, EventArgs e)
        {
            BindDropDown();

            this.ActiveControl = ddlGroupName;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(ddlGroupName))
                {
                    return;
                }


                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.PartyWiseItemRateDTO objPartyWiseItemRateDO = new PurelifeErpClient.PartyWiseItemRateDTO();
                    objPartyWiseItemRateDO.Id = Code;

                    // objPartyWiseItemRateDO.PartyName       =    txtPartyName.Text.Trim();
                    objPartyWiseItemRateDO.PartyName = GetInt(ddlGroupName.SelectedValue);
                    //addForm.ddlGroupName.SelectedValue = grdAccountDetails.Rows[rowIndex].Cells["AccountGroupMasId"].Value.ToString();
                    objPartyWiseItemRateDO.ItemName = txtItemName.Text.Trim();
                    objPartyWiseItemRateDO.ItemCode = txtItemCode.Text.ToFloat();
                    objPartyWiseItemRateDO.PackingRate = txtItemRate.Text.ToFloat();
                    objPartyWiseItemRateDO.PONo = txtPONo.Text.Trim();
                    objPartyWiseItemRateDO.AmendmentNo = txtAmendmentNo.Text.ToInt();
                    objPartyWiseItemRateDO.PODate = txtPOdate.Text.ToDateTime();
                    objPartyWiseItemRateDO.AmendmentDate = txtAmendmentDate.Text.ToDateTime();
                    objPartyWiseItemRateDO.PartNo = txtPartno.Text.Trim();
                    objPartyWiseItemRateDO.ToolSupplyForQty = txtToolSupply.Text.ToFloat();
                    objPartyWiseItemRateDO.ToolRate = txtToolRate.Text.ToFloat();
                    objPartyWiseItemRateDO.Tax = txtTax.Text.ToFloat();
                    objPartyWiseItemRateDO.ToolNarr = txtToolNarr.Text.Trim();
                    objPartyWiseItemRateDO.ProcessName = txtProcessName.Text.Trim();

                    PurelifeErpClient.ERPDTOBase objERPDOBase = objPartyWiseItemRateDO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.PartyWiseItemRate, objERPDOBase);
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
            // txtPartyName.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            txtItemRate.Text = string.Empty;
            txtPONo.Text = string.Empty;
            txtAmendmentNo.Text = string.Empty;
            txtAmendmentDate.Text = string.Empty;
            txtPartno.Text = string.Empty;
            txtProcessName.Text = string.Empty;
            txtToolNarr.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtToolRate.Text = string.Empty;
            txtToolSupply.Text = string.Empty;
            txtPOdate.Text = string.Empty;





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ddlGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPartyName_Click(object sender, EventArgs e)
        {
            AccountAdd sForm = new AccountAdd();
            sForm.Show();
        }

        private void btnItemName_Click(object sender, EventArgs e)
        {
            ItemGroupAdd sForm = new ItemGroupAdd();
            sForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        //private void btnSave_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnSave_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{

        //}
    }
}
