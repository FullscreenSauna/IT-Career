using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var firstNum = new List<int>();
            
            for (int i = 0; i < firstInput.Length; i++)
            {
                firstNum.Add((int)Char.GetNumericValue(firstInput[i]));
            }

            var secondInput = Console.ReadLine();
            var secondNum = new List<int>();

            for (int i = 0; i < secondInput.Length; i++)
            {
                secondNum.Add((int)Char.GetNumericValue(secondInput[i]));
            }

            var endResult = new List<int>();
            bool isBigger = false;

            if (firstNum.Count > secondNum.Count || firstNum.Count == secondNum.Count)
            {
                isBigger = FirstNumLonger(firstNum, secondNum, endResult, isBigger);
            }
            else
            {
                isBigger = SecondNumLonger(firstNum, secondNum, endResult, isBigger);
            }

            if (endResult[endResult.Count -1] == 0)
            {
                endResult.Add(1);
            }

            endResult.Reverse();

            Console.WriteLine(string.Join("",endResult));
        }

        private static bool FirstNumLonger(List<int> firstNum, List<int> secondNum, List<int> endResult, bool isBigger)
        {
            while (firstNum.Count > 0)
            {
                int result = 0;

                if (isBigger)
                {
                    result++;
                }

                isBigger = false;
                int num1 = firstNum[firstNum.Count - 1];

                if (secondNum.Count > 0)
                {
                    int num2 = secondNum[secondNum.Count - 1];
                    result += num1 + num2;
                }
                else
                {
                    result += num1;
                }                

                if (result > 9)
                {
                    isBigger = true;
                    string seperateNums = result.ToString();

                    endResult.Add((int)Char.GetNumericValue(seperateNums[1]));
                }
                else
                {
                    endResult.Add(result);
                }

                firstNum.RemoveAt(firstNum.Count - 1);

                if (secondNum.Count > 0)
                {
                    secondNum.RemoveAt(secondNum.Count - 1);
                }
            }

            return isBigger;
        }

        private static bool SecondNumLonger(List<int> firstNum, List<int> secondNum, List<int> endResult, bool isBigger)
        {
            while (secondNum.Count > 0)
            {
                int result = 0;

                if (isBigger)
                {
                    result++;
                }

                isBigger = false;
                int num1 = secondNum[secondNum.Count - 1];

                if (firstNum.Count > 0)
                {
                    int num2 = firstNum[firstNum.Count - 1];
                    result += num1 + num2;
                }
                else
                {
                    result += num1;
                }

                if (result > 9)
                {
                    isBigger = true;
                    string seperateNums = result.ToString();

                    endResult.Add((int)Char.GetNumericValue(seperateNums[1]));
                }
                else
                {
                    endResult.Add(result);
                }

                secondNum.RemoveAt(secondNum.Count - 1);

                if (firstNum.Count > 0)
                {
                    firstNum.RemoveAt(firstNum.Count - 1);
                }
            }

            return isBigger;
        }


    }
}
