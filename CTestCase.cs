using NUnit.Framework;

namespace wf_AI_lab1
{
    class CTestCase
    {           
        readonly double[] m_aResultVector, m_aInputVector;

        public int InputVectorSize { get { return m_aInputVector.Length; } }
        public int ResultVectorSize { get { return m_aResultVector.Length; } }
        public CTestCase(double[] aInputVector, double[] aResultVector)
        {
            Assert.IsTrue(aInputVector != null && aResultVector != null);
            Assert.IsTrue(aInputVector.Length >0 && aResultVector.Length >0);
            
            m_aInputVector = aInputVector;
            m_aResultVector = aResultVector;
        }     
        public double[] GetInputVector()
        {            
            return m_aInputVector;
        }
        public double[] GetErrorVector(double[] aActualResultVector)
        {
            Assert.IsTrue(aActualResultVector != null);
            Assert.IsTrue(aActualResultVector.Length == ResultVectorSize);
            double[] aErrorVector = new double[ResultVectorSize];
            for (int i = 0; i < ResultVectorSize; i++)
            {
                aErrorVector[i] = m_aResultVector[i] - SCActivationFunction.GetDerivativeFunctionValue(aActualResultVector[i]);
            }
            return aErrorVector;
        }

    }
}
