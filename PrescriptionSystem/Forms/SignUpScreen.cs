﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms
{
    public partial class SignUpScreen : BaseControl
    {
        private IEnumerable<MedicalConditionDTO> _allergies;
        private IEnumerable<MedicalConditionDTO> _diseases;
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void SignUpScreen_Load(object sender, EventArgs e)
        {
            _allergies = Services.Instance.GetAllergies();
            _diseases= Services.Instance.GetDiseases();
            DateTimePickerDOB.MaxDate = DateTime.Today;
            DateTimePickerDOB.Value = DateTime.Today;
            foreach (var allergy in _allergies)
            {
                CheckedListBoxAllergies.Items.Add($"{allergy.Id} - {allergy.Name}");
            }

            foreach (var disease in _diseases)
            {
                CheckedListBoxDiseases.Items.Add($"{disease.Id} - {disease.Name}");
            }

            SetCheckedListBoxColumnWidth(CheckedListBoxDiseases);
            SetCheckedListBoxColumnWidth(CheckedListBoxAllergies);
            SetCheckedListBoxColumnWidth(CheckedListBoxMissingBodyParts);
            SetFormAcceptButton(ButtonSignUp);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new LoginScreen());
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            var userType =
                Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked)
                    ?.Text;
            var errorCodes = Services.Instance.CheckUserRegistration(TextBoxName.Text,
                DateTimePickerDOB.Value,
                TextBoxPhoneNumber.Text, TextBoxHealthUserNumber.Text, TextBoxEmail.Text, TextBoxPassword.Text,
                userType);
            var allergies = new List<MedicalConditionDTO>();
            foreach (var checkedItem in CheckedListBoxAllergies.CheckedItems)
            {
                allergies.Add(GetAllergyFromString(checkedItem.ToString()));
            }

            var diseases = new List<MedicalConditionDTO>();
            foreach (var checkedItem in CheckedListBoxDiseases.CheckedItems)
            {
                diseases.Add(GetDiseaseFromString(checkedItem.ToString()));
            }

            var missingBodyParts = new List<string>();
            foreach (var checkedItem in CheckedListBoxMissingBodyParts.CheckedItems)
            {
                missingBodyParts.Add(checkedItem.ToString());
            }

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            Services.Instance.RegisterUser(TextBoxName.Text, DateTimePickerDOB.Value,
                int.Parse(TextBoxPhoneNumber.Text), int.Parse(TextBoxHealthUserNumber.Text), TextBoxEmail.Text,
                TextBoxPassword.Text,
                allergies, diseases, missingBodyParts, userType);
            ShowInformationMessageBox("User registered successively.", "Success");
            MoveToScreen(new LoginScreen());
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
                    case Services.PhoneNumberRequired:
                        ShowTextBoxErrorMessage(TextBoxPhoneNumber, "Phone Number is required!");
                        break;
                    case Services.HealthUserNumberRequired:
                        ShowTextBoxErrorMessage(TextBoxHealthUserNumber, "Health User Number is required!");
                        break;
                    case Services.EmailRequired:
                        ShowTextBoxErrorMessage(TextBoxEmail, "Email is required!");
                        break;
                    case Services.PasswordRequired:
                        ShowTextBoxErrorMessage(TextBoxPassword, "Password is required!");
                        break;
                    case Services.PhoneNumberWrongLength:
                        if (Services.PhoneNumberMinimumLength == Services.PhoneNumberMaximumLength)
                        {
                            ShowTextBoxErrorMessage(TextBoxPhoneNumber,
                                $"Phone Number needs to have {Services.PhoneNumberMinimumLength} digits!");
                        }
                        else
                        {
                            ShowTextBoxErrorMessage(TextBoxPhoneNumber,
                                $"Phone Number needs to be longer than {Services.PhoneNumberMinimumLength - 1} digits and shorter than {Services.PhoneNumberMaximumLength + 1}!");
                        }

                        break;
                    case Services.PhoneNumberNotANumber:
                        ShowTextBoxErrorMessage(TextBoxPhoneNumber, "Phone Number needs to be a number!");
                        break;
                    case Services.HealthUserNumberWrongLength:
                        ClearTextBox(TextBoxHealthUserNumber);
                        if (Services.HealthUserNumberMinimumLength == Services.HealthUserNumberMaximumLength)
                        {
                            ShowTextBoxErrorMessage(TextBoxHealthUserNumber,
                                $"Health User Number needs to have {Services.HealthUserNumberMinimumLength} digits!");
                        }
                        else
                        {
                            ShowTextBoxErrorMessage(TextBoxHealthUserNumber,
                                $"Health User Number needs to be longer than {Services.HealthUserNumberMinimumLength - 1} digits and shorter than {Services.HealthUserNumberMaximumLength + 1}!");
                        }

                        break;
                    case Services.HealthUserNumberNotANumber:
                        ShowTextBoxErrorMessage(TextBoxHealthUserNumber, "Health User Number needs to be a number!");
                        break;
                    case Services.HealthUserNumberAlreadyExists:
                        ShowTextBoxErrorMessage(TextBoxHealthUserNumber,
                            "Health User Number belongs to a registered user!");
                        break;
                    case Services.EmailNotValid:
                        ShowTextBoxErrorMessage(TextBoxEmail, "E-mail is not in a valid format!");
                        break;
                    case Services.EmailAlreadyExists:
                        ShowTextBoxErrorMessage(TextBoxEmail, "E-mail belongs to a registered user!");
                        break;
                    case Services.TherapistNotOldEnough:
                        ShowInformationMessageBox("Therapist needs to be at least 22 years old!", "Error Detected");
                        break;
                    case Services.MiscError:
                        ShowInformationMessageBox("Something went wrong...", "Error Detected");
                        MoveToScreen(new LoginScreen());
                        break;
                }
            }
        }

        private MedicalConditionDTO GetAllergyFromString(string allergyString)
        {
            return _allergies.First(e => e.Id.ToString() == allergyString.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0]);
        }
        private MedicalConditionDTO GetDiseaseFromString(string diseaseString)
        {
            return _diseases.First(e => e.Id.ToString() == diseaseString.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0]);
        }
    }
}