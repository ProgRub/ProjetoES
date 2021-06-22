using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComponentsLibrary.Entities;
using Forms.TherapistScreens;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.HealthCareProfessionalScreens
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

            var bodyPartEnum = new List<BodyPart>();

            if (bodyPart != "")
            {
                bodyPartEnum.Add(Services.Instance.ConvertStringToBodyPart(bodyPart));
            }

            var errorCodes = Services.Instance.CheckExerciseOrTreatmentCreation(TextBoxTreatmentName.Text,
                TextBoxTreatmentDescription.Text,
                TextBoxMinimumAge.Text, TextBoxMaximumAge.Text, DateTimePickerDuration.Value.TimeOfDay,
                bodyPartEnum, "Treatment");
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
            var first = true;
            var errorMessage = "";
            ClearAllTextboxesPlaceholderText();
            foreach (var errorCode in errorCodes)
            {
                if (!first)
                {
                    errorMessage += Environment.NewLine;
                }

                switch (errorCode)
                {
                    case Services.NameRequired:
                        ShowTextBoxErrorMessage(TextBoxTreatmentName, "Name is required!");
                        break;
                    case Services.AgeMinimumNotANumber:
                        errorMessage += "Age minimum needs to be an integer!";
                        first = false;
                        break;
                    case Services.AgeMaximumNotANumber:
                        errorMessage += "Age maximum needs to be an integer!";
                        first = false;
                        break;
                    case Services.AgesNotValid:
                        errorMessage += "The maximum age has to be greater than the minimum age.";
                        first = false;
                        break;
                    case Services.AgeMinimumRequired:
                        errorMessage += "You have to set a minimum age for the treatment.";
                        first = false;
                        break;
                    case Services.AgeMaximumRequired:
                        errorMessage += "You have to set a maximum age for the treatment.";
                        first = false;
                        break;
                    case Services.ItemAlreadyExists:
                        errorMessage += "That treatment already exists in the database.";
                        first = false;
                        break;
                    case Services.AtLeastOneBodyPart:
                        errorMessage += "The treatment must target a body part.";
                        first = false;
                        break;
                }
            }

            ShowInformationMessageBox(errorMessage, "Error");

        }
    }
}