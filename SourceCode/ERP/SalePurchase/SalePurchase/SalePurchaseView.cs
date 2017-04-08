using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class SalePurchaseView : Form
    {
        public SalePurchaseView()
        {
            InitializeComponent();
        }
        private static SalePurchaseView sForm = null;
        public static SalePurchaseView Instance()
        {

            if (sForm == null) { sForm = new SalePurchaseView(); }
            return sForm;
        }

    }
}
