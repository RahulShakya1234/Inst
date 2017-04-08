using System;

using Common;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;

using System.Drawing;
using System.Collections.Generic;

namespace ERP.Masters
{
    public partial class UMOAdd : Global.BaseClass
    {
        #region private members
        private UOMView viewForm;
        int Code = 0;
        string sql = string.Empty;
        #endregion


        public UMOAdd()
        {
            InitializeComponent();
        }

         public UMOAdd(UOMView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
           // BindDropDown();
            this.Text = this.Text + " (Add)";
        }

         public UMOAdd(UOMView view, int code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            //BindDropDown();
            if (code > 0)
            {
                this.Text = this.Text + " (Edit)";
            }
            else
            {
                this.Text = this.Text + " (Add)";
            }
        }

        private void UMO_Load(object sender, EventArgs e)
        {

            this.ActiveControl = txtUMOName;
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(txtUMOName))
                {
                    return;
                }


                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.UMODTO objUMODO = new PurelifeErpClient.UMODTO();
                    objUMODO.Id = Code;
                    objUMODO.Name = txtUMOName.Text.Trim();
                    PurelifeErpClient.ERPDTOBase objERPDOBase = objUMODO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.UMO, objERPDOBase);
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
        public void ResetControls()
        {

            txtUMOName.Text = string.Empty;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBillNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUMOName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

