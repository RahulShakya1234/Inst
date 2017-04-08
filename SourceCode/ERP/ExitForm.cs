using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace ERP
{
    public partial class ExitForm : Form
    {
        KeyValue K;

        public ExitForm()
        {
            InitializeComponent();
        }

        public ExitForm(KeyValue k)
        {
            K = k;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            K.Key = "Exit";
            K.Value = "Exit Form";
            this.Close();
        }

        private void btnChangeCompany_Click(object sender, EventArgs e)
        {
            K.Key = "Change";
            K.Value = "Change Company";
            this.Close();
        }

        private void btnDoNothing_Click(object sender, EventArgs e)
        {
            K.Key = "Cancel";
            K.Value = "Cancel";
            this.Close();
        }

        private void ExitForm_Load(object sender, EventArgs e)
        {
            //btnChangeCompany.SetBackGroundImage();
            //btnDoNothing.SetBackGroundImage();
            //btnExit.SetBackGroundImage();
        }

    }
}
