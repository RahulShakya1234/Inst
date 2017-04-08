using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class PendingSaleOrderReport : Form
    {
        public PendingSaleOrderReport()
        {
            InitializeComponent();
        }
        private static PendingSaleOrderReport sForm = null;
        public static PendingSaleOrderReport Instance()
        {

            if (sForm == null) { sForm = new PendingSaleOrderReport(); }
            return sForm;

        }

    }
}
