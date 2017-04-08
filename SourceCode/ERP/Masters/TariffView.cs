using System;
using System.Data;
using System.Windows.Forms;
using Common;

using DgvFilterPopup;

namespace ERP.SalePurchase
{
    public partial class TariffView : Global.BaseClass
    {
        int SelectedRow = 0;

        public TariffView()
        {
            InitializeComponent();
        }

        #region private members
        private TariffView viewForm;
        Double Code = Double.MinValue;
        string sql = string.Empty;
        #endregion

        private void TariffView_Load(object sender, EventArgs e)
        {
            //SetButtons();
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            new TariffAdd(this, 0).ShowDialog();
        }

        public void BindData()
        {
            String SQL = string.Empty;

            SQL = " Select RTCode,Heading,Tariff,Unit,PrintRt,Acccode,ShowInER1 from RT12Mas";

            //grdTariffDetails.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, SQL).Tables[0];
            //new DgvFilterManager(grdTariffDetails);
        }


        private static TariffView sForm = null;
        public static TariffView Instance()
        {

            if (sForm == null) { sForm = new TariffView(); }
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
            SelectedRow = grdTariffDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdTariffDetails.Rows[SelectedRow].Cells["RTCode"].Value);
            DeleteMaster(codeValue);
        }

        private void DeleteMaster(Double codeValue)
        {
            try
            {

                //base.Delete("RT12Mas", "RTCode", codeValue.ToString());

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
                TariffAdd addForm = new TariffAdd(this, codeValue);
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
            SelectedRow = grdTariffDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdTariffDetails.Rows[SelectedRow].Cells["RTCode"].Value);
            EditMaster(SelectedRow, codeValue);
        }




    }
}
