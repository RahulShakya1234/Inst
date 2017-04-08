using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.A_CVoucher
{
    public partial class ContraVoucherView : Form
    {
        public ContraVoucherView()
        {
            InitializeComponent();

        }
        private static ContraVoucherView sForm = null;
        public static ContraVoucherView Instance()
        {

            if (sForm == null) { sForm = new ContraVoucherView(); }
            return sForm;
        }
    }
}
