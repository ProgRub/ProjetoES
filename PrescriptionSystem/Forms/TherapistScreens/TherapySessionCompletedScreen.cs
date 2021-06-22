﻿using System;
using System.Linq;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.Commands;
using ServicesLibrary.Commands.FinishedTherapySession;
using ServicesLibrary.DTOs;

namespace Forms.TherapistScreens
{
    public partial class TherapySessionCompletedScreen : BaseControl
    {
        private TherapySessionDTO _therapySession;
        public TherapySessionCompletedScreen()
        {
            InitializeComponent();
        }

        private void TherapySessionCompletedScreen_Enter(object sender, EventArgs e)
        {
            _therapySession = Services.Instance.GetSelectedTherapySession();
            CommandsManager.Instance.Notify += (sender, args) => { ButtonUndo.Enabled = CommandsManager.Instance.HasUndo; };
            CommandsManager.Instance.Notify += (sender, args) => { ButtonRedo.Enabled = CommandsManager.Instance.HasRedo; };
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
            ButtonAddTreatmentNoteSetCompletedState.Enabled = state;
            CheckBoxCompletedTreatment.Enabled = state;
        }

        private void ButtonAddTreatmentNoteSetCompletedState_Click(object sender, EventArgs e)
        {
            CommandsManager.Instance.Execute(new CommandAddTreatmentNoteSetCompleted(TextBoxTreatmentNote.Text,
                CheckBoxCompletedTreatment.Checked, _therapySession.Id,
                _therapySession.Treatments.ElementAt(ListViewTreatments.SelectedIndices[0]).Id));
            TextBoxTreatmentNote.Text = "";
            CheckBoxCompletedTreatment.Checked = false;
            SetEnabledTreatmentNoteControls(false);
        }

        private void ButtonAddSessionNote_Click(object sender, EventArgs e)
        {
            CommandsManager.Instance.Execute(new CommandAddTherapySessionNote(TextBoxTherapySessionNote.Text));
        }
    }
}