
namespace wf_AI_lab1
{
    class CNetHandler
    {
        readonly CNeuroNet m_rNet;

        public CNetHandler()
        {
            m_rNet = new CNeuroNet();
        }
        public void SimpleNet()
        {
            int[] aLevelNeuronsCount = {9,6 };
            m_rNet.SetNeuronCountOnLevel(aLevelNeuronsCount);
            m_rNet.SetConnections(GetConnections());
            AddTests();            

        }
        private bool[][][] GetConnections()
        {
            bool[][][] aConnections = new bool[1][][];            
            aConnections[0] = new bool[6][];
            for (int i = 0; i < aConnections.Length; i++)
            {
                aConnections[0][i] = new bool[9];
            }
            aConnections[0][0] = GetSymbolN();
            aConnections[0][1] = GetSymbolT();
            aConnections[0][2] = GetSymbolP();
            aConnections[0][3] = GetSymbolS();
            aConnections[0][4] = GetSymbolG();
            aConnections[0][5] = GetSymbolO();
            return aConnections;
        }
        private bool[] GetSymbolN()
        {
            bool[] aSym = { true, false, true, 
                            true, true,  true, 
                            true, false, true };
            return aSym;
        }
        private bool[] GetSymbolT()
        {
            bool[] aSym = { true, true, true, 
                            false, true, false, 
                            false, true, false };
            return aSym;
        }
        private bool[] GetSymbolP()
        {
            bool[] aSym = { true, true, true, 
                            true, false, true, 
                            true, false, true };
            return aSym;
        }
        private bool[] GetSymbolS()
        {
            bool[] aSym = { true, true, true,
                            true, false, false,
                            true, true, true };
            return aSym;
        }
        private bool[] GetSymbolG()
        {
            bool[] aSym = { true, true, true,
                            true, false, false,
                            true, false, false };
            return aSym;
        }
        private bool[] GetSymbolO()
        {
            bool[] aSym = { true, true, true,
                            true, false, true,
                            true, true, true };
            return aSym;
        }
        private void AddTests()
        {
            /////////////-------H---------///
            int[] aInputVector = { 1, 0, 1, 1, 1, 1, 1, 0, 1 };
            double[] aResultVector = { 1.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 0, 0, 1, 1, 1, 1, 0, 1 };
            aResultVector = new double[] { 1.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 0, 0, 1, 1, 1, 1, 1, 0, 1 };
            aResultVector = new double[] { 1.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 0, 1, 1, 1, 1, 1, 0, 0 };
            aResultVector = new double[] { 1.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            /////////////-------T---------///
            aInputVector = new int[] { 1, 1, 1, 0, 1, 0, 0, 1, 0 };
            aResultVector = new double[] { 0.0, 1.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 0, 0, 1, 0, 0, 1, 0 };
            aResultVector = new double[] { 0.0, 1.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 0, 1, 1, 0, 1, 0, 0, 1, 0 };
            aResultVector = new double[] { 0.0, 1.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 1, 0, 1, 0, 0, 0, 0 };
            aResultVector = new double[] { 0.0, 1.0, 0.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            /////////////-------П---------///
            aInputVector = new int[] { 1, 1, 1, 1, 0, 1, 1, 0, 1 };
            aResultVector = new double[] { 0.0, 0.0, 1.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 1, 1, 0, 1, 1, 0, 0 };
            aResultVector = new double[] { 0.0, 0.0, 1.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 1, 1, 0, 1, 0, 0, 1 };
            aResultVector = new double[] { 0.0, 0.0, 1.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 1, 1, 0, 1, 0, 0, 0 };
            aResultVector = new double[] { 0.0, 0.0, 1.0, 0.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            /////////////-------С---------///
            aInputVector = new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 1.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 1.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 0, 1, 0, 0, 1, 1, 1 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 1.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 0, 1, 0, 0, 1, 1, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 1.0, 0.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            /////////////-------Г---------///
            aInputVector = new int[] { 1, 1, 1, 1, 0, 0, 1, 0, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 1.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 1.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 0, 1, 0, 0, 1, 0, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 1.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 0, 1, 1, 1, 0, 0, 1, 0, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 1.0, 0.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            /////////////-------О---------///
            aInputVector = new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 1.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 0 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 1.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 0, 1, 0, 1, 1, 1, 1 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 1.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);

            aInputVector = new int[] { 1, 1, 1, 1, 0, 1, 0, 1, 1 };
            aResultVector = new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 1.0 };
            m_rNet.AddTestCase(aInputVector, aResultVector);
        }

    }
}
