
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
        public void SimpleNet(int iSensorsCounts, int iResultCounts, int[] aHiddenLevelCounts)
        {
            int[] aLevelNeuronsCount = new int[aHiddenLevelCounts.Length+2];
            aLevelNeuronsCount[0] = iSensorsCounts;
            for (int i = 0; i < aHiddenLevelCounts.Length; i++)
            {
                aLevelNeuronsCount[i + 1] = aHiddenLevelCounts[i];
            }
            aLevelNeuronsCount[aLevelNeuronsCount.Length-1] = iResultCounts;
            try
            {
                m_rNet.Clear();
            }
            catch (AssertionException rExp)
            {
                ErrorLog += rExp.Message+"\r\n";
            }
            m_rNet.SetNeuronCountOnLevel(aLevelNeuronsCount);                            
        }
        public void Learn(double fLearnNormal)
        {
            m_rNet.Learn(fLearnNormal);
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
        public void AddTest(int[] aInputVector, double[] aResultVector)
        {
            m_rNet.AddTestCase(aInputVector, aResultVector);
        }
       

    }
}
