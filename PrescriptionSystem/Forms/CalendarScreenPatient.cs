using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.Commands;
using ServicesLibrary.DTOs;

namespace Forms
{
    public partial class CalendarScreenPatient : BaseControl
    {
        public CalendarScreenPatient()
        {
            InitializeComponent();
            CommandsManager.Instance.ResetCommandsList();
        }

        private void ButtonGetPrescriptionHistory_Click(object sender, EventArgs e)
        {
            MoveToScreen(new GetPrescriptionHistoryScreen());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new LoginScreen());
        }

        private void ButtonAddPermission_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPrescriptionsScreen());
        }

        private void MonthCalendarPatient_DateChanged(object sender, DateRangeEventArgs e)
        {

            var data = new List<KeyValuePair<string, string>>();

            var prescriptions =
                Services.Instance.GetLoggedInPatientsPrescriptionsStartedBeforeDate(MonthCalendarPatient.SelectionRange
                    .Start);


            foreach (var prescription in prescriptions)
            {
                foreach (var item in prescription.PrescriptionItemsRecommendedTimes.Keys)
                {
                    if (Services.Instance.IsMedicine(item.Id))
                    {
                        foreach (var timeSpan in prescription.PrescriptionItemsRecommendedTimes[item])
                        {
                            var data_string = "Take " + item.Name + " medicine.";
                            data.Add(new KeyValuePair<string, string>(timeSpan.ToString(@"hh\:mm"), data_string));
                        }
                    }

                    if (Services.Instance.IsExercise(item.Id))
                    {
                        foreach (var timeSpan in prescription.PrescriptionItemsRecommendedTimes[item])
                        {
                            var data_string = "Do " + item.Name + " exercise.";
                            data.Add(new KeyValuePair<string, string>(timeSpan.ToString(@"hh\:mm"), data_string));
                        }
                    }
                }
            }

            foreach (var session in Services.Instance.GetLoggedInPatientsTherapySessionsAtDate(MonthCalendarPatient
                .SelectionRange.Start))
            {
                var data_string = "Therapy session with therapist " + session.Therapist.FullName + ".";
                data.Add(new KeyValuePair<string, string>(session.DateTime.TimeOfDay.ToString(), data_string));
            }

            data.Sort((b, a) => (b.Value.CompareTo(a.Value)));

            var sessions = data.Aggregate("", (current, pair) => current + pair + Environment.NewLine);

            if (sessions == "")
            {
                sessions = "Nothing for today";
            }

            TextBoxDayEvents.Text = sessions;
        }
    }
}