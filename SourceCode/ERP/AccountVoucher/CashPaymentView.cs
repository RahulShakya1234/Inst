using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class CashPaymentView : Form
    {
        public CashPaymentView()
        {
            InitializeComponent();
        }

        private static CashPaymentView sForm = null;
        public static CashPaymentView Instance()
        {

            if (sForm == null) { sForm = new CashPaymentView(); }
            return sForm;
        }

    }
}
