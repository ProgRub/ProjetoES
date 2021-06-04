using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class CalendarScreenPatient : BaseControl
    {
        public CalendarScreenPatient()
        {
            InitializeComponent();
        }

        private void CalendarScreenPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToScreen(new GetPrescriptionHistoryScreen());
        }
    }
}
