using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Commands.FinishedTherapySession
{
    public class CommandAddTherapySessionNote : ICommand
    {
        private readonly string _therapySessionOldNote;
        private readonly string _therapySessionNewNote;
        private readonly TherapySession _therapySession = TherapySessionService.Instance.GetSelectedTherapySession();
        private readonly TherapySessionDTO _therapySessionDto;

        public CommandAddTherapySessionNote(string note, TherapySessionDTO therapySession)
        {
            _therapySessionNewNote = note;
            _therapySessionOldNote = _therapySession.Note;
            _therapySessionDto = therapySession;
        }

        public void Execute()
        {
            _therapySession.Note = _therapySessionNewNote;
            _therapySessionDto.Note = _therapySessionNewNote;
            TherapySessionService.Instance.SaveChanges();
        }

        public void Undo()
        {
            _therapySession.Note = _therapySessionOldNote;
            _therapySessionDto.Note = _therapySessionOldNote;
            TherapySessionService.Instance.SaveChanges();
        }

        public void Redo()
        {
            Execute();
        }
    }
}