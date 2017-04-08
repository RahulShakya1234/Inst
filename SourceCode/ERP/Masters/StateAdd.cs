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
    public partial class StateAdd : Form
    {
        public StateAdd()
        {
            InitializeComponent();
        }
        #region private members
        private StateView viewForm;
        Double Code = Double.MinValue;
        #endregion

        
        public StateAdd(StateView view)
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
        public StateAdd(StateView view, Double code)
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
                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Update StateMas Set StateName='{0}' Where StateCode={1}", txtStateCity.Text.Trim(), Code));
                        MessageBox.Show(Messages.UpdateMsg);
                        this.Close();
                    }
                    else
                    {

                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Insert into StateMas( StateName) Values('{0}')", txtStateCity.Text.Trim()));
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
                 string sql = "Select * From StateMas Where StateCode  = " + Code;
                //DataTable details = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
                //if (details != null)
                //{
                //    txtStateCity.Text = Convert.ToString(details.Rows[0]["StateName"]);                  

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
            txtStateCity.Text = string.Empty;

        }

        private void StateAdd_Load(object sender, EventArgs e)
        {
           
            if (!Code.Equals(0.0))
            {
                SetPageControlsValue();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
