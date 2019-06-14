using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(1);

            Console.WriteLine(stack.Pop());
        }
    }
}
