using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class BankReceiptView : Form
    {
        public BankReceiptView()
        {
            InitializeComponent();
        }


        private static BankReceiptView sForm = null;
        public static BankReceiptView Instance()
        {

            if (sForm == null) { sForm = new BankReceiptView(); }
            return sForm;
        }

        private void txtToDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {

        }
    }
}
