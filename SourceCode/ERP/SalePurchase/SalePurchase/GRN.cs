using System;
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
    public partial class GRN : Global.BaseClass
    {
        int Code = 0;
        private GRNView viewForm;
        public GRN()
        {
            InitializeComponent();
        }
          public GRN(GRNView view, int code)
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

        void BindDropDown()
        {
            FillCombo(ddlSupplierName, Common.Masters.AccountType, "Please Select");
            FillCombo(ddlMaterialDescription, Common.Masters.ItemDesc, "Please Select");
            FillCombo(ddlUnitCode, Common.Masters.UMO, "Please Select");
        }
        private void GRN_Load(object sender, EventArgs e)
        {
            BindDropDown();
        }
        private static GRN sForm = null;
        public static Form Instance()
        {
            if (sForm == null) { sForm = new GRN(); }
            return sForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string GRNNo = "";
            try
            {
                if (grdGRNDetails.Rows.Count == 0)
                {
                    MessageBox.Show("Please Add Details ");
                }
             
                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    #region masters
                    PurelifeErpClient.MSTGRNDTO objMSTGRNDTO = new PurelifeErpClient.MSTGRNDTO();

                    objMSTGRNDTO.Id = Code;
                    objMSTGRNDTO.SupplierName =GetInt(ddlSupplierName.SelectedValue);
                    objMSTGRNDTO.DCBillInvoiceNo = txtDCBillInvoiceNo.Text;
                    objMSTGRNDTO.DcBillInvoiceDate = txtDCBillInvoiceDate.Text.ToDateTime().Date;
                    objMSTGRNDTO.GRNNo = txtGRNNo.Text;
                    objMSTGRNDTO.GRNDate = txtGRNDate.Text.ToDateTime().Date;
                    objMSTGRNDTO.LLRRWayBillNo =txtLLRRWayBillNo.Text;
                    objMSTGRNDTO.LLRRWayBillDate = txtLLRRWayBillDate.Text.ToDateTime().Date;
                    objMSTGRNDTO.PONo = txtPONo.Text;
                    objMSTGRNDTO.PODate = txtPODate.Text.ToDateTime().Date;
                    objMSTGRNDTO.Prepared= txtPrepared.Text.Trim();
                    objMSTGRNDTO.StoreIncharge = txtStoreIncharge.Text.Trim();
                    objMSTGRNDTO.MaterialManager = txtMaterialManager.Text.Trim();
                    objMSTGRNDTO.PostedIntoStockBy = txtPostedIntoStockBy.Text.Trim();
                    PurelifeErpClient.ERPDTOBase objERPDOBase = objMSTGRNDTO as PurelifeErpClient.ERPDTOBase;
                    PurelifeErpClient.Result res = purelifeErpClient.Save(PurelifeErpClient.PageName.MSTPurchaseBill, objERPDOBase);

                    int i = 5 - res.Id.ToString().Length;
                    string result = new string('0', i);
                    string prefix = "GRN/" + DateTime.Now.Year.ToString().Substring(2) + "-" + DateTime.Now.AddYears(1).Year.ToString().Substring(2) + "/";
                    GRNNo = string.Format("{0}{1}{2}", prefix, result, res.Id);

                    #endregion

                    #region Details

                    if (res.Id > 0)
                    {
                        for (int sno = 0; sno < grdGRNDetails.Rows.Count; sno++)
                        {
                            try
                            {
                                PurelifeErpClient.DETGRNDTO objDETGRNDTO = new PurelifeErpClient.DETGRNDTO();
                                objDETGRNDTO.Id = res.Id;
                                objDETGRNDTO.SNo = grdGRNDetails.Rows[sno].Cells["SNo"].Value.ToInt();
                                objDETGRNDTO.MaterialDesc = grdGRNDetails.Rows[sno].Cells["MaterialDescId"].Value.ToInt();
                                objDETGRNDTO.UnitCode = grdGRNDetails.Rows[sno].Cells["UnitCodeId"].Value.ToInt();
                                objDETGRNDTO.DC = grdGRNDetails.Rows[sno].Cells["DC"].Value.ToInt();
                                objDETGRNDTO.Recieved = grdGRNDetails.Rows[sno].Cells["Recieved"].Value.ToInt();
                                objDETGRNDTO.AcceptedIntoStock = grdGRNDetails.Rows[sno].Cells["AcceptedIntoStock"].Value.ToInt();
                                objDETGRNDTO.MaterialCheckingSlipNo = grdGRNDetails.Rows[sno].Cells["MaterialCheckingSlipNo"].Value.ToString();
                                objDETGRNDTO.Value = grdGRNDetails.Rows[sno].Cells["Value"].Value.ToFloat();
                                PurelifeErpClient.ERPDTOBase objERPDOBaseDET = objDETGRNDTO as PurelifeErpClient.ERPDTOBase;
                                purelifeErpClient.Save(PurelifeErpClient.PageName.DETPurchaseBill, objERPDOBaseDET);
                            }
                            catch (Exception ex)
                            {

                                Common.ErrorLog.LogErrorInTxtFormat(ex);
                            }

                        }
                    }
                    #endregion

                    purelifeErpClient.Close();
                    if (Code > 0)
                    {
                        ShowMessage("Updated successfully");
                      //  viewForm.BindData();
                        Close();
                    }
                    else
                    {
                        ShowMessage(String.Format("Saved successfully, Your Serial No is {0}", GRNNo));
                        ResetMasterControls();
                        ResetDetailControls();
                        grdGRNDetails.Rows.Clear();
                    }
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }

             
        }

        private void ResetMasterControls()
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int sno =GetInt(txtDSno.Text);
                if (sno < 0)
                {
                    MessageBox.Show("SNo is Required");
                    return;
                }
                
                if (sno > grdGRNDetails.Rows.Count - 1)
                {
                    sno -= 1;
                    grdGRNDetails.Rows.Add();
                    grdGRNDetails.Rows[sno].Cells["SNo"].Value = txtDSno.Text;
                    grdGRNDetails.Rows[sno].Cells["MaterialCode"].Value = txtMaterialCode.Text;
                    grdGRNDetails.Rows[sno].Cells["MaterialDescId"].Value = ddlMaterialDescription.SelectedValue.ToString();
                    grdGRNDetails.Rows[sno].Cells["UnitCodeId"].Value = ddlUnitCode.SelectedValue.ToString();
                    grdGRNDetails.Rows[sno].Cells["DC"].Value = txtDC.Text;
                    grdGRNDetails.Rows[sno].Cells["Recieved"].Value = txtRecieved.Text;
                    grdGRNDetails.Rows[sno].Cells["AcceptedIntoStock"].Value = txtAcceptedIntoStock.Text;
                    grdGRNDetails.Rows[sno].Cells["MaterialCheckingSlipNo"].Value = txtMaterialCheckingSlipNo.Text;
                    grdGRNDetails.Rows[sno].Cells["Value"].Value = txtValue.Text;
                    grdGRNDetails.Rows[sno].Cells["MaterialDescription"].Value = ddlMaterialDescription.Text;
                    grdGRNDetails.Rows[sno].Cells["UnitCodeDescription"].Value = ddlMaterialDescription.Text;
                }
                else
                {
                    grdGRNDetails.Rows[sno].Cells["SNo"].Value = txtDSno.Text;
                    grdGRNDetails.Rows[sno].Cells["MaterialCode"].Value = txtMaterialCode.Text;
                    grdGRNDetails.Rows[sno].Cells["MaterialDescId"].Value = ddlMaterialDescription.SelectedValue;
                    grdGRNDetails.Rows[sno].Cells["UnitCodeId"].Value = ddlUnitCode.SelectedValue;
                    grdGRNDetails.Rows[sno].Cells["DC"].Value = txtDC.Text;
                    grdGRNDetails.Rows[sno].Cells["Recieved"].Value = txtRecieved.Text;
                    grdGRNDetails.Rows[sno].Cells["AcceptedIntoStock"].Value = txtAcceptedIntoStock.Text;
                    grdGRNDetails.Rows[sno].Cells["MaterialCheckingSlipNo"].Value = txtMaterialCheckingSlipNo.Text;
                    grdGRNDetails.Rows[sno].Cells["Value"].Value = txtValue.Text;
                    grdGRNDetails.Rows[sno].Cells["MaterialDescription"].Value = ddlMaterialDescription.Text;
                    grdGRNDetails.Rows[sno].Cells["UnitCodeDescription"].Value = ddlMaterialDescription.Text;
                }
                //CalculateTotalAmount();
              //  txtDSno.Text = Convert.ToString(grdPurchaseBillDetailsDET.Rows[sno].Cells["SNo"].Value.ToInt() + 1);
                txtDSno.Focus();
                ResetDetailControls();
            }
            catch (Exception ex)
            {
                throw;
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
                Common.ErrorLog.LogErrorInTxtFormat(ex);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            grdGRNDetails.Rows.RemoveAt(grdGRNDetails.CurrentRow.Index);

            for (int i = 0; i < grdGRNDetails.Rows.Count; i++)
            {
                grdGRNDetails.Rows[i].Cells["SNO"].Value = i + 1;
            }
            txtDSno.Text = Convert.ToString(grdGRNDetails.Rows.Count + 1);
        }

        public void ResetDetailControls()
        {

            txtMaterialCode.Text = string.Empty;
            txtDC.Text = string.Empty;
            txtRecieved.Text = string.Empty;
            txtAcceptedIntoStock.Text = string.Empty;
            txtMaterialCheckingSlipNo.Text = string.Empty;
            txtValue.Text = string.Empty;
            ddlMaterialDescription.SelectedIndex = 0;
            ddlUnitCode.SelectedIndex = 0;
        }

        private void txtMaterialCode_Leave(object sender, EventArgs e)
        {
            string query = string.Format("AliasItemCode='{0}'", txtMaterialCode.Text.Trim());
            DataRow[] dr = Common.Masters.ItemDesc.Select(query);
            if (dr.Length > 0)
            {
                ddlMaterialDescription.SelectedValue = dr[0]["Code"].ToString();
            }
        }

        private void ddlMaterialDescription_Leave(object sender, EventArgs e)
        {
            string query = string.Format("Code={0}", ddlMaterialDescription.SelectedValue.ToString());
            DataRow[] dr = Common.Masters.ItemDesc.Select(query);
            if (dr.Length > 0)
            {
                txtMaterialCode.Text = dr[0]["AliasItemCode"].ToString();
            }
        }

       
    }
}

