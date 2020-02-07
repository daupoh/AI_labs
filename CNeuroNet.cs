using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace wf_AI_lab1
{
    class CNeuroNet
    {
        readonly IList<CLevel> m_aLevels;
        readonly IList<CTestCase> m_aTestCases;
        int m_iLevelCount;
        bool m_bNeuronsAdded = false;
        public string State
        {
            get
            {
                string sState = "";
                if (m_bNeuronsAdded)
                {
                    foreach(CLevel rLevel in m_aLevels)
                    {
                        sState += "Уровень "+rLevel.Name+"\r\n";
                        sState += rLevel.State;
                    }
                }
                else
                {
                    sState = "В сеть не были добавлены нейроны.\r\n";
                }
                return sState;

            }

        }
        public CNeuroNet() 
        {            
            m_aLevels = new List<CLevel>();
            m_aTestCases = new List<CTestCase>();       
        }
        public void SetNeuronCountOnLevel(int[] aLevelNeuronsCount)
        {
            Assert.IsTrue(aLevelNeuronsCount != null && aLevelNeuronsCount.Length >1);
            m_iLevelCount = aLevelNeuronsCount.Length;
            int iHideLevelCount = m_iLevelCount - 2;
            m_aLevels.Add(new CLevel(null, aLevelNeuronsCount[0], "Входной слой", false));
            for (int i = 0; i < iHideLevelCount; i++)
            {
                m_aLevels.Add(new CLevel(m_aLevels[i], aLevelNeuronsCount[i + 1], "Скрытый слой #"+(i+1).ToString(), false));
            }
            m_aLevels.Add(new CLevel(m_aLevels[m_aLevels.Count- 1], aLevelNeuronsCount[m_iLevelCount - 1], "Выходной слой", true));
            m_bNeuronsAdded = true;
            for (int i = 1; i < m_iLevelCount; i++)
            {
                m_aLevels[i].SetConnections();
            }
        }      
        public void AddTestCase(int[] aInputVector, double[] aResultVector)
        {
            if (m_bNeuronsAdded)
            {
                Assert.IsTrue(aInputVector.Length == m_aLevels[0].NeuronCount);
                Assert.IsTrue(aResultVector.Length == m_aLevels[m_iLevelCount - 1].NeuronCount);
                m_aTestCases.Add(new CTestCase(aInputVector, aResultVector));
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
        
        public void Learn(int iAgesCount, double fLearnNormal)
        {
            if (m_bNeuronsAdded)
            {
                for (int i = 0; i < iAgesCount; i++)
                {   
                    foreach (CTestCase rTest in m_aTestCases)
                    {
                        m_aLevels[0].Excite(rTest.GetInputVector());
                        LevelsGetExcited();
                        LevelsErrorUpdates(rTest);
                        LevelsLearning(fLearnNormal);
                        LevelsCooloff();
                    }
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
        public double[] GetResult(int[] aInputVector)
        {
            m_aLevels[0].Excite(aInputVector);
            LevelsGetExcited();
            return m_aLevels[m_iLevelCount - 1].ResultVector;
        }
        public void Clear()
        {
            if (m_bNeuronsAdded)
            {
                foreach (CLevel rLevel in m_aLevels)
                {
                    rLevel.Clear();
                }
                m_aLevels.Clear();
                m_iLevelCount = 0;
                m_aTestCases.Clear();
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
        private void LevelsCooloff()
        {
            foreach (CLevel rLevel in m_aLevels)
            {
                rLevel.Cooloff();
            }
        }
        private void LevelsGetExcited()
        {
            for (int j = 1; j < m_iLevelCount; j++)
            {
                m_aLevels[j].GetExcited();
            }
        }
        private void LevelsErrorUpdates(CTestCase rTest)
        {
            double[] aErrorVector = rTest.GetErrorVector(m_aLevels[m_iLevelCount - 1].ResultVector);
            m_aLevels[m_iLevelCount - 1].ErrorVector = aErrorVector;
            for (int k = m_iLevelCount - 2; k > 0; k--)
            {
                m_aLevels[k].UpdateByErrorVector();
            }
        }
        private void LevelsLearning(double fLearnNormal)
        {
            for (int l = 1; l < m_iLevelCount; l++)
            {                
                m_aLevels[l].Learning(fLearnNormal);
            }
        }
       
    }
}
