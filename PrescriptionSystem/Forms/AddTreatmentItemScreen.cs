using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ServicesLibrary.DTOs;

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
            var bodyPart = "";
            foreach (var radioButton in GroupBoxBodyPart.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    bodyPart = radioButton.Text;
                    break;
                }
            }

            var errorCodes = Services.Instance.CheckExerciseOrTreatmentCreation(TextBoxTreatmentName.Text,
                TextBoxTreatmentDescription.Text,
                TextBoxMinimumAge.Text, TextBoxMaximumAge.Text, DateTimePickerDuration.Value.TimeOfDay,
                new[] {Services.Instance.ConvertStringToBodyPart(bodyPart)}, "Treatment");
            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            Services.Instance.CreateTreatmentPrescriptionItem(new TreatmentDTO
            {
                Name = TextBoxTreatmentName.Text, Description = TextBoxTreatmentDescription.Text,
                AgeMinimum = int.Parse(TextBoxMinimumAge.Text),
                AgeMaximum = int.Parse(TextBoxMaximumAge.Text), Duration = TimeSpan.Parse(DateTimePickerDuration.Text),
                BodyPart = Services.Instance.ConvertStringToBodyPart(bodyPart)
            });
            ShowInformationMessageBox("Treatment successfully added.", "Success");
            MoveToScreen(new AddPrescriptionItemScreen(), new CalendarScreenTherapist());
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
                        ShowInformationMessageBox("Age minimum is required and needs to be a whole number!", "Error");
                        break;
                    case Services.AgeMaximumNotValid:
                        ShowInformationMessageBox("Age maximum is required and needs to be a whole number!", "Error");
                        break;
                    case Services.AgesNotValid:
                        ShowInformationMessageBox("The maximum age has to be greater than the minimum age.", "Error");
                        break;
                    case Services.ItemAlreadyExists:
                        ShowInformationMessageBox("That treatment already exists in the database.", "Error");
                        break;
                }
            }
        }

        private void AddTreatmentItemScreen_Load(object sender, EventArgs e)
        {
        }
    }
}