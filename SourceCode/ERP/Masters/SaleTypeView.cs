using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERP.Global;
using Common;

namespace ERP.SalePurchase
{
    public partial class SaleTypeView : Form
    {
        public SaleTypeView()
        {
            InitializeComponent();
        }
       

        private static SaleTypeView sForm = null;
        public static SaleTypeView Instance()
        {

            if (sForm == null) { sForm = new SaleTypeView(); }
            return sForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // new SaleTypeSetupAdd(this, 0).ShowDialog();

            Form sForm = SaleTypeSetupAdd.Instance();
           // sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();
        }
     

       

    }
}
