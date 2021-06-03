using System;
using System.Collections.Generic;

namespace BinaryTree
{
    internal class BinaryTree : IBinaryTree
    {
        private TreeNode Root { get; set; }

        public BinaryTree(string key)
        {
            Root = new TreeNode(key);
        }

        public BinaryTree()
        {
            
        }

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
            if (Root == null)
            {
                Root = new TreeNode(key);
                return;
            }

            var queue = new Queue<TreeNode>();

            queue.Enqueue(Root);

            var temp = Root;

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
                Root = temp;
            }
        }
    }
}
    
