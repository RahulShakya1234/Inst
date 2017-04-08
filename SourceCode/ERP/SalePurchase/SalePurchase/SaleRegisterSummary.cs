using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SaleRegisterSummary : Form
    {
        public SaleRegisterSummary()
        {
            InitializeComponent();
        }
        private static SaleRegisterSummary sForm = null;
        public static SaleRegisterSummary Instance()
        {

            if (sForm == null) { sForm = new SaleRegisterSummary(); }
            return sForm;
        }

        private void SaleRegisterSummary_Load(object sender, EventArgs e)
        {

        }

    }
}
