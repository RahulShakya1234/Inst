using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.Utilities
{
    public partial class ProblemSolution : Form
    {
        public ProblemSolution()
        {
            InitializeComponent();
        }
        private static ProblemSolution sForm = null;
        public static ProblemSolution Instance()
        {

            if (sForm == null) { sForm = new ProblemSolution(); }
            return sForm;
        }

    }
}
