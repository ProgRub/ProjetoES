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
using ServicesLibrary.Commands;
using ServicesLibrary.Commands.FinishedTherapySession;
using ServicesLibrary.DTOs;

namespace Forms
{
    public partial class TherapySessionCompletedScreen : BaseControl
    {
        private TherapySessionDTO _therapySession;

        public TherapySessionCompletedScreen()
        {
            InitializeComponent();
        }

        private void TherapySessionCompletedScreen_Load(object sender, EventArgs e)
        {
            _therapySession = Services.Instance.GetSelectedTherapySession();
            CommandsManager.Instance.Notify += (sender, args) =>
            {
                ButtonUndo.Enabled = CommandsManager.Instance.HasUndo;
            };
            CommandsManager.Instance.Notify += (sender, args) =>
            {
                ButtonRedo.Enabled = CommandsManager.Instance.HasRedo;
            };
            LabelSessionInfo.Text =
                $"{_therapySession.Id} | {_therapySession.Patient.FullName} | {_therapySession.DateTime:dddd dd/MM/yyyy HH:mm}";
            foreach (var treatment in _therapySession.Treatments)
            {
                var listViewItem = new ListViewItem(treatment.Name);
                listViewItem.SubItems.Add(treatment.Description);
                listViewItem.SubItems.Add(treatment.BodyPart.ToString());
                listViewItem.SubItems.Add(treatment.Duration.ToString());
                ListViewTreatments.Items.Add(listViewItem);
            }

            TextBoxTherapySessionNote.Text = _therapySession.Note;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPastTherapySessionScreen());
        }

        private void ButtonRedo_Click(object sender, EventArgs e)
        {
            CommandsManager.Instance.Redo();
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            CommandsManager.Instance.Undo();
        }

        private void ListViewTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewTreatments.SelectedIndices.Count == 1)
            {
                SetEnabledTreatmentNoteControls(true);
                TextBoxTreatmentNote.Text = Services.Instance.GetTreatmentNote(_therapySession.Id,
                    _therapySession.Treatments.ElementAt(ListViewTreatments.SelectedIndices[0]).Id);
                CheckBoxCompletedTreatment.Checked =
                    Services.Instance.GetTreatmentCompletedStatus(_therapySession.Id,
                        _therapySession.Treatments.ElementAt(ListViewTreatments.SelectedIndices[0]).Id);
            }
            else
            {
                SetEnabledTreatmentNoteControls(false);
                TextBoxTreatmentNote.Text = "";
                CheckBoxCompletedTreatment.Checked = false;
            }
        }

        private void SetEnabledTreatmentNoteControls(bool state)
        {
            TextBoxTreatmentNote.Enabled = state;
            ButtonAddTreatmentNote.Enabled = state;
            CheckBoxCompletedTreatment.Enabled = state;
        }

        private void ButtonAddTreatmentNote_Click(object sender, EventArgs e)
        {
            SetEnabledTreatmentNoteControls(false);
            CommandsManager.Instance.Execute(new CommandAddTreatmentNoteSetCompleted(TextBoxTreatmentNote.Text,
                CheckBoxCompletedTreatment.Checked, _therapySession.Id,
                _therapySession.Treatments.ElementAt(ListViewTreatments.SelectedIndices[0]).Id));
            TextBoxTreatmentNote.Text = "";
            CheckBoxCompletedTreatment.Checked = false;
        }

        private void ButtonAddSessionNote_Click(object sender, EventArgs e)
        {
            CommandsManager.Instance.Execute(new CommandAddTherapySessionNote(TextBoxTherapySessionNote.Text));
        }
    }
}