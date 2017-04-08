using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class CashReceiptVoucherView : Form
    {
        public CashReceiptVoucherView()
        {
            InitializeComponent();

        }
        private static CashReceiptVoucherView sForm = null;
        public static CashReceiptVoucherView Instance()
        {

            if (sForm == null) { sForm = new CashReceiptVoucherView(); }
            return sForm;
        }
    }
}
