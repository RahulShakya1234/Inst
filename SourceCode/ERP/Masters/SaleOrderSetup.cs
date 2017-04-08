using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SaleOrderSetup : Form
    {
        public SaleOrderSetup()
        {
            InitializeComponent();
        }

        private static SaleOrderSetup sForm = null;
        public static SaleOrderSetup Instance()
        {

            if (sForm == null) { sForm = new SaleOrderSetup(); }
            return sForm;
        }


        private void bLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
