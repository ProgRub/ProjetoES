using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            MoveToScreen(new CalendarScreenTherapist());
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SignUpScreen());
        }
    }
}
