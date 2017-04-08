using System;

using Common;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;

using System.Drawing;
using System.Collections.Generic;
namespace ERP.Masters
{
    public partial class SoftwareRoleAdd :Global.BaseClass
    {
        #region private members
        private SoftwareRoleView viewForm;
        int Code = 0;
        string sql = string.Empty;
        #endregion
        public SoftwareRoleAdd()
        {
            InitializeComponent();
        }

         public SoftwareRoleAdd(SoftwareRoleView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
           // BindDropDown();
            this.Text = this.Text + " (Add)";
        }

         public SoftwareRoleAdd(SoftwareRoleView view, int code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            //BindDropDown();
            this.Text = this.Text + " (Edit)";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(txtSoftwareRole))
                {
                    return;
                }


                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.SoftwareRoleDTO objUMODO = new PurelifeErpClient.SoftwareRoleDTO();
                    objUMODO.Id = Code;
                    objUMODO.SoftwareRole = txtSoftwareRole.Text.Trim();
                    PurelifeErpClient.ERPDTOBase objERPDOBase = objUMODO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.SoftwareRole, objERPDOBase);
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
            txtSoftwareRole.Text = string.Empty;
        
        }
    }
}
