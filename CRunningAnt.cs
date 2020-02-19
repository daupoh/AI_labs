using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CRunningAnt
    {
        CLaw m_rLaw;
        CPathGraph m_rGraph;
        int[] m_aTabuList, m_aPath;
        public int StartPos { get; private set; }
        
        public CRunningAnt(CLaw rLaw, int iStartPos,CPathGraph rGraph)
        {
            if (rLaw!=null && rGraph!=null && rLaw.IsPosInNet(iStartPos))
            {
                m_rLaw = rLaw;
                m_rGraph = rGraph;
                StartPos = iStartPos;                
            }
            else
            {
                throw new FormatException();
            }
        }
        public double CyclePath { get { return m_rGraph.GetCyclePathDistance(m_aPath); } }
        public override string ToString()
        {
            string sAnt = "",sPath="{";
            for (int i = 0; i < m_aPath.Length-1; i++)
            {
                sPath += m_aPath[i].ToString() + ",";
            }
            sPath+=m_aPath[m_aPath.Length - 1].ToString() + "}";
            sAnt += String.Format("Муравей двигался по пути {0} длины {1} [{2}]\r\n"
                ,sPath,m_rGraph.GetPathDistance(m_aPath),m_rGraph.GetCyclePathDistance(m_aPath));
            return sAnt;
        }
        public void FirstRun()
        {
            Repath();
            int iNextPosIndex = 1;
            while (IsTabuNotFull())
            {
                int iNextPos = RandomPos();
                m_aPath[iNextPosIndex] = iNextPos;
                m_aTabuList[iNextPos] = 1;
                iNextPosIndex++;
            }
            UpdateNet();
        }
        public void SmartRun()
        {
            Repath();
            int iNextPosIndex = 1;
            while (IsTabuNotFull())
            {
                int iNextPos = SmartPos(m_aPath[iNextPosIndex-1]);
               
                m_aPath[iNextPosIndex] = iNextPos;
                m_aTabuList[iNextPos] = 1;
                iNextPosIndex++;
            }
            UpdateNet();            
        }
        private int RandomPos()
        {
            int iRandomPos = (int)(SCRandom.Random * m_rLaw.NetSize);
            while (IsTabuPos(iRandomPos))
            {
                iRandomPos = (int)(SCRandom.Random * m_rLaw.NetSize);
            }
            return iRandomPos;
        }
        private int SmartPos(int iCurrentPos)
        {
            double[] aChoise = new double[m_rLaw.NetSize];
            double fChoisesSum = 0, fMaxChoise=0;
            int iSmartPos = -1;
            List<double> aRoulette = new List<double>();
            List<int> aRoulettePos = new List<int>();
            for (int i = 0; i < m_rLaw.NetSize; i++)
            {
                if (IsTabuPos(i))
                {
                    aChoise[i] = -1;
                }
                else
                {
                    double fPheromone = Math.Pow(m_rGraph.GetPheromoneOnRib(iCurrentPos, i), m_rLaw.PheromonePower),
                        fDistance = Math.Pow(1 / m_rGraph.GetDistanceOnRib(iCurrentPos, i), m_rLaw.DistancePower);
                    aChoise[i] = fPheromone * fDistance;
                    fChoisesSum += aChoise[i];                   
                }
            }

            for (int i = 0; i < m_rLaw.NetSize; i++)
            {
                if (aChoise[i]!=-1)
                {
                    aChoise[i] = aChoise[i] / fChoisesSum;
                    aRoulette.Add(aChoise[i]);
                    aRoulettePos.Add(i);
                }
               /* if (aChoise[i]>fMaxChoise)
                {
                    fMaxChoise = aChoise[i];
                    iSmartPos = i;
                }*/
            }
            double fRand = SCRandom.Random, fRoulette=0;
            iSmartPos = aRoulettePos[aRoulettePos.Count - 1];
            for (int i = 0; i < aRoulette.Count; i++)
            {
                if (fRoulette>fRand)
                {
                    iSmartPos = aRoulettePos[i];
                    break;
                }
                fRoulette += aRoulette[i];
            }
            return iSmartPos;
        }
         
        private void UpdateNet()
        {
            double fPathLength = m_rGraph.GetPathDistance(m_aPath),
               fPheromone = m_rLaw.Attractive / fPathLength;
            m_rGraph.SetPheromonesOnPath(fPheromone, m_aPath);
        }
        private void Repath()
        {
            m_aTabuList = new int[m_rLaw.NetSize];
            m_aPath = new int[m_rLaw.NetSize];
            for (int i = 0; i < m_rLaw.NetSize; i++)
            {
                m_aTabuList[i] = -1;
                m_aPath[i] = -1;
            }
            m_aTabuList[StartPos] = 1;
            m_aPath[0] = StartPos;
        }
        private bool IsTabuPos(int iPos)
        {
            return m_aTabuList[iPos] == 1;
        } 
        private bool IsTabuNotFull()
        {
            bool bNotFull = false;
            for (int i = 0; i < m_aTabuList.Length; i++)
            {
                if (m_aTabuList[i]==-1)
                {
                    bNotFull = true;
                    break;
                }
            }
            return bNotFull;
        }
    }
}
