using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms
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


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenTherapist());
        }

        private void ButtonAddTherapySession_Click(object sender, EventArgs e)
        {
            var treatments = new List<TreatmentDTO>();
            foreach (var checkedItem in CheckedListBoxTreatments.CheckedItems)
            {
                treatments.Add(GetTreatmentFromString(checkedItem.ToString()));
            }

            var estimatedDuration = TimeSpan.Parse(LabelSessionDuration.Text);

            var errorCodes = Services.Instance.CheckTherapySessionCreation(GetSelectedPatientInComboBox(),
                DateTimePickerDate.Value,
                DateTimePickerSessionHour.Value, treatments, estimatedDuration);
            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            Services.Instance.CreateTherapySession(GetSelectedPatientInComboBox(), DateTimePickerDate.Value,
                DateTimePickerSessionHour.Value, treatments, estimatedDuration);
            ShowInformationMessageBox("Therapy Session successfully scheduled.", "Success");
            MoveToScreen(new CalendarScreenTherapist());
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