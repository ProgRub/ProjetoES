using System;
using System.Collections.Generic;
using System.Linq;
using Forms.TherapistScreens;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.HealthCareProfessionalScreens
{
    public partial class AddExerciseItemScreen : BaseControl
    {
        public AddExerciseItemScreen()
        {
            InitializeComponent();
        }

        private void AddExerciseItemScreen_Enter(object sender, EventArgs e)
        {
            SetCheckedListBoxColumnWidth(CheckedListBoxBodyPart);
        }

        private void ButtonAddExercise_Click(object sender, EventArgs e)
        {
            var bodyParts = new List<string>();
            foreach (var checkedItem in CheckedListBoxBodyPart.CheckedItems)
            {
                bodyParts.Add(checkedItem.ToString());
            }


            var errorCodes = Services.Instance.CheckExerciseOrTreatmentCreation(TextBoxName.Text,
                TextBoxDescription.Text,
                TextBoxMinimumAge.Text, TextBoxMaximumAge.Text, DateTimePickerDuration.Value.TimeOfDay,
                bodyParts.Select(e => Services.Instance.ConvertStringToBodyPart(e)), "Exercise");

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            Services.Instance.CreateExercisePrescriptionItem(new ExerciseDTO
            {
                Name = TextBoxName.Text, Description = TextBoxDescription.Text,
                AgeMinimum = int.Parse(TextBoxMinimumAge.Text),
                AgeMaximum = int.Parse(TextBoxMaximumAge.Text), Duration = TimeSpan.Parse(DateTimePickerDuration.Text),
                BodyParts = bodyParts.Select(e => Services.Instance.ConvertStringToBodyPart(e))
            });
            ShowInformationMessageBox("Exercise successfully added.", "Success");
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
                        ShowTextBoxErrorMessage(TextBoxName, "Name is required!");
                        break;
                    case Services.AgeMinimumNotANumber:
                        errorMessage += "Age minimum needs to be a non-negative integer!";
                        first = false;
                        break;
                    case Services.AgeMaximumNotANumber:
                        errorMessage += "Age maximum needs to be a non-negative integer!";
                        first = false;
                        break;
                    case Services.AgesNotValid:
                        errorMessage += "The maximum age has to be greater than the minimum age.";
                        first = false;
                        break;
                    case Services.AgeMinimumRequired:
                        errorMessage += "You have to set a minimum age for the exercise.";
                        first = false;
                        break;
                    case Services.AgeMaximumRequired:
                        errorMessage += "You have to set a maximum age for the exercise.";
                        first = false;
                        break;
                    case Services.ItemAlreadyExists:
                        errorMessage += "That exercise already exists in the database.";
                        first = false;
                        break;
                    case Services.AtLeastOneBodyPart:
                        errorMessage += "The exercise must target, at least, one body part.";
                        first = false;
                        break;
                    case Services.DurationNotValid:
                        errorMessage += "The exercise must have a duration.";
                        first = false;
                        break;
                }
            }

            ShowInformationMessageBox(errorMessage, "Error");
        }
    }
}