using System;
using Common;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;
using ERP.SalePurchase;
using System.Drawing;
using System.Collections.Generic;


namespace ERP.SalePurchase.SalePurchase
{
    public partial class DirectEntryAdd : Global.BaseClass
    {
        private DirectEntryView viewForm;
        int SelectedRow = 0;
        int Code = 0;
        string sql = string.Empty;
        public decimal total = 0;

        public DirectEntryAdd()
        {
            InitializeComponent();
        }

        private void DirectEntryAdd_Load(object sender, EventArgs e)
        {
            //BindDropDown();
            this.ActiveControl = txtSerialBillNo;
            grdPurchaseBillDetailsDET.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            grdPurchaseBillDetailsDET.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }
            txtEntryDate.Focus();
        }

        public DirectEntryAdd(DirectEntryView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
            BindDropDown();
        }

        public DirectEntryAdd(DirectEntryView view, int code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            if (code > 0)
            {
                this.Text = this.Text + " (Edit)";
            }
            else
            {
                this.Text = this.Text + " (Add)";
            }
            BindDropDown();
        }

        #region  User Function
        private void SetDetailValue(int sno)
        {
            try
            {
                if (sno <= 0 || sno > (grdPurchaseBillDetailsDET.Rows.Count))
                { return; }

                txtDSno.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["SNO"].Value.ToString();
                txtDItemCode.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["AliasItemCode"].Value.ToString();
                // ddlItemDesc.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["MaterialDesc"].Value.ToString();
                ddlDUMO.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["UMO"].Value.ToString();
                txtDQuantity.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["Qty"].Value.ToString();
                txtDRate.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["Rate"].Value.ToString();
                txtDTotalAmt.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["TotalAmount"].Value.ToString();
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
            }
        }

        public void CalculateTotalAmount()
        {
            decimal total = 0;

            for (int i = 0; i < grdPurchaseBillDetailsDET.Rows.Count; i++)
            {
                total = total + grdPurchaseBillDetailsDET.Rows[i].Cells["Amount"].Value.ToDecimal();
            }
            txtTotalAmount.Text = total.ToString();
        }

        private void BindDropDown()
        {


            FillCombo(ddlPurchaseType, 11);
            FillCombo(ddlPurchaseCategory, 20);
            //FillCombo(ddlAccountType, 12);ddlItemDesc

            //FillCombo(ddlItemDesc, 21);
            FillCombo(ddlPurchaseAccount, Common.Masters.AccountGroup, "Please Select");
            FillCombo(ddlDUMO, Common.Masters.UMO);
            try
            {
                FillCombo(ddlDItemDesc, Common.Masters.ItemDesc);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void ResetMasterControls()
        {
            txtSerialBillNo.Clear();
            txtEntryDate.Text = string.Empty;
            txtBillNo.Text = string.Empty;
            txtBillDate.Text = string.Empty;
            txtNarration.Text = string.Empty;
            ddlPurchaseCategory.SelectedIndex = 0;
            ddlPurchaseType.SelectedIndex = 0;

            ddlPurchaseAccount.SelectedIndex = 0;
            txtTotalAmount.Text = string.Empty;

            //txtExcise.Text = string.Empty;
            //txtCess.Text = string.Empty;
            //txtHECess.Text = string.Empty;
            //txtExciseReg.Text = string.Empty;
            //txtExciseNo.Text = string.Empty;
            //txtTransport.Text = string.Empty;
            //txtCarrier.Text = string.Empty;
            //txtRemark.Text = string.Empty;
            //txtTotalAmount.Text = string.Empty;
            //txtSaleTax.Text = string.Empty;
            //txtSurchargeTax.Text = string.Empty;
            //txtBillAmount.Text = string.Empty;
            //txtFrieghtInsurance.Text = string.Empty;
            //txtPackingForword.Text = string.Empty;

        }

        public void ResetDetailControls()
        {
            txtDQuantity.Text = string.Empty;
            txtDRate.Text = string.Empty;
            txtDTotalAmt.Text = string.Empty;
            txtDItemCode.Text = string.Empty;
            ddlDUMO.SelectedIndex = 0;
            ddlDItemDesc.SelectedIndex = 0;
        }

        void Naration()
        {

            txtNarration.Text = "Bill No:" + txtBillNo.Text + ", Date :" + txtBillDate.Text;

        }
        #endregion

        #region Button event
        private void btnReset_Click(object sender, EventArgs e)
        {
           // txtDSno.Clear();
          //  txtDSno.Text = string.Empty;
            txtDQuantity.Text = string.Empty;
            txtDRate.Text = string.Empty;
            txtDTotalAmt.Text = string.Empty;
            txtDItemCode.Text = string.Empty;
            ddlDUMO.SelectedIndex = 0;
            ddlDItemDesc.SelectedIndex = 0;
            txtSerialBillNo.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


        private void txtSno_Enter_1(object sender, EventArgs e)
        {

            txtDSno.Text = (grdPurchaseBillDetailsDET.Rows.Count + 1).ToString();

            //var sno = Convert.ToInt32(e.ToInt());
            //txtSno.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["SNO"].Value.ToString();
            //txtItemCode.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["AliasItemCode"].Value.ToString();
            //ddlItemDesc.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno].Cells["MaterialDesc"].Value.ToString();
            //ddlUMO.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno].Cells["UMO"].Value.ToString();
            //txtQuantity.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value.ToString();
            //txtRate.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value.ToString();
            //txtTotalAmt.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["TotalAmount"].Value.ToString();
        }

        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDQuantity.Text) && !string.IsNullOrEmpty(txtDRate.Text))
                //txtDTotalAmt.Text = (Convert.ToDecimal(txtDQuantity.Text) * Convert.ToDecimal(txtDRate.Text)).ToString();
                txtDTotalAmt.Text =Convert.ToString(txtDQuantity.Text.ToDecimal() * txtDRate.Text.ToDecimal());
        }

        private void txtRate_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDQuantity.Text) && !string.IsNullOrEmpty(txtDRate.Text))
                txtDTotalAmt.Text =( txtDQuantity.Text.ToDecimal() * txtDRate.Text.ToDecimal()).ToString();
                //txtDTotalAmt.Text = Convert.ToString(txtDQuantity.Text.ToDecimal() * txtDRate.ToDecimal());
        }

        private void txtSno_Leave(object sender, EventArgs e)
        {
            int sno = txtDSno.Text.ToInt();
            SetDetailValue(sno);
        }
        //private void SetDetailValue(int sno)
        //{
        //    if (sno <= 0 || sno > (grdPurchaseBillDetailsDET.Rows.Count))
        //    { return; }

        //    txtDSno.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["SNO"].Value.ToString();
        //    txtDItemCode.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["AliasItemCode"].Value.ToString();
        //    ddlDItemDesc.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["ItemDecsId"].Value.ToString();
        //    ddlDUMO.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["UOMId"].Value.ToString();
        //    txtDQuantity.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["Qty"].Value.ToString();
        //    txtDRate.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["Rate"].Value.ToString();
        //    txtDTotalAmt.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["TotalAmount"].Value.ToString();
        //}   



        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string billSno = "";
            try
            {
                if (grdPurchaseBillDetailsDET.Rows.Count == 0)
                {
                    MessageBox.Show("Please Add Details ");
                }

                #region Validation
                //if (CheckRequiredField(txtSerialBillNo))
                //    return;
                //    if (CheckRequiredField(ddlItemDesc))
                //return;
                if (CheckRequiredField(ddlPurchaseAccount))
                    return;
                //if (CheckRequiredField(ddlPurchaseBill))
                //{
                //    return;
                //}

                //if (CheckRequiredField(ddlPurchaseType))
                //{
                //    return;
                //}

                //if (CheckRequiredField(ddlUMO))
                //{
                //    return;
                //} 
                #endregion

                if (grdPurchaseBillDetailsDET.Rows.Count == 0)
                {
                    MessageBox.Show("Please add  information");
                    //return;
                }


                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    #region masters
                    PurelifeErpClient.MSTPurchaseBillDTO objPurchaseBillDOMST = new PurelifeErpClient.MSTPurchaseBillDTO();

                    objPurchaseBillDOMST.Id = Code;

                    objPurchaseBillDOMST.SerialBillNo = txtSerialBillNo.Text.Trim();
                    objPurchaseBillDOMST.Entrydate = txtEntryDate.Text.ToDateTime().Date;
                    objPurchaseBillDOMST.BillNo = txtBillNo.Text.Trim();
                    objPurchaseBillDOMST.BillDate = txtBillDate.Text.ToDateTime().Date;
                    //objPurchaseBillDO.Supplier =         GetInt(ddlSupplier.SelectedValue);
                    objPurchaseBillDOMST.Narration = txtNarration.Text.Trim();
                    objPurchaseBillDOMST.PurchaseCategy = GetInt(ddlPurchaseCategory.SelectedValue);
                    objPurchaseBillDOMST.PurchaseType = GetInt(ddlPurchaseType.SelectedValue);
                    objPurchaseBillDOMST.PurchaseAcc = GetInt(ddlPurchaseAccount.SelectedValue);
                    objPurchaseBillDOMST.TotalAmount = txtTotalAmount.Text.ToFloat();
                    objPurchaseBillDOMST.Type = 2;

                    PurelifeErpClient.ERPDTOBase objERPDOBase = objPurchaseBillDOMST as PurelifeErpClient.ERPDTOBase;

                    PurelifeErpClient.Result res = purelifeErpClient.Save(PurelifeErpClient.PageName.MSTPurchaseBill, objERPDOBase);

                    int i = 4 - res.Id.ToString().Length;
                    string result = new string('0', i);
                    string prefix = "DE/" + DateTime.Now.Year.ToString().Substring(2) + "-" + DateTime.Now.AddYears(1).Year.ToString().Substring(2) + "/";
                    billSno = string.Format("{0}{1}{2}", prefix, result, res.Id);

                    #endregion

                    #region Details

                    if (res.Id > 0)
                    {
                        for (int sno = 0; sno < grdPurchaseBillDetailsDET.Rows.Count; sno++)
                        {
                            try
                            {
                                PurelifeErpClient.DETPurchaseBillDTO objPurchaseBillDO = new PurelifeErpClient.DETPurchaseBillDTO();
                                objPurchaseBillDO.Id = res.Id;
                                objPurchaseBillDO.SNo = grdPurchaseBillDetailsDET.Rows[sno].Cells["SNo"].Value.ToInt();
                                objPurchaseBillDO.MaterialDesc = grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemId"].Value.ToInt();
                                objPurchaseBillDO.UMOId = grdPurchaseBillDetailsDET.Rows[sno].Cells["UOMId"].Value.ToInt();
                                objPurchaseBillDO.Qty = grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value.ToFloat();
                                objPurchaseBillDO.Rate = grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value.ToFloat();
                                objPurchaseBillDO.TotalAmount = grdPurchaseBillDetailsDET.Rows[sno].Cells["Amount"].Value.ToFloat();

                                PurelifeErpClient.ERPDTOBase objERPDOBaseDET = objPurchaseBillDO as PurelifeErpClient.ERPDTOBase;
                                purelifeErpClient.Save(PurelifeErpClient.PageName.DETPurchaseBill, objERPDOBaseDET);
                            }
                            catch (Exception ex)
                            {

                                ErrorLog.LogErrorInTxtFormat(ex);
                            }

                        }
                    }
                    #endregion

                    purelifeErpClient.Close();
                    if (Code > 0)
                    {
                        ShowMessage("Updated successfully");
                        viewForm.BindData();
                        Close();
                    }
                    else
                    {
                        ShowMessage(String.Format("Saved successfully, Your Serial No is {0}", billSno));
                        // ShowMessage("Saved successfully");
                        viewForm.BindData();
                        ResetMasterControls();
                        ResetDetailControls();
                        grdPurchaseBillDetailsDET.Rows.Clear();
                    }
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                int sno = txtDSno.Text.ToInt();
                if (sno < 0)
                {
                    MessageBox.Show("SNo is Required");
                    return;
                }
                if (sno > grdPurchaseBillDetailsDET.Rows.Count - 1)
                {
                    sno -= 1;
                    grdPurchaseBillDetailsDET.Rows.Add();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Sno"].Value = txtDSno.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemCode"].Value = txtDItemCode.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemId"].Value = ddlDItemDesc.SelectedValue.ToString();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Item"].Value = ddlDItemDesc.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["UOMId"].Value = ddlDUMO.SelectedValue.ToString();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["UOM"].Value = ddlDUMO.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value = txtDQuantity.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value = txtDRate.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Amount"].Value = txtDTotalAmt.Text;

                }
                else
                {
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Sno"].Value = txtDSno.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemCode"].Value = txtDItemCode.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemId"].Value = ddlDItemDesc.SelectedValue.ToString();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Item"].Value = ddlDItemDesc.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["UOMId"].Value = ddlDUMO.SelectedValue.ToString();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["UOM"].Value = ddlDUMO.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value = txtDQuantity.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value = txtDRate.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Amount"].Value = txtDTotalAmt.Text;

                }
                CalculateTotalAmount();
                txtDSno.Text = Convert.ToString(grdPurchaseBillDetailsDET.Rows[sno].Cells["SNo"].Value.ToInt() + 1);
                txtDSno.Focus();
                ResetDetailControls();
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //int sno= grdPurchaseBillDetailsDET.SelectedRows.ToInt();
            grdPurchaseBillDetailsDET.Rows.RemoveAt(grdPurchaseBillDetailsDET.CurrentRow.Index);

            for (int i = 0; i < grdPurchaseBillDetailsDET.Rows.Count; i++)
            {
                grdPurchaseBillDetailsDET.Rows[i].Cells["SNO"].Value = i + 1;
            }

            txtDSno.Text = Convert.ToString(grdPurchaseBillDetailsDET.Rows.Count + 1);
        }

        #endregion

        #region control event

        private void grdPurchaseBillDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                this.grdPurchaseBillDetailsDET.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);

                txtDSno.Clear();
                txtDSno.Text = string.Empty;
                txtDQuantity.Text = string.Empty;
                txtDRate.Text = string.Empty;
                // txtDics.Text = string.Empty;
                //txtAmount.Text = string.Empty;
                //txtExciseAmount.Text = string.Empty;
                //txtECess.Text = string.Empty;
                //txtHEChess.Text = string.Empty;
                //txtHECessAmount.Text = string.Empty;
                //txtInvoiceDate.Text = string.Empty;
                //txtETADate.Text = string.Empty;
                //txtSpec.Text = string.Empty;
                //txtTariff.Text = string.Empty;
                //txtCVDAmt.Text = string.Empty;
                txtDTotalAmt.Text = string.Empty;
                txtDItemCode.Text = string.Empty;
                ddlDUMO.SelectedIndex = 0;
                ddlDItemDesc.SelectedIndex = 0;


            }
        }

        private void grdPurchaseBillDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdPurchaseBillDetailsDET.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void grdPurchaseBillDetails_MouseEnter(object sender, EventArgs e)
        {
            grdPurchaseBillDetailsDET.DefaultCellStyle.SelectionBackColor = Color.Silver;
            grdPurchaseBillDetailsDET.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        //private void txtSno_Enter_1(object sender, EventArgs e)
        //{

        //    txtSno.Text = (grdPurchaseBillDetailsDET.Rows.Count + 1).ToString();

        //    //var sno = Convert.ToInt32(e.ToInt());
        //    //txtSno.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["SNO"].Value.ToString();
        //    //txtItemCode.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["AliasItemCode"].Value.ToString();
        //    //ddlItemDesc.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno].Cells["MaterialDesc"].Value.ToString();
        //    //ddlUMO.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno].Cells["UMO"].Value.ToString();
        //    //txtQuantity.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value.ToString();
        //    //txtRate.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value.ToString();
        //    //txtTotalAmt.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["TotalAmount"].Value.ToString();
        //}

        //private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtRate.Text))
        //        txtTotalAmt.Text = (Decimal.Parse(txtQuantity.Text) * Decimal.Parse(txtRate.Text)).ToString();
        //}

        //private void txtRate_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtRate.Text))
        //        txtTotalAmt.Text = (Decimal.Parse(txtQuantity.Text) * Decimal.Parse(txtRate.Text)).ToString();
        //}

        //private void txtSno_Leave(object sender, EventArgs e)
        //{
        //    int sno = txtSno.Text.ToInt();
        //    SetDetailValue(sno);
        //}

        private void grdPurchaseBillDetailsDET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sno = Convert.ToInt32(e.RowIndex);
            try
            {
                txtDSno.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["SNO"].Value.ToString();
                txtDQuantity.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value.ToString();
                txtDRate.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value.ToString();
                txtDTotalAmt.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["TotalAmount"].Value.ToString();
                txtDItemCode.Text = grdPurchaseBillDetailsDET.Rows[sno].Cells["AliasItemCode"].Value.ToString();
                ddlDItemDesc.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno].Cells["MaterialDesc"].Value.ToString();
                ddlDUMO.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno].Cells["UMO"].Value.ToString();

            }
            catch (Exception exception)
            {
                //ErrorLog.LogErrorInTxtFormat(exception);
                throw exception;
            }
        }

        private void grdPurchaseBillDetailsDET_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdPurchaseBillDetailsDET.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);

            }
        }

        private void grdPurchaseBillDetailsDET_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdPurchaseBillDetailsDET.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            string query = string.Format("AliasItemCode='{0}'", txtDItemCode.Text.Trim());
            DataRow[] dr = Common.Masters.ItemDesc.Select(query);
            if (dr.Length > 0)
            {
                ddlDItemDesc.SelectedValue = dr[0]["Code"].ToString();
            }

        }

        private void ddlItemDesc_Leave(object sender, EventArgs e)
        {
            string query = string.Format("Code={0}", ddlDItemDesc.SelectedValue.ToString());
            DataRow[] dr = Common.Masters.ItemDesc.Select(query);
            if (dr.Length > 0)
            {
                txtDItemCode.Text = dr[0]["AliasItemCode"].ToString();
            }

        }

        private void btnItemDesc_Click(object sender, EventArgs e)
        {
            ItemsAdd sForm = new ItemsAdd();
            sForm.Show();
        }

        private void txtBillNo_Leave(object sender, EventArgs e)
        {
            if (txtBillNo.Text == "")
            {
                MessageBox.Show("Please enter BillNo.");
                txtBillNo.Focus();
                return;

            }
            else
            {
                Naration();
            }
        }

        private void txtBillDate_Leave(object sender, EventArgs e)
        {
            Naration();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {



            for (int i = 0; i < grdPurchaseBillDetailsDET.Rows.Count; i++)
            {
                grdPurchaseBillDetailsDET.Rows[i].Cells["SNO"].Value = i + 1;
            }
            txtDSno.Text = Convert.ToString(grdPurchaseBillDetailsDET.Rows.Count + 1);

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        #endregion

        


    }
}
