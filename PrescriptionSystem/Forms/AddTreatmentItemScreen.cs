using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddTreatmentItemScreen : BaseControl
    {
        public AddTreatmentItemScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void AddMedicineItem_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var errorCodes = Services.Instance.CheckExerciseOrTreatmentCreation(textBoxTreatmentName.Text, textBoxTreatmentDescription.Text,
               textBoxMinAge.Text, textBoxMaxAge.Text);

            var bodyPart = "";
            foreach (var radioButton in groupBox1.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    bodyPart = radioButton.Text;
                    break;
                }
            }
            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }
            Services.Instance.CreateTreatmentPrescriptionItem(textBoxTreatmentName.Text, textBoxTreatmentDescription.Text,
                int.Parse(textBoxMinAge.Text), int.Parse(textBoxMaxAge.Text), dateTimePickerDuration.Value.TimeOfDay, bodyPart);
            ShowInformationMessageBox("Treatment successfully added.", "Success");

        }

        private void ShowErrorMessages(IEnumerable<int> errorCodes)
        {
            ClearAllTextboxesPlaceholderText();
            foreach (var error in errorCodes)
            {
                switch (error)
                {
                    case Services.NameRequired:
                        ShowTextBoxErrorMessage(textBoxTreatmentName, "Name is required!");
                        break;
                    case Services.DescriptionRequired:
                        ShowTextBoxErrorMessage(textBoxTreatmentDescription, "Description is required!");
                        break;
                    case Services.AgeMinimumNotValid:
                        ShowTextBoxErrorMessage(textBoxMinAge, "Age minimum is required!");
                        break;
                    case Services.AgeMaximumNotValid:
                        ShowTextBoxErrorMessage(textBoxMaxAge, "Age maximum is required!");
                        break;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen());
        }
    }
}
