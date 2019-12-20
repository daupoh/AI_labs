using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNeuroNet
    {
        IList<CLevel> m_aLevels;
        int m_iHideLevelCount, m_iLevelCount;
        public CNeuroNet(int iHideLevelCount) 
        {
            Assert.IsTrue(iHideLevelCount >= 0);
            m_aLevels = new List<CLevel>();
            m_iHideLevelCount = iHideLevelCount;
            m_iLevelCount = iHideLevelCount + 2;
        }
        public void SetNeuronCountOnLevel(int[] aLevelNeuronNumbers)
        {
            Assert.IsTrue(aLevelNeuronNumbers != null && aLevelNeuronNumbers.Length == m_iLevelCount);
            m_aLevels.Add(new CLevel(null, aLevelNeuronNumbers[0], "Входной слой", false));
            for (int i = 0; i < m_iHideLevelCount; i++)
            {
                m_aLevels.Add(new CLevel(m_aLevels[0], aLevelNeuronNumbers[i + 1], "Скрытый слой #"+(i+1).ToString(), false));
            }
            m_aLevels.Add(new CLevel(m_aLevels[m_iLevelCount-1], aLevelNeuronNumbers[m_iLevelCount - 1], "Выходной слой", true));
            for (int i = 0; i < m_iLevelCount; i++)
            {
                m_aLevels[i].RandomizeConnections();
            }
        }
       
    }
}
