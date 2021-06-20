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

        private void ButtonMedicine_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddMedicineItemScreen());
        }

        private void ButtonTreatment_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddTreatmentItemScreen());
        }

        private void ButtonExercise_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddExerciseItemScreen());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenTherapist());
        }
    }
}