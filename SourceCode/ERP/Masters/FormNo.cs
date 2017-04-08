using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace ERP.SalePurchase
{
    public partial class FormNo : Global.BaseClass
    {
        public FormNo()
        {
            InitializeComponent();
        }
        #region private members
        private STFormView viewForm;
        Double Code = Double.MinValue;
        #endregion

        
        public FormNo(STFormView view)
        {
            viewForm = view;
            Code = 0.0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
        }

        /// <summary>
        /// open page in edit format existing record
        /// </summary>
        /// <param name="_accountMasterView"></param>
        /// <param name="_Code"></param>
        public FormNo(STFormView view, Double code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            this.Text = this.Text + " (Edit)";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(txtStateCity.Text))
                    //{ EP.SetError(txtName, Messages.Required); return; }
                    if (Code > 0)
                    {
                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Update STFormSetup Set FormName='{0}' Where FormCode={1}", txtFormName.Text.Trim(), Code));
                        MessageBox.Show(Messages.UpdateMsg);
                        this.Close();
                    }
                    else
                    {

                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Insert into STFormSetup( FormName) Values('{0}')", txtFormName.Text.Trim()));
                        MessageBox.Show(Messages.SaveMsg);
                    }

                viewForm.BindData();
                ResetControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void PageLoad(object sender, EventArgs e)
        {
            //SetButtons();


            if (!Code.Equals(0.0))
            {
                SetPageControlsValue();
            }

        }

        private void SetPageControlsValue()
        {
            try
            {
                 string sql = "Select * From STFormSetup Where FormCode  = " + Code;
                //DataTable details = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
                //if (details != null)
                //{
                //    txtFormName.Text = Convert.ToString(details.Rows[0]["fORMName"]);                  

                //}
            }
            catch (Exception Ex)
            {
                
              MessageBox.Show(Ex.Message);
            }
        }

        private void SetButtons()
        {
            //throw new NotImplementedException();
        }
        private void ResetControls()
        {
            txtFormName.Text = string.Empty;

        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
