using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddMedicineItemScreen : BaseControl
    {
        private IEnumerable<MedicalConditionDTO> _diseases;
        private IEnumerable<MedicalConditionDTO> _allergies;
        public AddMedicineItemScreen()
        {
            InitializeComponent();
        }

        private void AddMedicineItemScreen_Load(object sender, EventArgs e)
        {
            _allergies = Services.Instance.GetAllergies();
            _diseases = Services.Instance.GetDiseases();
            foreach (var allergy in _allergies)
            {
                CheckedListBoxAllergies.Items.Add($"{allergy.Id} - {allergy.Name}");
            }
            foreach (var disease in _diseases)
            {
                CheckedListBoxDiseases.Items.Add($"{disease.Id} - {disease.Name}");
            }

            SetCheckedListBoxColumnWidth(CheckedListBoxAllergies);
            SetCheckedListBoxColumnWidth(CheckedListBoxDiseases);
        }

        private MedicalConditionDTO GetAllergyFromString(string conditionString)
        {
            var conditionSplit = conditionString.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            return _allergies.First(e => e.Id.ToString() == conditionSplit[0]);
        }

        private MedicalConditionDTO GetDiseaseFromString(string conditionString)
        {
            var conditionSplit = conditionString.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            return _diseases.First(e => e.Id.ToString() == conditionSplit[0]);
        }

        private void ButtonAddMedicine_Click(object sender, EventArgs e)
        {
            var errorCodes = Services.Instance.CheckMedicineCreation(TextBoxMedicineName.Text,
                TextBoxMedicineDescription.Text, TextBoxMedicinePrice.Text);

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            var allergies = new List<MedicalConditionDTO>();
            var diseases = new List<MedicalConditionDTO>();

            foreach (var checkedItem in CheckedListBoxAllergies.CheckedItems)
            {
                allergies.Add(GetAllergyFromString(checkedItem.ToString()));
            }
            foreach (var checkedItem in CheckedListBoxDiseases.CheckedItems)
            {
                diseases.Add(GetDiseaseFromString(checkedItem.ToString()));
            }

            Services.Instance.CreateMedicinePrescriptionItem(TextBoxMedicineName.Text, TextBoxMedicineDescription.Text,
                double.Parse(TextBoxMedicinePrice.Text), allergies, diseases);
            ShowInformationMessageBox("Medicine successfully added.", "Success");
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
                        ShowTextBoxErrorMessage(TextBoxMedicineName, "Name is required!");
                        break;
                    case Services.DescriptionRequired:
                        ShowTextBoxErrorMessage(TextBoxMedicineDescription, "Description is required!");
                        break;
                    case Services.PriceNotValid:
                        ShowTextBoxErrorMessage(TextBoxMedicinePrice, "Price is required!");
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