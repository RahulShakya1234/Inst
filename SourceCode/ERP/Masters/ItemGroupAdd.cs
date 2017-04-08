
using System;

using Common;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace ERP.SalePurchase
{
    public partial class ItemGroupAdd : Global.BaseClass
    {
        private ItemGroupView viewForm;
        Double Code = Double.MinValue;
        string sql = string.Empty;
        public ItemGroupAdd()
        {
            InitializeComponent();

        }

        public ItemGroupAdd(ItemGroupView view)
        {
            viewForm = view;
            Code = 0.0;
            InitializeComponent();
            this.Text = this.Text + " (Add)";
            BindDropDown();
        }
        public ItemGroupAdd(ItemGroupView view, Double code)
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

        //  public AccountAdd(AccountView view)
        //{
        //    viewForm = view;
        //    Code = 0.0;
        //    InitializeComponent();
        //    this.Text = this.Text + " (Add)";
        //    BindDropDown();
        //}

        //public AccountAdd(AccountView view, Double code)
        //{
        //    viewForm = view;
        //    Code = code;
        //    InitializeComponent();
        //    this.Text = this.Text + " (Edit)";
        //    BindDropDown();
        //}

        private void SetButtons()
        {
            btnSave.SetBackGroundImage();
            btnCancel.SetBackGroundImage();
        }
        private void ItemGroupAdd_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtGroupName;
            
            //if (!Code.Equals(0.0))
            //{
            //    //BindData();
            //}
            //BindDropDown();
           // grdAccountDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10.5f, FontStyle.Bold);
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 235, 215);
            //grdAccountDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            this.BackColor = Color.FromArgb(240, 248, 255);
            //grdAccountDetails.EnableHeadersVisualStyles = false;
            //grdAccountDetails.RowHeadersVisible = false;
        
            SetButtons();
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }
            
        }

        
        private void BindDropDown()
        {
            FillCombo(ddlUpperGroup, 8);
            FillCombo(ddlSalableItemGrp, 1);
            FillCombo(ddlAutomaticQC, 1);
            FillCombo(ddlAutoAssemlyfromRGP, 1);
            FillCombo(ddlAutoMRN, 1);
            FillCombo(ddlPORequiredinMRN, 1);
            FillCombo(ddlShowinWorkerOrder, 1);
            FillCombo(ddlMakeAutoProductionEntry, 1);
            FillCombo(ddlScheduleNoRequiredinMRN, 1);
           // FillCombo(ddlPrimaryGroup, Common.Masters.AccountGroup);    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(txtGroupName))
                {
                    return;
                }


                //if (CheckRequiredField(ddlUpperGroup))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlSalableItemGrp))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlAutomaticQC))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlAutoAssemlyfromRGP))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlAutoMRN))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlShowinWorkerOrder))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlMakeAutoProductionEntry))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlScheduleNoRequiredinMRN))
                //{
                //    return;
                //}
                //if (CheckRequiredField(ddlPORequiredinMRN))
                //{
                //    return;
                //}



                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.ItemGroupDTO objAccountDO = new PurelifeErpClient.ItemGroupDTO();
                    objAccountDO.Id = Code.ToInt();

                    objAccountDO.ItemGroupName = txtGroupName.Text.Trim();
                    objAccountDO.UpperGroup = GetInt(ddlUpperGroup.SelectedValue);
                    objAccountDO.Prefix = txtPrefix.Text.Trim();
                    objAccountDO.SalableItemGrp = ddlSalableItemGrp.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.AutomaticQC = ddlAutomaticQC.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.AutoAssemlyfromRGP = ddlAutoAssemlyfromRGP.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.AutoMRN = ddlAutoMRN.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.PORequiredinMRN = ddlPORequiredinMRN.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.ShowinWorkerOrder = ddlShowinWorkerOrder.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.MakeAutoProductionEntry = ddlMakeAutoProductionEntry.SelectedValue.ToString() == "0" ? false : true;
                    objAccountDO.ScheduleNoRequiredinMRN = ddlScheduleNoRequiredinMRN.SelectedValue.ToString() == "0" ? false : true;

                    PurelifeErpClient.ERPDTOBase objERPDOBase = objAccountDO as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.ItemGroup, objERPDOBase);
                    purelifeErpClient.Close();
                }

                viewForm.BindData();

                if (Code > 0)
                {
                    ShowMessage("Updated successfully");
                    Close();
                }
                else
                {
                    ShowMessage("Saved successfully");
                    ResetControls();
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        private void ResetControls()
        {
            txtGroupName.Text = string.Empty;
            ddlUpperGroup.SelectedIndex = 0;
            txtPrefix.Text = string.Empty;
            //ddlSalableItemGrp.SelectedIndex = 0;
            //ddlAutomaticQC.SelectedIndex = 0;
            //ddlAutoMRN.SelectedIndex = 0;
            //ddlPORequiredinMRN.SelectedIndex = 0;
            //ddlShowinWorkerOrder.SelectedIndex = 0;
            //ddlMakeAutoProductionEntry.SelectedIndex = 0;
            //ddlScheduleNoRequiredinMRN.SelectedIndex = 0;
           
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
