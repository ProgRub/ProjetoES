using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class CalendarScreenTherapist : BaseControl
    {
        public CalendarScreenTherapist()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new LoginScreen());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CreatePrescription());
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddTherapySessionScreen());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPastTherapySessionScreen());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MoveToScreen(new AddTherapySessionScreen());
        }
    }
}
