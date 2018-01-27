using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class BinaryTreeNode<T>
    {
        private T _value;
        private BinaryTreeNode<T> _left;
        private BinaryTreeNode<T> _right;

        public BinaryTreeNode(T val, BinaryTreeNode<T> left = null, BinaryTreeNode<T> right = null)
        {
            _value = val;
            _right = right;
            _left = left;
        }

        public T Value { get { return _value; } set { _value = value; } }
        public BinaryTreeNode<T> Left { get { return _left; } set { _left = value; } }
        public BinaryTreeNode<T> Right { get { return _right; } set { _right = value; } }
    }
}
