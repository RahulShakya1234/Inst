using System;

using Common;
using System.Data;
using System.Windows.Forms;
using DgvFilterPopup;
using ERP.SalePurchase;
using System.Drawing;
using System.Collections.Generic;

namespace ERP.Masters
{
    public partial class IssueMaster : Global.BaseClass
    {
        private IssueMasterView viewForm;
        int SelectedRow = 0;
        int Code = 0;
        string sql = string.Empty;
        public IssueMaster()
        {
            InitializeComponent();
        }
        public IssueMaster(IssueMasterView view)
        {
            viewForm = view;
            Code = 0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
            BindDropDown();
        }

        public IssueMaster(IssueMasterView view, int code)
        {
            viewForm = view;
            Code = code;
            //Code2 = code2;
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
       
        #region  Button Event
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
                if (sno > grdIssueMaster.Rows.Count - 1)
                {
                    sno -= 1;
                    grdIssueMaster.Rows.Add();
                    grdIssueMaster.Rows[sno].Cells["Sno"].Value = txtSno.Text;
                    grdIssueMaster.Rows[sno].Cells["ItemCode"].Value = txtItemCode.Text;
                    grdIssueMaster.Rows[sno].Cells["ItemId"].Value = ddlItemDesc.SelectedValue.ToString();
                    grdIssueMaster.Rows[sno].Cells["ItemDes"].Value = ddlItemDesc.Text;
                    grdIssueMaster.Rows[sno].Cells["UOMId"].Value = ddlUMO.SelectedValue.ToString();
                    grdIssueMaster.Rows[sno].Cells["UOM"].Value = ddlUMO.Text;
                    grdIssueMaster.Rows[sno].Cells["Qty"].Value = txtQuantity.Text;

                }
                else
                {
                    grdIssueMaster.Rows[sno].Cells["Sno"].Value = txtSno.Text;
                    grdIssueMaster.Rows[sno].Cells["ItemCode"].Value = txtItemCode.Text;
                    grdIssueMaster.Rows[sno].Cells["ItemId"].Value = ddlItemDesc.SelectedValue.ToString();
                    grdIssueMaster.Rows[sno].Cells["ItemDes"].Value = ddlItemDesc.Text;
                    grdIssueMaster.Rows[sno].Cells["UOMId"].Value = ddlUMO.SelectedValue.ToString();
                    grdIssueMaster.Rows[sno].Cells["UOM"].Value = ddlUMO.Text;
                    grdIssueMaster.Rows[sno].Cells["Qty"].Value = txtQuantity.Text;

                }
                txtSno.Text = Convert.ToString(grdIssueMaster.Rows[sno].Cells["SNo"].Value.ToInt() + 1);
                ResetDetailControls();
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            grdIssueMaster.Rows.RemoveAt(grdIssueMaster.CurrentRow.Index);

            for (int i = 0; i < grdIssueMaster.Rows.Count; i++)
            {
                grdIssueMaster.Rows[i].Cells["SNO"].Value = i + 1;
            }
            txtSno.Text = Convert.ToString(grdIssueMaster.Rows.Count + 1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ResetDetailControls();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string IssueSno = "";
            {
                try
                {
                    if (grdIssueMaster.Rows.Count == 0)
                    {
                        MessageBox.Show("Please add  information");
                        return;
                    }
                    if (CheckRequiredField(ddlIssueTo)) return;
                    if (CheckRequiredField(txtOrderDate)) return;


                    #region masters
                    using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                    {
                        PurelifeErpClient.MSTIssueMasterDTO oMSTIssueMasterDTO = new PurelifeErpClient.MSTIssueMasterDTO();
                        oMSTIssueMasterDTO.Id = Code;
                        oMSTIssueMasterDTO.OrderNo = txtOrderNo.Text.Trim();
                        oMSTIssueMasterDTO.Orderdate = txtOrderDate.Text.ToDateTime();
                        oMSTIssueMasterDTO.Remarks = txtRemarks.Text.Trim();
                        oMSTIssueMasterDTO.IssueTo = GetInt(ddlIssueTo.SelectedValue);

                        PurelifeErpClient.ERPDTOBase objERPDOBase = oMSTIssueMasterDTO as PurelifeErpClient.ERPDTOBase;
                        PurelifeErpClient.Result res = purelifeErpClient.Save(PurelifeErpClient.PageName.MSTIssueMaster, objERPDOBase);

                        int i = 4 - res.Id.ToString().Length;
                        string result = new string('0', i);
                        string prefix = "ISM/" + DateTime.Now.Year.ToString().Substring(2) + "-" + DateTime.Now.AddYears(1).Year.ToString().Substring(2) + "/";
                        IssueSno = string.Format("{0}{1}{2}", prefix, result, res.Id);
                        
                    #endregion

                        #region Details
                        if (res.Id > 0)
                        {
                            for (int sno = 0; sno < grdIssueMaster.Rows.Count; sno++)
                            {
                                PurelifeErpClient.DETIssueUserDTO oDETIssueUserDTO = new PurelifeErpClient.DETIssueUserDTO();
                                oDETIssueUserDTO.Id = res.Id;
                                oDETIssueUserDTO.SNo = grdIssueMaster.Rows[sno].Cells["SNo"].Value.ToInt();
                                oDETIssueUserDTO.MaterialDesc = grdIssueMaster.Rows[sno].Cells["ItemId"].Value.ToInt();
                                oDETIssueUserDTO.UMOId = grdIssueMaster.Rows[sno].Cells["UOMId"].Value.ToInt();
                                oDETIssueUserDTO.Qty = grdIssueMaster.Rows[sno].Cells["Qty"].Value.ToFloat();

                                PurelifeErpClient.ERPDTOBase objERPDOBaseDET = oDETIssueUserDTO as PurelifeErpClient.ERPDTOBase;
                                purelifeErpClient.Save(PurelifeErpClient.PageName.DETIssueMaster, objERPDOBaseDET);
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
                            ShowMessage(String.Format("Saved successfully, Your Order No is {0}", IssueSno));
                            viewForm.BindData();
                            ResetMasterControls();
                            txtSno.Text = "";
                            ResetDetailControls();
                            grdIssueMaster.Rows.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorLog.LogErrorInTxtFormat(ex);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region  Control Event

        private void btnItemDesc_Click(object sender, EventArgs e)
        {
            ItemsAdd sForm = new ItemsAdd();
            sForm.Show();
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            string query = string.Format("AliasItemCode='{0}'", txtItemCode.Text.Trim());
            DataRow[] dr = Common.Masters.ItemDesc.Select(query);
            if (dr.Length > 0)
            {
                ddlItemDesc.SelectedValue = dr[0]["Code"].ToString();
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
            catch (Exception ex)
            {

                ErrorLog.LogErrorInTxtFormat(ex);
            }


        }

        private void grdIssueMaster_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.grdIssueMaster.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                //this.grdAccountGroupDetails.Rows[lastindex].DefaultCellStyle.BackColor = Color.SkyBlue; 
                //lastindex = e.RowIndex;
            }
        }

        private void grdIssueMaster_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.grdIssueMaster.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void IssueMaster_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtOrderNo;
            grdIssueMaster.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }
            if (grdIssueMaster.Rows.Count == 0)
            {
                txtSno.Text = "1";
            }
            else
            {
                txtSno.Text = Convert.ToString(grdIssueMaster.Rows.Count + 1);
            }
            txtOrderDate.Focus();
        }

        private void grdIssueMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSno_Leave(object sender, EventArgs e)
        {
            int sno = txtSno.Text.ToInt();
            SetDetailValue(sno);
        }
        #endregion

        #region User Function

        private void BindDropDown()
        {
            FillCombo(ddlUMO, Common.Masters.UMO);
            FillCombo(ddlItemDesc, Common.Masters.ItemDesc);
            FillCombo(ddlIssueTo, Common.Masters.IssueTo);

        }

        private void SetDetailValue(int sno)
        {
            try
            {
                if (sno <= 0 || sno > (grdIssueMaster.Rows.Count))
                { return; }

                txtSno.Text = grdIssueMaster.Rows[sno - 1].Cells["SNO"].Value.ToString();
                txtItemCode.Text = grdIssueMaster.Rows[sno - 1].Cells["ItemCode"].Value.ToString();
                ddlItemDesc.SelectedValue = grdIssueMaster.Rows[sno - 1].Cells["ItemId"].Value.ToString();
                ddlUMO.SelectedValue = grdIssueMaster.Rows[sno - 1].Cells["UOMId"].Value.ToString();
                txtQuantity.Text = grdIssueMaster.Rows[sno - 1].Cells["Qty"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
            }
        }

        public void ResetMasterControls()
        {
            txtOrderNo.Text = string.Empty;
            ddlIssueTo.SelectedIndex = 0;
            txtRemarks.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
        }

        public void ResetDetailControls()
        {
            //txtSno.Clear();
            txtQuantity.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            ddlItemDesc.SelectedIndex = 0;
            ddlUMO.SelectedIndex = 0;
            txtSno.Focus();
        }
        #endregion

     







    }
}


