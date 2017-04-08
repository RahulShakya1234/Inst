using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.ACvoucher
{
    public partial class JournalAdd : Form
    {
        public JournalAdd()
        {
            InitializeComponent();

        }
        private static JournalAdd sForm = null;
        public static JournalAdd Instance()
        {

            if (sForm == null) { sForm = new JournalAdd(); }
            return sForm;
        }

    }
}
