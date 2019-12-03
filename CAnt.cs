using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CAnt
    {
        readonly CNet m_rNet;
        protected int[] m_aTabu;
        protected int m_iStartVertex,m_iPosition;
        protected static Random m_rRandomiser = new Random();        
       public int StartPos
        {
            get
            {
                return m_iStartVertex;
            }
            set
            {
                Assert.IsTrue(value >= 0 && value < m_rNet.CountOfVertex);
                m_iStartVertex = value;                
            }
        }
       
        public int[] Path
        {
            get
            {
                if (IsPathFinished())
                {
                    return m_aTabu;
                }
                else
                {
                    return null;
                }
            }
        }
        public CAnt(ref CNet rNet)
        {
            Assert.IsTrue(rNet !=null);
            m_rNet = rNet;
            m_aTabu = new int[m_rNet.CountOfVertex];            
            m_iStartVertex = 0;
            m_iPosition = 0;
            m_iStartVertex = (int)Math.Truncate(m_rRandomiser.NextDouble() * m_rNet.CountOfVertex);           
        }
        public void PrepareToRun()
        {
            for (int i = 0; i < m_rNet.CountOfVertex; i++)
            {
                m_aTabu[i] = -1;
            }            
            m_iPosition = 0;
            m_aTabu[0] = StartPos;
            m_iPosition++;            
        }
        public void FirstRun()
        {           
            while (m_iPosition < m_aTabu.Length)
            {
                int iNextPos = m_aTabu[m_iPosition];
                double fRand = m_rRandomiser.NextDouble();
                while (!NotTabu(iNextPos))
                {
                    fRand = m_rRandomiser.NextDouble();
                    iNextPos = (int)Math.Round(fRand * (m_rNet.CountOfVertex - 1));                    
                }
                Console.WriteLine(iNextPos.ToString() + " because of " + fRand);
                m_aTabu[m_iPosition++] = iNextPos;               
            }
        }
        public void Run(double fAlpha, double fBeta)
        {           
            while (m_iPosition < m_aTabu.Length)
            {
                int iCurrentPos = m_aTabu[m_iPosition - 1], iNextPos = -1;
                double[] aPheromones = m_rNet.GetPheromoneDestinations(iCurrentPos),
                             aAttractives = m_rNet.GetAttractiveDestinations(iCurrentPos);
                double aProbability = 0, fSumAttractivePheromones = 0, fMaxProbability = 0;
                for (int i = 0; i < m_rNet.CountOfVertex; i++)
                {
                    if (NotTabu(i))
                    {
                        fSumAttractivePheromones += Math.Pow(aPheromones[i], fAlpha) * Math.Pow(aAttractives[i], fBeta);
                    }
                }

                Console.WriteLine("Sum = " + Math.Round(fSumAttractivePheromones, 6).ToString());
                for (int i = 0; i < m_rNet.CountOfVertex; i++)
                {
                    if (NotTabu(i))
                    {
                        aProbability = Math.Pow(aPheromones[i], fAlpha) * Math.Pow(aAttractives[i], fBeta) / fSumAttractivePheromones;
                        Console.WriteLine("Probability of rib " + iCurrentPos.ToString() + " to " + i.ToString() + " "
                            + Math.Round(aProbability, 4).ToString());

                        if (aProbability > fMaxProbability)
                        {
                            iNextPos = i;
                            fMaxProbability = aProbability;
                            Console.WriteLine("New max probability = " + Math.Round(fMaxProbability, 4).ToString());
                        }
                    }
                }
                Console.WriteLine("_______________");
                m_aTabu[m_iPosition++] = iNextPos;             
            }
        }
        private bool NotTabu(int iPos)
        {
            bool bIsIt = true;
            for (int i = 0; i <= m_iPosition; i++)
            {
                if (m_aTabu[i]==iPos)
                {
                    bIsIt = false;
                    break;
                }
            }
            return bIsIt;
        }
        private bool IsPathFinished()
        {
            bool bIsIt = true;
            int i = 0;
            while (bIsIt && i < m_aTabu.Length)
            {
                bIsIt = bIsIt && m_aTabu[i++] != -1;
            }
            return bIsIt;
        }
    }
}
