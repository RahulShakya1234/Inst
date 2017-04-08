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
    public partial class NarrationAdd : Form
    {
       public NarrationAdd()
        {
            InitializeComponent();
        }

        #region private members
        private NarrationView viewForm;
        Double Code = Double.MinValue;
        private   NarrationView narrationView;
        private   int p;

       //public    NarrationAdd(NarrationView narrationView,int p)
       // {
       //     // TODO: Complete member initialization
       //     this.narrationView = narrationView;
       //     this.p = p;
       // }
        #endregion

        
        public NarrationAdd(NarrationView view)
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
        public NarrationAdd(NarrationView view, Double code)
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
                //if (string.IsNullOrEmpty(txtNarrationCity.Text))
                    //{ EP.SetError(txtName, Messages.Required); return; }
                    if (Code > 0)
                    {
                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Update NarrationMaster Set NarrationName='{0}' Where NarrationCode={1}", txtNarration.Text.Trim(), Code));
                        MessageBox.Show(Messages.UpdateMsg);
                        this.Close();
                    }
                    else
                    {

                        //OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, string.Format("Insert into NarrationMaster( NarrationName) Values('{0}')", txtNarration.Text.Trim()));
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
                 string sql = "Select * From NarrationMaster Where NarrationCode  = " + Code;
                //DataTable details = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
                //if (details != null)
                //{
                //    txtNarration.Text = Convert.ToString(details.Rows[0]["NarrationName"]);                  

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
            txtNarration.Text = string.Empty;

        }

        private void NarrationAdd_Load(object sender, EventArgs e)
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
