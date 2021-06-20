using ServicesLibrary.Commands;

namespace Forms.CommandsCreatePrescription
{
    public class CommandCreatePrescriptionItem : ICommand
    {
        public CommandCreatePrescriptionItem(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Execute()
        {
            Name = Name;
        }

        public void Undo()
        {
            Name = null;
        }

        public void Redo()
        {
            Execute();
        }
    }
}