
using NUnit.Framework;

namespace wf_AI_lab1
{
    class CNetHandler
    {
        readonly CNeuroNet m_rNet;
        public string ErrorLog { get; private set; }
        public CNetHandler()
        {
            m_rNet = new CNeuroNet();
        }
        public void SimpleNet()
        {
            int[] aLevelNeuronsCount = {9,6 };
            try
            {
                m_rNet.Clear();
            }
            catch (AssertionException rExp)
            {
                ErrorLog += rExp.Message+"\r\n";
            }
            m_rNet.SetNeuronCountOnLevel(aLevelNeuronsCount);            
            AddTests();            
        }
        public void Learn(int iAgesCount, double fLearnNormal)
        {
            m_rNet.Learn(iAgesCount,fLearnNormal);
        }
        public double[] GetResult(int[] aInputVector)
        {
            
            return m_rNet.GetResult(aInputVector);
        }
        public string State
        {
            get
            {
                return m_rNet.State;
            }
        }
        
        private void AddTests()
        {
            /////////////------- - ---------///
            int[] aInputVector = { 1, 1, 1, 0, 0, 0, 0, 0, 0 };
            double[] aResultVector = { 1.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            /////////////-------^---------///
            aInputVector = new int[] { 0, 1, 0, 1, 0, 1, 0, 0, 0 };
            aResultVector = new double[] { 0.0, 1.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            /////////////--------_---------///
            aInputVector = new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 1 };
            aResultVector = new double[] { 0.0, 0.0, 1.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            /////////////-------|---------///
            aInputVector = new int[] { 0, 1, 0, 0, 1, 0, 0, 1, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 1.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

          
            /////////////-------/---------///
            aInputVector = new int[] { 0, 0, 1, 0, 1, 0, 1, 0, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 1.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

          
            /////////////-------\---------///
            aInputVector = new int[] { 1, 0, 0, 0, 1, 0, 0, 0, 1 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 1.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

        }

    }
}
