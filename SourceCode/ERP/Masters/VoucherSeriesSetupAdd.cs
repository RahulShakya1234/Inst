using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class voucherSeriesSetupAdd : Form
    {
        public voucherSeriesSetupAdd()
        {
            InitializeComponent();
        }
        private static voucherSeriesSetupAdd sForm = null;
        public static voucherSeriesSetupAdd Instance()
        {

            if (sForm == null) { sForm = new voucherSeriesSetupAdd(); }
            return sForm;

        }

    }
}
