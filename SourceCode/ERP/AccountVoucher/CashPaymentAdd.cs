using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class CashPaymentAdd : Form
    {
        public CashPaymentAdd()
        {
            InitializeComponent();
        }

        private static CashPaymentAdd sForm = null;
        public static CashPaymentAdd Instance()
        {

            if (sForm == null) { sForm = new CashPaymentAdd(); }
            return sForm;
        }


        private void bLabel7_Click(object sender, EventArgs e)
        {

        }

        private void CashPaymentAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
