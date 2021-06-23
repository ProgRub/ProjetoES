using System.Collections.Generic;

namespace ServicesLibrary.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void Add(ICommand aCommand)
        {
            _commands.Add(aCommand);
        }

        public void Remove(ICommand aCommand)
        {
            _commands.Remove(aCommand);
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            _commands.Reverse();
            foreach (var command in _commands)
            {
                command.Undo();
            }

            _commands.Reverse();
        }

        public void Redo()
        {
            foreach (var command in _commands)
            {
                command.Redo();
            }
        }
    }
}