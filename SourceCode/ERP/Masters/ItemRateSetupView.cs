using System;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;
using Common;


namespace ERP.SalePurchase
{
    public partial class ItemRateSetupView : Global.BaseClass
    {
        int SelectedRow = 0;

        public ItemRateSetupView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ItemRateSetupAdd(this, 0).ShowDialog();
        }

        private static ItemRateSetupView sForm = null;
        public static ItemRateSetupView Instance()
        {
            if (sForm == null) { sForm = new ItemRateSetupView(); }
            return sForm;
        }

        private void ItemRateSetupView_Load(object sender, EventArgs e)
        {
            SetButtons();
            BindData();
        }

        private void SetButtons()
        {
            //throw new NotImplementedException();
        }
        public void BindData()
        {
            String SQL = string.Empty;

            SQL = " SELECT ItemsAdd.ItemCode, ItemsAdd.StateRate, ItemRateMaster.PackingRate,ItemRateMaster.IRate,ItemRateMaster.PoNo, ItemRateMaster.ItemRateCode, ItemRateMaster.ToolRate, ItemRateMaster.Tax, ItemsAdd.DisplayName, AccMas.AccName"
                   + " FROM ItemsAdd INNER JOIN (AccMas INNER JOIN ItemRateMaster ON AccMas.AccCode = ItemRateMaster.AccCode) ON ItemsAdd.Id = ItemRateMaster.ItemCode";

            //grdItemRateDetails.DataSource = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, SQL).Tables[0];
            new DgvFilterManager(grdItemRateDetails);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedRow = grdItemRateDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdItemRateDetails.Rows[SelectedRow].Cells["ItemRateCode"].Value);
            EditMaster(SelectedRow, codeValue);
        }


        #region Delete

        /// <summary>
        /// Delete the master for the respective table
        /// </summary>
        private void DeleteMaster(Double codeValue)
        {
            try
            {

                //base.Delete("ItemRateMas", "ItemRateCode", codeValue.ToString());

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
                ItemRateSetupAdd addForm = new ItemRateSetupAdd(this, codeValue);
                addForm.ShowDialog();
            }
            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
            }

        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectedRow = grdItemRateDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdItemRateDetails.Rows[SelectedRow].Cells["ItemRateCode"].Value);
            DeleteMaster(codeValue);
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            SelectedRow = grdItemRateDetails.CurrentRow.Index;
            double codeValue = Convert.ToDouble(grdItemRateDetails.Rows[SelectedRow].Cells["ItemRateCode"].Value);
            EditMaster(SelectedRow, codeValue);
        }

        
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
