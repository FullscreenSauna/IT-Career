using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public abstract class Identifiables
    {
        protected Identifiables(List<string> ids)
        {
            Ids = ids;
        }

        protected List<string> Ids { get; }

        public List<string> IdentifyCriminals(string fakeIdSnippet)
        {
            List<string> criminals = new List<string>();

            foreach (var id in Ids)
            {
                if (id.Substring(id.Length - fakeIdSnippet.Length, fakeIdSnippet.Length) == fakeIdSnippet)
                {
                    criminals.Add(id);
                }
            }

            return criminals;
        }
        }
    }
