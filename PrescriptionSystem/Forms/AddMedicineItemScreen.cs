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

namespace Forms
{
    public partial class AddMedicineItemScreen : BaseControl
    {
        public AddMedicineItemScreen()
        {
            InitializeComponent();
        }

        private void AddMedicineItemScreen_Load(object sender, EventArgs e)
        {
            foreach (var allergy in Services.Instance.GetAllergies())
            {
                CheckedListBoxAllergies.Items.Add(allergy);
            }

            foreach (var disease in Services.Instance.GetDiseases())
            {
                CheckedListBoxDiseases.Items.Add(disease);
            }

            SetCheckedListBoxColumnWidth(CheckedListBoxAllergies);
            SetCheckedListBoxColumnWidth(CheckedListBoxDiseases);
        }

        private void ButtonAddMedicine_Click(object sender, EventArgs e)
        {
            var errorCodes = Services.Instance.CheckMedicineCreation(TextBoxMedicineName.Text,
                TextBoxMedicineDescription.Text, TextBoxMedicinePrice.Text);

            var allergies = new List<string>();
            foreach (var checkedItem in CheckedListBoxAllergies.CheckedItems)
            {
                allergies.Add(checkedItem.ToString());
            }

            var diseases = new List<string>();
            foreach (var checkedItem in CheckedListBoxDiseases.CheckedItems)
            {
                diseases.Add(checkedItem.ToString());
            }

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
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