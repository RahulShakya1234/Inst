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
    public partial class CostCenterView : Global.BaseClass
    {
        public CostCenterView()
        {
            InitializeComponent();
        }
        int SelectedRow = 0;
         


        private void btnAdd_Click(object sender, EventArgs e)
        {
            new CostCenter(this, 0).ShowDialog();
        }

        //public void BindData()
        //{
        //    String SQL = string.Empty;

        //    SQL = " Select CostCenterCode,CostCenterName from CostCenterMaster";

        //    grdCostCenterDetails.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, SQL).Tables[0];
        //    new DgvFilterManager(grdCostCenterDetails);
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedRow = grdCostCenterDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdCostCenterDetails.Rows[SelectedRow].Cells["CostCenterCode"].Value);
            EditMaster(SelectedRow, codeValue);
        }

        #region Edit Master

        /// <summary>
        /// Edit Master
        /// </summary>
        /// <param name="rowIndex"></param>

        private void EditMaster(int rowIndex, double codeValue)
        {
            try
            {
                CostCenter addForm = new CostCenter(this, codeValue);
                addForm.ShowDialog();
            }

            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
            }

        }

        #endregion

        #region Delete

        /// <summary>
        /// Delete the master for the respective table
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectedRow = grdCostCenterDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdCostCenterDetails.Rows[SelectedRow].Cells["CostCenterCode"].Value);
            DeleteMaster(codeValue);
        }

        private void DeleteMaster(Double codeValue)
        {
            try
            {

                //base.Delete("CostCenterMaster", "CostCenterCode", codeValue.ToString());

                //BindData();

            }

            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
            }

        }

        #endregion


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static CostCenterView sForm = null;
        public static CostCenterView Instance()
        {

            if (sForm == null) { sForm = new CostCenterView(); }
            return sForm;
        }

        private void CostCenterView_Load(object sender, EventArgs e)
        {
            //BindData();
        }
    }
}
