using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class PurchaseTypeSetupAdd : Form
    {
        public PurchaseTypeSetupAdd()
        {
            InitializeComponent();
        }
         private PriceListView priceListView;
     
        private static PurchaseTypeSetupAdd sForm = null;
        public static PurchaseTypeSetupAdd Instance()
        {

            if (sForm == null) { sForm = new PurchaseTypeSetupAdd(); }
            return sForm;

        }


        private void bAllButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ddlFormDue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
