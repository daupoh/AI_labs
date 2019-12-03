using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CTestCase
    {
        int m_iSizeOfInputVector,
            m_iSizeOfResultVector;
        int[] m_aInputVector;
        double[] m_aResultVector;
        public CTestCase(int[] aInputVector, int[] aResultVector)
        {
            Assert.IsTrue(aInputVector != null && aResultVector != null);
            Assert.IsTrue(aInputVector.Length >0 && aResultVector.Length >0);
            m_iSizeOfInputVector = aInputVector.Length;
            m_iSizeOfResultVector = aResultVector.Length;
            m_aInputVector = new int[m_iSizeOfInputVector];
            m_aResultVector = new double[m_iSizeOfResultVector];
            for (int i = 0; i < m_iSizeOfInputVector; i++)
            {
                m_aInputVector[i] = aInputVector[i];
            }
            for (int i = 0; i < m_iSizeOfResultVector; i++)
            {
                m_aResultVector[i] = aResultVector[i];
            }
        }     
        public int[] GetInputVector()
        {            
            return m_aInputVector;
        }
        public double[] GetErrorVector(double[] aActualResultVector)
        {
            Assert.IsTrue(aActualResultVector != null);
            Assert.IsTrue(aActualResultVector.Length == m_iSizeOfResultVector);
            double[] aErrorVector = new double[m_iSizeOfResultVector];
            for (int i = 0; i < m_iSizeOfResultVector; i++)
            {
                aErrorVector[i] = m_aResultVector[i] - SCActivationFunction.GetReverseFunctionValue(aActualResultVector[i]);
            }
            return aErrorVector;
        }

    }
}
