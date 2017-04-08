using System;
using System.Data;
using System.Windows.Forms;
using Common;
using DgvFilterPopup;


namespace ERP.SalePurchase
{
    public partial class NarrationView : Global.BaseClass
    {
        int SelectedRow = 0;

        public NarrationView()
        {
            InitializeComponent();
        }



        #region private members
        private NarrationView viewForm;
        Double Code = Double.MinValue;
        string sql = string.Empty;
        #endregion

        private void NarrationView_Load(object sender, EventArgs e)
        {
            //SetButtons();
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            new NarrationAdd(this, 0).ShowDialog();
        }

        public void BindData()
        {
            String SQL = string.Empty;

            SQL = " Select NarrationCode,NarrationName from NarrationMaster";

            //grdNarrationDetails.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, SQL).Tables[0];
            //new DgvFilterManager(grdNarrationDetails);
        }


        private static NarrationView sForm = null;
        public static NarrationView Instance()
        {

            if (sForm == null) { sForm = new NarrationView(); }
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
            SelectedRow = grdNarrationDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdNarrationDetails.Rows[SelectedRow].Cells["NarrationCode"].Value);
            DeleteMaster(codeValue);
        }

        private void DeleteMaster(Double codeValue)
        {
            try
            {

                //base.Delete("NarrationMaster", "NarrationCode", codeValue.ToString());

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
                NarrationAdd addForm = new NarrationAdd(this, codeValue);
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
            SelectedRow = grdNarrationDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdNarrationDetails.Rows[SelectedRow].Cells["NarrationCode"].Value);
            EditMaster(SelectedRow, codeValue);
        }



    }
}
