using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CRelation
    {
        public CNode First { get; private set; }
        public CNode Second { get; private set; }
        public string Name { get; private set; }

        public CRelation(string sName, CNode rFirst, CNode rSecond)
        {
            if (sName.Length > 0 && rFirst!=null && rSecond!=null)
            {
                Name = sName;
                First = rFirst;
                Second = rSecond;
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
