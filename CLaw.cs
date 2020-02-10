using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CLaw
    {
        public  int PopulationSize
        {
            get;
            private set;
        }
        public  int GensCount { get; private set; }
        public  double CrossbreedingChance { get; private set; }
        public  double MutateChance { get; private set; }

        public CLaw(int iPopulationSize, int iGensCount)
        {
            if (iPopulationSize>0 && iGensCount>0)
            {
                PopulationSize = iPopulationSize;
                GensCount = iGensCount;
            }
            else
            {
                throw new FormatException("Law creation error");
            }
            CrossbreedingChance = 0.5;
            MutateChance = 0.1;
        }

        public void UpdateParameters(double fCrossbreedengChance, double fMutateChance) 
        {
            if (IsBetweenZeroOne(fCrossbreedengChance) && IsBetweenZeroOne(fMutateChance))
            {
                CrossbreedingChance = fCrossbreedengChance;
                MutateChance = fMutateChance;
            }
            else
            {
                throw new FormatException("Law update chances error");
            }
        }
        private bool IsBetweenZeroOne(double fNumber)
        {
            return (fNumber > 0.0 && fNumber < 1.0);
        }
    }
}
