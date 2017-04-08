using System;
using System.Data;
using System.Windows.Forms;

using Common;

namespace ERP.SalePurchase
{
    public partial class TariffAdd : Form
    {
         public TariffAdd()
        {
            InitializeComponent();
        }
        #region private members
        private TariffView viewForm;
        Double Code = Double.MinValue;
        #endregion

        
        public TariffAdd(TariffView view)
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
        public TariffAdd(TariffView view, Double code)
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
                    int CodeAcc=100;

                    if (Code > 0)
                    {
                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Update Rt12Mas Set Heading='{0}', Tariff='{1}',Unit='{2}',PrintRt={3},AccCode={4},ShowInER1={5} Where RTCode={6}", txtHeading.Text.Trim(),txtTariff.Text.Trim(),txtUnit.Text.Trim(),CodeAcc,Convert.ToInt32(ddlPrint.SelectedValue),Convert.ToInt32(ddlShowInER1.SelectedValue), Code));
                        MessageBox.Show(Messages.UpdateMsg);                                                            
                        this.Close();                                                                                   
                    }                                                                                                   
                    else                                                                                            
                    {
                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Insert into Rt12Mas( Heading,Tariff,Unit,AccCode,PrintRt,ShowInER1) Values('{0}','{1}','{2}',{3},{4},{5})",txtHeading.Text.Trim(), txtTariff.Text.Trim(), txtUnit.Text.Trim(),CodeAcc, Convert.ToInt32(ddlPrint.SelectedValue), Convert.ToInt32(ddlShowInER1.SelectedValue)));
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
                string sql = "Select * From Rt12Mas Where RTCode  = " + Code;
                //DataTable details = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
                //if (details != null)
                //{
                //    //txtStateCity.Text = Convert.ToString(details.Rows[0]["StateName"]);    
                //    txtRTCode.Text = Convert.ToString(details.Rows[0]["RTCode"]);
                //      txtHeading.Text=Convert.ToString(details.Rows[0]["Heading"]);
                //      txtTariff.Text=Convert.ToString(details.Rows[0]["Tariff"]);
                //      txtUnit.Text=Convert.ToString(details.Rows[0]["Unit"]);
                //      ddlPrint.SelectedValue = Convert.ToUInt32(details.Rows[0]["PrintRt"]); 
                //      ddlShowInER1.SelectedValue=Convert.ToInt32(details.Rows[0]["ShowInER1"]);
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
            //txtStateCity.Text = string.Empty;

        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
