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
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new LoginScreen());
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            string userType =
                Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked).Text;
            IEnumerable<int> errorCodes = Services.Instance.CheckUserRegistration(TextBoxName.Text,
                DateTimePickerDOB.Value,
                TextBoxPhoneNumber.Text, TextBoxHealthUserNumber.Text, TextBoxEmail.Text, TextBoxPassword.Text,
                userType);
            if (errorCodes.First() == Services.Ok)
            {
                Services.Instance.RegisterUser(TextBoxName.Text, DateTimePickerDOB.Value,
                    int.Parse(TextBoxPhoneNumber.Text), int.Parse(TextBoxHealthUserNumber.Text), TextBoxEmail.Text,
                    TextBoxPassword.Text,
                    new List<string>(), new List<string>(), userType);
            }
            else
            {
                ShowErrorMessages(errorCodes);
            }
        }

        private void ShowErrorMessages(IEnumerable<int> errorCodes)
        {
            foreach (var error in errorCodes)
            {
                switch (error)
                {
                    case Services.NameRequired:
                        TextBoxName.PlaceholderText = "Name is required!";
                        break;
                    case Services.PhoneNumberRequired:
                        TextBoxPhoneNumber.PlaceholderText = "Phone Number is required!";
                        break;
                    case Services.HealthUserNumberRequired:
                        TextBoxHealthUserNumber.PlaceholderText = "Health User Number is required!";
                        break;
                    case Services.EmailRequired:
                        TextBoxEmail.PlaceholderText = "Email is required!";
                        break;
                    case Services.PasswordRequired:
                        TextBoxPassword.PlaceholderText = "Password is required!";
                        break;
                    case Services.PhoneNumberWrongLength:
                        if (Services.PhoneNumberMinimumLength == Services.PhoneNumberMaximumLength)
                        {
                            TextBoxPhoneNumber.PlaceholderText =
                                $"Phone Number needs to have {Services.PhoneNumberMinimumLength } digits!";
                        }
                        else
                        {
                            TextBoxPhoneNumber.PlaceholderText =
                                $"Phone Number needs to be longer than {Services.PhoneNumberMinimumLength - 1} digits and shorter than {Services.PhoneNumberMaximumLength + 1}!";
                        }
                        break;
                    case Services.PhoneNumberNotANumber:
                        TextBoxPhoneNumber.PlaceholderText = "Phone Number needs to be a number!";
                        break;
                    case Services.HealthUserNumberWrongLength:
                        if (Services.HealthUserNumberMinimumLength == Services.HealthUserNumberMaximumLength)
                        {
                            TextBoxPhoneNumber.PlaceholderText =
                                $"Health User Number needs to have {Services.HealthUserNumberMinimumLength } digits!";
                        }
                        else
                        {
                            TextBoxPhoneNumber.PlaceholderText =
                                $"Health User Number needs to be longer than {Services.HealthUserNumberMinimumLength - 1} digits and shorter than {Services.HealthUserNumberMaximumLength + 1}!";
                        }
                        break;
                    case Services.HealthUserNumberNotANumber:
                        TextBoxHealthUserNumber.PlaceholderText = "Health User Number needs to be a number!";
                        break;
                    case Services.EmailNotValid:
                        TextBoxEmail.PlaceholderText = "E-mail is not in a valid format!";
                        break;
                    case Services.MiscError:
                        MessageBox.Show("Something went wrong...", "Error Detected", MessageBoxButtons.OK);
                        MoveToScreen(new LoginScreen());
                        break;
                }
            }
        }

        private void SignUpScreen_Load(object sender, EventArgs e)
        {

        }
    }
}