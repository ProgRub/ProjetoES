namespace ServicesLibrary.Commands
{

    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}