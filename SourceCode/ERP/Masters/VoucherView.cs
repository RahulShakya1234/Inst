using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class grdVoucher : Form
    {
        public grdVoucher()
        {
            InitializeComponent();
        }

        private static grdVoucher sForm = null;
        public static grdVoucher Instance()
        {

            if (sForm == null) { sForm = new grdVoucher(); }
            return sForm;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form sForm = VoucherAdd.Instance();
           // sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();


        }
    }
}
