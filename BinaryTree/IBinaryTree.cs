namespace BinaryTree
{
    internal interface IBinaryTree
    {
        /// <summary>
        /// Utility function to find height of the tree.
        /// </summary>
        /// <returns></returns>
        int Height();

        /// <summary>
        /// Utility function to find height of a tree, rooted at 'node'.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        int GetNodeHeight(TreeNode node);

        /// <summary>
        /// Utility function to return the value of the deepest node of the tree.
        /// </summary>
        string GetDeepestNodeValue();

        /// <summary>
        /// Utility function to return the value of the deepest node of the tree.
        /// </summary>
        /// <param name="root"></param>
        TreeNode GetDeepestNode(TreeNode root);

        /// <summary>
        /// Method to insert value into the first empty spot in the binary tree.
        /// </summary>
        /// <param name="key">Value to insert</param>
        void Insert(string key);

        /// <summary>
        /// Method to insert value into the first empty spot in a given <see cref="TreeNode"/>.
        /// </summary>
        /// <param name="temp">Node to traverse.</param>
        /// <param name="key">Value to insert</param>
        void Insert(TreeNode temp, string key);
    }
}