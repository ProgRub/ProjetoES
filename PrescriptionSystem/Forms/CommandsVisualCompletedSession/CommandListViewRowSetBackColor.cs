using System.Drawing;
using System.Windows.Forms;
using ServicesLibrary.Commands;

namespace Forms.CommandsVisualCompletedSession
{
    public class CommandListViewRowSetBackColor : ICommand
    {
        private ListViewItem ListViewItem { get; set; }
        private readonly Color _newColor;
        private readonly Color _oldColor;

        public CommandListViewRowSetBackColor(ListViewItem listViewItem, Color newColor)
        {
            _oldColor = listViewItem.BackColor;
            _newColor = newColor;
            ListViewItem = listViewItem;
        }

        public void Execute()
        {
            ListViewItem.BackColor = _newColor;
        }

        public void Undo()
        {
            ListViewItem.BackColor = _oldColor;
        }

        public void Redo()
        {
            Execute();
        }
    }
}