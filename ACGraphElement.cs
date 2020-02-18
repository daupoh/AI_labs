using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    abstract class ACGraphElement
    {
        public string Name { get; protected set; }
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
                    else if (sRequest.Length > 3 &&
                        Name.ToLower().Contains(sRequest.Remove(sRequest.Length - 1).ToLower()))
                    {
                        fProbability = (sRequest.Length * 1.0 / Name.Length * 1.0) * 0.85;
                    }
                    else if (sRequest.Length > 3 &&
                        Name.ToLower().Contains(sRequest.Remove(sRequest.Length - 2).ToLower()))
                    {
                        fProbability = (sRequest.Length * 1.0 / Name.Length * 1.0) * 0.65;
                    }
            }
            return fProbability;
        }
    }
}
