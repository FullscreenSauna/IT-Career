using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            list.ForEach(n => n++);

            List<int> list2 = new List<int>() { 1, 2, 3, 4 };

            list2.ForEach(n => n++);

            Console.WriteLine(string.Join(", ", list2.ToArray()));
        }
    }
}
