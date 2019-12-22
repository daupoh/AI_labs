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
        IList<CConnection> m_aConnections;
        CLevel m_rInputLevel;
       
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
            m_aConnections = new List<CConnection>();
            for (int i = 0; i < iNeuronCount; i++)
            {
                m_aNeurons.Add(new CNeuron("Нейрон уровня " + sLevelName + "_#" + i.ToString()));
            }           
        }
        public void SetConnections(bool[][] aConnections)
        {
            Assert.IsTrue(aConnections!=null && aConnections.Length == NeuronCount);
            for (int i = 0; i < NeuronCount; i++)
            {
                Assert.IsTrue(aConnections[i]!=null && aConnections[i].Length == m_rInputLevel.NeuronCount);
                for (int j = 0; j < m_rInputLevel.NeuronCount; j++)
                {
                    CNeuron rLessLevelNeuron = m_rInputLevel.m_aNeurons[j],
                        rBigerLevelNeuron = m_aNeurons[i];
                    if (aConnections[i][j])
                    {
                        m_aConnections.Add(new CConnection(this, rLessLevelNeuron, rBigerLevelNeuron));
                    }
                }
            }
        }     
        public void Learning(double fLearningNormal)
        {
            for (int i = 0; i < m_aConnections.Count; i++)
            {
                m_aConnections[i].Weight += fLearningNormal * m_aConnections[i].BiggerLevelNeuron.Error *
                    m_aConnections[i].BiggerLevelNeuron.Derivative * m_aConnections[i].LessLevelNeuron.Active;
            }
        }
        public void UpdateByErrorVector()
        {
            if (!m_bIsResultLevel)
            {
                for (int i = 0; i < m_rInputLevel.NeuronCount; i++)
                {
                    CNeuron rLessLevelNeuron = m_rInputLevel.m_aNeurons[i];
                    double fError = 0;                    
                    CConnection[] aOutputConnections = FindOutputConnections(rLessLevelNeuron);
                    foreach (CConnection rConnection in aOutputConnections)
                    {
                        fError += rConnection.Weight * rConnection.BiggerLevelNeuron.Error;
                    }
                    rLessLevelNeuron.Error = fError;
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
                for (int i = 0; i < NeuronCount; i++)
                {
                    if (aInputVector[i]==1)
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
                    double fPotencial = 0;
                    CNeuron rBiggerLevelNeuron = m_aNeurons[i];
                    CConnection[] aInputConnections = FindInputConnections(rBiggerLevelNeuron);
                    foreach(CConnection rConnection in aInputConnections)
                    {
                        fPotencial += rConnection.Weight * rConnection.LessLevelNeuron.Active;
                    }
                    rBiggerLevelNeuron.Excite(fPotencial);
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }       
        private CConnection[] FindInputConnections(CNeuron rBiggerLevelNeuron)
        {
            IList<CConnection> aConnections = new List<CConnection>();
            foreach (CConnection rTempConnection in m_aConnections)
            {
                if (rTempConnection.IsBiggerConnected(rBiggerLevelNeuron))
                {
                    aConnections.Add(rTempConnection);
                }
            }
            return aConnections.ToArray();
        }
        private CConnection[] FindOutputConnections(CNeuron rLessLevelNeuron)
        {
            IList<CConnection> aConnections = new List<CConnection>();
            foreach (CConnection rTempConnection in m_aConnections)
            {
                if (rTempConnection.IsLessConnected(rLessLevelNeuron))
                {
                    aConnections.Add(rTempConnection);
                }
            }
            return aConnections.ToArray();
        }

    }
}
