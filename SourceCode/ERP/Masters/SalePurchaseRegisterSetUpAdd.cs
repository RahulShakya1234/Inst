using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SalePurchaseRegisterSetUpAdd : Form
    {
        public SalePurchaseRegisterSetUpAdd()
        {
            InitializeComponent();
        }

        private static SalePurchaseRegisterSetUpAdd sForm = null;
        public static SalePurchaseRegisterSetUpAdd Instance()
        {

            if (sForm == null) { sForm = new SalePurchaseRegisterSetUpAdd(); }
            return sForm;
        }


        private void bGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalePurchaseRegisterSetUpAdd_Load(object sender, EventArgs e)
        {

        }

       
       
    }
}
