using System.Windows.Forms;
using ServicesLibrary.Commands;

namespace Forms.CommandsVisualCompletedSession
{
    public class CommandSetTextboxText : ICommand
    {
        private TextBox TextBox { get; set; }
        private string _oldText;
        private string _newText;

        public CommandSetTextboxText(TextBox textBox, string oldText)
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