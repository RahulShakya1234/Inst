using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class VoucherAdd : Form
    {
        public VoucherAdd()
        {
            InitializeComponent();
        }
        private static VoucherAdd sForm = null;
        public static VoucherAdd Instance()
        {

            if (sForm == null) { sForm = new VoucherAdd(); }
            return sForm;

        }


        private void txtSeriesNumbering_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
