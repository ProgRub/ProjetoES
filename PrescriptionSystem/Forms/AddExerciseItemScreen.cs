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
using ServicesLibrary.DTOs;

namespace Forms
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
            var errorCodes = Services.Instance.CheckExerciseOrTreatmentCreation(TextBoxName.Text,
                TextBoxDescription.Text,
                TextBoxMinimumAge.Text, TextBoxMaximumAge.Text);

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            var bodyParts = new List<string>();
            foreach (var checkedItem in CheckedListBoxBodyPart.CheckedItems)
            {
                bodyParts.Add(checkedItem.ToString());
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
                        ShowTextBoxErrorMessage(TextBoxMinimumAge, "Age minimum is required!");
                        break;
                    case Services.AgeMaximumNotValid:
                        ShowTextBoxErrorMessage(TextBoxMaximumAge, "Age maximum is required!");
                        break;
                    case Services.AgesNotValid:
                        ShowInformationMessageBox("The maximum age has to be greater than the minimum age.", "Error");
                        break;
                }
            }
        }

        private void TextBoxMaximumAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}