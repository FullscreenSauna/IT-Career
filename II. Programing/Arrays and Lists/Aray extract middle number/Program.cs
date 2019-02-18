using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aray_extract_middle_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();

            int lenght = inputArr.Length;

            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;

            if (lenght == 1)
            {
                firstNumber = inputArr[0];

                Console.WriteLine($"{firstNumber}");
            }
            else if (lenght % 2 == 0)
            {
                firstNumber = inputArr[lenght / 2 - 1];
                secondNumber = inputArr[lenght / 2];

                Console.WriteLine($"{firstNumber}, {secondNumber}");
            }
            else
            {
                firstNumber = inputArr[lenght / 2 - 1];
                secondNumber = inputArr[lenght / 2];
                thirdNumber = inputArr[lenght / 2 + 1];

                Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber}");
            }          
        }
    }
}
