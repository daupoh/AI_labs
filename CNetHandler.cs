
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
        public void SimpleNet(int[] aHiddenLevelCounts)
        {
            int[] aLevelNeuronsCount = new int[aHiddenLevelCounts.Length];
            aLevelNeuronsCount[0] = 64;
            for (int i = 0; i < aHiddenLevelCounts.Length; i++)
            {
                aLevelNeuronsCount[i + 1] = aHiddenLevelCounts[i];
            }
            aLevelNeuronsCount[aLevelNeuronsCount.Length] = 6;
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
        public void AddTest(int[] aInputVector, double[] aResultVector)
        {
            m_rNet.AddTestCase(aInputVector, aResultVector);
        }
       

    }
}
