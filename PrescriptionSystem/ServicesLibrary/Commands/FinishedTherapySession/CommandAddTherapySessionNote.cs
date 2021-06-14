using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.Commands.FinishedTherapySession
{
    public class CommandAddTherapySessionNote:ICommand
    {
        private string _therapySessionOldNote, _therapySessionNewNote;
        private TherapySession _therapySession = TherapySessionService.Instance.GetSelectedTherapySession();
        public CommandAddTherapySessionNote(string note)
        {
            _therapySessionNewNote = note;
            _therapySessionOldNote= _therapySession.Note;
        }
        public void Execute()
        {
            _therapySession.Note = _therapySessionNewNote;
            TherapySessionService.Instance.SaveChanges();
        }

        public void Undo()
        {
            _therapySession.Note = _therapySessionOldNote;
            TherapySessionService.Instance.SaveChanges();
        }

        public void Redo()
        {
            Execute();
        }
    }
}