using System.Collections.Generic;

namespace DataStructure
{
    public class Stack<T>
    {
        private LinkedList<T> _linkList;

        public Stack()
        {
            _linkList = new LinkedList<T>() ;
        }
        public void Push(T data)
        {
            if (_linkList == null)
            {
                _linkList = new LinkedList<T>();
            }
            _linkList.AddToLinkedList(data);
        }

        public T Pop()
        {
            Node<T> node = _linkList.RemoveLast();
            return node.Value;
        }

        public bool IsEmpty()
        {
            return _linkList.Head == null ? true : false;
        }

        public T Peek()
        {
            Node<T> node = _linkList.GetLastElement();
            return node.Value;
        }
    }
}
