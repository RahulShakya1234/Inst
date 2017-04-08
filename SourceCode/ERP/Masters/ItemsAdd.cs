
using System;

using Common;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using ERP.Masters;

namespace ERP.SalePurchase
{
    public partial class ItemsAdd : Global.BaseClass
    {
        private ItemsView viewForm;
        Double Code = Double.MinValue;
        string sql = string.Empty;
        public ItemsAdd()
        {
            InitializeComponent();
           // BindDropDown();
        }
        public ItemsAdd(ItemsView view, Double code)
        {
            viewForm = view;
            Code = code;
            InitializeComponent();
            BindDropDown();
            if (code > 0) { this.Text = this.Text + " (Edit)"; }
            else this.Text = this.Text + " ( Create )"; 
        }
        private void BindDropDown()
        {
            FillCombo(ddlActive, 1);
            FillCombo(ddlTaxableItem, 1);
            FillCombo(ddlMakeMRNJwAuto, 1);
            FillCombo(ddlPackageType,17 );
            FillCombo(ddlItemType, 16);
            FillCombo(ddlExciseRegister, 15);
          
            FillCombo(ddlItemSpecCode,17 );
            FillCombo(ddlRawMaterialUsed, 16);
            FillCombo(ddlPriceListName, 15);
            FillCombo(ddlProcessName, 15);
            FillCombo(ddlRT12Code,1);
            FillCombo(ddlGroupName, Common.Masters.ItemGroup,"Please Select");    
        }

        //private void BindData()
        //{
        //    try
        //    {
        //        string sql = " SELECT * FROM ItemsAdd WHERE Id = " + Code;
        //        DataTable dt = OleDbHelper.ExecuteDataset(Connection.CON, CommandType.Text, sql).Tables[0];
        //        if (dt != null)
        //        {
        //            btnSave.Text = "Update";

        //            txtDisplayName.Text = Convert.ToString(dt.Rows[0]["DisplayName"]);
        //            txtAliceItemCode.Text = Convert.ToString(dt.Rows[0]["ItemCode"]);
        //            txtPrintDescription.Text = Convert.ToString(dt.Rows[0]["PrintDescription"]);
        //            txtBasicUnit.Text = Convert.ToString(dt.Rows[0]["BasicUnit"]);
        //            txtPackage.Text = Convert.ToString(dt.Rows[0]["Package"]);
        //            ddlGroupName.SelectedValue = Convert.ToString(dt.Rows[0]["GroupName"]);
        //            txtStateRate.Text = Convert.ToString(dt.Rows[0]["StateRate"]);
        //            txtMRP.Text = Convert.ToString(dt.Rows[0]["MRP"]);
        //            txtPurchaseRate.Text = Convert.ToString(dt.Rows[0]["PurchaseRate"]);
        //            txtMRPRate.Text = Convert.ToString(dt.Rows[0]["MRPRate"]);
        //            txtExportRate.Text = Convert.ToString(dt.Rows[0]["ExportRate"]);
        //            txtPlatingRate.Text = Convert.ToString(dt.Rows[0]["PlatingRate"]);
        //            txtStockRate.Text = Convert.ToString(dt.Rows[0]["StockRate"]);
        //            txtValue.Text = Convert.ToString(dt.Rows[0]["Value"]);
        //            txtRT12Code.Text = Convert.ToString(dt.Rows[0]["RT12Code"]);
        //            txtTraiffNo.Text = Convert.ToString(dt.Rows[0]["TraiffNo"]);
        //            ddlActive.SelectedValue = Convert.ToString(dt.Rows[0]["Active"]);
        //            ddlTaxableItem.SelectedValue = Convert.ToString(dt.Rows[0]["TaxableItem"]);
        //            ddlExciseRegister.SelectedValue = Convert.ToString(dt.Rows[0]["ExciseRegister"]);
        //            ddlItemType.SelectedValue = Convert.ToString(dt.Rows[0]["ItemType"]);
        //            txtNonExciseStock.Text = Convert.ToString(dt.Rows[0]["NonExciseStock"]);
        //            txtExciseRG1Stock.Text = Convert.ToString(dt.Rows[0]["ExciseRG1Stock"]);
        //            txtExciseRG23AStock.Text = Convert.ToString(dt.Rows[0]["ExciseRG23AStock"]);
        //            txtExciseRG23CStock.Text = Convert.ToString(dt.Rows[0]["ExciseRG23Stock"]);
        //            txtTotalStock.Text = Convert.ToString(dt.Rows[0]["TotalStock"]);
        //            txtMinQuantity.Text = Convert.ToString(dt.Rows[0]["MinQuanity"]);
        //            txtReOrderLevel.Text = Convert.ToString(dt.Rows[0]["ReOrderLevel"]);
        //            txtCutWeight.Text = Convert.ToString(dt.Rows[0]["CutWeight"]);
        //            txtLength.Text = Convert.ToString(dt.Rows[0]["Length"]);
        //            txtBinPackageQty.Text = Convert.ToString(dt.Rows[0]["PackagingQty"]);
        //            txtFreeQtyBin.Text = Convert.ToString(dt.Rows[0]["FreeQty"]);
        //            txtConversionFormule1.Text = Convert.ToString(dt.Rows[0]["ConversionFormule1"]);
        //            txtConversionFormule2.Text = Convert.ToString(dt.Rows[0]["ConversionFormule2"]);
        //            txtMaxQty.Text = Convert.ToString(dt.Rows[0]["MaxQty"]);
        //            txtNetWeight.Text = Convert.ToString(dt.Rows[0]["NetWeight"]);
        //            txtGrossWeight.Text = Convert.ToString(dt.Rows[0]["GrossWeight"]);
        //            txtWidth.Text = Convert.ToString(dt.Rows[0]["Width"]);
        //            txtAlternateUnit.Text = Convert.ToString(dt.Rows[0]["AleternateUnit"]);
        //            txtItemSpecificationCode.Text = Convert.ToString(dt.Rows[0]["ItemSpecificationCode"]);
        //            txtDescriptionForInvoice.Text = Convert.ToString(dt.Rows[0]["Description"]);
        //            txtRackNo.Text = Convert.ToString(dt.Rows[0]["RackNo"]);
        //            ddlMakeMRNJwAuto.SelectedValue = Convert.ToString(dt.Rows[0]["MakeMRNJwAuto"]);
        //            txtItemArea.Text = Convert.ToString(dt.Rows[0]["ItemArea"]);
        //            txtMinOrderQty.Text = Convert.ToString(dt.Rows[0]["MinOrderQty"]);
        //            txtLeadTime.Text = Convert.ToString(dt.Rows[0]["LeadTime"]);
        //            ddlPackageType.SelectedValue = Convert.ToString(dt.Rows[0]["PackagingType"]);
        //            txtCode.Text = Convert.ToString(dt.Rows[0]["Code"]);
        //            ddlRawMaterialUsed.SelectedValue = Convert.ToString(dt.Rows[0]["RawMetrialUsed"]);
        //            ddlPriceListName.SelectedValue = Convert.ToString(dt.Rows[0]["PriceListName"]);
        //            txtRateFactor1.Text = Convert.ToString(dt.Rows[0]["RateFactor1"]);
        //            txtRateFactor2.Text = Convert.ToString(dt.Rows[0]["RateFactor2"]);
        //            txtRateFactor3.Text = Convert.ToString(dt.Rows[0]["RateFactor3"]);
        //            txtRateFactor4.Text = Convert.ToString(dt.Rows[0]["RateFactor4"]);
        //            ddlProcessName.SelectedValue = Convert.ToString(dt.Rows[0]["ProcessName"]);


        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        //ErrorLog.LogErrorInTxtFormat(exception);
        //    }
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ddlGroupName.SelectedValue = 1; ddlActive.SelectedValue = 1; ddlTaxableItem.SelectedValue = 1; ddlExciseRegister.SelectedValue = 1; ddlItemType.SelectedValue = 1;
        //        ddlMakeMRNJwAuto.SelectedValue = 1; ddlPackageType.SelectedValue = 1; ddlRawMaterialUsed.SelectedValue = 1; ddlPriceListName.SelectedValue = 1; ddlProcessName.SelectedValue = 1;
        //        if (Code > 0)
        //        {


        //            //sql = "update ItemsAdd set " +
        //            //"DisplayName = '" + txtDisplayName.Text.Trim() + "'," +
        //            //"ItemCode = '" + txtAliceItemCode.Text.Trim() + "'," +
        //            //"PrintDescription = '" + txtPrintDescription.Text.Trim() + "'," +
        //            //"BasicUnit = '" + txtBasicUnit.Text.Trim() + "'," +
        //            //"Package = '" + txtPackage.Text.Trim() + "'," +
        //            //"GroupName = '" + GetInt(ddlGroupName.SelectedValue) + "'," +
        //            //"StateRate= '" + txtStateRate.Text.Trim() + "'," +
        //            //"MRP= '" + txtMRP.Text.Trim() + "'," +
        //            //"PurchaseRate = '" + txtPurchaseRate.Text.Trim() + "'," +
        //            //"MRPRate = '" + txtMRPRate.Text.Trim() + "'," +
        //            //"ExportRate = '" + txtExportRate.Text.Trim() + "'," +
        //            //"PlatingRate= '" + txtPlatingRate.Text.Trim() + "'," +
        //            //"StockRate = '" + txtStockRate.Text.Trim() + "'," +
        //            //"[Value] = '" + txtValue.Text.Trim() + "'," +
        //            //"RT12Code= '" + txtRT12Code.Text.Trim() + "'," +
        //            //"TraiffNo = '" + txtTraiffNo.Text.Trim() + "'," +
        //            //"Active = '" + GetInt(ddlActive.SelectedValue) + "'," +
        //            //"TaxableItem= '" + GetInt(ddlTaxableItem.SelectedValue) + "'," +
        //            //"ExciseRegister= '" + GetInt(ddlExciseRegister.SelectedValue) + "'," +
        //            //"ItemType = '" + GetInt(ddlItemType.SelectedValue) + "'," +
        //            //"NonExciseStock = '" + txtNonExciseStock.Text.Trim() + "'," +
        //            //"ExciseRG1Stock = '" + txtExciseRG1Stock.Text.Trim() + "'," +
        //            //"ExciseRG23AStock = '" + txtExciseRG23AStock.Text.Trim() + "'," +
        //            //"ExciseRG23Stock = '" + txtExciseRG23CStock.Text.Trim() + "'," +
        //            //"TotalStock = '" + txtTotalStock.Text.Trim() + "'," +
        //            //"MinQuanity = '" + txtMinQuantity.Text.Trim() + "'," +
        //            //"ReOrderLevel = '" + txtReOrderLevel.Text.Trim() + "'," +
        //            //"CutWeight= '" + txtCutWeight.Text.Trim() + "'," +
        //            //"Length = '" + txtLength.Text.Trim() + "'," +
        //            //"PackagingQty = '" + txtBinPackageQty.Text.Trim() + "'," +
        //            //"FreeQty= '" + txtFreeQtyBin.Text.Trim() + "'," +
        //            //"ConversionFormule1= '" + txtConversionFormule1.Text.Trim() + "'," +
        //            //"ConversionFormule2= '" + txtConversionFormule2.Text.Trim() + "'," +
        //            //"MaxQty= '" + txtMaxQty.Text.Trim() + "'," +
        //            //"NetWeight= '" + txtNetWeight.Text.Trim() + "'," +
        //            //"GrossWeight= '" + txtGrossWeight.Text.Trim() + "'," +
        //            //"Width= '" + txtWidth.Text.Trim() + "'," +
        //            //"AleternateUnit= '" + txtAlternateUnit.Text.Trim() + "'," +
        //            //"ItemSpecificationCode= '" + txtItemSpecificationCode.Text.Trim() + "'," +
        //            //"Description= '" + txtDescriptionForInvoice.Text.Trim() + "'," +
        //            //"RackNo= '" + txtRackNo.Text.Trim() + "'," +
        //            //"MakeMRNJwAuto= '" + GetInt(ddlMakeMRNJwAuto.SelectedValue) + "'," +
        //            //"ItemArea= '" + txtItemArea.Text.Trim() + "'," +
        //            //"MinOrderQty= '" + txtMinOrderQty.Text.Trim() + "'," +
        //            //"LeadTime= '" + txtLeadTime.Text.Trim() + "'," +
        //            //"PackagingType= '" + GetInt(ddlPackageType.SelectedValue) + "'," +
        //            //"Code= '" + txtCode.Text.Trim() + "'," +
        //            //"RawMetrialUsed= '" + GetInt(ddlRawMaterialUsed.SelectedValue) + "'," +
        //            //"PriceListName= '" + GetInt(ddlPriceListName.SelectedValue) + "'," +
        //            //"RateFactor1= '" + txtRateFactor1.Text.Trim() + "'," +
        //            //"RateFactor2= '" + txtRateFactor2.Text.Trim() + "'," +
        //            //"RateFactor3= '" + txtRateFactor3.Text.Trim() + "'," +
        //            //"RateFactor4= '" + txtRateFactor4.Text.Trim() + "'," +
        //            //"ProcessName= '" + GetInt(ddlProcessName.SelectedValue) + "' " +
        //            //"where ID=" + Code;


        //            sql = "update ItemsAdd set " +
        //            "DisplayName = '" + txtDisplayName.Text.Trim() + "'," +
        //            "ItemCode = '" + txtAliceItemCode.Text.Trim() + "'," +
        //            "PrintDescription = '" + txtPrintDescription.Text.Trim() + "'," +
        //            "BasicUnit = '" + txtBasicUnit.Text.Trim() + "'," +
        //            "Package = '" + txtPackage.Text.Trim() + "'," +
        //            "GroupName = '" + GetInt(1) + "'," +
        //            "StateRate= '" + txtStateRate.Text.Trim() + "'," +
        //            "MRP= '" + txtMRP.Text.Trim() + "'," +
        //            "PurchaseRate = '" + txtPurchaseRate.Text.Trim() + "'," +
        //            "MRPRate = '" + txtMRPRate.Text.Trim() + "'," +
        //            "ExportRate = '" + txtExportRate.Text.Trim() + "'," +
        //            "PlatingRate= '" + txtPlatingRate.Text.Trim() + "'," +
        //            "StockRate = '" + txtStockRate.Text.Trim() + "'," +
        //            "[Value] = '" + txtValue.Text.Trim() + "'," +
        //            "RT12Code= '" + txtRT12Code.Text.Trim() + "'," +
        //            "TraiffNo = '" + txtTraiffNo.Text.Trim() + "'," +
        //            "Active = '" + GetInt(1) + "'," +
        //            "TaxableItem= '" + GetInt(1) + "'," +
        //            "ExciseRegister= '" + GetInt(1) + "'," +
        //            "ItemType = '" + GetInt(1) + "'," +
        //            "NonExciseStock = '" + txtNonExciseStock.Text.Trim() + "'," +
        //            "ExciseRG1Stock = '" + txtExciseRG1Stock.Text.Trim() + "'," +
        //            "ExciseRG23AStock = '" + txtExciseRG23AStock.Text.Trim() + "'," +
        //            "ExciseRG23Stock = '" + txtExciseRG23CStock.Text.Trim() + "'," +
        //            "TotalStock = '" + txtTotalStock.Text.Trim() + "'," +
        //            "MinQuanity = '" + txtMinQuantity.Text.Trim() + "'," +
        //            "ReOrderLevel = '" + txtReOrderLevel.Text.Trim() + "'," +
        //            "CutWeight= '" + txtCutWeight.Text.Trim() + "'," +
        //            "Length = '" + txtLength.Text.Trim() + "'," +
        //            "PackagingQty = '" + txtBinPackageQty.Text.Trim() + "'," +
        //            "FreeQty= '" + txtFreeQtyBin.Text.Trim() + "'," +
        //            "ConversionFormule1= '" + txtConversionFormule1.Text.Trim() + "'," +
        //            "ConversionFormule2= '" + txtConversionFormule2.Text.Trim() + "'," +
        //            "MaxQty= '" + txtMaxQty.Text.Trim() + "'," +
        //            "NetWeight= '" + txtNetWeight.Text.Trim() + "'," +
        //            "GrossWeight= '" + txtGrossWeight.Text.Trim() + "'," +
        //            "Width= '" + txtWidth.Text.Trim() + "'," +
        //            "AleternateUnit= '" + txtAlternateUnit.Text.Trim() + "'," +
        //            "ItemSpecificationCode= '" + txtItemSpecificationCode.Text.Trim() + "'," +
        //            "Description= '" + txtDescriptionForInvoice.Text.Trim() + "'," +
        //            "RackNo= '" + txtRackNo.Text.Trim() + "'," +
        //            "MakeMRNJwAuto= '" + GetInt(1) + "'," +
        //            "ItemArea= '" + txtItemArea.Text.Trim() + "'," +
        //            "MinOrderQty= '" + txtMinOrderQty.Text.Trim() + "'," +
        //            "LeadTime= '" + txtLeadTime.Text.Trim() + "'," +
        //            "PackagingType= '" + GetInt(1) + "'," +
        //            "Code= '" + txtCode.Text.Trim() + "'," +
        //            "RawMetrialUsed= '" + GetInt(1) + "'," +
        //            "PriceListName= '" + GetInt(1) + "'," +
        //            "RateFactor1= '" + txtRateFactor1.Text.Trim() + "'," +
        //            "RateFactor2= '" + txtRateFactor2.Text.Trim() + "'," +
        //            "RateFactor3= '" + txtRateFactor3.Text.Trim() + "'," +
        //            "RateFactor4= '" + txtRateFactor4.Text.Trim() + "'," +
        //            "ProcessName= '" + GetInt(1) + "' " +
        //            "where ID=" + Code;

        //           int i= OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, sql);
        //           if (i>0)
        //           {
        //               MessageBox.Show("updtate");
        //               this.Close();
        //           }
        //           else
        //           {
        //               MessageBox.Show("Some Error! Check ");
        //           }
                    
        //        }

        //        else
        //        {

        //            //sql = "insert into ItemsAdd (DisplayName,ItemCode,PrintDescription,BasicUnit,Package ,GroupName,StateRate,MRP,PurchaseRate,MRPRate,ExportRate,PlatingRate,"+
        //            //"StockRate,Value,RT12Code,TraiffNo,Active,TaxableItem,ExciseRegister,ItemType,NonExciseStock,ExciseRG1Stock,ExciseRG23AStock,ExciseRG23Stock,TotalStock,"+
        //            //"MinQuanity,ReOrderLevel,CutWeight,Length,PackagingQty,FreeQty" + "ConversionFormule1,ConversionFormule2,MaxQty,NetWeight,GrossWeight,Width,AleternateUnit,"+
        //            //"ItemSpecificationCode,Description,RackNo,MakeMRNJwAuto,ItemArea,MinOrderQty,LeadTime,PackagingType,Code," +
        //            //"RawMetrialUsed,PriceListName,RateFactor1,RateFactor2,RateFactor3,RateFactor4,ProcessName) " +
        //            //"Values ( " + txtDisplayName.Text.Trim() + "," + txtAliceItemCode.Text.Trim() + "," + txtPrintDescription.Text.Trim() + "," + txtBasicUnit.Text.Trim() + "," + txtPackage.Text.Trim() + "," + GetInt(ddlGroupName.SelectedValue) + "," + txtStateRate.Text.Trim() + "," + txtMRP.Text.Trim() + "," + txtPurchaseRate.Text.Trim() + "," + txtMRPRate.Text.Trim() + "," + txtExportRate.Text.Trim() + "," + txtPlatingRate.Text.Trim() + "," + txtStockRate.Text.Trim() + "," + txtValue.Text.Trim() + "," + txtRT12Code.Text.Trim() + "," + txtTraiffNo.Text.Trim() + "," + GetInt(ddlActive.SelectedValue) + "," + GetInt(ddlTaxableItem.SelectedValue) + "," + GetInt(ddlExciseRegister.SelectedValue) + "," + GetInt(ddlItemType.SelectedValue) + "," + txtNonExciseStock.Text.Trim() + "," + txtExciseRG1Stock.Text.Trim() + "," + txtExciseRG23AStock.Text.Trim() + "," + txtExciseRG23CStock.Text.Trim() + "," + txtTotalStock.Text.Trim() + "," + txtMinOrderQty.Text.Trim() + "," + txtReOrderLevel.Text.Trim() + "," + txtCutWeight.Text.Trim() + "," + txtLength.Text.Trim()+ "," +txtBinPackageQty.Text.Trim()+","+txtFreeQtyBin.Text.Trim()+","+txtConversionFormule1.Text.Trim()+","+txtConversionFormule2.Text.Trim()+","+txtMaxQty.Text.Trim()+","+txtNetWeight.Text.Trim()+","+txtGrossWeight.Text.Trim()+","+txtWidth.Text.Trim()+","+txtAlternateUnit.Text.Trim()+","+txtItemSpecificationCode.Text.Trim()+","+txtDescriptionForInvoice.Text.Trim()+","+txtRackNo.Text.Trim()+","+GetInt(ddlMakeMRNJwAuto.SelectedValue)+","+txtItemArea.Text.Trim()+","+txtMinOrderQty.Text.Trim()+","+txtLeadTime.Text.Trim()+","+GetInt(ddlPackageType.SelectedValue)+","+txtCode.Text.Trim()+","+GetInt(ddlRawMaterialUsed.SelectedValue)+","+GetInt(ddlPriceListName.SelectedValue)+","+txtRateFactor1.Text.Trim()+","+txtRateFactor2.Text.Trim()+","+txtRateFactor3.Text.Trim()+","+txtRateFactor4.Text.Trim()+","+GetInt(ddlProcessName.SelectedValue)+")";

        //            sql = "insert into ItemsAdd (DisplayName,ItemCode,PrintDescription,BasicUnit,Package ,GroupName,StateRate,MRP,PurchaseRate,MRPRate,ExportRate,PlatingRate," +
        //            "StockRate,[Value],RT12Code,TraiffNo,Active,TaxableItem,ExciseRegister,ItemType,NonExciseStock,ExciseRG1Stock,ExciseRG23AStock,ExciseRG23Stock,TotalStock," +
        //            "MinQuanity,ReOrderLevel,CutWeight,Length,PackagingQty,FreeQty," + "ConversionFormule1,ConversionFormule2,MaxQty,NetWeight,GrossWeight,Width,AleternateUnit," +
        //            "ItemSpecificationCode,Description,RackNo,MakeMRNJwAuto,ItemArea,MinOrderQty,LeadTime,PackagingType,Code," +
        //            "RawMetrialUsed,PriceListName,RateFactor1,RateFactor2,RateFactor3,RateFactor4,ProcessName) " +
        //            "Values ( '" + txtDisplayName.Text.Trim() + "','" + txtAliceItemCode.Text.Trim() + "','" + txtPrintDescription.Text.Trim() + "','" + txtBasicUnit.Text.Trim() + "','" + txtPackage.Text.Trim() + "','" + GetInt(1) + "','" + txtStateRate.Text.Trim() + "','" + txtMRP.Text.Trim() + "','" + txtPurchaseRate.Text.Trim() + "','" + txtMRPRate.Text.Trim() + "','" + txtExportRate.Text.Trim() + "','" + txtPlatingRate.Text.Trim() + "','" + txtStockRate.Text.Trim() + "','" + txtValue.Text.Trim() + "','" + txtRT12Code.Text.Trim() + "','" + txtTraiffNo.Text.Trim() + "','" + GetInt(1) + "','" + GetInt(1) + "','" + GetInt(1) + "','" + GetInt(1) + "','" + txtNonExciseStock.Text.Trim() + "','" + txtExciseRG1Stock.Text.Trim() + "','" + txtExciseRG23AStock.Text.Trim() + "','" + txtExciseRG23CStock.Text.Trim() + "','" + txtTotalStock.Text.Trim() + "','" + txtMinOrderQty.Text.Trim() + "','" + txtReOrderLevel.Text.Trim() + "','" + txtCutWeight.Text.Trim() + "','" + txtLength.Text.Trim() + "','" + txtBinPackageQty.Text.Trim() + "','" + txtFreeQtyBin.Text.Trim() + "','" + txtConversionFormule1.Text.Trim() + "','" + txtConversionFormule2.Text.Trim() + "','" + txtMaxQty.Text.Trim() + "','" + txtNetWeight.Text.Trim() + "','" + txtGrossWeight.Text.Trim() + "','" + txtWidth.Text.Trim() + "','" + txtAlternateUnit.Text.Trim() + "','" + txtItemSpecificationCode.Text.Trim() + "','" + txtDescriptionForInvoice.Text.Trim() + "','" + txtRackNo.Text.Trim() + "','" + GetInt(1) + "','" + txtItemArea.Text.Trim() + "','" + txtMinOrderQty.Text.Trim() + "','" + txtLeadTime.Text.Trim() + "','" + GetInt(1) + "','" + txtCode.Text.Trim() + "','" + GetInt(1) + "','" + GetInt(1) + "','" + txtRateFactor1.Text.Trim() + "','" + txtRateFactor2.Text.Trim() + "','" + txtRateFactor3.Text.Trim() + "','" + txtRateFactor4.Text.Trim() + "','" + GetInt(1) + "')";

        //          int i= OleDbHelper.ExecuteNonQuery(Connection.CON, CommandType.Text, sql);
        //            if (i > 0)
        //            {
        //                MessageBox.Show("Save");
        //                this.Close();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Some Error! Check ");
        //            }
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        private void ItemsAdd_Load(object sender, EventArgs e)
        {

            this.ActiveControl = txtDisplayName;
            if (!Code.Equals(0.0))
            {
                //BindData();
            }
              //BindDropDown();  // creating problm while linking to another page
            this.BackColor = Color.FromArgb(240, 248, 255);
            if (Code > 0)
            {
                btnSave.Text = "Update";
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tzbGeneralInfo_Click(object sender, EventArgs e)
        {

        }

        private void txtMinQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRateFactor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            ItemGroupAdd sForm = new ItemGroupAdd();
            sForm.Show();
          
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredField(txtDisplayName))
                {
                    return;
                }

                if (CheckRequiredField(txtAliasItemCode))
                {
                    return;
                }
                    //if (CheckRequiredField(ddlActive))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlExciseRegister))
                    //{
                    //    return;
                    //}
                    if (CheckRequiredField(ddlGroupName))
                    {
                        return;
                    }
                    //if (CheckRequiredField(ddlItemSpecCode))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlItemType))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlMakeMRNJwAuto))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlPriceListName))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlPackageType))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlProcessName))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlRawMaterialUsed))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlRT12Code))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(ddlTaxableItem))
                    //{
                    //    return;
                    //}
                    //if (CheckRequiredField(txtDisplayName))
                    //{
                    //    return;
                    //}
                

                using (PurelifeErpClient.PurelifeErpClient purelifeErpClient = new PurelifeErpClient.PurelifeErpClient())
                {
                    PurelifeErpClient.ItemDTO objItemDT = new PurelifeErpClient.ItemDTO();
                    objItemDT.Id = Code.ToInt();
                   

                    objItemDT.DisplayName = txtDisplayName.Text.Trim();//AccountName
                    objItemDT.AliasItemCode = txtAliasItemCode.Text.Trim();
                    objItemDT.PrintDescription = txtPrintDescription.Text.Trim();
                    objItemDT.BasicUnit = txtBasicUnit.Text.ToFloat();
                    objItemDT.Package = txtPackage.Text.Trim();

                    objItemDT.GroupName = GetInt(ddlGroupName.SelectedValue);


                    objItemDT.SaleRate = txtSaleRate.Text.ToFloat();
                    objItemDT.MRP = txtMRP.Text.ToFloat();

                    objItemDT.PurchaseRate = txtPurchaseRate.Text.ToFloat();
                    objItemDT.MRPRate = txtMRPRate.Text.ToFloat();

                    objItemDT.ExportRate = txtExportRate.Text.ToFloat();
                    objItemDT.PlatingRate = txtPlatingRate.Text.ToFloat();

                    objItemDT.StockRate = txtStockRate.Text.ToFloat();
                    objItemDT.Value = txtValue.Text.ToFloat();

                    objItemDT.RT12Code = GetInt(ddlRT12Code.SelectedValue);
                    objItemDT.TraiffNo = txtTraiffNo.Text.Trim();

                    objItemDT.Active = ddlActive.SelectedValue.ToString() == "0" ? false : true;

                    objItemDT.TaxableItem = ddlTaxableItem.SelectedValue.ToString() == "0" ? false : true;
                    objItemDT.ExciseRegister = GetInt(ddlExciseRegister.SelectedValue);
                    objItemDT.ItemType = GetInt(ddlItemType.SelectedValue);

                    objItemDT.NonExciseStock = txtNonExciseStock.Text.ToFloat();
                    objItemDT.ExciseRG1Stock = txtExciseRG1Stock.Text.ToFloat();
                    objItemDT.ExciseRG23AStock = txtExciseRG23AStock.Text.ToFloat();
                    objItemDT.ExciseRG23CStock = txtExciseRG23CStock.Text.ToFloat();
                    objItemDT.TotalStock = txtTotalStock.Text.ToFloat();

                    //Other Info(Tab)
                    objItemDT.MinQuantity = txtMinQuantity.ToFloat();
                    objItemDT.MaxQty = txtMaxQty.Text.ToFloat();

                    objItemDT.ReOrderLevel = txtReOrderLevel.Text.ToFloat();
                    objItemDT.NetWeight = txtNetWeight.Text.ToFloat();

                    objItemDT.CutWeight = txtCutWeight.Text.ToFloat();
                    objItemDT.GrossWeight = txtGrossWeight.Text.ToFloat();

                    objItemDT.Length = txtLength.Text.ToFloat();
                    objItemDT.Width = txtWidth.Text.ToFloat();

                    objItemDT.BinPackageQty = txtBinPackageQty.Text.ToFloat();
                    objItemDT.FreeQtyBin = txtFreeQtyBin.Text.ToFloat();
                    objItemDT.AlternateUnit = txtAlternateUnit.Text.ToFloat();

                    objItemDT.ConversionFormule1 = txtConversionFormule1.Text.Trim();
                    objItemDT.ConversionFormule2 = txtConversionFormule2.Text;
                    objItemDT.ItemSpecCode = GetInt(ddlItemSpecCode.SelectedValue);

                    objItemDT.DescriptionForInvoice = txtDescriptionForInvoice.Text.Trim();

                    objItemDT.RackNo = txtRackNo.Text.Trim();
                    objItemDT.MakeMRNJwAuto = ddlMakeMRNJwAuto.SelectedValue.ToString() == "0" ? false : true;

                    objItemDT.ItemArea = txtItemArea.Text.ToFloat();

                    objItemDT.FileName = txtFileName.Text.Trim();

                    objItemDT.MinOrderQty = txtMinOrderQty.Text.ToFloat();
                    objItemDT.LeadTime = txtLeadTime.Text.ToFloat();

                    objItemDT.PackageType = GetInt(ddlPackageType.SelectedValue);

                    objItemDT.Code = txtCode.Text.Trim();
                    objItemDT.RawMaterialUsed = GetInt(ddlRawMaterialUsed.SelectedValue);
                    objItemDT.PriceListName = GetInt(ddlPriceListName.SelectedValue);


                    objItemDT.RateFactor1 = txtRateFactor1.Text.ToFloat();
                    objItemDT.RateFactor2 = txtRateFactor2.Text.ToFloat();
                    objItemDT.RateFactor3 = txtRateFactor3.Text.ToFloat();
                    objItemDT.RateFactor4 = txtRateFactor4.Text.ToFloat();

                    objItemDT.ProcessName = GetInt(ddlProcessName.SelectedValue);

                    PurelifeErpClient.ERPDTOBase objERPDOBase = objItemDT as PurelifeErpClient.ERPDTOBase;
                    purelifeErpClient.Save(PurelifeErpClient.PageName.Item, objERPDOBase);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ResetControls()
        {
            txtDisplayName.Text = string.Empty;
            txtAliasItemCode.Text = string.Empty;
            txtPrintDescription.Text = string.Empty;
            txtBasicUnit.Text = string.Empty;
            txtPackage.Text = string.Empty;
            ddlGroupName.SelectedIndex = 0;
            txtSaleRate.Text = string.Empty;
            txtMRP.Text = string.Empty;
            txtPurchaseRate.Text = string.Empty;
            txtMRPRate.Text = string.Empty;
          
            txtExportRate.Text = string.Empty;
            txtPlatingRate.Text = string.Empty;
            txtStockRate.Text = string.Empty;
            txtValue.Text = string.Empty;
            ddlRT12Code.SelectedIndex = 0;
            txtTraiffNo.Text = string.Empty;
            ddlActive.SelectedIndex = 0;
            ddlExciseRegister.SelectedIndex = 0;
            ddlTaxableItem.SelectedIndex = 0;
            ddlItemType.SelectedIndex = 0;
            txtNonExciseStock.Text = string.Empty;
            txtExciseRG1Stock.Text = string.Empty;
            txtExciseRG23AStock.Text = string.Empty;
            txtExciseRG23CStock.Text = string.Empty;
            txtTotalStock.Text = string.Empty;

            txtMinQuantity.Text = string.Empty;
            txtMaxQty.Text = string.Empty;
            txtReOrderLevel.Text = string.Empty;
            txtNetWeight.Text = string.Empty;

            txtCutWeight.Text = string.Empty;
            txtGrossWeight.Text = string.Empty;
            txtLength.Text = string.Empty;
            txtWidth.Text = string.Empty;
            txtBinPackageQty.Text = string.Empty;
            txtFreeQtyBin.Text = string.Empty;


            txtAlternateUnit.Text = string.Empty;
            txtConversionFormule1.Text = string.Empty;
            txtConversionFormule2.Text = string.Empty;
            ddlItemSpecCode.SelectedIndex = 0;

            txtDescriptionForInvoice.Text = string.Empty;
            txtRackNo.Text = string.Empty;
            ddlMakeMRNJwAuto.SelectedIndex = 0;

            txtItemArea.Text = string.Empty;
            txtFileName.Text = string.Empty;
            txtMinOrderQty.Text = string.Empty;
            ddlPriceListName.SelectedIndex = 0;
            txtLeadTime.Text = string.Empty;
            ddlPackageType.SelectedIndex = 0;
            txtRateFactor1.Text = string.Empty;
            txtRateFactor2.Text = string.Empty;
            txtRateFactor3.Text = string.Empty;
            txtRateFactor4.Text = string.Empty;
            txtCode.Text = string.Empty;
            ddlRawMaterialUsed.SelectedIndex = 0;
            ddlProcessName.SelectedIndex = 0;
            ddlPriceListName.SelectedIndex = 0;


        }

    }
}
