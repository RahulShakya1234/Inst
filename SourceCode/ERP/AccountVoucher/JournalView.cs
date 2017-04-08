using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class JournalView : Form
    {
        public JournalView()
        {
            InitializeComponent();
        }

        private static JournalView sForm = null;
        public static JournalView Instance()
        {

            if (sForm == null) { sForm = new JournalView(); }
            return sForm;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
