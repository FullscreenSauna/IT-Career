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

            queue.Enque(1);
            queue.Enque(1);
            queue.Enque(1);

            queue[0] = 5;

           Console.WriteLine(string.Join(", ", queue.ToArray()));
        }
    }
}
