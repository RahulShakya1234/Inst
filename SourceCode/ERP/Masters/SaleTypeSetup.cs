using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SaleTypeSetup : Form
    {
        public SaleTypeSetup()
        {
            InitializeComponent();
        }
        private static SaleTypeSetup sForm = null;
        public static SaleTypeSetup Instance()
        {

            if (sForm == null) { sForm = new SaleTypeSetup(); }
            return sForm;
        }

    }
}
