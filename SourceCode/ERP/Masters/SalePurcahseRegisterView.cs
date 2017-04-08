using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SalePurcahseRegisterView : Form
    {
        public SalePurcahseRegisterView()
        {
            InitializeComponent();
        }

        private static SalePurcahseRegisterView sForm = null;
        public static SalePurcahseRegisterView Instance()
        {

            if (sForm == null) { sForm = new SalePurcahseRegisterView(); }
            return sForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form sForm = SalePurchaseRegisterSetUpAdd.Instance();
            //sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }

    }
}
