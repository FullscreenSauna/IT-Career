using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_DoublyLinkedList
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        internal class Node<T>
        {
            public T Value { get; private set; }
            public Node<T> Next { get; set; }
            public Node<T> Prev { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }

        public int Count { get; private set; }
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public DoublyLinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }


        private void ValidateList()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("List Emmpty");
            }
        }


        public void AddFirst(T value)
        {
            if (Head == null)
            {
                Count++;
                Head = Tail = new Node<T>(value);
            }
            else
            {
                Count++;
                var newHead = new Node<T>(value);
                Head.Prev = newHead;
                newHead.Next = Head;
                Head = newHead;
            }
        }

        public void AddLast(T value)
        {
            if (Head == null)
            {
                Count++;
                Head = Tail = new Node<T>(value);
            }
            else
            {
                Count++;
                var newTail = new Node<T>(value);
                Tail.Next = newTail;
                newTail.Prev = Tail;
                Tail = newTail;
            }
        }

        public void ForEach(Action<T> action)
        {
            var currNode = Head;
            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.Next;
            }
        }

        public void RemoveFirst()
        {
            ValidateList();

            if (Head == Tail)
            {
                Count--;
                Head = Tail = null;
            }

            Count--;
            Head = Head.Next;
            Head.Prev = null;
        }

        public void RemoveLast()
        {
            ValidateList();

            if (Head == Tail)
            {
                Head = Tail = null;
            }

            Count--;
            Tail = Tail.Prev;
            Tail.Next = null;
        }

        public T[] ToArray()
        {
            var arr = new T[Count];
            var currNode = Head;

            for (int i = 0; i < Count; i++)
            {
                arr[i] = currNode.Value;
                currNode = currNode.Next;
            }

            return arr;
        }


        public IEnumerator<T> GetEnumerator()
        {
            var currNode = Head;
            while (currNode != null)
            {
                yield return currNode.Value;
                currNode = currNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
