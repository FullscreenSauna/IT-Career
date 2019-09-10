using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfStrings
{
    class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            data = new List<string>();
        }

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("List is empty");
            }

            return data.Last();
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("List is empty");
            }

            string item = data.Last();
            data.RemoveAt(data.Count - 1);
            return item;
        }

        public bool IsEmpty()
        {
            return data.Count <= 0;
        }
    }
}
