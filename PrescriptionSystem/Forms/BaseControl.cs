using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class BaseControl : UserControl
    {
        public BaseControl()
        {
            InitializeComponent();
            AutoSize = true;
        }

        protected void MoveToScreen(BaseControl newControl)
        {
            var window = ((Window)Parent);
            window.Controls.Remove(this);
            newControl.Dock = DockStyle.Fill;
            window.Controls.Add(newControl);
        }

        protected void DisableBackButton()
        {
            ButtonBack.Enabled = false;
            ButtonBack.Visible = false;
        }
        protected void ClearTextbox(TextBox textBox) => textBox.Text = "";

        protected void ShowTextBoxErrorMessage(TextBox textBox, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.PlaceholderText))
            {
                ((Window)Parent).ActiveControl = null;
                ClearTextbox(textBox);
                textBox.PlaceholderText = errorMessage;
            }
        }

        protected void ShowInformationMessageBox(string message, string messageBoxTitle)
        {

            MessageBox.Show(message, messageBoxTitle, MessageBoxButtons.OK);
        }

        protected void SetFormAcceptButton(Button button)
        {
            ((Window)Parent).AcceptButton = button;
        }
    }
}
