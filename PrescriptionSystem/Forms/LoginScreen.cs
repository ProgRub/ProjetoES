using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;

namespace Forms
{
    public partial class LoginScreen : BaseControl
    {
        public LoginScreen()
        {
            InitializeComponent();
            DisableBackButton();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var code = Services.Instance.Login(TextBoxEmail.Text, TextBoxPassword.Text);
            switch (code)
            {
                case Services.EmailDoesntExist:
                    ShowTextBoxErrorMessage(TextBoxEmail,"Incorrect Email");
                    ShowTextBoxErrorMessage(TextBoxPassword, "Incorrect Password");
                    return;
                case Services.PasswordDoesntMatch:
                    ShowTextBoxErrorMessage(TextBoxPassword,"Incorrect Password");
                    return;
                case Services.Patient:
                    MoveToScreen(new CalendarScreenPatient());
                    return;
                case Services.Therapist:
                    MoveToScreen(new CalendarScreenTherapist());
                    return;
            }
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SignUpScreen());
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            SetFormAcceptButton(ButtonLogin);
        }
    }
}
