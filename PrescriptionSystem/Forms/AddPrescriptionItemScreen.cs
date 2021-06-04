using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddPrescriptionItemScreen : BaseControl
    {
        public AddPrescriptionItemScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddMedicineItemScreen());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddTreatmentItemScreen());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddExerciseItemScreen());
        }
    }
}
