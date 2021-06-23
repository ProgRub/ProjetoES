using System.Windows.Forms;
using ServicesLibrary.Commands;

namespace Forms.CommandsVisualCompletedSession
{
    public class CommandSetTextBoxText : ICommand
    {
        private TextBox TextBox { get; set; }
        private readonly string _oldText;
        private readonly string _newText;

        public CommandSetTextBoxText(TextBox textBox, string oldText)
        {
            _oldText = oldText;
            TextBox = textBox;
            _newText = textBox.Text;
        }



        public void Execute()
        {
            TextBox.Text = _newText;
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            TextBox.Text = _oldText;
        }
    }
}