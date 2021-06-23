using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.Commands.FinishedTherapySession
{
    public class CommandAddTreatmentNoteSetCompleted : ICommand
    {
        private readonly string _treatmentOldNote;
        private readonly string _treatmentNewNote;
        private readonly bool _treatmentOldCompletedState;
        private readonly bool _treatmentNewCompletedState;
        private readonly TherapySessionHasTreatments _therapySessionHasTreatments;

        public CommandAddTreatmentNoteSetCompleted(string note, bool completedState, int sessionId, int treatmentId)
        {
            _therapySessionHasTreatments =
                TherapySessionService.Instance.GetTherapySessionHasTreatmentsBySessionIdAndTreatmentId(sessionId,
                    treatmentId);
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