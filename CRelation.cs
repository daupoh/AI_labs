using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CRelation: ACGraphElement
    {
        public CNode First { get; private set; }
        public CNode Second { get; private set; }        
        public string Pretext { get; private set; }
        public string Show
        {
            get
            {
                return String.Format("{0} {1} {2} {3}",First.Name,Name,Pretext, Second.Name);
            }
        }

        public CRelation(string sName, string sPretext, CNode rFirst, CNode rSecond)
        {
            if (sName.Length > 0 && rFirst!=null && rSecond!=null)
            {
                Name = sName;
                First = rFirst;
                Second = rSecond;
                Pretext = sPretext;
            }
            else
            {
                throw new FormatException();
            }
        }
       
    }
}
