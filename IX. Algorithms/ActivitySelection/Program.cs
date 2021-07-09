using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ActivitySelection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use Queue instead of Dictionary
            var activities = new Dictionary<int, int[]>
            {
                {1, new int[2]{1,4} },
                {2, new int[2]{3,5} },
                {3, new int[2]{0,6} },
                {4, new int[2]{5,7} },
                {5, new int[2]{3,8} },
                {6, new int[2]{5,9} },
                {7, new int[2]{6,10} },
                {8, new int[2]{8,11} },
                {9, new int[2]{8,12} },
                {10, new int[2]{2,13} },
                {11, new int[2]{12,14} }
            };

            var selectedActivies = new List<int[]>();

            while (activities.Count != 0)
            {
                var currentActivity = activities.Values.First();

                selectedActivies.Add(currentActivity);

                foreach (var activity in activities)
                {
                    if (currentActivity[1] > activity.Value[0] )
                    {
                        activities.Remove(activity.Key);
                    }
                }
            }

            foreach (var activity in selectedActivies)
            {
                Console.WriteLine($"{activity[0]} -> {activity[1]}");
            }
        }
    }
}
