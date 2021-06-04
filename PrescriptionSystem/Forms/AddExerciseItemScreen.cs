using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddExerciseItemScreen : BaseControl
    {
        public AddExerciseItemScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen());
        }
    }
}
