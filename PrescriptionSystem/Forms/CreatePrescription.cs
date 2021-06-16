using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;

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

            Services.Instance.CreatePrescription(patient, textBoxDescription.Text, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, treatments, medicines, exercises);

            ShowInformationMessageBox("Prescription successfully created.", "Success");

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
