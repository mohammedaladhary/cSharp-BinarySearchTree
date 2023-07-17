using System;
namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }
        public void Insert(int data)
        {
            root = InsertRec(root, data);
        }

        private Node InsertRec(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.data)
                root.left = InsertRec(root.left, data);
            else if (data > root.data)
                root.right = InsertRec(root.right, data);

            return root;
        }
        public void InOrderTraversal()
        {
            InOrderTraversalBst(root);
        }

        private void InOrderTraversalBst(Node root)
        {
            if (root != null)
            {
                InOrderTraversalBst(root.left);
                Console.Write(root.data + " ");
                InOrderTraversalBst(root.right);
            }
        }
        public void TraversePostOrder()
        {
            TraversePostOrderBst(root);
        }
        private void TraversePostOrderBst(Node root)
        {
            if (root != null)
            {
                TraversePostOrderBst(root.left);
                TraversePostOrderBst(root.right);
                Console.Write(root.data + " ");
            }
        }
        public void TraversePreOrder()
        {
            TraversePreOrderBst(root);
        }
        private void TraversePreOrderBst(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                TraversePreOrderBst(root.left);
                TraversePreOrderBst(root.right);
            }
        }
    }
}