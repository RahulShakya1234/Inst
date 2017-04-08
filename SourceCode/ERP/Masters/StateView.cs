using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;

using Common;

namespace ERP.SalePurchase
{
    public partial class StateView : Global.BaseClass
    
    {
        int SelectedRow = 0;
        
        public StateView()
        
        {
            InitializeComponent();
        }


        #region private members
        private StateView viewForm;
        Double Code = Double.MinValue;
        string sql = string.Empty;
        #endregion

        private void StateView_Load(object sender, EventArgs e)
        
        {
            //SetButtons();
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        
        {
            //new StateAdd(this, 0).ShowDialog();
            new StateAdd(this, 0).ShowDialog();
        }

        public void BindData()
        {
            String SQL = string.Empty;

            SQL = " Select StateCode,StateName from StateMas";

            //grdStateDetails.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, SQL).Tables[0];
            //new DgvFilterManager(grdStateDetails);
        }


        private static StateView sForm = null;
        public static StateView Instance()
        
        {
        
            if (sForm == null) { sForm = new StateView(); }
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
            SelectedRow = grdStateDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdStateDetails.Rows[SelectedRow].Cells["StateCode"].Value);
            DeleteMaster(codeValue);
        }
        
        private void DeleteMaster(Double codeValue)
        
        {
            try
            {

                //base.Delete("StateMas", "StateCode", codeValue.ToString());

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
                StateAdd addForm = new StateAdd(this, codeValue);
                addForm.ShowDialog();
            }

            catch (Exception exception)
            
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
            }

        }
        
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        
        {
            SelectedRow = grdStateDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdStateDetails.Rows[SelectedRow].Cells["StateCode"].Value);
            EditMaster(SelectedRow, codeValue);
        }

        
    }
}
