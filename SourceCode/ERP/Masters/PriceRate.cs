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
    public partial class PriceRate : Form
    {
        private PriceListView priceListView;
       
        
        #region private members
        private PriceListView viewForm;
        Double Code = Double.MinValue;
        #endregion

        public PriceRate(PriceListView view)
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
        public PriceRate(PriceListView view, Double code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            this.Text = this.Text + " (Edit)";
        }

        public PriceRate()
        {
            InitializeComponent();
        }

        //public PriceRate(PriceRateView PriceRateView)
        //{
        //    // TODO: Complete member initialization
        //    this.PriceRateView = PriceRateView;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(txtStateCity.Text))
                //{ EP.SetError(txtName, Messages.Required); return; }
                if (Code > 0)
                {
                    //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Update PriceRateMaster Set PriceRateName='{0}' Where  PriceRateCode={1}", txtPriceListName.Text.Trim(), Code));
                    MessageBox.Show(Messages.UpdateMsg);
                    this.Close();
                }
                else
                {

                    //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Insert into PriceRateMaster( PriceRateName) Values('{0}')", txtPriceListName.Text.Trim()));
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

      

        private void SetPageControlsValue()
        {
            try
            {
                string sql = "SELECT * FROM PriceRateMaster WHERE PriceRateCode  = " + Code;
                ////DataTable details = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
                //if (details != null)
                //{
                //    txtPriceListName.Text = Convert.ToString(details.Rows[0]["PriceRateName"]);

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
            txtPriceListName.Text = string.Empty;

        }       

        private void PriceRate_Load(object sender, EventArgs e)
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
