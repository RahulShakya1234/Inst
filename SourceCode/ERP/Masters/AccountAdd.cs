using System;

using Common;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
//using System.Drawing.Design;
//using System.Dynamic;
using WinControlLibrary;
using System.Collections.Generic;   
//using System.ServiceModel.Channels;
//using System.Drawing.Graphics;


namespace ERP.SalePurchase
{
    public partial class AccountAdd : Global.BaseClass
    {
        #region private members
        private AccountView viewForm;
        Double Code = Double.MinValue;
        string sql = string.Empty;

        //private ItemRateSetupAdd itemRateSetupAdd;
        private int p;
        //private ItemRateSetupView itemRateSetupView;
        #endregion

        public AccountAdd()
        {
            InitializeComponent();  

        }
        public AccountAdd(AccountView view)
        {
            viewForm = view;
            Code = 0.0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
            BindDropDown();
           // txtAccountType.Focus();
        }

        public AccountAdd(AccountView view, Double code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            if (code>0)
            {
            this.Text = this.Text + " (Edit)";    
            }
            else
            {
                this.Text = this.Text + " (Add)";    
            }

            BindDropDown();
           // txtAccountType.Focus();
        }

        //public AccountAdd(ItemRateSetupAdd itemRateSetupAdd, int p)
        //{
        //    // TODO: Complete member initialization
        //    this.itemRateSetupAdd = itemRateSetupAdd;
        //    Code = p;
        //    this.p = p;
        //    InitializeComponent();
        //}

        //public AccountAdd(ItemRateSetupView itemRateSetupView, int p)
        //{
        //    // TODO: Complete member initialization
        //    this.itemRateSetupView = itemRateSetupView;
        //    this.p = p;
        //}




        
        public void PageLoad(object sender, EventArgs e)
        {
            this.ActiveControl = txtAccountType;
          
            //BindDropDown();
            this.BackColor = Color.FromArgb(240, 248, 255);
           // txtAccountType.Focus();
            SetButtons();
            //ddlPrimaryGroup.BackColor = Color.Gray;
            //this.BackColor = Color.FromArgb(240, 248, 255);
            //SetButtons ();comboBox1.BackColor = Color.Aqua;
            //this.BackColor = System.Drawing.Color.AntiqueWhite;
           //var colorBlue = System.Drawing.Color.Blue;
          // var hexBlue = System.Drawing.ColorTranslator.ToHtml(colorBlue);
           //this.ForeColor = System.Drawing.Color.Black;
         
           //foreach (Control c in Controls)
           //{
           //    BTextBox tb = c as BTextBox;
           //    if (tb != null)
           //    {
           //        tb.BackColor = Color.Black;
           //    }
           //}

            //txtAccountType.Focus();
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }

        }
        private void BindDropDown()
        {
            //fill the account group combo
            FillCombo(ddlDrCr, 9);
            // FillCombo(ddlState, 11);    
            FillCombo(ddlSaleType, 10);
            FillCombo(ddlPurchaseType, 11);
            FillCombo(ddlAccountType, 12);
            FillCombo(ddlAdjBillWise, 1);
            FillCombo(ddlLockAcc, 1);   
            FillCombo(ddlTypeOfSupplier, 13);
            FillCombo(ddlActive, 1);
            FillCombo(ddlCustomerType, 14);
            FillCombo(ddlState, 18);
            FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup,"Please Select");

        }
        /// <summary>
        /// Sets the buttons BG
        /// </summary>
        /// 
        public void SetButtons()
        {
            btnSave.SetBackGroundImage();
            btnClose.SetBackGroundImage();
        }

        //public void SetPageControlsValue()
        //{

        //    try
        //    {
        //        string sql = "Select * From AccMas Where AccCode  = " + Code;
        //        DataTable details = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
        //        if (details != null)
        //        {
        //            txtAccountType.Text = Convert.ToString(details.Rows[0]["AccName"]);
        //            txtBalance.Text = Convert.ToString(details.Rows[0]["Balance"]);
        //            ddlState.SelectedValue = details.Rows[0]["State"].ToString();
        //            ddlSaleType.SelectedValue = details.Rows[0]["Saletype"].ToString();
        //            ddlPurchaseType.SelectedValue = details.Rows[0]["PurchaseType"].ToString();
        //            txtAddress1.Text = Convert.ToString(details.Rows[0]["Address1"]);
        //            txtAddress2.Text = Convert.ToString(details.Rows[0]["Address2"]);
        //            txtAddress3.Text = Convert.ToString(details.Rows[0]["Address3"]);
        //            txtAddress4.Text = Convert.ToString(details.Rows[0]["Address4"]);
        //            txtAddress5.Text = Convert.ToString(details.Rows[0]["Address5"]);
        //            txtMobileNo.Text = Convert.ToString(details.Rows[0]["MobileNo"]);
        //            txtEmail.Text = Convert.ToString(details.Rows[0]["Email"]);
        //            txtRegistration.Text = Convert.ToString(details.Rows[0]["Registration"]);
        //            txtPLACodeNo.Text = Convert.ToString(details.Rows[0]["PLACodeNo"]);
        //            txtCommodity.Text = Convert.ToString(details.Rows[0]["Commodity"]);
        //            txtRange.Text = Convert.ToString(details.Rows[0]["Range"]);
        //            txtDivision.Text = Convert.ToString(details.Rows[0]["Divivsion"]);
        //            txtCollactorate.Text = Convert.ToString(details.Rows[0]["Collactorate"]);
        //            txtPanNo.Text = Convert.ToString(details.Rows[0]["PanNo"]);
        //            txtCSTNo.Text = Convert.ToString(details.Rows[0]["CSTNo"]);
        //            txtCreditDays.Text = Convert.ToString(details.Rows[0]["Creditdays"]);
        //            ddlAdjBillWise.SelectedValue = (details.Rows[0]["AdjBillWise"]);
        //            txtECCNo.Text = Convert.ToString(details.Rows[0]["EccNo"]);
        //            txtSTNo.Text = Convert.ToString(details.Rows[0]["TinNo"]);
        //            txtTDSCategory.Text = (details.Rows[0]["TDSCategory"]).ToString();
        //            txtTDSRate.Text = (details.Rows[0]["TDSRate"]).ToString();
        //            ddlLockAcc.SelectedValue = (details.Rows[0]["LockAccount"]);
        //            txtModeofTransport.Text = Convert.ToString(details.Rows[0]["ModeOfTransport"]);
        //            txtNatureofPay.Text = Convert.ToString(details.Rows[0]["NatureOfPay"]);
        //            txtVenderCode.Text = Convert.ToString(details.Rows[0]["VendorCode"]);
        //            ddlTypeOfSupplier.SelectedValue = Convert.ToString(details.Rows[0]["SupplierCode"]);
        //            txtCountry.Text = Convert.ToString(details.Rows[0]["Country"]);
        //            txtDestination.Text = Convert.ToString(details.Rows[0]["Destination"]);
        //            txtFax.Text = Convert.ToString(details.Rows[0]["Fax"]);
        //            txtCodeNo.Text = Convert.ToString(details.Rows[0]["CodeNo"]);
        //            txtDiscount.Text = (details.Rows[0]["Discount"]).ToString();
        //            ddlCustomerType.SelectedValue = (details.Rows[0]["TypeOfCustomer"]);
        //            txtLocation.Text = Convert.ToString(details.Rows[0]["Location"]);
        //            txtIntrestRate.Text = (details.Rows[0]["InterestRate"]).ToString();
        //            ddlIsActive.SelectedValue = (details.Rows[0]["Active"]).ToString();

        //        }
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //}

        public void ResetControls()
        {
            txtAccountType.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtBalance.Text = string.Empty;
            txtCodeNo.Text = string.Empty;
            txtCollactorate.Text = string.Empty;
            txtCommodity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCreditDays.Text = string.Empty;
            txtCSTNo.Text = string.Empty;
            txtDestination.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtDivision.Text = string.Empty;
            txtECCNo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtIntrestRate.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtMobileNo.Text = string.Empty;
            txtModeofTransport.Text = string.Empty;
            txtNatureofPay.Text = string.Empty;
            txtPanNo.Text = string.Empty;
            txtPLACodeNo.Text = string.Empty;
            txtRange.Text = string.Empty;
            txtRegistration.Text = string.Empty;
            txtSTNo.Text = string.Empty;
            txtTDSCategory.Text = string.Empty;
            txtTDSRate.Text = string.Empty;
            txtVenderCode.Text = string.Empty;

            ddlPrimaryGroup.SelectedIndex = 0;
            ddlAccountType.SelectedIndex = 1;
            ddlDrCr.SelectedIndex = 0;
            ddlState.SelectedIndex = 0;
            ddlSaleType.SelectedIndex = 0;
            ddlPurchaseType.SelectedIndex = 0;
            ddlAdjBillWise.SelectedIndex = 0;
            ddlLockAcc.SelectedIndex = 0;
            ddlTypeOfSupplier.SelectedIndex = 0;
            ddlCustomerType.SelectedIndex = 0;
            ddlActive.SelectedIndex = 0;

           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // SaveClicked();
            try
            {
                if (CheckRequiredField(txtAccountType))
                {
                    return;
                }
                //if (CheckRequiredField(ddlAccountType))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlDrCr))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlActive))
                //{
                //    return;
                //}
                //if (CheckRequiredField( ddlAdjBillWise))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlCustomerType))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlLockAcc))
                //{
                //    return;
                //}
                if (CheckRequiredField(ddlPrimaryGroup))
                {
                    return;
                }
                //if (CheckRequiredField(ddlPurchaseType))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlSaleType))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlState))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlTypeOfSupplier))
                //{
                //    return;
                //}
               

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.AccountDTO objAccountDO = new PurelifeErpClient.AccountDTO();
                    objAccountDO.Id = Code.ToInt();

                    objAccountDO.Account = txtAccountType.Text.Trim();//AccountName
                    objAccountDO.GroupName = GetInt(ddlPrimaryGroup.SelectedValue);//AccountGroupMasId
                    objAccountDO.AccountType = GetInt(ddlAccountType.SelectedValue);
                    objAccountDO.Balance = GetInt(txtBalance.Text);
                    objAccountDO.DrCr = GetInt(ddlDrCr.SelectedValue);
                    objAccountDO.State = GetInt(ddlState.SelectedValue);
                    objAccountDO.SaleType = GetInt(ddlSaleType.SelectedValue);
                    objAccountDO.PurchaseType = GetInt(ddlPurchaseType.SelectedValue);

                    objAccountDO.Address = txtAddress1.Text;
                    objAccountDO.MobileNo = txtMobileNo.Text.ToInt();
                    objAccountDO.Email = txtEmail.Text.Trim();
                    objAccountDO.Registration = txtRegistration.Text.Trim();
                    objAccountDO.PLACodeNo = txtPLACodeNo.Text.Trim();
                    objAccountDO.Commodity = txtCommodity.Text.Trim();
                    objAccountDO.Range = txtRange.Text.Trim();
                    objAccountDO.Division = txtDivision.Text.Trim();
                    objAccountDO.Collactorate = txtCollactorate.Text.Trim();

                    objAccountDO.PanNo = txtPanNo.Text.Trim();
                    objAccountDO.CSTNo = txtCSTNo.Text.Trim();
                    objAccountDO.STNo = txtSTNo.Text.Trim();
                    objAccountDO.ECCNo = txtECCNo.Text.Trim();
                    objAccountDO.CreditDays = txtCreditDays.Text.Trim();
                    objAccountDO.AdjBillWise = ddlAdjBillWise.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.TDSRate = txtTDSRate.Text.Trim();

                    objAccountDO.TDSCategory = txtTDSCategory.Text.Trim();
                    objAccountDO.LockAcc = ddlLockAcc.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.ModeofTransport = txtModeofTransport.Text.Trim();
                    objAccountDO.NatureofPay = txtNatureofPay.Text.Trim();
                    objAccountDO.VenderCode = txtVenderCode.Text.Trim();
                    objAccountDO.TypeOfSupplier = GetInt(ddlTypeOfSupplier.SelectedValue);
                    objAccountDO.Country = txtCountry.Text.Trim();
                    objAccountDO.Destination = txtDestination.Text.Trim();

                    objAccountDO.Fax = txtFax.Text.Trim();
                    objAccountDO.CodeNo = txtCodeNo.Text.Trim();
                    objAccountDO.Discount = txtDiscount.Text.Trim();
                    objAccountDO.CustomerType = GetInt(ddlCustomerType.SelectedValue);
                    objAccountDO.Location = txtLocation.Text.Trim();
                    objAccountDO.IntrestRate = txtIntrestRate.Text.Trim();
                    objAccountDO.Active = ddlActive.SelectedValue.ToString() == "0" ? false : true;


                    PurelifeErpClient.ERPDTOBase objERPDOBase = objAccountDO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.Account, objERPDOBase);
                    purelifeErpClient.Close();
                }

                viewForm.BindData();

                if (Code > 0)
                {
                    ShowMessage("Updated successfully");
                    viewForm.BindDropDown();
                    Close();
                }
                else
                {   
                    ShowMessage("Saved successfully");
                    ResetControls();
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        
        internal static Form Instance()
        {
            throw new NotImplementedException();
        }

       
        private void tzbGeneralInfo_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(240, 248, 255);



    }

        private void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabOtherInfo_Click(object sender, EventArgs e)
        {
           //this.BackColor = Color.FromArgb(240, 248, 255);
        }
        

       

    }
}




