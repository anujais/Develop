using System.Collections.Generic;

namespace DataStructure
{
    public class LinkedList<T>
    {
        private Node<T> _head;

        public Node<T> Head { get { return _head; } }

        public void AddToLinkedList(T value)
        {
            if (_head == null)
            {
                _head = new Node<T>(value);
            }
            else
            {
                Node<T> temp = _head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Node<T>(value);
            }
        }

        public Node<T> RemoveLast()
        {
            Node<T> lastNode = null;
            if (_head != null)
            {
                if (_head.Next == null)
                {
                    lastNode = _head;
                    _head = null;
                }
                else
                {
                    lastNode = _head;
                    Node<T> cursor = _head.Next;
                    while (cursor.Next != null)
                    {
                        lastNode = cursor;
                        cursor = cursor.Next;
                    }
                    lastNode.Next = null;
                    lastNode = cursor;
                }
            }
            return lastNode;
        }

        public Node<T> GetLastElement()
        {
            Node<T> lastNode = null;
            if (_head != null)
            {
                lastNode = _head;
                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
            }
            return lastNode;
        }

        public Node<T> RemoveFront()
        {
            Node<T> headNode = _head;
            if (_head != null)
            {
                _head = _head.Next;
            }
            return headNode;
        }

        public bool Contains(T element)
        {
            bool found = false;
            Node<T> current = _head;
            while (current != null && !found)
            {
                found = current.Value.Equals(element);
                current = current.Next;
            }
            return found;
        }

        public void DeleteNode(T element)
        {
            if (_head != null)
            {
                if (_head.Value.Equals(element))
                {
                    _head = null;
                }
                else
                {
                    bool found = false;
                    Node<T> preNode = _head;
                    Node<T> currentNode = _head;
                    while (currentNode.Next != null && !found)
                    {
                        found = currentNode.Next.Value.Equals(element);
                        preNode = currentNode;
                        currentNode = currentNode.Next;
                    }
                    if (found)
                    {
                        preNode.Next = currentNode.Next;
                        currentNode = null;
                    }
                }
            }
        }

        public void PrintElement()
        {
            Node<T> temp = _head;
            while (temp != null)
            {
                System.Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}
