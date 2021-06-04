using System;
using System.Collections.Generic;

namespace BinaryTree
{
    internal class BinaryTree : IBinaryTree
    {
        #region Private Properites & Constructors

        private TreeNode Root { get; set; }

        public BinaryTree()
        {
            
        }

        public BinaryTree(string key)
        {
            Root = new TreeNode(key);
        }

        #endregion

        #region Public Methods

        public int Height()
        {
            return GetNodeHeight(Root);
        }

        public int GetNodeHeight(TreeNode node)
        {
            if (node == null) return 0;

            var leftHt = GetNodeHeight(node.Left);
            var rightHt = GetNodeHeight(node.Right);

            return Math.Max(leftHt, rightHt) + 1;
        }

        public string GetDeepestNodeValue()
        {
            var node = GetDeepestNode(Root);
            return node.Data;
        }

        public TreeNode GetDeepestNode(TreeNode node)
        {
            TreeNode temp = null;
            if (node == null)
                return null;
 
            // Creating a Queue
            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);
 
            // Iterates until queue become empty
            while (queue.Count != 0)
            {
                temp = queue.Peek();
                queue.Dequeue();
                if (temp.Left != null)
                    queue.Enqueue(temp.Left);
                if (temp.Right != null)
                    queue.Enqueue(temp.Right);
            }
            return temp;
        }

        public void Insert(string key)
        {
            Insert(Root, key);
        }
        
        public void Insert(TreeNode temp, string key)
        {
            if (temp == null)
            {
                Root = new TreeNode(key);
                return;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(temp);

            // Do level order traversal until we find
            // an empty place.
            while (queue.Count != 0) {
                temp = queue.Peek();
                queue.Dequeue();

                if (temp.Left == null) {
                    temp.Left = new TreeNode(key);
                    break;
                }

                queue.Enqueue(temp.Left);

                if (temp.Right == null) {
                    temp.Right = new TreeNode(key);
                    break;
                }

                queue.Enqueue(temp.Right);
            }
        }

        #endregion
    }
}
    
