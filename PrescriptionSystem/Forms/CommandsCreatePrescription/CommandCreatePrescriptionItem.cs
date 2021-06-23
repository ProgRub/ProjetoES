using ServicesLibrary.Commands;
using ServicesLibrary.DTOs;

namespace Forms.CommandsCreatePrescription
{
    public class CommandCreatePrescriptionItem : ICommand
    {
        public CommandCreatePrescriptionItem(PrescriptionItemDTO prescriptionItem)
        {
            Name = $"{prescriptionItem.Id} - {prescriptionItem.Name}";
        }

        public string Name { get; private set; }

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