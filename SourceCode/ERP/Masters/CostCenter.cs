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
    public partial class CostCenter : Form
    {
        private CostCenterView costCenterView;
       
        
        #region private members
        private CostCenterView viewForm;
        Double Code = Double.MinValue;
        #endregion
        
        public CostCenter(CostCenterView view)
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
        /// 
        public CostCenter(CostCenterView view, Double code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            this.Text = this.Text + " (Edit)";
        }

        public CostCenter()
        {
            InitializeComponent();
        }

        //public CostCenter(CostCenterView costCenterView)
        //{
        //    // TODO: Complete member initialization
        //    this.costCenterView = costCenterView;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(txtStateCity.Text))
                //{ EP.SetError(txtName, Messages.Required); return; }
                if (Code > 0)
                {
                    //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Update CostCenterMaster Set CostCenterName='{0}' Where  CostCenterCode={1}", txCostCenterName.Text.Trim(), Code));
                    MessageBox.Show(Messages.UpdateMsg);
                    this.Close();
                }
                else
                {

                    //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Insert into CostCenterMaster( CostCenterName) Values('{0}')", txCostCenterName.Text.Trim()));
                    MessageBox.Show(Messages.SaveMsg);
                }

                //viewForm.BindData();
                ResetControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void SetPageControlsValue()
        {
            try
            {
                string sql = "SELECT * FROM CostCenterMaster WHERE CostCenterCode  = " + Code;
                //DataTable details = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
                //if (details != null)
                //{
                //    txCostCenterName.Text = Convert.ToString(details.Rows[0]["CostCenterName"]);

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
            txCostCenterName.Text = string.Empty;

        }       

        private void CostCenter_Load(object sender, EventArgs e)
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
