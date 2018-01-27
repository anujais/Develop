using System.Collections.Generic;

namespace DataStructure
{
    public class Queue<T>
    {
        private LinkedList<T> _linkList;

        public Queue()
        {
            _linkList = new LinkedList<T>() ;
        }
        public void EnQueue(T data)
        {
            if (_linkList == null)
            {
                _linkList = new LinkedList<T>();
            }
            _linkList.AddToLinkedList(data);
        }

        public T DeQueue()
        {
            Node<T> node = _linkList.RemoveFront();
            return node.Value;
        }

        public bool IsEmpty()
        {
            return _linkList.Head == null ? true : false;
        }

        public T GetFront()
        {
            Node<T> node = _linkList.Head;
            return node.Value;
        }
    }
}
