namespace BinaryTree
{
    // A tree node with constructor
    public class TreeNode
    {
        public string Data;
        public TreeNode Left, Right;

        // constructor
        public TreeNode(string key)
        {
            Data = key;
            Left = null;
            Right = null;
        }
    }
}