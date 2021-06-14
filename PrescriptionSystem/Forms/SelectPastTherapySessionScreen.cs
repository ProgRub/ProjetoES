using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;

namespace Forms
{
    public partial class SelectPastTherapySessionScreen : BaseControl
    {
        public SelectPastTherapySessionScreen()
        {
            InitializeComponent();
        }

        private void SelectPastTherapySessionScreen_Load(object sender, EventArgs e)
        {
            var therapySessions = Services.Instance.GetPastTherapySessionsOfLoggedInTherapist();
            if (!therapySessions.Any())
            {
                LabelTitle.Text = "You haven't completed any therapy sessions yet...";
                return;
            }
            for (int index = 0; index < therapySessions.Count(); index++)
            {
                Button button = new Button();
                button.AutoSize = false;
                button.Font = ButtonExampleTherapySession.Font;
                button.ForeColor = ButtonExampleTherapySession.ForeColor;
                button.Text = therapySessions.ElementAt(index);
                button.Size = ButtonExampleTherapySession.Size;
                button.Location = new Point(ButtonExampleTherapySession.Location.X,
                    ButtonExampleTherapySession.Location.Y + index * ButtonExampleTherapySession.Size.Height);
                button.MouseClick += ButtonClicked;
                Controls.Add(button);
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Services.Instance.SelectTherapySession(((Button)sender).Text);
            MoveToScreen(new TherapySessionCompletedScreen());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenTherapist());
        }
    }
}