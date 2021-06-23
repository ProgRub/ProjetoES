using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.TherapistScreens
{
    public partial class SelectPastTherapySessionScreen : BaseControl
    {
        private IEnumerable<TherapySessionDTO> _therapySessions;

        public SelectPastTherapySessionScreen()
        {
            InitializeComponent();
        }

        private void SelectPastTherapySessionScreen_Enter(object sender, EventArgs e)
        {
            _therapySessions = Services.Instance.GetPastTherapySessionsOfLoggedInTherapist();
            if (!_therapySessions.Any())
            {
                LabelTitle.Text = "You haven't completed any therapy sessions yet...";
                return;
            }

            FlowLayoutPanelTherapySessions.Controls.Clear();
            for (var index = 0; index < _therapySessions.Count(); index++)
            {
                var button = new Button
                {
                    AutoSize = false,
                    Font = ButtonExampleTherapySession.Font,
                    ForeColor = ButtonExampleTherapySession.ForeColor,
                    BackColor = ButtonExampleTherapySession.BackColor,
                    Text =
                        $"{_therapySessions.ElementAt(index).Id} | {_therapySessions.ElementAt(index).Patient.FullName}{Environment.NewLine}{_therapySessions.ElementAt(index).DateTime:dddd dd/MM/yyyy HH:mm}",
                    Size = ButtonExampleTherapySession.Size,
                    Location = new Point(
                        ButtonExampleTherapySession.Location.X +
                        (index / 8) * (ButtonExampleTherapySession.Size.Width + 25),
                        ButtonExampleTherapySession.Location.Y +
                        (index % 8) * (ButtonExampleTherapySession.Size.Height + 25))
                };
                button.MouseClick += ButtonClicked;

                FlowLayoutPanelTherapySessions.Controls.Add(button);
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Services.Instance.SelectTherapySession(GetSessionFromString(((Button) sender).Text));
            MoveToScreen(new TherapySessionCompletedScreen(), this);
        }

        private TherapySessionDTO GetSessionFromString(string therapySessionString)
        {
            return _therapySessions.FirstOrDefault(treatment =>
                treatment.Id.ToString() == therapySessionString.Split(" | ", StringSplitOptions.RemoveEmptyEntries)[0]);
        }
    }
}