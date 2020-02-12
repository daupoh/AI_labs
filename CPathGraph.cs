using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CPathGraph:IGradeUpdater
    {
        readonly double[][] aDistancesGraph;
        public int VertexCount { get; private set; }
        public CPathGraph(int iVertexCount, double fMaxPathDistance)
        {
            if (iVertexCount > 0 && fMaxPathDistance > 0)
            {
                VertexCount = iVertexCount;
                aDistancesGraph = new double[iVertexCount][];
                for (int i = 0; i < iVertexCount; i++)
                {
                    aDistancesGraph[i] = new double[iVertexCount];
                }
                for (int i = 0; i < iVertexCount; i++)
                {
                    for (int j = i; j < iVertexCount; j++)
                    {
                        if (i != j)
                        {
                            double fDistance = (int)(SCRandom.Random * fMaxPathDistance) +1;
                            aDistancesGraph[i][j] = fDistance;
                            aDistancesGraph[j][i] = fDistance;
                        }
                        else
                        {
                            aDistancesGraph[i][j] = 0;
                        }
                    }
                }
            }
            else
            {
                throw new FormatException();
            }
        }

        public double UpdateGrade(CCombinatoricChromosome rChromosome)
        {
            double fPathDistance = 0;
            int[] aGens = rChromosome.Gens;
            int iLastIndex = aGens.Length - 1;
            for (int i = 0; i < iLastIndex; i++)
            {
                fPathDistance += aDistancesGraph[aGens[i]][aGens[i + 1]];
            }
            fPathDistance += aDistancesGraph[aGens[iLastIndex]][aGens[0]];
            return fPathDistance;
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
                        sGraph += "{"+ Math.Round(aDistancesGraph[i][j],3).ToString()+" ";
                    }
                    else if (j==VertexCount-1)
                    {
                        sGraph += Math.Round(aDistancesGraph[i][j], 3).ToString() + "}";
                    }
                    else
                    {
                        sGraph += Math.Round(aDistancesGraph[i][j],3).ToString()+" ";
                    }
                }
                sGraph += "\r\n";
            }
            sGraph += "}";
            return sGraph;
        }
    }
}
