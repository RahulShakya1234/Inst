using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Utilities
{
    public partial class DataChecking : Form
    {
        public DataChecking()
        {
            InitializeComponent();
        }

        private static DataChecking sForm = null;

        public static DataChecking Instance()
        {
            if (sForm == null) { sForm = new DataChecking(); }
            return sForm;
        }

    }
}
