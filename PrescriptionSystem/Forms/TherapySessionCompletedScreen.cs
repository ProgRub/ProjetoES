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

namespace Forms
{
    public partial class TherapySessionCompletedScreen : BaseControl
    {
        public TherapySessionCompletedScreen()
        {
            InitializeComponent();
        }

        private void TherapySessionCompletedScreen_Load(object sender, EventArgs e)
        {
            CommandsManager.Instance.Notify += (sender, args) =>
            {
                ButtonUndo.Enabled = CommandsManager.Instance.HasUndo;
            };
            CommandsManager.Instance.Notify += (sender, args) =>
            {
                ButtonRedo.Enabled = CommandsManager.Instance.HasRedo;
            };
            LabelSessionInfo.Text = Services.Instance.GetSelectedTherapySessionBaseInfo();
            foreach (var treatment in Services.Instance.GetSelectedTherapySessionTreatments())
            {
                var listViewItem = new ListViewItem(treatment.First());
                listViewItem.SubItems.Add(treatment.ElementAt(1));
                listViewItem.SubItems.Add(treatment.ElementAt(2));
                listViewItem.SubItems.Add(treatment.ElementAt(3));
                ListViewTreatments.Items.Add(listViewItem);
            }
            TextBoxTherapySessionNote.Text = Services.Instance.GetSelectedTherapySessionNote();
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
                TextBoxTreatmentNote.Text = Services.Instance.GetTreatmentNote(GetSelectedTreatmentString());
                CheckBoxCompletedTreatment.Checked =
                    Services.Instance.GetTreatmentCompletedStatus(GetSelectedTreatmentString());
            }
            else
            {
                SetEnabledTreatmentNoteControls(false);
                TextBoxTreatmentNote.Text = "";
                CheckBoxCompletedTreatment.Checked =false;
            }
        }

        private void SetEnabledTreatmentNoteControls(bool state)
        {
            TextBoxTreatmentNote.Enabled = state;
            ButtonAddTreatmentNote.Enabled = state;
            CheckBoxCompletedTreatment.Enabled = state;
        }

        private string GetSelectedTreatmentString()
        {
            return
                $"{ListViewTreatments.SelectedItems[0].Text} | {ListViewTreatments.SelectedItems[0].SubItems[2].Text} | {ListViewTreatments.SelectedItems[0].SubItems[3].Text}";
        }

        private void ButtonAddTreatmentNote_Click(object sender, EventArgs e)
        {
            SetEnabledTreatmentNoteControls(false);
            CommandsManager.Instance.Execute(new CommandAddTreatmentNoteSetCompleted(TextBoxTreatmentNote.Text,
                CheckBoxCompletedTreatment.Checked, GetSelectedTreatmentString()));
            TextBoxTreatmentNote.Text = "";
            CheckBoxCompletedTreatment.Checked = false;
        }

        private void ButtonAddSessionNote_Click(object sender, EventArgs e)
        {
            CommandsManager.Instance.Execute(new CommandAddTherapySessionNote(TextBoxTherapySessionNote.Text));
        }
    }
}