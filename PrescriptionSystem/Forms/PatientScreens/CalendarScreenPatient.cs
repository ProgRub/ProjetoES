using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.PatientScreens
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
            ShowDayEvents();
        }

        private void ShowDayEvents()
        {
            var data = new List<KeyValuePair<string, string>>();
            string sessions = "";

            var prescriptions =
                Services.Instance.GetLoggedInPatientsPrescriptionsStartedBeforeDate(MonthCalendarPatient.SelectionRange
                    .Start);


            foreach (var prescription in prescriptions)
            {
                foreach (var item in prescription.PrescriptionItemsRecommendedTimes.Keys)
                {
                    if (Services.Instance.IsMedicine(item.Id))
                    {
                        AddMedicineInformation(prescription, item, data);
                    }

                    if (Services.Instance.IsExercise(item.Id))
                    {
                        AddExerciseInformation(prescription, item, data);
                    }
                }
            }

            AddTherapySessionsInformation(data);

            var orderByKey = data.OrderBy(kvp => kvp.Key);

            sessions = BeautifyInformation(orderByKey, sessions);

            TextBoxDayEvents.Text = sessions;
        }

        private string BeautifyInformation(IOrderedEnumerable<KeyValuePair<string, string>> orderByKey, string sessions)
        {
            foreach (var pair in orderByKey)
            {
                if (pair.Key == "")
                {
                    sessions = sessions + "[" + pair.Value + "]" + Environment.NewLine;
                }
                else
                {
                    sessions = sessions + pair + Environment.NewLine;
                }
            }

            if (sessions == "")
            {
                sessions = "Nothing for today!";
            }

            return sessions;
        }

        private void AddTherapySessionsInformation(List<KeyValuePair<string, string>> data)
        {
            foreach (var session in Services.Instance.GetLoggedInPatientsTherapySessionsAtDate(MonthCalendarPatient
                .SelectionRange.Start))
            {
                var dataString = "Therapy session with therapist " + session.Therapist.FullName + ".";
                data.Add(new KeyValuePair<string, string>(Services.Instance.RemoveSecondsInTimeSpan(session.DateTime.TimeOfDay),
                    dataString));
            }
        }

        private void AddMedicineInformation(PrescriptionDTO prescription, PrescriptionItemDTO item, List<KeyValuePair<string, string>> data)
        {
            if (prescription.PrescriptionItemsRecommendedTimes[item] != null)
            {
                data.AddRange(from timeSpan in prescription.PrescriptionItemsRecommendedTimes[item]
                    let dataString = "Take " + item.Name + " medicine."
                    select new KeyValuePair<string, string>(timeSpan.ToString(@"hh\:mm"), dataString));
            }
            else
            {
                var dataString = "Take " + item.Name + " medicine.";
                data.Add(new KeyValuePair<string, string>("", dataString));
            }

        }

        private void AddExerciseInformation(PrescriptionDTO prescription, PrescriptionItemDTO item, List<KeyValuePair<string, string>> data)
        {
            if (prescription.PrescriptionItemsRecommendedTimes[item] != null)
            {
                foreach (var timeSpan in prescription.PrescriptionItemsRecommendedTimes[item])
                {
                    var dataString = "Do " + item.Name + " exercise.";
                    data.Add(new KeyValuePair<string, string>(timeSpan.ToString(@"hh\:mm"), dataString));
                }
            }
            else
            {
                var dataString = "Do " + item.Name + " exercise.";
                data.Add(new KeyValuePair<string, string>("", dataString));
            }
        }

        private void CalendarScreenPatient_Enter(object sender, EventArgs e)
        {
            ShowDayEvents();
        }
    }
}