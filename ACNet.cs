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
        }
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
        public void ErrorAnalys()
        {
            double[] aVectorResult = GetResultVector();

        }
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

    }
}
