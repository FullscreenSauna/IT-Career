using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizens : Identifiables
    {
        private List<string> names;
        private List<int> ages;

        public Citizens(List<string> ids,List<string> names, List<int> ages) 
            : base(ids)
        {
            this.names = names;
            this.ages = ages;
        }
    }
}
