using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class SignUpScreen : BaseControl
    {
        public SignUpScreen()
        {
            InitializeComponent();
            DateTimePickerDOB.MaxDate=DateTime.Today;
            DateTimePickerDOB.Value=DateTime.Today;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new LoginScreen());
        }
    }
}
