using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class CreatePrescription : BaseControl
    {
        public CreatePrescription()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenTherapist());
        }
    }
}
