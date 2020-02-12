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

        public CLaw(int iNetSize)
        {
            if (iNetSize > 0)
            {
                NetSize = iNetSize;                
            }
            else
            {
                throw new FormatException("Law creation error");
            }
            PheromoneEvaporation = 0.4;
            DistancePower = 1;
            PheromonePower = 2;
            Attractive = 10;
            AntsCount = NetSize;
        }

        public void UpdateParameters(double fPheromoneEvaporation, double fDistancePower,
            double fPheromonePower, int iAttractive, int iAntsCount) 
        {
            if (IsBetweenZeroOne(fPheromoneEvaporation) && iAttractive>0 && iAntsCount > 0)
            {
                PheromoneEvaporation = fPheromoneEvaporation;
                DistancePower = fDistancePower;
                AntsCount = iAntsCount;
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
