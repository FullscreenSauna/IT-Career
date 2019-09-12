using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_IPerson
{
    interface IPerson
    {
         string Name { get; set; }
         int Age { get; set; }
    }
}
