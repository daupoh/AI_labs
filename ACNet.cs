using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    abstract class ACNet
    {
        protected IList<CNeuron> m_aInput, m_aOutput;
        protected IList<CNeuron>[] m_aHide;
        protected IList<CTestCase> m_aTestCases;       
        public string AllNet()
        {
            string sNet = "";
            sNet += "Входной уровень: \r\n";            
           foreach(CNeuron rNeuron in m_aInput)
            {
                sNet += rNeuron.NetConnections+ "\r\n";                
            }
            sNet += "-------------------------\r\n";
            for (int i = 0; i < m_aHide.Length; i++)
            {
                sNet += "Внутренний уровень #" + i.ToString() + ": \r\n";
                foreach (CNeuron rNeuron in m_aHide[i])
                {
                    sNet += rNeuron.NetConnections + "\r\n";
                }               
            }
            sNet += "-------------------------\r\n";
            sNet += "Выходной уровень: \r\n";
            foreach (CNeuron rNeuron in m_aOutput)
            {
                sNet += rNeuron.NetConnections+"\r\n";
            }
            sNet += "-------------------------\r\n";
            return sNet;
        }
        public string GetTextResultVector()
        {
            double[] aVectorResult = GetResultVector();
            string sVectorResult = "{";
            for (int i = 0; i < m_aOutput.Count - 1; i++)
            {
                sVectorResult += Math.Round(aVectorResult[i], 5).ToString() + ',';
            }
            int iLast = m_aOutput.Count - 1;
            sVectorResult += Math.Round(aVectorResult[iLast], 5).ToString() + '}';
            return sVectorResult;
        }

        public void Excite(int[] aExcitingVector)
        {
            Assert.IsTrue(aExcitingVector != null && aExcitingVector.Length == m_aInput.Count);
            for (int i = 0; i < aExcitingVector.Length; i++)
            {
                if (aExcitingVector[i] == 1)
                {
                    m_aInput[i].Excite(1.0);
                }
            }
            for (int i = 0; i < m_aHide.Length; i++)
            {
                for (int j = 0; j < m_aHide[i].Count; j++)
                {
                    m_aHide[i][j].Excite(0);
                }
            }
            for (int i = 0; i < m_aOutput.Count; i++)
            {
                m_aOutput[i].Excite(0);
            }
        }

        public void Learning(double fLearningMetric, int iAgeCount)
        {
            Assert.IsTrue(m_aTestCases.Count > 0 && iAgeCount>0 && fLearningMetric>0);
            for (int i = 0; i < iAgeCount; i++)
            {
                foreach (CTestCase rTestCase in m_aTestCases)
                {
                    int[] aInputVector = rTestCase.GetInputVector();
                    Excite(aInputVector);
                    double[] aErrorResultVector = rTestCase.GetErrorVector(GetResultVector());
                    double[][] aErrorHideMatrix = GetHideErrorMatrix(aErrorResultVector);
                    UpdateWeights(aErrorResultVector, aErrorHideMatrix, fLearningMetric);
                }
            }
        }
       
        /***************************** PROTECTED *********************************/
        protected ACNet(int iHideLevelsCount)
        {
            Assert.IsTrue(iHideLevelsCount >= 0);
            m_aHide = new IList<CNeuron>[iHideLevelsCount];
            for (int i = 0; i < iHideLevelsCount; i++)
            {
                m_aHide[i] = new List<CNeuron>();
            }
            m_aInput = new List<CNeuron>();
            m_aOutput = new List<CNeuron>();
            m_aTestCases = new List<CTestCase>();
        }
        protected void InputConnections(int iInputIndex, int[][] aHideConnections,int[] aOutputConnections)
        {
            Assert.IsTrue(iInputIndex >= 0 && iInputIndex < m_aInput.Count);
            Assert.IsTrue(aHideConnections != null && aHideConnections.Length == m_aHide.Length);
            Assert.IsTrue(aOutputConnections != null && aOutputConnections.Length == m_aOutput.Count);
            for (int i = 0; i < aHideConnections.Length; i++)
            {
                Assert.IsTrue(aHideConnections[i].Length == m_aHide[i].Count);
                for (int j = 0; j < aHideConnections[i].Length; j++)
                {
                    Assert.IsTrue(aHideConnections[i][j] == 0 || aHideConnections[i][j] == 1);
                    if (aHideConnections[i][j] == 1)
                    {
                        m_aHide[i][j].AddDendrit(m_aInput[iInputIndex]);
                    }    
                }
            }
            for (int i = 0; i < aOutputConnections.Length; i++)
            {
                Assert.IsTrue(aOutputConnections[i] == 0 || aOutputConnections[i] == 1);
                if (aOutputConnections[i]==1)
                {
                    m_aOutput[i].AddDendrit(m_aInput[iInputIndex]);
                }
            }
        }
        protected void HideConnections(int iHideLevel,int iHideIndex, int[][] aHideConnections, int[] aOutputConnections)
        {
            Assert.IsTrue(iHideLevel >= 0 && iHideLevel < m_aHide.Length);
            Assert.IsTrue(iHideIndex >= 0 && iHideIndex < m_aHide[iHideLevel].Count);
            Assert.IsTrue(aHideConnections != null && aHideConnections.Length == m_aHide.Length);
            Assert.IsTrue(aOutputConnections != null && aOutputConnections.Length == m_aOutput.Count);
            for (int i = 0; i < aHideConnections.Length; i++)
            {
                Assert.IsTrue(aHideConnections[i].Length == m_aHide[i].Count);
                for (int j = 0; j < aHideConnections[i].Length; j++)
                {
                    Assert.IsTrue(aHideConnections[i][j] == 0 || aHideConnections[i][j] == 1);
                    if (aHideConnections[i][j] == 1)
                    {
                        m_aHide[i][j].AddDendrit(m_aHide[iHideLevel][iHideIndex]);
                    }
                }
            }
            for (int i = 0; i < aOutputConnections.Length; i++)
            {
                Assert.IsTrue(aOutputConnections[i] == 0 || aOutputConnections[i] == 1);
                if (aOutputConnections[i] == 1)
                {
                    m_aOutput[i].AddDendrit(m_aHide[iHideLevel][iHideIndex]);
                }
            }
        }     
        protected void AddHideNeuron(int iHideLevel)
        {
            Assert.IsTrue(iHideLevel >= 0 && iHideLevel < m_aHide.Length);
            m_aHide[iHideLevel].Add(new CNeuron("Внутренний нейрон (уровня #" + iHideLevel.ToString() +") #" + (m_aHide[iHideLevel].Count + 1).ToString()));
        }
        protected void AddInputNeuron()
        {
            m_aInput.Add(new CNeuron("Входной нейрон #"+(m_aInput.Count+1).ToString()));
        }
        protected void AddOutputNeuron()
        {
            m_aOutput.Add(new CNeuron("Выходной нейрон #" + (m_aOutput.Count + 1).ToString()));
        }
      

        /******************PRIVATE****************************************/
        private double[] GetResultVector()
        {
            double[] aVectorResult = new double[m_aOutput.Count];            
            for (int i = 0; i < m_aOutput.Count - 1; i++)
            {
                aVectorResult[i] = m_aOutput[i].Active;                
            }
            int iLast = m_aOutput.Count - 1;
            aVectorResult[iLast] = m_aOutput[iLast].Active;
            return aVectorResult;
        }
        private double[][] GetHideErrorMatrix(double[] aErrorResultVector)
        {
            double[][] aHideErrorMatrix = new double[m_aHide.Length][];            
            for (int k = 0; k < m_aHide.Length; k++)
            {
                aHideErrorMatrix[k] = new double[m_aHide[k].Count];
                for (int l = 0; l < m_aHide[k].Count; l++)
                {
                    for (int j = 0; j < m_aOutput.Count; j++)
                    {
                        aHideErrorMatrix[k][l] += m_aOutput[j].SynapseWeights(m_aHide[k][l]) * aErrorResultVector[j];
                    }
                }
            }
            return aHideErrorMatrix;
        }
        private void UpdateWeights(double[] aErrorResultVector, double[][] aErrorHideMatrix, double fLearningMetric)
        {
            double fNewWeights;
            for (int i = 0; i < m_aOutput.Count; i++)
            {
                fNewWeights = fLearningMetric * aErrorResultVector[i] * SCActivationFunction.GetReverseFunctionValue(m_aOutput[i].Active);
                m_aOutput[i].UpdateWeights(fNewWeights);
            }
            for (int i = 0; i < m_aHide.Length; i++)
            {
                for (int j = 0; j < m_aHide[i].Count; j++)
                {
                    fNewWeights = fLearningMetric * aErrorHideMatrix[i][j] * SCActivationFunction.GetReverseFunctionValue(m_aHide[i][j].Active);
                    m_aHide[i][j].UpdateWeights(fNewWeights);
                }
            }
        }

    }
}
