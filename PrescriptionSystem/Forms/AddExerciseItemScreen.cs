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

        private void AddExerciseItemScreen_Load(object sender, EventArgs e)
        {
            SetCheckedListBoxColumnWidth(CheckedListBoxBodyPart);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen());
        }

        private void ButtonAddExercise_Click(object sender, EventArgs e)
        {
            var errorCodes = Services.Instance.CheckExerciseOrTreatmentCreation(TextBoxName.Text,
                TextBoxDescription.Text,
                TextBoxMinimumAge.Text, TextBoxMaximumAge.Text);

            var bodyParts = new List<string>();
            foreach (var checkedItem in CheckedListBoxBodyPart.CheckedItems)
            {
                bodyParts.Add(checkedItem.ToString());
            }

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            Services.Instance.CreateExercisePrescriptionItem(TextBoxName.Text, TextBoxDescription.Text,
                int.Parse(TextBoxMinimumAge.Text), int.Parse(TextBoxMaximumAge.Text),
                DateTimePickerDuration.Value.TimeOfDay, bodyParts);
            ShowInformationMessageBox("Exercise successfully added.", "Success");
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
                }
            }
        }
    }
}