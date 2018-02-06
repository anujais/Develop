using System.Collections.Generic;

namespace DataStructure
{
    public class BinarySearchTree
    {
        public BinaryTreeNode<int> Root;

        public void AddElement(int data)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode<int>(data, null, null);
            }
            else
            {
                bool found = false;
                BinaryTreeNode<int> parentNode = Root;
                BinaryTreeNode<int> currentNode = Root;
                while (currentNode != null && !found)
                {
                    if (data == currentNode.Value)
                    {
                        found = true;
                    }

                    if (data < currentNode.Value)
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.Left;
                    }
                    else
                    {
                        if (data > currentNode.Value)
                        {
                            parentNode = currentNode;
                            currentNode = currentNode.Right;
                        }
                    }
                }

                if (found)
                {
                    System.Console.WriteLine("Node {0} already exists", data);
                }
                else
                {
                    if (data < parentNode.Value)
                    {
                        parentNode.Left = new BinaryTreeNode<int>(data, null, null);
                    }
                    else
                    {
                        parentNode.Right = new BinaryTreeNode<int>(data, null, null);
                    }
                }
            }
        }

        public bool Contains(int data)
        {
            bool found = false;
            BinaryTreeNode<int> parentNode = Root;
            BinaryTreeNode<int> currentNode = Root;
            while (currentNode != null && !found)
            {
                if (data == currentNode.Value)
                {
                    found = true;
                }

                if (!found)
                {
                    if (data < currentNode.Value)
                        currentNode = currentNode.Left;
                    else
                    {
                        if (data > currentNode.Value)
                            currentNode = currentNode.Right;
                    }
                }
            }
            return found;
        }

        public void DeleteElement(int data)
        {

        }

        public int GetParent(int element)
        {
            return 0;
        }

    }
}
