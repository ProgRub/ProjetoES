using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.Commands;

namespace Forms
{
    public partial class CalendarScreenPatient : BaseControl
    {
        public CalendarScreenPatient()
        {
            InitializeComponent();
            CommandsManager.Instance.ResetCommandsList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToScreen(new GetPrescriptionHistoryScreen());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new LoginScreen());
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPrescriptionsScreen());
        }

        private void monthCalendarPatient_DateChanged(object sender, DateRangeEventArgs e)
        {
            var sessions = "";
            var newLine = Environment.NewLine;

            var data = new List<KeyValuePair<TimeSpan, string>>();

            foreach (var prescription in Services.Instance.GetPrescriptionByDate(monthCalendarPatient.SelectionRange.Start))
            {
                foreach (var item in Services.Instance.GetPrescriptionHasItemsEnumerableByPrescriptionId(prescription.Id))
                {
                    if(Services.Instance.IsMedicine(item.PrescriptionItemId))
                    {
                        var data_string = "Take " + Services.Instance.GetMedicineByItemId(item.PrescriptionItemId).Name + " medicine.";
                        data.Add(new KeyValuePair<TimeSpan, string>(item.RecommendedTime, data_string));
                    }
                    if (Services.Instance.IsExercise(item.PrescriptionItemId))
                    {
                        var data_string = "Do " + Services.Instance.GetExerciseByItemId(item.PrescriptionItemId).Name + " exercise.";
                        data.Add(new KeyValuePair<TimeSpan, string>(item.RecommendedTime, data_string));
                    }
                }
            }

            foreach (var session in Services.Instance.GetSessionsByPatientId(monthCalendarPatient.SelectionRange.Start))
            {
                var data_string = "Therapy session with therapist " + Services.Instance.GetUserById(session.TherapistId).FullName + ".";
                data.Add(new KeyValuePair<TimeSpan, string>(session.DateTime.TimeOfDay, data_string));
            }

            data.Sort((b, a) => (b.Value.CompareTo(a.Value)));

            foreach (var pair in data)
            {
                sessions = sessions + pair + newLine;
            }

            if (sessions == "")
            {
                sessions = "Nothing for today.";
            }
            textBox1.Text = sessions;
        }
    }
}
