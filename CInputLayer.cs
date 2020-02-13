using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CInputLayer: ILayer
    {        
        readonly IList<CNeuron> m_aNeurons;     
        public int NeuronsCount { get; private set; }
        public CInputLayer(int iNeuronsCount)
        {
            if (iNeuronsCount > 0)
            {
                NeuronsCount = iNeuronsCount;
                m_aNeurons = new List<CNeuron>();
                for (int i = 0; i < NeuronsCount; i++)
                {
                    m_aNeurons.Add(new CNeuron(String.Format("Нейрон Входного слоя #{0}", i)));
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
                string sState = "Список нейронов:" + "\r\n";
                foreach (CNeuron rNeuron in m_aNeurons)
                {
                    sState += rNeuron.Name + "\r\n";
                }                
                sState += "----------------------------\r\n";
                return sState;
            }
        }
        public void Excite(double[] aInputVector)
        {
            if (aInputVector.Length == NeuronsCount)
            {
                for (int i = 0; i < NeuronsCount; i++)
                {
                    m_aNeurons[i].Excite(aInputVector[i]);
                }
            }
            else
            {
                throw new FormatException();
            }

        }
        public CNeuron GetNeuronByIndex(int i)
        {
            if (i >= 0 && i < NeuronsCount)
            {
                return m_aNeurons[i];
            }
            else
            {
                throw new FormatException();
            }
        }
        public double[] GetResultVector()
        {
            double[] aResultVector = new double[NeuronsCount];

            for (int i = 0; i < NeuronsCount; i++)
            {
                aResultVector[i] = m_aNeurons[i].Potencial;
            }

            return aResultVector;
        }
    }
}
