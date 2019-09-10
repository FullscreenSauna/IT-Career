using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class RandomList : ArrayList
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public string RandomString()
        {
            int element = random.Next(0, base.Count);
            string str = (string)base[element];
            base.RemoveAt(element);
            return str;
        }
    }
}
