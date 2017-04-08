using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;
using DgvFilterPopup;

namespace ERP.SalePurchase
{
    public partial class STFormSetup : Global.BaseClass
    {
      int SelectedRow = 0;

      public STFormSetup()
        
        {
            InitializeComponent();
        }

        #region private members
        private STFormSetup viewForm;
        Double Code = Double.MinValue;
        string sql = string.Empty;
        #endregion

        private void STFormSetup_Load(object sender, EventArgs e)
        
        {
            //SetButtons();
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        
        {
            //new StateAdd(this, 0).ShowDialog();
            //new FormNo(this, 0).ShowDialog();
        }

        public void BindData()
        {
            String SQL = string.Empty;

            SQL = " Select FormCode,FormName from STFormSetup";

            //grdFormNoDetails.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, SQL).Tables[0];
            new DgvFilterManager(grdFormNoDetails);
        }


        private static STFormSetup sForm = null;
        public static Form Instance()
        
        {

            if (sForm == null) { sForm = new STFormSetup(); }
            return sForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        
        {
            this.Close();
        }

        #region Delete

        /// <summary>
        /// Delete the master for the respective table
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        
        {
            SelectedRow = grdFormNoDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdFormNoDetails.Rows[SelectedRow].Cells["FormCode"].Value);
            DeleteMaster(codeValue);
        }
        
        private void DeleteMaster(Double codeValue)
      
        {
            try
            {

                //base.Delete("STFormSetup", "FormCode", codeValue.ToString());

                BindData();

            }

            catch (Exception exception)
            
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
            }

        }

        #endregion

        #region Edit Master

        /// <summary>
        /// Edit Master
        /// </summary>
        /// <param name="rowIndex"></param>
        
        private void EditMaster(int rowIndex, double codeValue)
        
        {
            try
        
            {
                //FormNo addForm = new FormNo(this, codeValue);
                //addForm.ShowDialog();
            }

            catch (Exception exception)
            
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
            }

        }
        
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        
        {
            SelectedRow = grdFormNoDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdFormNoDetails.Rows[SelectedRow].Cells["FormCode"].Value);
            EditMaster(SelectedRow, codeValue);
        }        
    }
}
