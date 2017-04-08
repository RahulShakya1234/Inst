using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class Study : Form
    {
        public Study()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt1.Text);
            int num2 = Convert.ToInt32(txt2.Text);
            int num3 = Convert.ToInt32(txt3.Text);
            int num4 = Convert.ToInt32(txt4.Text);
            int num5 = Convert.ToInt32(txt5.Text);

            int num6 = num1 + num2 + num3 + num4 + num5;
           

            MessageBox.Show(num6.ToString());
         
        }

       
         private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt1.Text);
            int num2 = Convert.ToInt32(txt2.Text);
            int num3 = Convert.ToInt32(txt3.Text);

            int num7 = num1 * num2 * num3;

            MessageBox.Show(num7.ToString());
        }

         private void btnDevide_Click(object sender, EventArgs e)
         {
             int num1 = Convert.ToInt32(txt1.Text);
             int num2 = Convert.ToInt32(txt2.Text);

             int num8 = num1 / num2;

             MessageBox.Show(num8.ToString());
         }

        

      
    }
}
