using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CPathGraph
    {
        readonly double[][] m_aDistancesGraph, m_aPheromoneConcentration;
        CLaw m_rLaw;
        public int VertexCount { get; private set; }
        public CPathGraph(CLaw rLaw, double fMAximumDistance)
        {
            if (rLaw!=null && fMAximumDistance>0)
            {
                m_rLaw = rLaw;
                VertexCount = m_rLaw.NetSize;
                m_aDistancesGraph = new double[VertexCount][];
                m_aPheromoneConcentration = new double[VertexCount][];
                for (int i = 0; i < VertexCount; i++)
                {
                    m_aDistancesGraph[i] = new double[VertexCount];
                    m_aPheromoneConcentration[i] = new double[VertexCount];
                }
               /* for (int i = 0; i < VertexCount; i++)
                {
                    for (int j = i; j < VertexCount; j++)
                    {
                        if (i != j)
                        {
                            double fDistance = (int)(SCRandom.Random * fMAximumDistance) + 1;
                            m_aDistancesGraph[i][j] = fDistance;
                            m_aDistancesGraph[j][i] = fDistance;
                        }
                        else
                        {
                            m_aDistancesGraph[i][j] = 0;
                        }
                        m_aPheromoneConcentration[i][j] = 0.1;
                        m_aPheromoneConcentration[j][i] = 0.1;
                    }
                }*/
            }
            else
            {
                throw new FormatException();
            }
            m_aDistancesGraph[0][0] = 0;
            m_aDistancesGraph[0][1] = 27;
            m_aDistancesGraph[0][2] = 26;
            m_aDistancesGraph[0][3] = 19;
            m_aDistancesGraph[0][4] = 21;
            m_aDistancesGraph[0][5] = 22;
            m_aDistancesGraph[0][6] = 10;

            m_aDistancesGraph[1][0] = 29;
            m_aDistancesGraph[1][1] = 0;
            m_aDistancesGraph[1][2] = 8;
            m_aDistancesGraph[1][3] = 10;
            m_aDistancesGraph[1][4] = 10;
            m_aDistancesGraph[1][5] = 10;
            m_aDistancesGraph[1][6] = 17;

            m_aDistancesGraph[2][0] = 26;
            m_aDistancesGraph[2][1] = 10;
            m_aDistancesGraph[2][2] = 0;
            m_aDistancesGraph[2][3] = 7;
            m_aDistancesGraph[2][4] = 7;
            m_aDistancesGraph[2][5] = 8;
            m_aDistancesGraph[2][6] = 11;

            m_aDistancesGraph[3][0] = 21;
            m_aDistancesGraph[3][1] = 10;
            m_aDistancesGraph[3][2] = 9;
            m_aDistancesGraph[3][3] = 0;
            m_aDistancesGraph[3][4] = 1;
            m_aDistancesGraph[3][5] = 1;
            m_aDistancesGraph[3][6] = 10;

            m_aDistancesGraph[4][0] = 21;
            m_aDistancesGraph[4][1] = 12;
            m_aDistancesGraph[4][2] = 9;
            m_aDistancesGraph[4][3] = 1;
            m_aDistancesGraph[4][4] = 0;
            m_aDistancesGraph[4][5] = 1;
            m_aDistancesGraph[4][6] = 9;

            m_aDistancesGraph[5][0] = 22;
            m_aDistancesGraph[5][1] = 12;
            m_aDistancesGraph[5][2] = 8;
            m_aDistancesGraph[5][3] =1;
            m_aDistancesGraph[5][4] = 1;
            m_aDistancesGraph[5][5] = 0;
            m_aDistancesGraph[5][6] = 12;

            m_aDistancesGraph[6][0] = 10;
            m_aDistancesGraph[6][1] = 19;
            m_aDistancesGraph[6][2] = 13;
            m_aDistancesGraph[6][3] = 12;
            m_aDistancesGraph[6][4] = 9;
            m_aDistancesGraph[6][5] = 12;
            m_aDistancesGraph[6][6] = 0;
        }
        public void FlushPheromone()
        {
            for (int i = 0; i < VertexCount; i++)
            {
                for (int j = 0; j < VertexCount; j++)
                {
                    m_aPheromoneConcentration[i][j] = 0.1;
                }
            }
        }
        public void SetPheromonesOnPath(double fPheromone, int[] aPath)
        {
            int iLastIndex = aPath.Length - 1;
            for (int i = 0; i < iLastIndex; i++)
            {
                m_aPheromoneConcentration[aPath[i]][aPath[i + 1]] = fPheromone
                    + m_aPheromoneConcentration[aPath[i]][aPath[i + 1]] * (1-m_rLaw.PheromoneEvaporation);
            }           
        }
        public void Evaporation()
        {
            for (int i = 0; i < m_rLaw.NetSize; i++)
            {
                for (int j = 0; j < m_rLaw.NetSize; j++)
                {
                    m_aPheromoneConcentration[i][j] *= m_rLaw.PheromoneEvaporation;
                }
            }
        }
        public double GetPheromoneOnRib(int iStartPos, int iFinishPos)
        {
            if (m_rLaw.IsPosInNet(iStartPos) && m_rLaw.IsPosInNet(iFinishPos))
            {
                return m_aPheromoneConcentration[iStartPos][iFinishPos];
            }
            else
            {
                throw new FormatException();
            }
        }
        public double GetDistanceOnRib(int iStartPos, int iFinishPos)
        {
            if (m_rLaw.IsPosInNet(iStartPos) && m_rLaw.IsPosInNet(iFinishPos))
            {
                return m_aDistancesGraph[iStartPos][iFinishPos];
            }
            else
            {
                throw new FormatException();
            }
        }
        public double GetPathDistance(int[] aPath)
        {
            int iLastIndex = aPath.Length - 1;
            double fSum = 0;
            for (int i = 0; i < iLastIndex; i++)
            {
                fSum+= m_aDistancesGraph[aPath[i]][aPath[i + 1]];
            }
            return fSum;
        }
        public double GetCyclePathDistance(int[] aPath)
        {
            double fLength = GetPathDistance(aPath);
            int iLastIndex = aPath.Length - 1;
            fLength+= m_aDistancesGraph[aPath[iLastIndex]][aPath[0]];
            return fLength;
        }

        public override string ToString()
        {
            string sGraph = "{\r\n";
            for (int i = 0; i < VertexCount; i++)
            {
                for (int j = 0; j < VertexCount; j++)
                {
                    if (j==0)
                    {
                        sGraph += "{"+ Math.Round(m_aDistancesGraph[i][j],3).ToString()+" ";
                    }
                    else if (j==VertexCount-1)
                    {
                        sGraph += Math.Round(m_aDistancesGraph[i][j], 3).ToString() + "}";
                    }
                    else
                    {
                        sGraph += Math.Round(m_aDistancesGraph[i][j],3).ToString()+" ";
                    }
                }
                sGraph += "\r\n";
            }
            sGraph += "}";
            return sGraph;
        }
    }
}
