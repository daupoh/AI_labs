using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNode
    {
        public string Name { get; private set; }

        public CNode(string sName)
        {
            if (sName.Length>0)
            {
                Name = sName;
            }
            else
            {
                throw new FormatException();
            }
        }
        public double AboutThisProbability(string sRequest)
        {
            double fProbability = 0.0;
            if (sRequest==Name)
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
