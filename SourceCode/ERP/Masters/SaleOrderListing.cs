using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SaleOrderListing : Form
    {
        public SaleOrderListing()
        {
            InitializeComponent();
        }
        private static SaleOrderListing sForm = null;
        public static SaleOrderListing Instance()
        {

            if (sForm == null) { sForm = new SaleOrderListing(); }
            return sForm;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
