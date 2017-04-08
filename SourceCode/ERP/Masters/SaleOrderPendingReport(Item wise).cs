using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SaleOrderPendingReport : Form
    {
        public SaleOrderPendingReport()
        {
            InitializeComponent();
        }
        private static SaleOrderPendingReport sForm = null;
        public static SaleOrderPendingReport Instance()
        {

            if (sForm == null) { sForm = new SaleOrderPendingReport(); }
            return sForm;

        }


    }
}
