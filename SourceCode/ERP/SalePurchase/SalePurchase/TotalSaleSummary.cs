using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class TotalSaleSummary : Form
    {
        public TotalSaleSummary()
        {
            InitializeComponent();
        }
        private static TotalSaleSummary sForm = null;
        public static TotalSaleSummary Instance()
        {

            if (sForm == null) { sForm = new TotalSaleSummary(); }
            return sForm;
        }

    }
}
