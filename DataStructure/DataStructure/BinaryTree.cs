using System.Collections.Generic;

namespace DataStructure
{
    public static class BinaryTree<T>
    {
        public static void PreOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                System.Console.Write("{0} ", root.Value);
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

        public static int GetHeight(BinaryTreeNode<T> root)
        {
            if (root == null)
                return 0;
            else
            {
                int lHeight = 1;
                int rHeight = 1;

                if (root.Left != null)
                {
                    lHeight = GetHeight(root.Left) + 1;
                }

                if (root.Right != null)
                {
                    rHeight = GetHeight(root.Right) + 1;
                }

                return lHeight > rHeight ? lHeight : rHeight;
            }
        }
    }
}
