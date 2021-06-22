using System;
using System.Windows.Forms;
using ServicesLibrary;

namespace Forms
{
    public partial class CalendarScreenTherapist : BaseControl
    {
        public CalendarScreenTherapist()
        {
            InitializeComponent();
        }
        private void ButtonCreatePrescription_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CreatePrescription(), this);
        }

        private void ButtonCreatePrescriptionItem_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen(), this);
        }

        private void ButtonCreateTherapySession_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddTherapySessionScreen(), this);
        }

        private void ButtonTherapySessionHistory_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPastTherapySessionScreen(), this);
        }

        private void MonthCalendarTherapist_DateChanged(object sender, DateRangeEventArgs e)
        {
            var sessions = "";

            foreach (var session in Services.Instance.GetLoggedInTherapistsTherapySessionsAtDate(MonthCalendarTherapist
                .SelectionRange.Start))
            {
                var endSession = session.DateTime.TimeOfDay + session.EstimatedDuration;
                sessions +=
                    $"{session.DateTime.TimeOfDay:hh\\:mm} - {endSession:hh\\:mm}{Environment.NewLine}Therapy session with patient {session.Patient.FullName}{Environment.NewLine}{Environment.NewLine}";
            }

            if (sessions == "")
            {
                sessions = "There are no therapy sessions scheduled for today!";
            }

            TextBoxDayEvents.Text = sessions;
        }

        private void ButtonCheckPatientsPrescriptions_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPatientScreen(),this);
        }
    }
}