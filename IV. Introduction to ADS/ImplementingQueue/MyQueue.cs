using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingQueue
{
    class MyQueue<T>
    {
        internal class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
            }

            public Node(T value, Node<T> prevNode)
            {
                Value = value;
                prevNode.Next = this;
            }
        }

        public int Count { get; protected set; }
        public Node<T> Head { get; protected set; }
        public Node<T> Tail { get; protected set; }

        public MyQueue()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }


        private void ValidateQueue()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Queue Empty");
            }
        }


        public void Enque(T value)
        {
            Node<T> newNode;
            if (Head == null)
            {
                newNode = new Node<T>(value);
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode = new Node<T>(value, Tail);
                Tail = newNode;
            }
            Count++;
        }

        public T Dequeue()
        {
            ValidateQueue();

            T value = default;
            if (Head == Tail)
            {
                Count--;
                value = Head.Value;
                Head = Tail = null;
                return value;
            }

            var currNode = Head;
            for (int i = 0; i < Count - 1; i++)
            {
                if (currNode.Next == Tail)
                {
                    Count--;
                    value = Tail.Value;
                    currNode.Next = null;
                    Tail = currNode;
                    return value;
                }
                currNode = currNode.Next;
            }

            return default;
        }

        public T Peek()
        {
            ValidateQueue();
            return Tail.Value;
        }

        public void Clear()
        {
            var currNode = Head;

            while (Head != null)
            {
                currNode = currNode.Next;
                Head = currNode;
            }

            Tail = Head;
            Count = 0;
        }

        public bool Contains(T value)
        {
            ValidateQueue();

            var currNode = Head;

            for (int i = 0; i < Count; i++)
            {
                if (currNode.Value.Equals(value))
                {
                    return true;
                }
                currNode = currNode.Next;
            }

            return false;
        }

        public T[] ToArray()
        {
            ValidateQueue();

            var arr = new T[Count];
            var currNode = Head;

            for (int i = 0; i < Count; i++)
            {
                arr[i] = currNode.Value;
                currNode = currNode.Next;
            }

            return arr;
        }
    }
}
