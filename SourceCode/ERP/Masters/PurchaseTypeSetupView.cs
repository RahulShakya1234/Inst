using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class PurchaseTypeSetupView : Form
    {
        public PurchaseTypeSetupView()
        {
            InitializeComponent();
        }
        private static PurchaseTypeSetupView sForm = null;
        public static PurchaseTypeSetupView Instance()
        {

            if (sForm == null) { sForm = new PurchaseTypeSetupView(); }
            return sForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form sForm = PurchaseTypeSetupAdd.Instance();
            //sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
            
        }

    }
}
