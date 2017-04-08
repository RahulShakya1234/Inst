using System;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;

using Common;

namespace ERP.SalePurchase
{
    public partial class PriceListView : Global.BaseClass
    {
        public PriceListView()
        {
            InitializeComponent();
        }
        int SelectedRow = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new PriceRate(this, 0).ShowDialog();
        }

        public void BindData()
        {
            //String SQL = string.Empty;

            //SQL = " Select PriceRateCode,PriceRateName from PriceRateMaster";

            //grdPriceRateDetails.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, SQL).Tables[0];
            //new DgvFilterManager(grdPriceRateDetails);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedRow = grdPriceRateDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdPriceRateDetails.Rows[SelectedRow].Cells["PriceRateCode"].Value);
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
                PriceRate addForm = new PriceRate(this, codeValue);
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
            SelectedRow = grdPriceRateDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdPriceRateDetails.Rows[SelectedRow].Cells["PriceRateCode"].Value);
            DeleteMaster(codeValue);
        }

        private void DeleteMaster(Double codeValue)
        {
            try
            {

                //base.Delete("PriceRateMaster", "PriceRateCode", codeValue.ToString());

                BindData();

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

        private static PriceListView sForm = null;
        public static PriceListView Instance()
        {

            if (sForm == null) { sForm = new PriceListView(); }
            return sForm;
        }

        private void PriceRateView_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
