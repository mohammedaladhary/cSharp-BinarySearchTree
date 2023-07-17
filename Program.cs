
using System;
namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BinarySearchTree bst = new BinarySearchTree();

            bst.Insert(90);
            bst.Insert(30);
            bst.Insert(50);
            bst.Insert(40);
            bst.Insert(10);
            bst.Insert(60);
            bst.Insert(20);

            Console.WriteLine("\nIn-order traversal of the BST:");
            bst.InOrderTraversal();

            Console.WriteLine("\nPost-order traversal of the BST:");
            bst.TraversePostOrder();

            Console.WriteLine("\nPre-order traversal of the BST:");
            bst.TraversePreOrder();
        }
    }
}