using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CSolution
    {
        readonly int[] aiSolutionByColsNumber;
        int iEnergy;
        int iMaxLength;
        public int Energy
        {
            get
            {
                return iEnergy;
            }
            private set
            {               
                value.CompareTo(-1).Equals(1);
                iEnergy = value;
            }
        }
        public int MaxLen
        {
            get
            {
                return iMaxLength;
            }
            private set
            {                
                value.CompareTo(0).Equals(1);
                iMaxLength = value;
            }
        }
        public int[] Solution { get { return aiSolutionByColsNumber; }
            private set
            {
                SCValidator.CheckReferenceIsNotNull(value);               
                MaxLen.Equals(value.Length);
                for (int i = 0; i < MaxLen; i++)
                {
                    aiSolutionByColsNumber[i] = value[i];
                }
            }
        }
        public CSolution(int iLen, int iEng)
        {
            Energy = iEng;
            MaxLen = iLen;
            aiSolutionByColsNumber = new int[MaxLen];            
        }
        public CSolution(int[] aiSolutionByCols, int iEng)
        {
            Energy = iEng;
            SCValidator.CheckReferenceIsNotNull(aiSolutionByCols);
            MaxLen = aiSolutionByCols.Length;
            aiSolutionByColsNumber = new int[MaxLen];
            Solution = aiSolutionByCols;
        }
        public void CopySolution(CSolution rSolution)
        {
            MaxLen = rSolution.MaxLen;
            Energy = rSolution.Energy;
            Solution = rSolution.Solution;
        }
    }
}
