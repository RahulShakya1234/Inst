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
    public partial class Location : Global.BaseClass
    {
        #region private members
        private LocationView viewForm;
        int Code = 0;
        string sql = string.Empty;
        #endregion
        public Location()
        {
            InitializeComponent();
        }
        public Location(LocationView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
           // BindDropDown();
            this.Text = this.Text + " (Add)";
        }

        public Location(LocationView view, int code)
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
                if (CheckRequiredField(txtLocation))
                {
                    return;
                }


                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.LocationDTO objUMODO = new PurelifeErpClient.LocationDTO();
                    objUMODO.Id = Code;
                    objUMODO.Location = txtLocation.Text.Trim();
                    PurelifeErpClient.ERPDTOBase objERPDOBase = objUMODO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.Location, objERPDOBase);
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
            txtLocation.Text = string.Empty;
        }

        private void Location_Load(object sender, System.EventArgs e)
        {
            this.ActiveControl = txtLocation;

            if (Code > 0)
            {
                btnSave.Text = "Update";
            }
        }

    }
}
