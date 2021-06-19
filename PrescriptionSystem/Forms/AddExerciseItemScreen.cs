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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var errorCodes = Services.Instance.CheckExerciseOrTreatmentCreation(textBoxName.Text, textBoxDescription.Text,
               textBoxMinAge.Text, textBoxMaxAge.Text);

            var bodyParts = new List<string>();
            foreach (var checkedItem in checkedListBoxBodyPart.CheckedItems)
            {
                bodyParts.Add(checkedItem.ToString());
            }

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
            }
            else
            {
                Services.Instance.CreateExercisePrescriptionItem(textBoxName.Text, textBoxDescription.Text,
                    int.Parse(textBoxMinAge.Text), int.Parse(textBoxMaxAge.Text), dateTimePickerDuration.Value.TimeOfDay, bodyParts);
                ShowInformationMessageBox("Exercise successfully added.", "Success");

            }
            
        }

        private void ShowErrorMessages(IEnumerable<int> errorCodes)
        {
            ClearAllTextboxesPlaceholderText();
            foreach (var error in errorCodes)
            {
                switch (error)
                {
                    case Services.NameRequired:
                        ShowTextBoxErrorMessage(textBoxName, "Name is required!");
                        break;
                    case Services.DescriptionRequired:
                        ShowTextBoxErrorMessage(textBoxDescription, "Description is required!");
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
    }
}
