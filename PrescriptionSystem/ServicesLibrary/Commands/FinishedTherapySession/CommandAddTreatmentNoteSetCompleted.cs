﻿using System.Diagnostics;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.Commands.FinishedTherapySession
{
    public class CommandAddTreatmentNoteSetCompleted : ICommand
    {
        private string _treatmentOldNote, _treatmentNewNote;
        private bool _treatmentOldCompletedState, _treatmentNewCompletedState;
        private TherapySessionHasTreatments _therapySessionHasTreatments;

        public CommandAddTreatmentNoteSetCompleted(string note, bool completedState, string treatmentString)
        {
            _therapySessionHasTreatments =
                TherapySessionService.Instance.GetTherapySessionHasTreatmentsBySessionIdTreatmentId(
                    TherapySessionService.Instance.SelectedTherapySessionId,
                    PrescriptionItemService.Instance.GetTreatmentByNameBodyPartAndDurationString(treatmentString).Id);
            _treatmentOldNote = _therapySessionHasTreatments.Note;
            _treatmentOldCompletedState = _therapySessionHasTreatments.CompletedTreatment;
            _treatmentNewNote = note;
            _treatmentNewCompletedState = completedState;
        }

        public void Execute()
        {
            _therapySessionHasTreatments.Note = _treatmentNewNote;
            _therapySessionHasTreatments.CompletedTreatment = _treatmentNewCompletedState;
            TherapySessionService.Instance.SaveChanges();
        }

        public void Undo()
        {
            _therapySessionHasTreatments.Note = _treatmentOldNote;
            _therapySessionHasTreatments.CompletedTreatment = _treatmentOldCompletedState;
            TherapySessionService.Instance.SaveChanges();
        }

        public void Redo()
        {
            Execute();
        }
    }
}