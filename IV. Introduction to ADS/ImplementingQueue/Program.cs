using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
           MyQueue<int> queue = new MyQueue<int>();

           Console.WriteLine(string.Join(", ", queue.ToArray()));
        }
    }
}
