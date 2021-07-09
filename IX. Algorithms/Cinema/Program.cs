using System;
using System.Collections.Generic;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            Dictionary<string, int> pairs = new Dictionary<string, int>();

            string pair = string.Empty;


            while ((pair = Console.ReadLine()) != "generate")
            {
                string[] nameAndPosition = pair.Split(" - ");

                pairs[nameAndPosition[0]] = int.Parse(nameAndPosition[1]);
            }
        }

        public void Permute(int index, string[] sequence)
        {
            if (index == sequence.Length)
            {
                Console.WriteLine(string.Join(", ", sequence));
            }
            else
            {
                Permute(index + 1, sequence);

                for (int i = index + 1; i < sequence.Length; i++)
                {
                    
                }
            }
        }

       public void Swap()
       {

       }
    }
}
