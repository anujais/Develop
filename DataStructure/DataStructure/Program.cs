using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            //#region Linked List Showcase

            //LinkedList<string> linkedList = new LinkedList<string>();
            //linkedList.AddToLinkedList("A");
            //linkedList.AddToLinkedList("B");
            //linkedList.AddToLinkedList("C");
            //linkedList.AddToLinkedList("D");

            //linkedList.PrintElement();
            //Console.WriteLine(string.Format("Element found: {0}", linkedList.Contains("B")));
            //Console.WriteLine(string.Format("Element found: {0}", linkedList.Contains("E")));
            //linkedList.DeleteNode("C");
            //linkedList.PrintElement(); 

            //#endregion

            //#region Stack Showcase

            //Stack<int> stack = new Stack<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Push: {0}", i + 1);
            //    stack.Push(i + 1);
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("Peek: {0}", stack.Peek());
            //Console.WriteLine("\n");

            //while (!stack.IsEmpty())
            //{
            //    Console.WriteLine("Pop: {0}", stack.Pop());
            //} 
            //#endregion

            //#region Queue Showcase
            //Console.WriteLine("\n");

            //Queue<int> queue = new Queue<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("EnQueue: {0}", i + 1);
            //    queue.EnQueue(i + 1);
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("Front: {0}", queue.GetFront());
            //Console.WriteLine("\n");

            //while (!queue.IsEmpty())
            //{
            //    Console.WriteLine("DeQueue: {0}", queue.DeQueue());
            //} 
            //#endregion

            BinarySearchTree bst = new BinarySearchTree();

            for (int i = 1; i <= 20; i = i + 1)
                bst.AddElement(i);

            Console.WriteLine("\nIn-order traversal");
            BinaryTree<int>.InOrderTraversal(bst.Root);
            Console.WriteLine("\n\nPreorder traversal");
            BinaryTree<int>.PreOrderTraversal(bst.Root);
            Console.WriteLine("\n\nPostorder traversal");
            BinaryTree<int>.PostOrderTraversal(bst.Root);

            Console.WriteLine("\n\nHeight: {0}", BinaryTree<int>.GetHeight(bst.Root));

            Console.ReadLine();
        }
    }
}
