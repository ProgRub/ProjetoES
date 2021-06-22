using System.Drawing;
using System.Windows.Forms;
using ServicesLibrary.Commands;

namespace Forms.CommandsVisualCompletedSession
{
    public class CommandListViewRowSetColor : ICommand
    {
        private ListViewItem ListViewItem { get; set; }
        private Color _newColor;
        private Color _oldColor;

        public CommandListViewRowSetColor(ListViewItem listViewItem, Color newColor)
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