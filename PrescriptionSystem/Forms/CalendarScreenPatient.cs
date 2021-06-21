using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string sessions = "";
            string newLine = Environment.NewLine;

            var data = new List<KeyValuePair<string, string>>();

            var prescriptions = new List<PrescriptionDTO>();

            foreach (var prescription in Services.Instance.GetLoggedInPatientsPrescriptionsStartedBeforeDate(MonthCalendarPatient.SelectionRange.Start))
            {
                prescriptions.Add(prescription);
            }


            foreach (var presc in prescriptions)
            {
                foreach (var item in Services.Instance.GetPrescriptionHasItemsEnumerableByPrescriptionId(presc.Id))
                {
                    if (Services.Instance.IsMedicine(item.PrescriptionItemId))
                    {
                        foreach (TimeSpan ts in item.RecommendedTimes)
                        {
                            string data_string = "Take " + Services.Instance.GetMedicineById(item.PrescriptionItemId).Name + " medicine.";
                            data.Add(new KeyValuePair<string, string>(Services.Instance.RemoveSecondsInTimeSpan(ts), data_string));
                        }
                    }
                    if (Services.Instance.IsExercise(item.PrescriptionItemId))
                    {                     
                        foreach (TimeSpan ts in item.RecommendedTimes)
                        {
                            string data_string = "Do " + Services.Instance.GetExerciseById(item.PrescriptionItemId).Name + " exercise.";
                            data.Add(new KeyValuePair<string, string>(Services.Instance.RemoveSecondsInTimeSpan(ts), data_string));
                        }
                    }
                }
            }

            foreach (var session in Services.Instance.GetLoggedInPatientsTherapySessionsAtDate(MonthCalendarPatient.SelectionRange.Start))
            {
                string data_string = "Therapy session with therapist " + Services.Instance.GetUserById(session.Therapist.Id).FullName + ".";
                data.Add(new KeyValuePair<string, string>(session.DateTime.TimeOfDay.ToString(), data_string));
            }

            data.Sort((b, a) => (b.Value.CompareTo(a.Value)));

            foreach (var pair in data)
            {
                sessions = sessions + pair + newLine;
            }

            if (sessions == "")
            {
                sessions = "Nothing for today";
            }
            TextBoxDayEvents.Text = sessions;
        }
    }
}
