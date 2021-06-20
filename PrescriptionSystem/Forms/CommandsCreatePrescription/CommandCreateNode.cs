
using System.Windows.Forms;
using ServicesLibrary.Commands;

namespace Forms.CommandsCreatePrescription
{
    public class CommandCreateNode : ICommand
    {
        public CommandCreateNode(TreeNodeCollection nodes, int imageIndex, string type)
        {
            Nodes = nodes;

            Node = new TreeNode { Text = type };
            Node.ImageIndex = Node.SelectedImageIndex = imageIndex;
            Node.Tag = type;

        }

        public TreeNodeCollection Nodes { get; }

        public TreeNode Node { get; }

        public void Execute()
        {
            Nodes.Add(Node);
        }

        public void Undo()
        {
            Nodes.Remove(Node);
        }

        public void Redo()
        {
            Execute();
        }
    }
}