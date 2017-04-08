using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERP.SalePurchase;

namespace ERP.Masters
{
    public partial class PartyWiseItemRateView : Form
    {
        public PartyWiseItemRateView()
        {
            InitializeComponent();
        }

        private static PartyWiseItemRateView sForm = null;
        public static PartyWiseItemRateView Instance()
        {

            if (sForm == null) { sForm = new PartyWiseItemRateView(); }
            return sForm;
        }


        private void PartyWiseItemRateAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form sForm = PartyWiseItemAdd.Instance();
           // sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }
    }
}
