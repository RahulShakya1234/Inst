using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class CashRceiptVoucherAdd : Form
    {
        public CashRceiptVoucherAdd()
        {
            InitializeComponent();
        }

        private static CashRceiptVoucherAdd sForm = null;
        public static CashRceiptVoucherAdd Instance()
        {

            if (sForm == null) { sForm = new CashRceiptVoucherAdd(); }
            return sForm;
        }


        private void txtSno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAccount2_Click(object sender, EventArgs e)
        {

        }
    }
}
