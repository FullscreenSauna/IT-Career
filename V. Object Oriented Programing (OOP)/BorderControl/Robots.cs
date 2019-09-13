using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    class Robots : Identifiables
    {
        private List<string> models;

        public Robots(List<string> ids, List<string> models) 
            : base(ids)
        {
            this.models = models;
        }
    }
}
