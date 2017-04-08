using System;
using System;

using Common;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;

using System.Drawing;
using System.Collections.Generic;
namespace ERP.Masters
{
    public partial class Department : Global.BaseClass
    {
        #region private members
        private DeptView viewForm;
        int Code = 0;
        string sql = string.Empty;
        #endregion

        public Department()
        {
            InitializeComponent();
        }

        public Department(DeptView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
           // BindDropDown();
            
        }

        public Department(DeptView view, int code)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(txtDept))
                {
                    return;
                }


                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.DeptDTO objUMODO = new PurelifeErpClient.DeptDTO();
                    objUMODO.Id = Code;
                    objUMODO.Dept = txtDept.Text.Trim();
                    PurelifeErpClient.ERPDTOBase objERPDOBase = objUMODO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.Dept, objERPDOBase);
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

        private void txtDept_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }


        public void ResetControls()
        {
            txtDept.Text = string.Empty;
        }
        private void Department_Load(object sender, System.EventArgs e)
        {

        }

        private void Department_Load_1(object sender, System.EventArgs e)
        {
            this.ActiveControl = txtDept;
        }
    }
}
