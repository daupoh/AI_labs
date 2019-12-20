using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CLevel
    {
        IList<CNeuron> m_aNeurons;
        CLevel m_rInputLevel;
        double[][] m_aConnectionWeights;
        bool m_bIsSensorLevel, m_bIsResultLevel;
        string m_sName;
        public int NeuronCount
        {
            get
            {
                return m_aNeurons.Count;
            }
        }        
        public string Name
        {
            get
            {
                return m_sName;
            }
            private set
            {
                Assert.IsTrue(value.Length > 0);
                m_sName = value;
            }
        }  
        public double[] DerivativeVector
        {
            get
            {
                double[] aDerivativeVector = new double[NeuronCount];
                for (int i = 0; i < NeuronCount; i++)
                {
                    aDerivativeVector[i] = m_aNeurons[i].Derivative;
                }
                return aDerivativeVector;
            }
        }
        public double[] ResultVector
        {
            get
            {
                double[] aResultVector=new double[NeuronCount];
                for (int i = 0; i < NeuronCount; i++)
                {
                    aResultVector[i] = m_aNeurons[i].Active;
                }
                return aResultVector;
            }
        }
        public double[] ErrorVector
        {
            get
            {
                double[] aErrorVector = new double[NeuronCount];
                for (int i = 0; i < NeuronCount; i++)
                {
                    aErrorVector[i] = m_aNeurons[i].Error;
                }
                return aErrorVector;
            }
            set
            {
                if (m_bIsResultLevel)
                {
                    Assert.IsTrue(value != null && value.Length == NeuronCount);
                    for (int i = 0; i < NeuronCount; i++)
                    {
                        m_aNeurons[i].Error = value[i];
                    }
                }
                else
                {
                    Assert.IsTrue(false); 
                }
            }
        }
        public CLevel(CLevel rInputLevel, int iNeuronCount, string sLevelName, bool bIsResultLevel)
        {
            m_bIsSensorLevel = (rInputLevel == null);
            m_bIsResultLevel = bIsResultLevel;
            m_rInputLevel = rInputLevel;
            Name = sLevelName;
            Assert.IsTrue(iNeuronCount > 0);
            m_aNeurons = new List<CNeuron>();
            for (int i = 0; i < iNeuronCount; i++)
            {
                m_aNeurons.Add(new CNeuron("Нейрон уровня " + sLevelName + "_#" + i.ToString()));
            }
            if (m_bIsSensorLevel)
            {
                m_aConnectionWeights = null;
            }
            else 
            { 
                m_aConnectionWeights = new double[iNeuronCount][];
                for (int i = 0; i < iNeuronCount; i++)
                {
                    m_aConnectionWeights[i] = new double[rInputLevel.NeuronCount];
                    for (int j = 0; j < rInputLevel.NeuronCount; j++)
                    {
                        m_aConnectionWeights[i][j] = 0;
                    }
                }
            }
        }    
        public void Learning(double fLearningNormal)
        {
            double[] aErrorVector = ErrorVector, aDerivativeVector = DerivativeVector, aResultVector=m_rInputLevel.ResultVector;
            for (int i = 0; i < m_rInputLevel.NeuronCount; i++)
            {
                for (int j = 0; j < NeuronCount; j++)
                {
                    m_aConnectionWeights[j][i] += fLearningNormal * aErrorVector[j] * aDerivativeVector[j] * aResultVector[i];
                }               
            }
        }
        public void UpdateByErrorVector()
        {
            if (!m_bIsResultLevel)
            {
                double[] aErrorVector = ErrorVector;
                for (int i = 0; i < m_rInputLevel.NeuronCount; i++)
                {
                    double fError = 0;
                    for (int j = 0; j < NeuronCount; j++)
                    {
                        fError += m_aConnectionWeights[j][i] * aErrorVector[j];
                    }
                    m_rInputLevel.m_aNeurons[i].Error = fError;
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
        public void RandomizeConnections()
        {
            if (!m_bIsSensorLevel)
            {
                for (int i = 0; i < m_aConnectionWeights.Length; i++)
                {
                    for (int j = 0; j < m_aConnectionWeights[i].Length; j++)
                    {
                        double fRandomWeight = SCActivationFunction.GetRandom * 0.3, fSign = SCActivationFunction.GetRandom;
                        if (fSign > 0.5)
                        {
                            fRandomWeight *= -1;
                        }
                        m_aConnectionWeights[i][j] = fRandomWeight;
                    }
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
        public void Excite(int[] aInputVector)
        {
            if (m_bIsSensorLevel)
            {
                Assert.IsTrue(aInputVector.Length == NeuronCount);
                for (int i = 0; i < NeuronCount; i++)
                {
                    if (aInputVector[i] == 1)
                    {
                        m_aNeurons[i].Excite(1.0);
                    }
                    else
                    {
                        m_aNeurons[i].Cooloff();
                    }
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
        public void GetExcited()
        {
            if (!m_bIsSensorLevel)
            {
                for (int i = 0; i < NeuronCount; i++)
                {
                    double fExcite = 0;
                    for (int j = 0; j < m_aConnectionWeights[i].Length; j++)
                    {
                        fExcite += m_aConnectionWeights[i][j] * m_rInputLevel.m_aNeurons[j].Active;
                    }
                    m_aNeurons[i].Excite(fExcite);
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }    
      
    }
}
