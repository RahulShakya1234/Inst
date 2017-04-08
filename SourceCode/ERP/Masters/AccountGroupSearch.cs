using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class accountGroupSearch : Form
    {
        public accountGroupSearch()
        {
            InitializeComponent();

        }

        private static accountGroupSearch sForm = null;
        public static accountGroupSearch Instance()
        {

            if (sForm == null) { sForm = new accountGroupSearch(); }
            return sForm;
        }


    }
}
