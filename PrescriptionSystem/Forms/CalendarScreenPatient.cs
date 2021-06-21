using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ServicesLibrary;

namespace Forms
{
    public partial class CalendarScreenPatient : BaseControl
    {
        public CalendarScreenPatient()
        {
            InitializeComponent();
        }
        private void ButtonGetPrescriptionHistory_Click(object sender, EventArgs e)
        {
            MoveToScreen(new GetPrescriptionHistoryScreen(), this);
        }

        private void ButtonAddPermission_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPrescriptionsScreen(), this);
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
                        if (prescription.PrescriptionItemsRecommendedTimes != null)
                        {
                            foreach (var timeSpan in prescription.PrescriptionItemsRecommendedTimes[item])
                            {
                                var dataString = "Take " + item.Name + " medicine.";
                                data.Add(new KeyValuePair<string, string>(timeSpan.ToString(@"hh\:mm"), dataString));
                            }
                        }
                    }

                    if (Services.Instance.IsExercise(item.Id))
                    {
                        if (prescription.PrescriptionItemsRecommendedTimes != null)
                        {
                            foreach (var timeSpan in prescription.PrescriptionItemsRecommendedTimes[item])
                            {
                                var dataString = "Do " + item.Name + " exercise.";
                                data.Add(new KeyValuePair<string, string>(timeSpan.ToString(@"hh\:mm"), dataString));
                            }
                        }
                    }
                }
            }

            foreach (var session in Services.Instance.GetLoggedInPatientsTherapySessionsAtDate(MonthCalendarPatient
                .SelectionRange.Start))
            {
                var dataString = "Therapy session with therapist " + session.Therapist.FullName + ".";
                data.Add(new KeyValuePair<string, string>(session.DateTime.TimeOfDay.ToString(), dataString));
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