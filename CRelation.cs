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
        public double AboutThisProbability(string sRequest)
        {
            double fProbability = 0.0;
            if (sRequest == Name)
            {
                fProbability = 1.0;
            }
            else
            {
                if (sRequest.ToLower().Contains(Name.ToLower()))
                {
                    fProbability = (Name.Length * 1.0 / sRequest.Length * 1.0);
                }
            }
            return fProbability;
        }
    }
}
