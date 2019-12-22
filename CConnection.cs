using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CConnection
    {
        CNeuron m_rLessLevelNeuron, m_rBiggerLevelNeuron;
        double m_fConnectionWeight=0.0;
        CLevel m_rParentLevel;
        public CNeuron LessLevelNeuron
        {
            get
            {
                return m_rLessLevelNeuron;
            }
        }
        public CNeuron BiggerLevelNeuron
        {
            get
            {
                return m_rBiggerLevelNeuron;
            }
        }
        public double Weight
        {
            get
            {
                return m_fConnectionWeight;
            }
            set
            {
                m_fConnectionWeight = value;
            }
        }
        public CLevel Level
        {
            get
            {
                return m_rParentLevel;
            }
        }
        public CConnection(CLevel rParentLevel,CNeuron rLessLevelNeuron,CNeuron rBiggerLevelNeuron)
        {
            Assert.IsTrue(rParentLevel != null && rLessLevelNeuron != null
                && rBiggerLevelNeuron != null && rLessLevelNeuron != rBiggerLevelNeuron);
            double fRandomWeight = SCActivationFunction.GetRandom * 0.3,
                fSign = SCActivationFunction.GetRandom;
            if (fSign > 0.5)
            {
                fRandomWeight *= -1;
            }
            m_fConnectionWeight = fRandomWeight;
            m_rParentLevel = rParentLevel;
            m_rLessLevelNeuron = rLessLevelNeuron;
            m_rBiggerLevelNeuron = rBiggerLevelNeuron;
        }
        public bool IsBothConnected(CNeuron rLessLevelNeuron, CNeuron rBiggerLevelNeuron)
        {
            return m_rLessLevelNeuron.Equal(rLessLevelNeuron) && m_rBiggerLevelNeuron.Equal(rBiggerLevelNeuron);
        }
        public bool IsBiggerConnected(CNeuron rBiggerLevelNeuron)
        {
            return m_rBiggerLevelNeuron.Equal(rBiggerLevelNeuron);
        }
        public bool IsLessConnected(CNeuron rLessLevelNeuron)
        {
            return m_rLessLevelNeuron.Equal(rLessLevelNeuron);
        }
    }
}
