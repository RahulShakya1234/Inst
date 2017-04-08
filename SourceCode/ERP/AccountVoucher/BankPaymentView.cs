using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class BankPaymentView : Form
    {
        public BankPaymentView()
        {
            InitializeComponent();
        }
        private static BankPaymentView sForm = null;
        public static BankPaymentView Instance()
        {

            if (sForm == null) { sForm = new BankPaymentView(); }
            return sForm;
        }

    }
}
