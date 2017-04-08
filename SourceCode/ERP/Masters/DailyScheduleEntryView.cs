using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class DailyScheduleEntryView : Form
    {
        public DailyScheduleEntryView()
        {
            InitializeComponent();
        }

        private static DailyScheduleEntryView sForm = null;
        public static DailyScheduleEntryView Instance()
        {

            if (sForm == null) { sForm = new DailyScheduleEntryView(); }
            return sForm;
        }

        private void DailyScheduleEntryView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form sForm = DailyScheduleEntryAdd.Instance();
          //  sForm.MdiParent = this;
            sForm.Show();
            sForm.Activate();

        }
    }
}
