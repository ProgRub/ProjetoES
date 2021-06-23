using System;

namespace Forms.HealthCareProfessionalScreens
{
    public partial class AddPrescriptionItemScreen : BaseControl
    {
        public AddPrescriptionItemScreen()
        {
            InitializeComponent();
        }

        private void ButtonMedicine_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddMedicineItemScreen(), this);
        }

        private void ButtonTreatment_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddTreatmentItemScreen(), this);
        }

        private void ButtonExercise_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddExerciseItemScreen(), this);
        }
    }
}