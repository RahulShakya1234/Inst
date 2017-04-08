using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class VoucherSeriesView : Form
    {
        public VoucherSeriesView()
        {
            InitializeComponent();
        }


        private static VoucherSeriesView sForm = null;
        public static VoucherSeriesView Instance()
        {

            if (sForm == null) { sForm = new VoucherSeriesView(); }
            return sForm;
        }

        private void VoucherSeriesSetup_Load(object sender, EventArgs e) 
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form sForm = voucherSeriesSetupAdd.Instance();
           // sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }
    }
}
