using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class PurchaseTypeSetup : Form
    {
        public PurchaseTypeSetup()
        {
            InitializeComponent();
        }
        private static PurchaseTypeSetup sForm = null;
        public static PurchaseTypeSetup Instance()
        {

            if (sForm == null) { sForm = new PurchaseTypeSetup(); }
            return sForm;
        }

    }
}
