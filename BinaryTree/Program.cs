using System;

namespace BinaryTree
{
    public class Program
    {
        /// <summary>
        /// This problem was asked by Google.
        /// Given the root of a binary tree, return a deepest node.<br/>
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            IBinaryTree tree = new BinaryTree("a");

            tree.Insert("b");
            tree.Insert("c");
            tree.Insert("d");
            tree.Insert("e");
            tree.Insert("f");

            // Printing the height of tree
            Console.WriteLine($"The tree has {tree.Height()} levels");

            // Printing the deepest node
            Console.WriteLine($"The value of the deepest node is {tree.GetDeepestNodeValue()}");
        }

    }
}
