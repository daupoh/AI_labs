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
        double m_fRibAttraction, m_fAlpha, m_fBeta;
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
                    Assert.IsTrue(value > 0, "Значение расстояния между вершинами не может быть меньше или равно 0.");
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
        public int CountOfVertex
        {
            get
            {
                return m_iCountOfVertex;
            }
            private set
            {
                Assert.IsTrue(value > 1);
                m_iCountOfVertex = value;
            }
        }
        public double PheromonePower
        {
            get
            {
                return m_fAlpha;
            }
            set
            {
                Assert.IsTrue(value > 0);
                m_fAlpha = value;
            }
        }
        public double DistancePower
        {
            get
            {
                return m_fBeta;
            }
            set
            {
                Assert.IsTrue(value > 0);
                m_fBeta= value;
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

        public CNet(int iCountOfVertex)
        {
            CountOfVertex = iCountOfVertex;
            m_fRibAttraction = 1;
            m_fAlpha = 1;
            m_fBeta = 1;
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
        public double[] GetAttractiveDestinations(int iFromPosition)
        {
            Assert.IsTrue(iFromPosition >= 0 && iFromPosition < CountOfVertex);
            double[] aAttractiveDestinations = new double[CountOfVertex];
            for (int i = 0; i < CountOfVertex; i++)
            {
                aAttractiveDestinations[i] = Attraction / m_aGraph[iFromPosition][i].Distance;
            }
            return aAttractiveDestinations;
        }
        public double[] GetPheromoneDestinations (int iFromPosition)
        {
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
            double fSumOfPheromones = Attraction / GetPathLength(aPath);
        }
       
        public void SetRibs(double[][] aDistanceMatrix)
        {
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
                    m_aGraph[i][j].Pheromone = 0;
                }
            }
        }
        public double GetPathLength(int[] aPath)
        {
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
    }
}
