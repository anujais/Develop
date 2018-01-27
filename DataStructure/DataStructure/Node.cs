using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Node<T>
    {
        private T _value;
        private Node<T> _next;

        public Node() { }

        public Node(T val, Node<T> nxt =null)
        {
            _value = val;
            _next = nxt;
        }

        public Node<T> Next { get { return _next; } set { _next = value; } }
        public T Value { get { return _value; } set { _value = value; } }
    }
}
