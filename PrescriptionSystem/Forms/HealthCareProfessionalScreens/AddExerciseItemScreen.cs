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

        private void AddExerciseItemScreen_Load(object sender, EventArgs e)
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
            ClearAllTextboxesPlaceholderText();
            foreach (var error in errorCodes)
            {
                switch (error)
                {
                    case Services.NameRequired:
                        ShowTextBoxErrorMessage(TextBoxName, "Name is required!");
                        break;
                    case Services.DescriptionRequired:
                        ShowTextBoxErrorMessage(TextBoxDescription, "Description is required!");
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
                        ShowInformationMessageBox("That exercise already exists in the database.", "Error");
                        break;
                }
            }
        }

        private void TextBoxMaximumAge_TextChanged(object sender, EventArgs e)
        {
        }
    }
}