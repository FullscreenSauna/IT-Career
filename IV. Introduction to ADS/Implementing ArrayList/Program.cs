using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList<int> test = new MyArrayList<int>();

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);

            test.RemoveAt(1);

            test.Add(5);
            Console.WriteLine(test[1]);
        }
    }
}
