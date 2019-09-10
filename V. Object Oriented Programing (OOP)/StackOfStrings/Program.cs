using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            Console.WriteLine(stack.IsEmpty());

            stack.Push("Gosho");
            stack.Push("Pesho");
            stack.Push("Tosho");
            stack.Push("Sasho");

            Console.WriteLine(stack.IsEmpty());

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }
    }
}
