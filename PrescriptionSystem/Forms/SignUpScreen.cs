using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;

namespace Forms
{
    public partial class SignUpScreen : BaseControl
    {
        public SignUpScreen()
        {
            InitializeComponent();
            DateTimePickerDOB.MaxDate = DateTime.Today;
            DateTimePickerDOB.Value = DateTime.Today;
            foreach (var allergy in Services.Instance.GetAllergies())
            {
                CheckedListBoxAllergies.Items.Add(allergy);
            }

            foreach (var disease in Services.Instance.GetDiseases())
            {
                CheckedListBoxDiseases.Items.Add(disease);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new LoginScreen());
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            var userType =
                Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked).Text;
            var errorCodes = Services.Instance.CheckUserRegistration(TextBoxName.Text,
                DateTimePickerDOB.Value,
                TextBoxPhoneNumber.Text, TextBoxHealthUserNumber.Text, TextBoxEmail.Text, TextBoxPassword.Text,
                userType);
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
            var missingBodyParts = new List<string>();
            foreach (var checkedItem in CheckedListBoxMissingBodyParts.CheckedItems)
            {
                missingBodyParts.Add(checkedItem.ToString());
            }
            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
            }
            else
            {
                Services.Instance.RegisterUser(TextBoxName.Text, DateTimePickerDOB.Value,
                    int.Parse(TextBoxPhoneNumber.Text), int.Parse(TextBoxHealthUserNumber.Text), TextBoxEmail.Text,
                    TextBoxPassword.Text,
                    allergies, diseases, missingBodyParts, userType);
            }
        }

        private void ShowErrorMessages(IEnumerable<int> errorCodes)
        {
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
                        ClearTextbox(TextBoxHealthUserNumber);
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
                    case Services.EmailNotValid:
                        ShowTextBoxErrorMessage(TextBoxEmail, "E-mail is not in a valid format!");
                        break;
                    case Services.MiscError:
                        MessageBox.Show("Something went wrong...", "Error Detected", MessageBoxButtons.OK);
                        MoveToScreen(new LoginScreen());
                        break;
                }
            }
        }
    }
}