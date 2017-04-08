using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERP.SalePurchase
{
    public partial class DailyScheduleEntryAdd : Form
    {
        public DailyScheduleEntryAdd()
        {
            InitializeComponent();

        }

        private static DailyScheduleEntryAdd sForm = null;
        public static DailyScheduleEntryAdd Instance()
        {

            if (sForm == null) { sForm = new DailyScheduleEntryAdd(); }
            return sForm;

        }


    }
}
