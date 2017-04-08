using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class BankPaymentAdd : Form
    {
        public BankPaymentAdd()
        {
            InitializeComponent();
        }
        private static BankPaymentAdd sForm = null;
        public static BankPaymentAdd Instance()
        {

            if (sForm == null) { sForm = new BankPaymentAdd(); }
            return sForm;
        }

    }
}
