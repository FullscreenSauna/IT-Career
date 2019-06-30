using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    class CapacityList
    {
        private const int InitialCacity = 2;

        private Pair[] Items { get; set; }
        public int Count { get; set; }

        private int startIndex = 0;
        private int nextIndex = 0;

        public CapacityList(int capacity = InitialCacity)
        {
            Items = new Pair[capacity];
        }

        public Pair SumIntervalPairs()
        {
            Pair endPair = new Pair(0, 0);
            for (int i = 0; i < Items.Length; i++)
            {
                if (!Items[i].IsCombined)
                {
                    endPair.First += Items[i].First;
                    endPair.Last += Items[i].Last;
                }
            }
            return endPair;
        }

        public Pair Sum()
        {
            Pair endPair = new Pair(0, 0);
            for (int i = 0; i < Items.Length - 1; i++)
            {
                if (Items[i].IsCombined)
                {
                    endPair.First += Items[i].First;
                    endPair.Last += Items[i].Last;
                }
            }
            return endPair;
        }

        public void Add(Pair pair)
        {
            if (Count == Items.Length)
            {
                var combinedPair = SumIntervalPairs();

                Items[startIndex] = combinedPair;
                Items[startIndex].IsCombined = true;
                startIndex++;

                for (int i = startIndex; i < Items.Length; i++)
                {
                    Items[i] = null;
                }

                Items[startIndex] = pair;
                Count = startIndex + 1;
                nextIndex = startIndex + 1;
            }
            else
            {
                Items[nextIndex] = pair;
                nextIndex++;
                Count++;
            }
            
        }

        public void PrintCurrentState()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Console.WriteLine(Items[i]);
            }
        }
    }
}
