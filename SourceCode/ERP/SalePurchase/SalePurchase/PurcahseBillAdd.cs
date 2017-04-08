using System;

using Common;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;
using ERP.SalePurchase;
using System.Drawing;
using System.Collections.Generic;


namespace ERP.SalePurchase
{
    public partial class PurchaseBillAdd : Global.BaseClass
    {
        private PurcahseBillView viewForm;
        int SelectedRow = 0;
        int Code = 0;
        string sql = string.Empty;
        public PurchaseBillAdd()
        {
            InitializeComponent();
        }

        public PurchaseBillAdd(PurcahseBillView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
            BindDropDown();
        }

        public PurchaseBillAdd(PurcahseBillView view, int code)
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

        private void PurchaseBillAdd_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSerialBillNo;
            grdPurchaseBillDetailsDET.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            grdPurchaseBillDetailsDET.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }
            if (grdPurchaseBillDetailsDET.Rows.Count == 0)
            {
                txtSno.Text = "1";
            }
            else
            {
                txtSno.Text =Convert.ToString(grdPurchaseBillDetailsDET.Rows.Count+1);
            }

        }

        #region Button Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int sno = txtSno.Text.ToInt();
                if (sno < 0)
                {
                    MessageBox.Show("SNo is Required");
                    return;
                }
                if (sno > grdPurchaseBillDetailsDET.Rows.Count - 1)
                {
                    sno -= 1;
                    grdPurchaseBillDetailsDET.Rows.Add();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Sno"].Value = txtSno.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemCode"].Value = txtItemCode.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemId"].Value = ddlItemDesc.SelectedValue.ToString();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Item"].Value = ddlItemDesc.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["UOMId"].Value = ddlUOM.SelectedValue.ToString();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["UOM"].Value = ddlUOM.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value = txtQuantity.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value = txtRate.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Amount"].Value = txtTotalAmt.Text;

                }
                else
                {
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Sno"].Value = txtSno.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemCode"].Value = txtItemCode.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemId"].Value = ddlItemDesc.SelectedValue.ToString();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Item"].Value = ddlItemDesc.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["UOMId"].Value = ddlUOM.SelectedValue.ToString();
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["UOM"].Value = ddlUOM.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value = txtQuantity.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value = txtRate.Text;
                    grdPurchaseBillDetailsDET.Rows[sno].Cells["Amount"].Value = txtTotalAmt.Text;

                }
                CalculateTotalAmount();
                txtSno.Text = Convert.ToString(grdPurchaseBillDetailsDET.Rows[sno].Cells["SNo"].Value.ToInt() + 1);
                txtSno.Focus();
                ResetDetailControls();
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ResetDetailControls();
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            grdPurchaseBillDetailsDET.Rows.RemoveAt(grdPurchaseBillDetailsDET.CurrentRow.Index);

            for (int i = 0; i < grdPurchaseBillDetailsDET.Rows.Count; i++)
            {
                grdPurchaseBillDetailsDET.Rows[i].Cells["SNO"].Value = i + 1;
            }
            txtSno.Text = Convert.ToString(grdPurchaseBillDetailsDET.Rows.Count + 1);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string billSno = "";
            try
            {
                if (grdPurchaseBillDetailsDET.Rows.Count == 0)
                {
                    MessageBox.Show("Please Add Details");
                }
                if (CheckRequiredField(ddlPurchaseAccount)) return;
                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    #region masters
                    PurelifeErpClient.MSTPurchaseBillDTO objPurchaseBillDOMST = new PurelifeErpClient.MSTPurchaseBillDTO();
                    objPurchaseBillDOMST.Id = Code;
                    objPurchaseBillDOMST.SerialBillNo = billSno;
                    objPurchaseBillDOMST.Entrydate = txtEntryDate.Text.ToDateTime();
                    objPurchaseBillDOMST.Entrydate = txtEntryDate.Text.ToDateTime();
                    objPurchaseBillDOMST.BillNo = txtBillNo.Text.Trim();
                    objPurchaseBillDOMST.BillDate = txtBillDate.Text.ToDateTime();
                    objPurchaseBillDOMST.Narration = txtNarration.Text.Trim();
                    objPurchaseBillDOMST.PurchaseCategy = GetInt(ddlPurchaseCategory.SelectedValue);
                    objPurchaseBillDOMST.PurchaseType = GetInt(ddlPurchaseType.SelectedValue);
                    objPurchaseBillDOMST.PurchaseAcc = GetInt(ddlPurchaseAccount.SelectedValue);
                    objPurchaseBillDOMST.ExciseNo = txtExcise.Text.ToFloat();//   Excise Duty against form 'CT1'
                    objPurchaseBillDOMST.Cess = txtCess.Text.ToFloat();
                    objPurchaseBillDOMST.HECess = txtHECess.Text.ToFloat();
                    objPurchaseBillDOMST.AddExcise = ddlAddExcise.SelectedValue.ToString() == "0" ? false : true;
                    objPurchaseBillDOMST.ExciseReg = txtExciseReg.Text.ToFloat();
                    //objPurchaseBillDOMST.ExciseNo = txtExciseNo.Text.ToFloat();
                    objPurchaseBillDOMST.Transport = txtTransport.Text.Trim();
                    objPurchaseBillDOMST.Carrier = txtCarrier.Text.Trim();
                    objPurchaseBillDOMST.Remarks = txtRemark.Text.Trim();
                    objPurchaseBillDOMST.TotalAmount = txtMSTTotalAmount.Text.ToFloat();
                    objPurchaseBillDOMST.Freightnsurance = txtFrieghtInsurance.Text.Trim();
                    objPurchaseBillDOMST.PackingForwarding = txtPackingForword.Text.Trim();
                    objPurchaseBillDOMST.SaleTax = txtSaleTax.Text.ToFloat();  //Sales Tax against form 'H'
                    objPurchaseBillDOMST.SurchargeTax = txtSurchargeTax.Text.ToFloat();
                    objPurchaseBillDOMST.BillAmount = txtBillAmount.Text.ToFloat();
                    objPurchaseBillDOMST.MakeIssueToProductionBill = ddlIssueToProduction.SelectedValue.ToString() == "0" ? false : true;
                    objPurchaseBillDOMST.Type = 1;//

                    PurelifeErpClient.ERPDTOBase objERPDOBase = objPurchaseBillDOMST as PurelifeErpClient.ERPDTOBase;
                    PurelifeErpClient.Result res = purelifeErpClient.Save(PurelifeErpClient.PageName.MSTPurchaseBill, objERPDOBase);

                    int i = 4 - res.Id.ToString().Length;
                    string result = new string('0', i);
                    string prefix = "PB/" + DateTime.Now.Year.ToString().Substring(2) + "-" + DateTime.Now.AddYears(1).Year.ToString().Substring(2) + "/";
                    billSno = string.Format("{0}{1}{2}", prefix, result, res.Id);

                    #endregion
                    #region Details


                    if (res.Id > 0)
                    {
                        for (int sno = 0; sno < grdPurchaseBillDetailsDET.Rows.Count; sno++)
                        {
                            PurelifeErpClient.DETPurchaseBillDTO objPurchaseBillDO = new PurelifeErpClient.DETPurchaseBillDTO();
                            objPurchaseBillDO.Id = res.Id;

                            objPurchaseBillDO.SNo = grdPurchaseBillDetailsDET.Rows[sno].Cells["SNo"].Value.ToInt();
                            objPurchaseBillDO.MaterialDesc = grdPurchaseBillDetailsDET.Rows[sno].Cells["ItemId"].Value.ToInt();
                            objPurchaseBillDO.UMOId = grdPurchaseBillDetailsDET.Rows[sno].Cells["UOMId"].Value.ToInt();
                            objPurchaseBillDO.Qty = grdPurchaseBillDetailsDET.Rows[sno].Cells["Qty"].Value.ToFloat();
                            objPurchaseBillDO.Rate = grdPurchaseBillDetailsDET.Rows[sno].Cells["Rate"].Value.ToFloat();
                            objPurchaseBillDO.TotalAmount = grdPurchaseBillDetailsDET.Rows[sno].Cells["Amount"].Value.ToFloat();


                            //objPurchaseBillDO.DiscPerc = grdPurchaseBillDetailsDET.Rows[sno].Cells["DiscPerc"].Value.ToFloat();
                            // objPurchaseBillDO.DicsAmount = grdPurchaseBillDetailsDET.Rows[sno].Cells["DicsAmount"].Value.ToFloat();
                            // objPurchaseBillDO.ExciseDuty = grdPurchaseBillDetailsDET.Rows[sno].Cells["ExciseDuty"].Value.ToFloat();

                            //objPurchaseBillDO.ECess = grdPurchaseBillDetailsDET.Rows[sno].Cells["ECess"].Value.ToFloat();
                            //  objPurchaseBillDO.HECessPerc = grdPurchaseBillDetailsDET.Rows[sno].Cells["HECessPerc"].Value.ToFloat();


                            //  objPurchaseBillDO.HECessAmount = grdPurchaseBillDetailsDET.Rows[sno].Cells["HECessAmount"].Value.ToFloat();
                            //  objPurchaseBillDO.InvoiceDate = grdPurchaseBillDetailsDET.Rows[sno].Cells["InvoiceDate"].Value.ToDateTime();

                            //  objPurchaseBillDO.ETADate = grdPurchaseBillDetailsDET.Rows[sno].Cells["ETADate"].Value.ToDateTime();
                            //  objPurchaseBillDO.Specs = grdPurchaseBillDetailsDET.Rows[sno].Cells["Specs"].Value.ToString();

                            //  objPurchaseBillDO.Tariff = grdPurchaseBillDetailsDET.Rows[sno].Cells["Tariff"].Value.ToString();
                            //  objPurchaseBillDO.CVDAmount = grdPurchaseBillDetailsDET.Rows[sno].Cells["CVDAmount"].Value.ToFloat();

                            //  objPurchaseBillDO.TotalAmount = grdPurchaseBillDetailsDET.Rows[sno].Cells["TotalAmount"].Value.ToFloat();

                            PurelifeErpClient.ERPDTOBase objERPDOBaseDET = objPurchaseBillDO as PurelifeErpClient.ERPDTOBase;
                            purelifeErpClient.Save(PurelifeErpClient.PageName.DETPurchaseBill, objERPDOBaseDET);
                        }
                    }
                    #endregion
                    purelifeErpClient.Close();

                    //txtSerialBillNo.Text = (Convert.ToInt32(txtSerialBillNo.Text + 1)).ToString();
                    //txtSerialBillNo.Text = (int.Parse(txtSerialBillNo.Text) + 1).ToString();

                    if (Code > 0)
                    {
                        ShowMessage("Updated successfully");
                        viewForm.BindData();
                        Close();

                    }
                    else
                    {
                        ShowMessage(String.Format("Saved successfully, Your Serial No is {0}", billSno));
                        viewForm.BindData();
                        ResetMasterControls();
                        ResetDetailControls();
                        this.grdPurchaseBillDetailsDET.DataSource = null;
                        grdPurchaseBillDetailsDET.Rows.Clear();
                        // SerialBillNo();

                        //txtSerialBillNo.Text = (int.Parse(txtSerialBillNo.Text) + 1).ToString();
                    }
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Control Event


        private void grdPurchaseBillDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdPurchaseBillDetailsDET.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
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

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            AccountAdd sForm = new AccountAdd();
            sForm.Show();
        }

        private void btnItemDesc_Click(object sender, EventArgs e)
        {
            ItemsAdd sForm = new ItemsAdd();
            sForm.Show();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtRate.Text))
                //txtTotalAmt.Text = (Decimal.Parse(txtQuantity.Text) * Decimal.Parse(txtRate.Text)).ToString();
            txtTotalAmt.Text =Convert.ToString(txtQuantity.Text.ToDecimal() * txtRate.Text.ToDecimal());
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtRate.Text))
                txtTotalAmt.Text = Convert.ToString(txtQuantity.Text.ToDecimal() *txtRate.Text.ToDecimal());
        }

        private void txtSno_Leave(object sender, EventArgs e)
        {
            int sno = txtSno.Text.ToInt();
            SetDetailValue(sno);
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {

            try
            {
                string query = string.Format("AliasItemCode='{0}'", txtItemCode.Text.Trim());
                DataRow[] dr = Common.Masters.ItemDesc.Select(query);
                if (dr.Length > 0)
                {
                    ddlItemDesc.SelectedValue = dr[0]["Code"].ToString();
                }

            }
            catch (Exception exception)
            {

                ErrorLog.LogErrorInTxtFormat(exception);
            }

        }

        private void ddlItemDesc_Leave(object sender, EventArgs e)
        {

            try
            {
                string query = string.Format("Code={0}", ddlItemDesc.SelectedValue.ToString());
                DataRow[] dr = Common.Masters.ItemDesc.Select(query);
                if (dr.Length > 0)
                {
                    txtItemCode.Text = dr[0]["AliasItemCode"].ToString();
                }
            }
            catch (Exception exception)
            {

                ErrorLog.LogErrorInTxtFormat(exception);
            }

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                ShowMessage("Not Allowed");
                e.Handled = true;
            }
        }



        #endregion



        #region User function
        private void BindDropDown()
        {
            FillCombo(ddlIssueToProduction, 1);
            FillCombo(ddlPurchaseType, 11);
            FillCombo(ddlPurchaseCategory, 20);
            FillCombo(ddlAddExcise, 1);
            FillCombo(ddlPurchaseAccount, Common.Masters.AccountGroup, "Please Select");
            FillCombo(ddlUOM, Common.Masters.UMO);
            FillCombo(ddlItemDesc, Common.Masters.ItemDesc);

        }
        public void CalculateTotalAmount()
        {
            decimal total = 0;

            for (int i = 0; i < grdPurchaseBillDetailsDET.Rows.Count; i++)
            {
                total = total + grdPurchaseBillDetailsDET.Rows[i].Cells["Amount"].Value.ToDecimal();
            }
            txtMSTTotalAmount.Text = total.ToString();
        }
        public void ResetMasterControls()
        {
            txtSerialBillNo.Clear();
            txtEntryDate.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtBillNo.Text = string.Empty;
            txtBillDate.Text = string.Empty;
            txtNarration.Text = string.Empty;
            txtExcise.Text = string.Empty;
            txtCess.Text = string.Empty;
            txtHECess.Text = string.Empty;
            txtExciseReg.Text = string.Empty;
            txtExciseNo.Text = string.Empty;
            txtTransport.Text = string.Empty;
            txtCarrier.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtMSTTotalAmount.Text = string.Empty;
            txtSaleTax.Text = string.Empty;
            txtSurchargeTax.Text = string.Empty;
            txtBillAmount.Text = string.Empty;
            txtFrieghtInsurance.Text = string.Empty;
            txtPackingForword.Text = string.Empty;
            ddlPurchaseCategory.SelectedIndex = 0;
            ddlPurchaseType.SelectedIndex = 0;
            ddlPurchaseAccount.SelectedIndex = 0;
        }
        public void ResetDetailControls()
        {
            txtQuantity.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtDics.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtExciseAmount.Text = string.Empty;
            txtECess.Text = string.Empty;
            txtHEChess.Text = string.Empty;
            txtHECessAmount.Text = string.Empty;
            txtInvoiceDate.Text = string.Empty;
            txtETADate.Text = string.Empty;
            txtSpec.Text = string.Empty;
            txtTariff.Text = string.Empty;
            txtCVDAmt.Text = string.Empty;
            txtTotalAmt.Text = string.Empty;
            ddlItemDesc.SelectedIndex = 0;
            ddlUOM.SelectedIndex = 0;
        }
        private void SetDetailValue(int sno)
        {
            try
            {
                if (sno <= 0 || sno > (grdPurchaseBillDetailsDET.Rows.Count))
                { return; }

                txtSno.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["SNO"].Value.ToString();
                txtItemCode.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["ItemCode"].Value.ToString();
                ddlItemDesc.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["ItemId"].Value.ToString();
                ddlUOM.SelectedValue = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["UOMId"].Value.ToString();
                txtQuantity.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["Qty"].Value.ToString();
                txtRate.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["Rate"].Value.ToString();
                txtTotalAmt.Text = grdPurchaseBillDetailsDET.Rows[sno - 1].Cells["Amount"].Value.ToString();
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
            }
        }
        #endregion

    }
}
