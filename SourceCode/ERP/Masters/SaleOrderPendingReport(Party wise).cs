using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SaleOrderPendingReport_Party_wise_ : Form
    {
        public SaleOrderPendingReport_Party_wise_()
        {
            InitializeComponent();
        }
        private static SaleOrderPendingReport_Party_wise_ sForm = null;
        public static SaleOrderPendingReport_Party_wise_ Instance()
        {

            if (sForm == null) { sForm = new SaleOrderPendingReport_Party_wise_(); }
            return sForm;

        }


    }
}
