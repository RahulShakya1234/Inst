using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Common;
using ERP.ACvoucher;
using ERP.Masters;
using ERP.SalePurchase;
using ERP.SalePurchase.SalePurchase;
using System.Data;

namespace ERP
{
    public partial class MDIParentApp : Form
    {
        readonly KeyValue loginResult = new KeyValue();
        public MDIParentApp()
        {

            var loginForm = new Login(loginResult);
            loginForm.ShowDialog();

            if (loginResult.Value == "true")
            {
                InitializeComponent();
            }
            else
            {
                Application.Exit();
            }
        }

        private void mnuClients_Click(object sender, EventArgs e)
        {
            //Form sForm = ClientsView.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = AccountsView.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = ItemsView.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }



        private void jobCradToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void ShowToolForm()
        {

        }

        private void MDIParentTM_Load(object sender, EventArgs e)
        {
            var thread = new Thread(new ThreadStart(LoadMasters)) { IsBackground = true };
            thread.Start();

            SetPageBG();

            this.toolStripStatusLabel.Text = "User Name : " + SessionManager.UserName;

            menuControlPanel.Items.Add("Party Master", "Create Party", Properties.Resources.mypc);
            menuControlPanel.Items.Add("Item Master", "Create Item", Properties.Resources.mypc);
            menuControlPanel.Items.Add("Purchase Order", "Create PO", Properties.Resources.mypc);
            menuControlPanel.Items.Add("Item Master", "Create Item", Properties.Resources.mypc);

            menuControlPanel.MenuStartColor = Color.FromArgb(239, 239, 239);
            menuControlPanel.MenuEndColor = Color.FromArgb(202, 202, 202);
            menuControlPanel.MenuInnerBorderColor = Color.FromArgb(254, 254, 254);
            menuControlPanel.MenuOuterBorderColor = Color.FromArgb(192, 192, 192);
            menuControlPanel.SideBar = false;
            menuControlPanel.SideBarCaption = "DESKTOP-MENU-GATEWAY";
            menuControlPanel.SideBarEndGradient = Color.FromArgb(202, 202, 202);
            menuControlPanel.SideBarStartGradient = Color.FromArgb(202, 202, 202);
            menuControlPanel.SideBarFontColor = Color.Black;
            //menuControlPanel.SideBarBitmap = ((Bitmap)MenuControlTest.Properties.Resources.favorites.GetThumbnailImage(22, 22, null, IntPtr.Zero));
            foreach (VistaMenuControl.VistaMenuItem item in menuControlPanel.Items)
            {
                item.SelectionStartColor = Color.FromArgb(152, 193, 233);
                item.SelectionEndColor = Color.FromArgb(134, 186, 237);
                item.SelectionStartColorStart = Color.FromArgb(104, 169, 234);
                item.SelectionEndColorEnd = Color.FromArgb(169, 232, 255);
                item.InnerBorder = Color.FromArgb(254, 254, 254);
                item.OuterBorder = Color.FromArgb(231, 231, 231);
                item.CaptionFont = new Font("Tahoma", 10, FontStyle.Bold);
                item.ContentFont = new Font("Tahoma", 7);
                item.CaptionColor = Color.Black;
                item.ContentColor = Color.Black;
            }
            this.menuControlPanel.Visible = true;
        }

        private void SetPageBG()
        {
            try
            {
                string imagepath = "background.jpg";
                System.IO.FileStream fs;

                if (System.IO.File.Exists(imagepath))
                {
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    // Read Image file
                    fs = System.IO.File.OpenRead(imagepath);
                    fs.Position = 0;
                    // Change MDI From back ground picture
                    foreach (Control ctl in this.Controls)
                    {
                        if (ctl is MdiClient)
                        {
                            //ctl.BackColor = Color.AntiqueWhite;
                            ctl.BackgroundImage = System.Drawing.Image.FromStream(fs);
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
        }

        public void LoadMasters()
        {
            try
            {
                menuStrip.Invoke(new Action(() => menuStrip.Enabled = false));
                lblInfo.Invoke(new Action(() => lblInfo.Text = "Please wait.."));
                using (var purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    Common.Masters.AccountGroup = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.AccountGroup);
                    Common.Masters.ItemGroup = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.ItemGroup);
                    Common.Masters.SaleOrderReceivgEntry = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.Account);
                    Common.Masters.SaleOrderReceivgEntry = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.SaleOrderReceivingEntryDET);
                    Common.Masters.ItemDesc = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.ItemDescp);
                    Common.Masters.UMO = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.UMO);

                    Common.Masters.Department = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.Dept);
                    Common.Masters.Designation = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.Desig);
                    Common.Masters.SoftwareRole = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.SoftwareRole);
                    Common.Masters.Location = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.Location);
                    Common.Masters.IssueTo = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.MSTIssueMaster);

                    DataTable dt = purelifeErpClient.MastersListing(PurelifeErpClient.PageName.Account);
                    DataTable dtTemp = new DataTable();
                    dtTemp.Columns.Add("Code");
                    dtTemp.Columns.Add("Value");
                    dtTemp.Columns.Add("AccType");
                    DataRow[] s = null;
                    DataRow row = dtTemp.NewRow();
                    s = dt.Select("AccType=4");
                    foreach (DataRow item in s)
                    {
                        DataRow dr = dtTemp.NewRow();
                        dr["Code"] = item["Code"];
                        dr["Value"] = item["Value"];
                        dr["AccType"] = item["AccType"];
                        dtTemp.Rows.Add(dr);
                    }
                    //dtTemp.Rows.Add(dt.Select("AccType=4"));
                    Common.Masters.AccountType = dtTemp;

                    purelifeErpClient.Close();
                }

                lblInfo.Invoke(new Action(() => lblInfo.Text = ""));
                menuStrip.Invoke(new Action(() => menuStrip.Enabled = true));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void jobcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = JobCard.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void jobRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = JobRegister.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void accountBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = AccountBook.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void dayBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = DayBook.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void wagesRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = WagesRegister.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = WorkersView.Instance();          
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = ShopInformation.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void jobDeliverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // new FrameStyle().Equals( int 2);   
            Form sForm = AccountView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void accountGroupViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = AccountGroupView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void itemRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = ItemRateSetupView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void stateViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = StateView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void costcenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = CostCenterView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void narrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = NarrationView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }


        private void priceListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = PriceListView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void sTFormSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Form sForm = STFormSetup.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void voucherSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = grdVoucher.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void tariffAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = TariffView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void partyWiseSalePurchaseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partyWiseSaleRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthlyScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deliveryScheduleReportAllToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void joiunalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = JournalView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void saleInvoiceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = SaleInvoiceEntry.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void contraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = ContraVoucherView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void cashReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = CashReceiptVoucherView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void cashPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = CashPaymentView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void bankReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = BankReceiptView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void bankPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = BankPaymentView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void ledgerDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Form sForm = LedgerDisplay.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void trialBalanceDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = TrialBalanceDisplay.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void dayBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Form sForm = DayBook.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void cashBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = CashBankBook.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void viewLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = ViewLedger.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void voucherAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = VoucherAnalysis.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void costCenterLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = CostCentreLedger.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void billWiseOutstandingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = BillWiseoutstanding.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void voucheerSeriesViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = VoucherSeriesView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void salePurchaseRegisterViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = SalePurcahseRegisterView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void narrationViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = NarrationView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void dailyScheduleEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = DailyScheduleEntryView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }



        private void costCenterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form sForm = CostCenterView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void saleOrderReceiveEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = SaleOrderReceivingEntry.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void saleOrderListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = SaleOrderListing.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void pendingSaleOrderItemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = SaleOrderPendingReport.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void pendingSalesOrderPartyWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = SaleOrderPendingReport_Party_wise_.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void pendingSaleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = PendingSaleOrderReport.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void itemGroupViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = ItemGroupView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void itemViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = ItemsView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void saleTypeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SaleTypeSetupAdd
            Form sForm = SaleTypeView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void partyWiseItemRateSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = PartyWiseItemRateList.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = StateView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void priceListViewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form sForm = PriceListView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void sTFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = STFormView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void purchaseTypeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = PurchaseTypeSetupView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void purchaseInvoiceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = PurcahseBillView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void uMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = UOMView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form sForm = DirectEntryView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = LocationView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void softwareRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = SoftwareRoleView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = DesigView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = DeptView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sForm = UserView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }

        private void issueMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = IssueMasterView.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }

        private void IssueMasterToolStrip_Click(object sender, EventArgs e)
        {
            Form sForm = IssueMasterView.Instance();
            sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

        private void userViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyValue k = new KeyValue();
            ExitForm ef = new ExitForm(k);

            ef.ShowDialog();

            switch (k.Key)
            {
                case "Exit":
                    Application.Exit();
                    break;
                case "Change":
                    Application.Restart();
                    break;
                case "Cancel":
                    break;
                default:
                    break;
            }
        }

        private void purchaseOrderRequisitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form sForm = PurchaseOrderRequisitionView.Instance();
            //sForm.MdiParent = this;
            //sForm.Show();
            //sForm.Activate();
        }


    }
}
