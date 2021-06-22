using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Forms.CommonScreens;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.HealthCareProfessionalScreens
{
    public partial class SelectPrescriptionScreen : BaseControl
    {
        private IEnumerable<PrescriptionDTO> _prescriptions;

        public SelectPrescriptionScreen()
        {
            InitializeComponent();
        }

        private void SelectPrescriptionScreen_Enter(object sender, EventArgs e)
        {
            _prescriptions = Services.Instance.GetPatientsPrescriptionsByPatientId(Services.Instance.GetSelectedPatient().Id);
            if (!_prescriptions.Any())
            {
                LabelTitle.Text = "The selected patient doesn't have any prescriptions yet...";
                return;
            }

            for (var index = 0; index < _prescriptions.Count(); index++)
            {
                var button = new Button
                {
                    AutoSize = false,
                    BackColor = ButtonExamplePrescription.BackColor,
                    Size = ButtonExamplePrescription.Size,
                    Location = new Point(
                        ButtonExamplePrescription.Location.X +
                        (index / 8) * (ButtonExamplePrescription.Size.Width + 25),
                        ButtonExamplePrescription.Location.Y +
                        (index % 8) * (ButtonExamplePrescription.Size.Height + 25))
                };
                if (Services.Instance.CanHealthCareProfessionalViewPrescription(_prescriptions.ElementAt(index),
                    Services.Instance.GetLoggedInHealthCareProfessional()))
                {
                    button.Font = ButtonExamplePrescription.Font;
                    button.ForeColor = ButtonExamplePrescription.ForeColor;
                    button.Text =
                        $"{_prescriptions.ElementAt(index).Id} | {_prescriptions.ElementAt(index).Patient.FullName} | {_prescriptions.ElementAt(index).Author.FullName}{Environment.NewLine} From {_prescriptions.ElementAt(index).StartDate:d} to {_prescriptions.ElementAt(index).EndDate:d}";
                }
                else
                {
                    button.Font = ButtonExamplePrescription.Font;
                    button.ForeColor = Color.Red;
                    button.Text = "This is private information!";
                    button.Enabled = false;
                }

                ;
                button.MouseClick += ButtonClicked;
                Controls.Add(button);
            }
        }

        private void ButtonClicked(object sender, MouseEventArgs e)
        {
            Services.Instance.SelectPrescriptions(new[] {GetPrescriptionFromString(((Button) sender).Text)});
            MoveToScreen(new PrescriptionDetailsScreen(), this);
        }

        private PrescriptionDTO GetPrescriptionFromString(string text)
        {
            return _prescriptions.FirstOrDefault(treatment =>
                treatment.Id.ToString() == text.Split(" | ", StringSplitOptions.RemoveEmptyEntries)[0]);
        }
    }
}