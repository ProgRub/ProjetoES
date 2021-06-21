using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms
{
    public partial class SelectPatientScreen : BaseControl
    {
        private IEnumerable<PatientDTO> _patients;
        public SelectPatientScreen()
        {
            InitializeComponent();
        }
        private void SelectPatientScreen_Load(object sender, EventArgs e)
        {
            _patients = Services.Instance.GetAllPatients();
            if (!_patients.Any())
            {
                LabelTitle.Text = "There are no patients registered yet...";
                return;
            }

            for (var index = 0; index < _patients.Count(); index++)
            {
                var button = new Button
                {
                    AutoSize = false,
                    Font = ButtonExamplePatient.Font,
                    BackColor = ButtonExamplePatient.BackColor,
                    ForeColor = ButtonExamplePatient.ForeColor,
                    Text =
                        $"{_patients.ElementAt(index).Id} - {_patients.ElementAt(index).FullName}",
                    Size = ButtonExamplePatient.Size,
                    Location = new Point(
                        ButtonExamplePatient.Location.X +
                        (index / 8) * (ButtonExamplePatient.Size.Width + 25),
                        ButtonExamplePatient.Location.Y +
                        (index % 8) * (ButtonExamplePatient.Size.Height + 25))
                };
                button.MouseClick += ButtonClicked;
                Controls.Add(button);
            }
        }

        private void ButtonClicked(object sender, MouseEventArgs e)
        {
            Services.Instance.SelectPatient(GetPatientFromString(((Button)sender).Text));
            MoveToScreen(new SelectPrescriptionScreen(), this);
        }

        private PatientDTO GetPatientFromString(string text)
        {
            return _patients.FirstOrDefault(treatment =>
                treatment.Id.ToString() == text.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0]);
        }
    }
}
