using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ERP.SalePurchase
{
    public partial class SaleTypeSetupAdd : Form
    {
        public SaleTypeSetupAdd()
        {
            InitializeComponent();
        }

        private static SaleTypeSetupAdd sForm = null;
        public static SaleTypeSetupAdd Instance()
        {

            if (sForm == null) { sForm = new SaleTypeSetupAdd(); }
            return sForm;

        }
       


        private void bAllButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
