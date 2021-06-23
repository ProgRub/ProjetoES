using System;
using Forms.PatientScreens;
using Forms.TherapistScreens;
using ServicesLibrary;

namespace Forms.CommonScreens
{
    public partial class LoginScreen : BaseControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            ClearAllTextboxesPlaceholderText();
            var code = Services.Instance.Login(TextBoxEmail.Text, TextBoxPassword.Text);
            switch (code)
            {
                case Services.EmailDoesntExist:
                    ShowTextBoxErrorMessage(TextBoxEmail, "Incorrect Email");
                    ShowTextBoxErrorMessage(TextBoxPassword, "Incorrect Password");
                    return;
                case Services.PasswordDoesntMatch:
                    ShowTextBoxErrorMessage(TextBoxPassword, "Incorrect Password");
                    return;
                case Services.Patient:
                    MoveToScreen(new CalendarScreenPatient(), this);
                    return;
                case Services.Therapist:
                    MoveToScreen(new CalendarScreenTherapist(), this);
                    return;
            }
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SignUpScreen(), this);
        }

        private void LoginScreen_Enter(object sender, EventArgs e)
        {
            TextBoxPassword.Text = "";
            TextBoxEmail.Text = "";
            SetFormAcceptButton(ButtonLogin);
        }
    }
}