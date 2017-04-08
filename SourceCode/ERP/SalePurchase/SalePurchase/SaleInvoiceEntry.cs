using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SaleInvoiceEntry : Form
    {
        public SaleInvoiceEntry()
        {
            InitializeComponent();
        }

        private static SaleInvoiceEntry sForm = null;
        public static SaleInvoiceEntry Instance()
        {

            if (sForm == null) { sForm = new SaleInvoiceEntry(); }
            return sForm;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalStock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
