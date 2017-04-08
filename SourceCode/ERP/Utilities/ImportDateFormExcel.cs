using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Utilities
{
    public partial class ImportDateFormExcel : Form
    {
        public ImportDateFormExcel()
        {
            InitializeComponent();
        }

        private static ImportDateFormExcel sForm = null;

        public static ImportDateFormExcel Instance()
        {
            if (sForm == null) { sForm = new ImportDateFormExcel(); }
            return sForm;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
