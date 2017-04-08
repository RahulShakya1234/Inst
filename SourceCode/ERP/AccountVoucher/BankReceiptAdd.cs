using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class BankReceiptAdd : Form
    {
        public BankReceiptAdd()
        {
            InitializeComponent();
        }
        private static BankReceiptAdd sForm = null;
        public static BankReceiptAdd Instance()
        {

            if (sForm == null) { sForm = new BankReceiptAdd(); }
            return sForm;
        }

    }
}
