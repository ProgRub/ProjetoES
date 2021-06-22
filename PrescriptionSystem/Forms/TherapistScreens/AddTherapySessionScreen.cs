using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Forms.CommonScreens;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.TherapistScreens
{
    public partial class AddTherapySessionScreen : BaseControl
    {
        private IEnumerable<TreatmentDTO> _treatments;
        private IEnumerable<PatientDTO> _patients;
        public AddTherapySessionScreen()
        {
            InitializeComponent();
        }

        private void AddTherapySessionScreen_Load(object sender, EventArgs e)
        {
            _treatments = Services.Instance.GetAllTreatments();
            _patients = Services.Instance.GetAllPatients();
            //DateTimePickerDate.MinDate = DateTime.Today;
            foreach (var patient in _patients)
            {
                ComboBoxPatient.Items.Add($"{patient.Id} - {patient.FullName}");
            }

            foreach (var treatment in _treatments)
            {
                CheckedListBoxTreatments.Items.Add($"{treatment.Name} | {treatment.BodyPart} | {treatment.Duration}");
            }

            SetFormAcceptButton(ButtonAddTherapySession);
            SetCheckedListBoxColumnWidth(CheckedListBoxTreatments);
        }

        private void ButtonAddTherapySession_Click(object sender, EventArgs e)
        {
            var treatments = new List<TreatmentDTO>();
            foreach (var checkedItem in CheckedListBoxTreatments.CheckedItems)
            {
                treatments.Add(GetTreatmentFromString(checkedItem.ToString()));
            }

            var therapySession = new TherapySessionDTO
            {
                Patient = GetSelectedPatientInComboBox(), Therapist = Services.Instance.GetLoggedInTherapist(),
                DateTime = DateTimePickerDate.Value.Date.Add(DateTimePickerSessionHour.Value.TimeOfDay),
                EstimatedDuration = TimeSpan.Parse(LabelSessionDuration.Text), Treatments = treatments
            };
            
            var errorCodes = Services.Instance.CheckTherapySessionCreation(therapySession);
            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            Services.Instance.CreateTherapySession(therapySession);
            ShowInformationMessageBox("Therapy Session successfully scheduled.", "Success");
            MoveToScreen(new CalendarScreenTherapist(), new LoginScreen());
        }

        private void ShowErrorMessages(IEnumerable<int> errorCodes)
        {
            var first = true;
            var errorMessage = "";
            foreach (var errorCode in errorCodes)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    errorMessage += Environment.NewLine;
                }

                switch (errorCode)
                {
                    case Services.PatientUnavailable:
                        errorMessage += "Patient is unavailable at that time and/or day.";
                        break;
                    case Services.TherapistUnavailable:
                        errorMessage += "You are unavailable at that time and/or day.";
                        break;
                    case Services.PatientRequired:
                        errorMessage += "You have to select a patient.";
                        break;
                    case Services.AtLeastOneTreatment:
                        errorMessage += "You have to select at least one treatment.";
                        break;
                    case Services.InvalidAge:
                        errorMessage += "The patient is out of the age range of, at least, one of the selected treatments.";
                        break;
                    case Services.MissingBodyPart:
                        errorMessage += "The patient is missing the body part one of the treatments targets.";
                        break;
                }
            }

            ShowInformationMessageBox(errorMessage, "Error");
        }

        private void CheckedListBoxTreatments_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                LabelSessionDuration.Text =
                    (TimeSpan.Parse(LabelSessionDuration.Text) +
                     GetTreatmentFromString(CheckedListBoxTreatments.Items[e.Index].ToString()).Duration).ToString();
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                LabelSessionDuration.Text =
                    (TimeSpan.Parse(LabelSessionDuration.Text) -
                     GetTreatmentFromString(CheckedListBoxTreatments.Items[e.Index].ToString()).Duration).ToString();
            }
        }

        private TreatmentDTO GetTreatmentFromString(string treatmentString)
        {
            var treatmentSplit = treatmentString.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            return _treatments.FirstOrDefault(treatment =>
                treatment.Name == treatmentSplit[0] && treatment.BodyPart.ToString() == treatmentSplit[1] &&
                treatment.Duration.ToString() == treatmentSplit[2]);
        }

        private PatientDTO GetSelectedPatientInComboBox()
        {
            if (ComboBoxPatient.SelectedItem != null)
            {
                return _patients.First(e =>
                    e.Id.ToString() == ComboBoxPatient.Text.Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                        .First());
            }

            return null;
        }
    }
}