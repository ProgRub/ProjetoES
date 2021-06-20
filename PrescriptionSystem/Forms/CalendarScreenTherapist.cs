using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using ComponentsLibrary.Entities;
using ServicesLibrary.Commands;
using ServicesLibrary.DifferentServices;

namespace Forms
{
    public partial class CalendarScreenTherapist : BaseControl
    {
        public CalendarScreenTherapist()
        {
            InitializeComponent();
            CommandsManager.Instance.ResetCommandsList();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new LoginScreen());
        }

        private void ButtonCreatePrescription_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CreatePrescription());
        }

        private void ButtonCreatePrescriptionItem_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen());
        }

        private void ButtonCreateTherapySession_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddTherapySessionScreen());
        }

        private void ButtonTherapySessionHistory_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPastTherapySessionScreen());
        }

        private void MonthCalendarTherapist_DateChanged(object sender, DateRangeEventArgs e)
        {
            var sessions = "";
            var newLine = Environment.NewLine;

            foreach (var session in Services.Instance.GetLoggedInTherapistsTherapySessionsAtDate(MonthCalendarTherapist.SelectionRange.Start))
            {
                var endSession = session.DateTime.TimeOfDay + session.EstimatedDuration;
                sessions = sessions + session.DateTime.ToString("hh:mm") + " - " + endSession + newLine 
                    + "Therapy session with patient " + Services.Instance.GetUserById(session.PatientId).FullName + newLine + newLine;
            }

            if (sessions == "")
            {
                sessions = "There are no therapy sessions scheduled for today!";
            }
            TextBoxDayEvents.Text = sessions;
        }

        private void CalendarScreenTherapist_Load(object sender, EventArgs e)
        {

        }
    }
}
