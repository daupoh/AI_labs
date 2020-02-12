using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CLaw
    {
       public int NetSize { get; private set; }
        public int AntsCount { get; private set; }
        public double PheromoneEvaporation { get; private set; }
        public double DistancePower { get; private set; }
        public double PheromonePower { get; private set; }
        public int Attractive { get; private set; }

        public CLaw(int iNetSize, int iAntsCount)
        {
            if (iNetSize > 0 && iAntsCount > 0)
            {
                NetSize = iNetSize;
                AntsCount = iAntsCount;
            }
            else
            {
                throw new FormatException("Law creation error");
            }
            PheromoneEvaporation = 0.4;
            DistancePower = 1;
            PheromonePower = 2;
            Attractive = 10;
        }

        public void UpdateParameters(double fPheromoneEvaporation, double fDistancePower, double fPheromonePower, int iAttractive) 
        {
            if (IsBetweenZeroOne(fPheromoneEvaporation) && fDistancePower > 0 
                && fPheromonePower>0 && iAttractive>0)
            {
                PheromoneEvaporation = fPheromoneEvaporation;
                DistancePower = fDistancePower;
                PheromonePower = fPheromonePower;
                Attractive = iAttractive;
            }
            else
            {
                throw new FormatException("Law update chances error");
            }
        }       
        private bool IsBetweenZeroOne(double fNumber)
        {
            return (fNumber >= 0.0 && fNumber <= 1.0);
        }
        public bool IsPosInNet(int iPos)
        {
            return (iPos >= 0 && iPos < NetSize);
        }
    }
}
