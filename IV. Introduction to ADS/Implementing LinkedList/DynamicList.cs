using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_LinkedList
{
    class DynamicList<T>
    {
        internal class Node<T>
        {
            private T value;
            private Node<T> next;

            public T Value { get => value; set => this.value = value; }
            public Node<T> Next { get => next; set => next = value; }

            public Node(T value, Node<T> prevNode)
            {
                Value = value;
                prevNode.Next = this;
            }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node<T> head;
        private Node<T> tail;
        private int count;

        public T this[int index]
        {
            get => this[index];
            set => this[index] = value;
        }

        public DynamicList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        private void RemoveHead()
        {
            head = head.Next;
            count--;
        }

        private void RemoveTail()
        {
            var currNode = head;
            for (int i = 0; i < count; i++)
            {
                if (currNode.Next == tail)
                {
                    tail = currNode;
                    tail.Next = null;
                    count--;
                    return;
                }

                currNode = currNode.Next;
            }
        }

        private void RemoveNode(T value)
        {
            var currNode = head;
            for (int i = 0; i < count - 1; i++)
            {
                if (currNode.Next.Value.Equals(value))
                {
                    currNode.Next = currNode.Next.Next;
                    count--;
                    return;
                }

                currNode = currNode.Next;
            }
        }

        public void Add(T value)
        {
            Node<T> newNode;
            if (head == null)
            {
                newNode = new Node<T>(value);
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode = new Node<T>(value, tail);
                tail = newNode;
            }
            count++;
        }

        public bool Remove(T value)
        {
            if (Contains(value))
            {
                if (head.Value.Equals(value))
                {
                    RemoveHead();
                    return true;
                }
                else if (tail.Value.Equals(value))
                {
                    RemoveTail();
                    return true;
                }
                else
                {
                    RemoveNode(value);
                    return true;
                }
            }

            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                if (index == 0)
                {
                    RemoveHead();
                    return true;
                }

                if (index == count - 1)
                {
                    RemoveTail();
                    return true;
                }

                var currNode = head;
                int currIndex = 1;

                for (int i = 0; i < count - 1; i++)
                {
                    if (currIndex == index)
                    {
                        currNode.Next = currNode.Next.Next;
                        count--;
                        return true;
                    }

                    currIndex++;
                    currNode = currNode.Next;
                }
            }

            return false;
        }

        public int IndexOf(T value)
        {
            if (head.Value.Equals(value))
            {
                return 0;
            }

            if (tail.Value.Equals(value))
            {
                return count - 1;
            }

            var currNode = head.Next;
            int index = 1;
            for (int i = 1; i < count; i++)
            {
                if (currNode.Value.Equals(value))
                {
                    return index;
                }

                index++;
                currNode = currNode.Next;
            }

            return -1;
        }

        public bool Contains(T value)
        {
            if (head.Value.Equals(value))
            {
                return true;
            }

            var currNode = head;

            for (int i = 0; i < count; i++)
            {
                if (currNode.Value.Equals(value))
                {
                    return true;
                }

                currNode = currNode.Next;
            }

            return false;
        }
    }
}
