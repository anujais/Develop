using System.Collections.Generic;

namespace DataStructure
{
    public static class BinaryTree<T>
    {
        public static void PreOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root !=null)
            {
                System.Console.Write("{0} ",root.Value);
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }

        public static void PostOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                System.Console.Write("{0} ", root.Value);
            }
        }

        public static void InOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                System.Console.Write("{0} ", root.Value);
                InOrderTraversal(root.Right);
            }
        }
    }
}
