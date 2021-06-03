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
        /// Method to insert element in binary tree.
        /// </summary>
        /// <param name="key">Value to insert</param>
        void Insert(string key);
    }
}