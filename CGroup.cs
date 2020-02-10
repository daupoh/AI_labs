using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CGroup
    {        
        public int GroupSize { get; set; }
        IList<CCombinatoricChromosome> m_aChromosomes;
        public CGroup(int iGroupSize)
        {
            if (iGroupSize>0)
            {
                GroupSize = iGroupSize;
            }
            else
            {
                throw new FormatException();
            }
        }
        private double UpdateGrade(CCombinatoricChromosome rChromosome)
        {
            double fPathDistance = 0;
            int[] aGens = rChromosome.Gens;
            for (int i = 0; i < aGens.Length - 1; i++)
            {
                fPathDistance += aDistancesGraph[aGens[i]][aGens[i + 1]];
            }
            return fPathDistance;
        }

    }
}
