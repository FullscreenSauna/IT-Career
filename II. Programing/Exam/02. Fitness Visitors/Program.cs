using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fitness_Visitors
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfVisitors = Console.ReadLine().Split(',', ' ').Where(x => x != "").ToList();

            string command = Console.ReadLine();

            while (command != "END")
            {
                switch (command)
                {
                    case "Add visitor":
                        listOfVisitors.Add(Console.ReadLine());
                        break;

                    case "Add visitor on position":
                        string visitor = Console.ReadLine();
                        int positionForAddition = int.Parse(Console.ReadLine());

                        listOfVisitors.Insert(positionForAddition, visitor);
                        break;

                    case "Remove visitor on position":
                        int positionForRemoval = int.Parse(Console.ReadLine());

                        listOfVisitors.RemoveAt(positionForRemoval);
                        break;

                    case "Remove last visitor":
                        listOfVisitors.RemoveAt(listOfVisitors.Count - 1);
                        break;

                    case "Remove first visitor":
                        listOfVisitors.RemoveAt(0);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfVisitors));
        }
    }
}
