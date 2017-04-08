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
    public partial class Designation : Global.BaseClass
    {
        #region private members
        private DesigView viewForm;
        int Code = 0;
        string sql = string.Empty;
        #endregion

        public Designation()
        {
            InitializeComponent();
        }

        public Designation(DesigView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
           // BindDropDown();
            this.Text = this.Text + " (Add)";
        }

           public Designation(DesigView view, int code)
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
                if (CheckRequiredField(txtDesig))
                {
                    return;
                }


                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.DesignationDTO objUMODO = new PurelifeErpClient.DesignationDTO();
                    objUMODO.Id = Code;
                    objUMODO.Designation = txtDesig.Text.Trim();
                    PurelifeErpClient.ERPDTOBase objERPDOBase = objUMODO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.Desig, objERPDOBase);
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

        private void Designation_Load(object sender, System.EventArgs e)
        {

            this.ActiveControl = txtDesig;
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }
        }

        public void ResetControls()
        {
            txtDesig.Text = string.Empty;
    
        }
    }
}
