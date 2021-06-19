using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using System.Linq;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;

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

        private void button1_Click(object sender, EventArgs e)
        {
            var treatments = new List<string>();
            foreach (var checkedItem in checkedListBoxTreatment.CheckedItems)
            {
                treatments.Add(checkedItem.ToString());
            }

            var medicines = new List<string>();
            foreach (var checkedItem in checkedListBoxMedicine.CheckedItems)
            {
                medicines.Add(checkedItem.ToString());
            }

            var exercises = new List<string>();
            foreach (var checkedItem in checkedListBoxExercise.CheckedItems)
            {
                exercises.Add(checkedItem.ToString());
            }


            string patient = "";
            if (comboBoxPatient.SelectedItem != null)
            {
                patient += comboBoxPatient.SelectedItem.ToString();
            }

            IEnumerable<int> errorCodes = Services.Instance.CheckPrescriptionCreation(patient, textBoxDescription.Text, dateTimePickerStartDate.Value.Date,
               dateTimePickerEndDate.Value.Date, treatments, medicines, exercises); //SÓ FALTA TESTAR

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
            }
            else
            {
                Services.Instance.CreatePrescription(patient, textBoxDescription.Text, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, treatments, medicines, exercises);

                ShowInformationMessageBox("Prescription successfully created.", "Success");
                MoveToScreen(new CalendarScreenTherapist());
            }

        }

        private void ShowErrorMessages(IEnumerable<int> errorCodes)
        {
            bool first = true;
            string errorMessage = "";
            foreach (var errorCode in errorCodes)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    errorMessage += Environment.NewLine;
                }
                switch (errorCode)
                {
                    case Services.TreatmentInvalidAge:
                        errorMessage += "A treatment is not recommended for the patient's age.";
                        break;
                    case Services.ExerciseInvalidAge:
                        errorMessage += "An exercise is not recommended for the patient's age.";
                        break;
                    case Services.IncompatibleMedicine:
                        errorMessage += "A medicine can cause an allergic reaction.";
                        break;
                    case Services.IncompatibleDisease:
                        errorMessage += "A medicine is contraindicated.";
                        break;
                    case Services.MissingBodyPart:
                        errorMessage += "The patient can't do an exercise.";
                        break;

                }
            }
            ShowInformationMessageBox(errorMessage, "Error");
        }

        private void CreatePrescription_Load(object sender, EventArgs e)
        {
            foreach (var patient in Services.Instance.GetAllPatients())
            {
                comboBoxPatient.Items.Add(patient);
            }

            foreach (var treatment in Services.Instance.GetTreatments())
            {
                checkedListBoxTreatment.Items.Add(treatment);
            }

            foreach (var exercise in Services.Instance.GetExercises())
            {
                checkedListBoxExercise.Items.Add(exercise);
            }

            foreach (var medicine in Services.Instance.GetMedicine())
            {
                checkedListBoxMedicine.Items.Add(medicine);
            }
        }

        private void checkedListBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
