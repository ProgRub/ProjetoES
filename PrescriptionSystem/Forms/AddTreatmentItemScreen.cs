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

        private void ButtonAddTreatment_Click(object sender, EventArgs e)
        {
            var errorCodes = Services.Instance.CheckExerciseOrTreatmentCreation(TextBoxTreatmentName.Text, TextBoxTreatmentDescription.Text,
               TextBoxMinimumAge.Text, TextBoxMaximumAge.Text);

            var bodyPart = "";
            foreach (var radioButton in GroupBoxBodyPart.Controls.OfType<RadioButton>())
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
            Services.Instance.CreateTreatmentPrescriptionItem(TextBoxTreatmentName.Text, TextBoxTreatmentDescription.Text,
                int.Parse(TextBoxMinimumAge.Text), int.Parse(TextBoxMaximumAge.Text), DateTimePickerDuration.Value.TimeOfDay, bodyPart);
            ShowInformationMessageBox("Treatment successfully added.", "Success");
            MoveToScreen(new AddPrescriptionItemScreen());
        }

        private void ShowErrorMessages(IEnumerable<int> errorCodes)
        {
            ClearAllTextboxesPlaceholderText();
            foreach (var error in errorCodes)
            {
                switch (error)
                {
                    case Services.NameRequired:
                        ShowTextBoxErrorMessage(TextBoxTreatmentName, "Name is required!");
                        break;
                    case Services.DescriptionRequired:
                        ShowTextBoxErrorMessage(TextBoxTreatmentDescription, "Description is required!");
                        break;
                    case Services.AgeMinimumNotValid:
                        ShowTextBoxErrorMessage(TextBoxMinimumAge, "Age minimum is required!");
                        break;
                    case Services.AgeMaximumNotValid:
                        ShowTextBoxErrorMessage(TextBoxMaximumAge, "Age maximum is required!");
                        break;
                }
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen());
        }
    }
}
