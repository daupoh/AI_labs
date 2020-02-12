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
        
        public CRunningAnt(CLaw rLaw, int iStartPos,CPathGraph rGraph)
        {
            if (rLaw!=null && rGraph!=null && m_rLaw.IsPosInNet(iStartPos))
            {
                m_rLaw = rLaw;
                m_rGraph = rGraph;
                Repath(iStartPos);
            }
            else
            {
                throw new FormatException();
            }
        }
        public void FirstRun()
        {
            int iNextPosIndex = 1;
            while (IsTabuNotFull())
            {
                int iNextPos = RandomPos();
                m_aPath[iNextPosIndex] = iNextPos;
                m_aTabuList[iNextPos] = 1;
                iNextPosIndex++;
            }
            UpdateNet();
            Repath(m_aPath[0]);
        }
        public void SmartRun()
        {
            int iNextPosIndex = 1;
            while (IsTabuNotFull())
            {
                int iNextPos = SmartPos(m_aPath[iNextPosIndex-1]);
                m_aPath[iNextPosIndex] = iNextPos;
                m_aTabuList[iNextPos] = 1;
                iNextPosIndex++;
            }
            UpdateNet();
            Repath(m_aPath[0]);
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
                }
                if (aChoise[i]>fMaxChoise)
                {
                    fMaxChoise = aChoise[i];
                    iSmartPos = i;
                }
            }
            return iSmartPos;
        }
        private void UpdateNet()
        {
            double fPathLength = m_rGraph.GetPathDistance(m_aPath),
               fPheromone = m_rLaw.Attractive / fPathLength;
            m_rGraph.SetPheromonesOnPath(fPheromone, m_aPath);
        }
        private void Repath(int iStartPos)
        {
            m_aTabuList = new int[m_rLaw.NetSize];
            m_aPath = new int[m_rLaw.NetSize];
            for (int i = 0; i < m_rLaw.NetSize; i++)
            {
                m_aTabuList[i] = -1;
                m_aPath[i] = -1;
            }
            m_aTabuList[iStartPos] = 1;
            m_aPath[0] = iStartPos;
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
