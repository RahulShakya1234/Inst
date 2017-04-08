using System;

using Common;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace ERP.SalePurchase
{
    public partial class AccountGroupAdd : Global.BaseClass
    {
        #region private members
        private AccountGroupView viewForm;
        int Code = 0;
        string sql = string.Empty;
        #endregion

        public AccountGroupAdd()
        {
            InitializeComponent();
        }

        public AccountGroupAdd(AccountGroupView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
            BindDropDown();
            this.Text = this.Text + " (Add)";
        }

        public AccountGroupAdd(AccountGroupView view, int code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            BindDropDown();
            if (code > 0)
            {
                this.Text = this.Text + " (Edit)";
            }
            else
            {
                this.Text = this.Text + " (Add)";
            }
        }

        private void BindDropDown()
        {
            //fill the account group combo
            FillCombo(ddlPrintSummaryTrialBal, 1);
            FillCombo(ddlBType, 3);
            FillCombo(ddlType, 9);

            FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup, "Please Select");
          
        }
        private void SetButtons()
        {
            btnSave.SetBackGroundImage();
            btnClose.SetBackGroundImage();
        }
        /// <summary>
        /// save button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(txtGrpName))
                {
                    return;
                }
                if (CheckRequiredField(ddlPrimaryGroup))
                {
                    return;
                }

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.AccountGroupDTO objAccountGroupDO = new PurelifeErpClient.AccountGroupDTO();
                    objAccountGroupDO.Id = Code;

                    objAccountGroupDO.AccountGroupName = txtGrpName.Text.Trim();
                    objAccountGroupDO.PrimaryAccountGroup = GetInt(ddlPrimaryGroup.SelectedValue);
                    objAccountGroupDO.RefrenceNo = GetInt(txtReferenceNumber.Text);
                    objAccountGroupDO.BType = Convert.ToChar(ddlBType.SelectedValue);
                    objAccountGroupDO.GType = GetInt(ddlType.SelectedValue);
                    objAccountGroupDO.PrintSummaryTrialBalType = GetInt(ddlPrintSummaryTrialBal.SelectedValue);
                   
                    PurelifeErpClient.ERPDTOBase objERPDOBase = objAccountGroupDO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.AccountGroup, objERPDOBase);
                    viewForm.BindDropDown();
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
                    //viewForm.BindDropDown();
                    ResetControls();
                    //viewForm.BindDropDown();
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        private void ResetControls()
        {
            txtGrpName.Text = string.Empty;
            txtReferenceNumber.Text = string.Empty;
            ddlBType.SelectedIndex = 0;
            ddlPrimaryGroup.SelectedIndex = 0;
            ddlType.SelectedIndex = 0;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

   
        private void AccountGroupMasterAdd_Load(object sender, EventArgs e)
        {
            SetButtons();
            this.ActiveControl = txtGrpName;
          //  txtGrpName.Focus();
            
            this.BackColor = Color.FromArgb(240, 248, 255);
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }
            txtGrpName.Focus();
            //if (ddlPrimaryGroup.SelectedValue.ToInt() <34)
            //{
            //    ddlPrimaryGroup.Enabled = true;
            //}
            //else
            //{
            //    ddlPrimaryGroup.Enabled = false;
            //}
        }

        private void ddlPrimaryGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bLabel5_Click(object sender, EventArgs e)
        {


        }
    }
}
