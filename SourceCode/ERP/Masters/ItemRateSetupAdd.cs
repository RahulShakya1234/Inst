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
    public partial class ItemRateSetupAdd : Global.BaseClass
    {
        private ItemRateSetupView itemRateSetupView;
        private int p;

         #region private members
        private ItemRateSetupView viewForm;
        Double Code = Double.MinValue;
        string sql = string.Empty;
        #endregion

        public ItemRateSetupAdd()
        {
            InitializeComponent();
        }

        public ItemRateSetupAdd(ItemRateSetupView view)
        {
            viewForm = view;
            Code = 0.0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
        }

        public ItemRateSetupAdd(ItemRateSetupView view, Double code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            this.Text = this.Text + " (Edit)";
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClicked();           
        }

        private void SaveClicked()
        {
            try
            {
                //if (string.IsNullOrEmpty(txtGrpName.Text))
                //{ EP.SetError(txtGrpName, Messages.Required); return; }
                if (Code > 0)
                {
                    sql = " Update ItemRateMaster        Set " +
                      " AccCode              = " + Convert.ToInt32(ddlPartyName.SelectedValue) + "," +
                      " ItemCode             = " + Convert.ToInt32(ddlItemName.SelectedValue) + "," +
                      " ICode                = " + Convert.ToInt32(txtCode.Text.Trim()) + "," +
                      " IRate                = " + Convert.ToDouble(txtRate.Text.Trim()) + "," +
                      " PackingRate          = " + Convert.ToDouble(txtPackingRate.Text.Trim()) + "," +    
                      " PoNo                 = '" + Convert.ToString(txtPoNo.Text.Trim()) + "'," +
                      " PoDate               = '" + Convert.ToString(txtPODate.Text.Trim()) + "'," +
                      " AmendmentNo          = '" + Convert.ToString(txtAmendmentNo.Text.Trim()) + "'," +
                      " AmendmentDate        = '" + Convert.ToString(txtAmendmentDate.Text.Trim()) + "'," +
                      " PartNo               = '" + Convert.ToString(txtPartNo.Text.Trim()) + "'," +
                      " ToolSuppForQty       = '" + Convert.ToString(txtToolSuppyForQty.Text.Trim()) + "'," +
                      " ToolRate             = "  + Convert.ToDouble(txtToolRate.Text.Trim()) + "," +
                      " Tax                  = "  + Convert.ToDouble(txtTax.Text.Trim()) + "," +
                      " ToolNarr             = '" + Convert.ToString(txtToolNarr.Text.Trim()) + "'," +
                      " ProcessName          = '" + Convert.ToString(txtProcessName.Text.Trim()) + "'" +                      
                      " where ItemRateCode = " + Code;
                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, sql);
                        MessageBox.Show(Messages.UpdateMsg);
                        this.Close();
                }

                else
                {

                    sql = " Insert into ItemRateMaster(AccCode,ItemCode,ICode,IRate,PackingRate,PoNo,PoDate,AmendmentNo,AmendmentDate,PartNo,ToolSuppForQty,ToolRate,Tax,ToolNarr,ProcessName) " +
                     " Values (" + Convert.ToInt32(ddlPartyName.SelectedValue) + "," + Convert.ToInt32(ddlItemName.SelectedValue) + "," + Convert.ToInt32(txtCode.Text.Trim()) + 
                              "," + Convert.ToDouble(txtRate.Text.Trim()) + "," + Convert.ToDouble(txtPackingRate.Text.Trim()) + ",'" + Convert.ToString(txtPoNo.Text.Trim()) + "','" + Convert.ToString(txtPODate.Text.Trim()) +
                             "','" + Convert.ToString(txtAmendmentNo.Text.Trim()) + "','" + Convert.ToString(txtAmendmentDate.Text.Trim()) + "','" + Convert.ToString(txtPartNo.Text.Trim()) +
                             "','" + Convert.ToString(txtToolSuppyForQty.Text.Trim()) + "'," + Convert.ToDouble(txtToolRate.Text.Trim()) + "," + Convert.ToDouble(txtTax.Text.Trim()) +
                             ",'" + Convert.ToString(txtToolNarr.Text.Trim()) + "','" + Convert.ToString(txtProcessName.Text.Trim()) + "'  ) ";

                    //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, sql);
                    MessageBox.Show("Saved Successfully");
                    viewForm.BindData();
                    ResetControls();

                   
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetControls()
        {
         

        }

     
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPartyNames_Click(object sender, EventArgs e)
        {
            //new AccountAdd(this, 0).ShowDialog();
        }

        private void btnItemNames_Click(object sender, EventArgs e)
        {
            //new ItemsAdd(this, 0).ShowDialog();
        }

        private void ItemRateSetupAdd_Load(object sender, EventArgs e)
        {
            SetButtons();
            BindDropDown();

            if (!Code.Equals(0.0))
            {
                //SetPageControlsValue();
            }
        }

        //private void SetPageControlsValue()
        //{
        //    try
        //    {
        //        string sql = "Select * From ItemRateMaster Where ItemRateCode  = " + Code;
        //        DataTable details = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
        //        if (details != null)
        //        {                           
        //              ddlPartyName.SelectedValue=(details.Rows[0]["AccCode"]);
        //              ddlItemName.SelectedValue=(details.Rows[0]["ItemCode"]);
        //              txtCode.Text=Convert.ToString(details.Rows[0]["ICode"]);
        //              txtRate.Text=Convert.ToString(details.Rows[0]["IRate"]);
        //              txtPackingRate.Text=Convert.ToString(details.Rows[0]["PackingRate"]);
        //              txtPoNo.Text=Convert.ToString(details.Rows[0]["PoNo"]);
        //              txtPODate.Text=Convert.ToString(details.Rows[0]["PODate"]);
        //              txtAmendmentNo.Text=Convert.ToString(details.Rows[0]["AmendmentNo"]);
        //              txtAmendmentDate.Text=Convert.ToString(details.Rows[0]["AmendmentDate"]);
        //              txtPartNo.Text=Convert.ToString(details.Rows[0]["PartNo"]);
        //              txtToolSuppyForQty.Text=Convert.ToString(details.Rows[0]["ToolSuppForQty"]);
        //              txtToolRate.Text=Convert.ToString(details.Rows[0]["ToolRate"]);
        //              txtTax.Text=Convert.ToString(details.Rows[0]["Tax"]);
        //              txtToolNarr.Text=Convert.ToString(details.Rows[0]["ToolNarr"]);
        //              txtProcessName.Text=Convert.ToString(details.Rows[0]["ProcessName"]);                                                                                                                       
                                          

        //        }
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //}

        private void BindDropDown()
        {
            //FillCombo(ddlPartyName, "AccMas", "AccCode", "AccName");
            //FillCombo(ddlItemName, "Itemsadd", "ID", "DisplayName");
        }

        private void SetButtons()
        {
            //throw new NotImplementedException();
        }

        private void ddlItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Sql = "Select * from Itemsadd where Id = " + Convert.ToInt32(ddlItemName.SelectedValue);
            
            //DataSet Ds = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, Sql);
            //if (Ds.Tables[0].Rows.Count>0)
            //{
            //    txtCode.Text = Ds.Tables[0].Rows[0]["ItemCode"].ToString();
            //    txtRate.Text = Ds.Tables[0].Rows[0]["StateRate"].ToString();
            //}
            //else
            //{
            //    int Q=0;
            //    txtCode.Text =Q.ToString() ;
            //    txtRate.Text = Q.ToString();
            //}
        }

       
    }
}
