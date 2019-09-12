using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_IPerson
{
    interface IIdentifiable : IBirthable
    {
        string Id { get; set; }
    }
}
