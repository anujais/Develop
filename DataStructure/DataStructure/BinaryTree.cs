using System.Collections.Generic;

namespace DataStructure
{
    public class BinaryTree<T>
    {
        public static Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

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

        private static bool AncestorsInternal(BinaryTreeNode<T> root, T element)
        {
            bool found = false;
            if (root != null)
            {
                if (root.Value.Equals(element)) return true;

                found = AncestorsInternal(root.Left, element) || AncestorsInternal(root.Right, element);
                if (found)
                {
                    System.Console.Write("{0} ", root.Value);
                }
            }
            return found;
        }

        public static bool GetAncestors(BinaryTreeNode<T> root, T element)
        {
            return AncestorsInternal(root, element);
        }

        private static BinaryTreeNode<T> KthAncestorsInternal(BinaryTreeNode<T> root, T element, ref int k)
        {
            if (root != null)
            {
                if (root.Value.Equals(element) || KthAncestorsInternal(root.Left, element, ref k) != null || KthAncestorsInternal(root.Right, element, ref k) != null)
                {
                    if (k > 0)
                    {
                        k = k - 1;
                        return root;
                    }
                    else
                    {
                        System.Console.WriteLine("Kth Ancestor is {0}", root.Value);
                        return null;
                    }
                }
            }
            return null;
        }

        public static T GetKthAncestors(BinaryTreeNode<T> root, T element, int k)
        {
            BinaryTreeNode<T> node = KthAncestorsInternal(root, element, ref k);

            if (node != null)
            {
                System.Console.Write("{0}", node.Value);
                return node.Value;
            }
            else
            {
                System.Console.Write("Null");
                return element;
            }
        }

        public static void LevelOrderTraversal(BinaryTreeNode<T> root)
        {
            BinaryTreeNode<T> temp = root;
            while (temp != null)
            {
                System.Console.Write("{0} ", temp.Value);
                if (temp.Left != null)
                    queue.EnQueue(temp.Left);
                if (temp.Right != null)
                    queue.EnQueue(temp.Right);

                if (queue.IsEmpty())
                    temp = null;
                else
                    temp = queue.DeQueue();
            }
        }

        public static void PrintLevel(BinaryTreeNode<T> root, int k)
        {
            if (root != null)
            {
                if (k == 0)
                    System.Console.Write("{0} ", root.Value);
                else
                {
                    PrintLevel(root.Left, k - 1);
                    PrintLevel(root.Right, k - 1);
                }
            }
        }

        public static int GetNodesCountAtLevel(BinaryTreeNode<T> root, int k)
        {
            if (root == null || k < 0)
                return 0;
            else
            {
                if (k == 0)
                    return 1;
                else
                {
                    return GetNodesCountAtLevel(root.Left, k - 1) + GetNodesCountAtLevel(root.Right, k - 1);
                }
            }
        }

        //public void AddNode(NodeType type, T value)
        //{
        //    switch (type)
        //    {
        //        case NodeType.Root:
        //            if (Root==null)
        //                Root = new BinaryTreeNode<T>(value,null,null);
        //            else
        //                Root = new BinaryTreeNode<T>(value, Root.Left, Root.Right);
        //            break;
        //        case NodeType.Left:
        //            break;
        //        case NodeType.Right:
        //            break;
        //        default:
        //            break;
        //    }
        //}

    }
}
