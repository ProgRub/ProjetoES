using System.Windows.Forms;
using ServicesLibrary.Commands;

namespace Forms.CommandsCreatePrescription
{
    public class CommandDeleteNode : ICommand
    {
        public CommandDeleteNode(TreeNodeCollection nodes, TreeNode node)
        {
            Nodes = nodes;

            Node = node;

        }

        public TreeNodeCollection Nodes { get; }

        public TreeNode Node { get; }

        public void Execute()
        {
            Nodes.Remove(Node);
        }

        public void Undo()
        {
            Nodes.Add(Node);
        }

        public void Redo()
        {
            Execute();
        }

    }
}