using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNet
    {
        int m_iCountOfVertex;
        double m_fRibAttraction, m_fPheromonePower, m_fDistancePower, m_fEvaporation;
        public struct Rib
        {
            double fDistance;
            double fPheromone;
            public double Distance
            {
                get
                {
                    return fDistance;
                }
                set
                {
                    Assert.IsTrue(value >= 0, "Значение расстояния между вершинами не может быть меньше 0.");
                    fDistance = value;
                }
            }
            public double Pheromone
            {
                get
                {
                    return fPheromone;
                }
                set
                {
                    Assert.IsTrue(value >= 0, "Значение расстояния между вершинами не может быть меньше 0.");
                    fPheromone = value;
                }
            }          
            public Rib(double fDistance, double fFerment)
            {
                this.fDistance = fDistance;
                this.fPheromone = fFerment;
            }
        }

        Rib[][] m_aGraph;
        public double Evaporation
        {
            get
            {
                return m_fEvaporation;
            }
            set
            {
                Assert.IsTrue(value > 0 && value < 1);
                m_fEvaporation = value;
            }
        }
        public int CountOfVertex
        {
            get
            {
                return m_iCountOfVertex;
            }
            set
            {
                Assert.IsTrue(value > 1);
                m_iCountOfVertex = value;
            }
        }
        public double PheromonePower
        {
            get
            {
                return m_fPheromonePower;
            }
            set
            {
                Assert.IsTrue(value > 0);
                m_fPheromonePower = value;
            }
        }
        public double DistancePower
        {
            get
            {
                return m_fDistancePower;
            }
            set
            {
                Assert.IsTrue(value >= 1);
                m_fDistancePower= value;
            }
        }
        public double Attraction
        {
            get
            {
                return m_fRibAttraction;
            }
            set
            {
                Assert.IsTrue(value >= 1);
                m_fRibAttraction = value;
            }
        }

        public CNet()
        {
            m_iCountOfVertex = 2;
            m_fRibAttraction = 1;
            m_fPheromonePower = 1;
            m_fDistancePower = 1;
            m_fEvaporation = 0.5;
        }
        public double[] GetAttractiveDestinations(int iFromPosition)
        {
            Assert.IsTrue(m_aGraph != null);
            Assert.IsTrue(iFromPosition >= 0 && iFromPosition < CountOfVertex);
            double[] aAttractiveDestinations = new double[CountOfVertex];
            for (int i = 0; i < CountOfVertex; i++)
            {
                aAttractiveDestinations[i] = 1.0 / m_aGraph[iFromPosition][i].Distance;
            }

            return aAttractiveDestinations;
        }
        public double[] GetPheromoneDestinations(int iFromPosition)
        {
            Assert.IsTrue(m_aGraph != null);
            Assert.IsTrue(iFromPosition >= 0 && iFromPosition < CountOfVertex);
            double[] aPheromoneDestinations = new double[CountOfVertex];
            for (int i = 0; i < CountOfVertex; i++)
            {
                aPheromoneDestinations[i] = m_aGraph[iFromPosition][i].Pheromone;
            }

            return aPheromoneDestinations;
        }
        
        public void UpdatePheromones (int[] aPath)
        {
            Assert.IsTrue(m_aGraph != null);
            double fSumOfPheromones = Attraction / GetPathLength(aPath);
            for (int i = 0; i < aPath.Length-1; i++)
            {
                m_aGraph[aPath[i]][aPath[i + 1]].Pheromone = fSumOfPheromones + m_aGraph[i][i + 1].Pheromone*(1-Evaporation);
            }
            for (int i = 0; i < CountOfVertex; i++)
            {
                for (int j = 0; j < CountOfVertex; j++)
                {
                    m_aGraph[i][j].Pheromone *= Evaporation;
                }
            }
        }
        public string GetPheromones()
        {
            Assert.IsTrue(m_aGraph != null);
         
            string sPheromoneLog = "";
            for (int i = 0; i < CountOfVertex; i++)
            {
                for (int j = 0; j < CountOfVertex; j++)
                {
                    sPheromoneLog += Math.Round(m_aGraph[i][j].Pheromone, 5).ToString() + " ";
                }
                sPheromoneLog += "\r\n";
            }
            sPheromoneLog += "________________________\r\n";
            return sPheromoneLog;
        }
       
        public void SetRibs(double[][] aDistanceMatrix)
        {
            GeneretaGraph();
            Assert.IsTrue(aDistanceMatrix.Length == CountOfVertex);
            foreach (double[] aRow in aDistanceMatrix)
            {
                Assert.IsTrue(aRow.Length == CountOfVertex);
            }            
            for (int i = 0; i < CountOfVertex; i++)
            {
                for (int j = 0; j < CountOfVertex; j++)
                {
                    m_aGraph[i][j].Distance = aDistanceMatrix[i][j];
                    m_aGraph[i][j].Pheromone = 0.00001;
                }
            }
        }
        public double GetPathLength(int[] aPath)
        {
            Assert.IsTrue(m_aGraph != null);
            CheckPath(aPath);
            double fLength = 0;
            int iStart = aPath[0];
            for (int i = 1; i < aPath.Length; i++)
            {
                fLength += m_aGraph[iStart][aPath[i]].Distance;
                iStart = aPath[i];
            }           
            return fLength;
        }
      
        private void CheckPath(int[] aPath)
        {
            for (int i = 0; i < aPath.Length; i++)
            {
                Assert.IsTrue(aPath[i] >= 0 && aPath[i] < CountOfVertex);
            }
        }
        private void GeneretaGraph()
        {            
            m_aGraph = new Rib[CountOfVertex][];
            for (int i = 0; i < CountOfVertex; i++)
            {
                m_aGraph[i] = new Rib[CountOfVertex];
                for (int j = 0; j < CountOfVertex; j++)
                {
                    m_aGraph[i][j] = new Rib(1, 0);
                }
            }
        }
    }
}
