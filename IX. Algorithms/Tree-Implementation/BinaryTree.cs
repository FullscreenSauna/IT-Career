using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Implementation
{
    public class BinaryTree<T>
    {
        public BinaryTree(T value, BinaryTree<T> leftNode = null, BinaryTree<T> rightNode = null)
        {
            Value = value;
            LeftNode = leftNode;
            RightNode = rightNode;
        }

        public T Value { get; set; }

        public BinaryTree<T> LeftNode { get; set; }

        public BinaryTree<T> RightNode { get; set; }


        public void PreOrder(Action<T> action)
        {
            PreOrder(this, action);
        }

        private void PreOrder(BinaryTree<T> node, Action<T> action)
        {
            if (node != null)
            {
                action.Invoke(node.Value);
                PreOrder(node.LeftNode, action);
                PreOrder(node.RightNode, action);
            }
        }

        public void InOrder(Action<T> action)
        {
            InOrder(this, action);
        }

        private void InOrder(BinaryTree<T> node, Action<T> action)
        {
            if (node != null)
            {
                InOrder(node.LeftNode, action);
                action.Invoke(node.Value);
                InOrder(node.RightNode, action);
            }
        }

        public void PostOrder(Action<T> action)
        {
            PostOrder(this, action);
        }

        private void PostOrder(BinaryTree<T> node, Action<T> action)
        {
            if (node != null)
            {
                PostOrder(node.LeftNode, action);
                PostOrder(node.RightNode, action);
                action.Invoke(node.Value);
            }
        }
    }
}
