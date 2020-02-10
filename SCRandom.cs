using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    static class SCRandom
    {
        static Random m_rRandom = new Random();
        public static double Random
        {
            get
            {
               return m_rRandom.NextDouble();
            }
        }
    }
}
