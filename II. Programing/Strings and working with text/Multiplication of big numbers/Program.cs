using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_of_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumInput = Console.ReadLine();
            var bigNum = new List<int>();

            for (int i = 0; i < bigNumInput.Length; i++)
            {
                bigNum.Add((int)char.GetNumericValue(bigNumInput[i]));
            }

            int smallNum = int.Parse(Console.ReadLine());

            var endResult = CalculateEndResult(bigNum, smallNum);

            Console.WriteLine(string.Join("", endResult));
        }

        private static List<int> CalculateEndResult(List<int> bigNum, int smallNum)
        {
            var endResult = new List<int>();
            int additional = 0;

            while (bigNum.Count > 0)
            {
                int result = 0;

                if (bigNum.Count == 1)
                {
                    result = smallNum * bigNum[0] + additional;
                }
                else
                {
                    result = smallNum * bigNum[bigNum.Count - 1] + additional;
                }

                if (result > 9)
                {
                    string newResult = result.ToString();

                    endResult.Add((int)char.GetNumericValue(newResult[1]));
                    additional = (int)char.GetNumericValue(newResult[0]);
                }
                else
                {
                    endResult.Add(result);
                    additional = 0;
                }

                bigNum.RemoveAt(bigNum.Count - 1);
            }

            if (additional > 0)
            {
                endResult.Add(additional);
            }

            endResult.Reverse();
            return endResult;
        }
    }
}
