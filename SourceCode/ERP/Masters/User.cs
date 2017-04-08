using System;

using Common;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;
using ERP.SalePurchase;
using System.Drawing;
using System.Collections.Generic;


namespace ERP.Masters
{
    public partial class User : Global.BaseClass
    {
        private UserView viewForm;
        int SelectedRow = 0;
        int Code = 0;
        int Code2 = 0;
        string sql = string.Empty;
        public User()
        {
            InitializeComponent();
        }

        public User(UserView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
        
            BindDropDown();
        }

        public User(UserView view, int code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            if (code > 0)
            {
                this.Text = this.Text + " (Edit)";
                btnSave.Text = "Update";
            }
            else
            {
                this.Text = this.Text + " (Add)";
            }
            BindDropDown();
        }
        private void BindDropDown()
        {
            FillCombo(ddlGender, 22);

            FillCombo(ddlDept, Common.Masters.Department);
            FillCombo(ddlLocation, Common.Masters.Location);
            FillCombo(ddlDesig, Common.Masters.Designation);
            FillCombo(ddlSoftwareRole, Common.Masters.SoftwareRole);
        }

        private void User_Load(object sender, EventArgs e)
        {
            // BindDropDown();
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }

            this.ActiveControl = txtUserName;
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);

        }

        private void txtPlatingRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(txtUserName))
                {
                    return;
                }

                if (CheckRequiredField(txtPassword))
                {
                    return;
                }
                //if (CheckRequiredField(ddlDept))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlDesig))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlLocation))
                //{
                //    return;
                //}

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.UserDetailsDTO objPurchaseBillDOMST = new PurelifeErpClient.UserDetailsDTO();

                    objPurchaseBillDOMST.Id = Code;

                    objPurchaseBillDOMST.UserName = txtUserName.Text.Trim();
                    objPurchaseBillDOMST.Password = txtPassword.Text.Trim();
                    objPurchaseBillDOMST.Gender = GetInt(ddlGender.SelectedValue);


                    objPurchaseBillDOMST.DOB = txtDOB.Text.ToDateTime();
                    objPurchaseBillDOMST.DOJ = txtDOJ.Text.ToDateTime();
                    objPurchaseBillDOMST.DOL = txtDOL.Text.ToDateTime();
                    objPurchaseBillDOMST.Password = txtPassword.Text.Trim();
                    objPurchaseBillDOMST.SoftwareRole = GetInt(ddlSoftwareRole.SelectedValue);
                    objPurchaseBillDOMST.Department = GetInt(ddlDept.SelectedValue);
                    objPurchaseBillDOMST.Designation = GetInt(ddlDesig.SelectedValue);
                    objPurchaseBillDOMST.Location = GetInt(ddlLocation.SelectedValue);
                    PurelifeErpClient.ERPDTOBase objERPDOBase = objPurchaseBillDOMST as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.UserDetails, objERPDOBase);
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

            catch (Exception exception)
            {
                throw exception;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void ResetControls()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtDOJ.Text = string.Empty;
            txtDOL.Text = string.Empty;
            ddlGender.SelectedIndex = 0;
            ddlDept.SelectedIndex = 0;
            ddlDesig.SelectedIndex = 0;
            ddlSoftwareRole.SelectedIndex = 0;
            ddlLocation.SelectedIndex = 0;
        }


    }
}