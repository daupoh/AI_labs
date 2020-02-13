using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNet
    {
        readonly CInputLayer m_rInputLevel;
        readonly IList<CLayer> m_aLayers;
        readonly IList<CTestCase> m_aTestCases;
        public CNet(int[] aLayerNeuronsCount)
        {
            if (IsNeuronsCountCorrect(aLayerNeuronsCount))
            {
                m_aTestCases = new List<CTestCase>();
                m_aLayers = new List<CLayer>();
                m_rInputLevel = new CInputLayer(aLayerNeuronsCount[0]);
                m_aLayers.Add(new CLayer(aLayerNeuronsCount[1], m_rInputLevel,"Слой №1"));
                for (int i = 2; i < aLayerNeuronsCount.Length; i++)
                {
                    m_aLayers.Add(new CLayer(aLayerNeuronsCount[i], m_aLayers[i-2],String.Format("Слой №{0}",i)));
                }
            }
            else
            {
                throw new FormatException();
            }
        }
        public string State
        {
            get
            {
                string sState = "";
                sState += m_rInputLevel.State;
                foreach (CLayer rLayer in m_aLayers)
                    {                        
                        sState += rLayer.State;
                    }
                
                return sState;

            }

        }
        public double[] Analyse(double[] aInputVector)
        {   
            m_rInputLevel.Excite(aInputVector);
            double[] aIntermediateResult = m_rInputLevel.GetResultVector();
            for (int i = 0; i < m_aLayers.Count; i++)
            {
                m_aLayers[i].Excite(aIntermediateResult);
                aIntermediateResult = m_aLayers[i].GetResultVector();
            }         
            return aIntermediateResult;
        }
        public void AddTest(CTestCase rTest)
        {
            if (rTest!=null && rTest.InputVectorSize==m_rInputLevel.NeuronsCount && 
                rTest.ResultVectorSize==m_aLayers[m_aLayers.Count-1].NeuronsCount)
            {
                m_aTestCases.Add(rTest);
            }
            else
            {
                throw new FormatException();
            }
        }
        public void LearnAge(double fEducation)
        {
            for (int i = 0; i < m_aTestCases.Count; i++)
            {
                double[] aActualResultVector = Analyse(m_aTestCases[i].GetInputVector()),
                    aErrorVector = m_aTestCases[i].GetErrorVector(aActualResultVector);
                int iLastLayerIndex = m_aLayers.Count - 1;
                m_aLayers[iLastLayerIndex].SetError(aErrorVector);
                for (int j = iLastLayerIndex-1; j >= 0; j--)
                {
                    m_aLayers[j].CalculateError(m_aLayers[j + 1]);
                }
                for (int j = iLastLayerIndex; j >= 0; j--)
                {
                    m_aLayers[j].UpdateConnectionWeights(fEducation);
                }
            }
        }
        
        private bool IsNeuronsCountCorrect(int[] aLayerNeuronsCount)
        {
            bool bCorrect = aLayerNeuronsCount!=null && aLayerNeuronsCount.Length>1;
            if (bCorrect)
            {
                for (int i = 0; i < aLayerNeuronsCount.Length; i++)
                {
                    if (aLayerNeuronsCount[i] <= 0)
                    {
                        bCorrect = false;
                        break;
                    }
                }
            }
            return bCorrect;
        }
    }
}
