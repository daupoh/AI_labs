using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CLayer: ILayer
    {        
        readonly ILayer m_rPrevLayer;
        readonly IList<CNeuron> m_aNeurons;
        readonly double[][] m_aConnectionWeigths;
        public int NeuronsCount { get; private set; }
        public string State
        {
            get
            {
                string sState = "Список нейронов:" + "\r\n";
                foreach (CNeuron rNeuron in m_aNeurons)
                {
                    sState += rNeuron.Name + "\r\n";
                }
                sState += "Список входящих связей:" + "\r\n";
                for (int i = 0; i < NeuronsCount; i++)
                {
                    for (int j = 0; j < m_rPrevLayer.NeuronsCount; j++)
                    {
                        sState += String.Format("{0} влияет на {1} с весом {2}\r\n", m_rPrevLayer.GetNeuronByIndex(j).Name,
                            m_aNeurons[i].Name, Math.Round(m_aConnectionWeigths[i][j],3));
                    }
                }
                sState += "----------------------------\r\n";
                return sState;
            }
        }
        public CLayer(int iNeuronsCount, ILayer rPrevLayer,string sLayerName)
        {
            if (iNeuronsCount > 0)
            {
                NeuronsCount = iNeuronsCount;
                m_aNeurons = new List<CNeuron>();
                for (int i = 0; i < NeuronsCount; i++)
                {
                    m_aNeurons.Add(new CNeuron(String.Format("Нейрон слоя {0} #{1}",sLayerName, i)));
                }
                m_rPrevLayer = rPrevLayer;
                     
                m_aConnectionWeigths = new double[NeuronsCount][];
                for (int i = 0; i < NeuronsCount; i++)
                {
                    m_aConnectionWeigths[i] = new double[rPrevLayer.NeuronsCount];
                }
                RandomWeights();
            }
            else
            {
                throw new FormatException();
            }
        }
        public void Excite(double[] aInputVector)
        {
            if (aInputVector.Length == m_rPrevLayer.NeuronsCount)
            {
                double[] aPotencials = new double[NeuronsCount];
                for (int i = 0; i < NeuronsCount; i++)
                {
                    aPotencials[i] = 0;
                    for (int j = 0; j < m_rPrevLayer.NeuronsCount; j++)
                    {
                        aPotencials[i] += m_aConnectionWeigths[i][j] * aInputVector[j];
                    }
                }
                SetPotencials(aPotencials);
            }
            else
            {
                throw new FormatException();
            }

        }       
        public void SetError(double[] aErrorVector)
        {
            if (aErrorVector.Length==NeuronsCount)
            {
                for (int i = 0; i < m_aNeurons.Count; i++)
                {
                    m_aNeurons[i].Error = aErrorVector[i];
                }
            }
            else
            {
                throw new FormatException();
            }
        }
        public void CalculateError(CLayer rNextLayer)
        {
            double[] aErrorVector = new double[NeuronsCount];
            for (int i = 0; i < NeuronsCount; i++)
            {
                aErrorVector[i] = 0;
                for (int j = 0; j < rNextLayer.NeuronsCount; j++)
                {
                    aErrorVector[i] += rNextLayer.m_aNeurons[j].Error * rNextLayer.m_aConnectionWeigths[j][i];
                }
            }
            SetError(aErrorVector);
        }
       public CNeuron GetNeuronByIndex(int i)
        {
            if (i>=0 && i<NeuronsCount)
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
                aResultVector[i] = m_aNeurons[i].Active;
            }

            return aResultVector;
        }
        public void UpdateConnectionWeights(double fEducation)
        {
            double[] aResultVector = m_rPrevLayer.GetResultVector();
            for (int i = 0; i < NeuronsCount; i++)
            {
                for (int j = 0; j < m_rPrevLayer.NeuronsCount; j++)
                {
                    m_aConnectionWeigths[i][j] = m_aConnectionWeigths[i][j] + fEducation * m_aNeurons[i].Error
                        * m_aNeurons[i].Derivative * aResultVector[j];
                }
            }
        }
        private void SetPotencials(double[] aPotencials)
        {
            for (int i = 0; i < NeuronsCount; i++)
            {
                m_aNeurons[i].Excite(aPotencials[i]);
            }
        }
        private void RandomWeights()
        {
            for (int i = 0; i < NeuronsCount; i++)
            {
                for (int J = 0; J < m_rPrevLayer.NeuronsCount; J++)
                {
                    double fWeight = SCActivationFunction.Random * 0.3;
                    double fSign = SCActivationFunction.Random;
                    if (fSign>0.5)
                    {
                        m_aConnectionWeigths[i][J] = fWeight;
                    }
                    else
                    {
                        m_aConnectionWeigths[i][J] = -fWeight;
                    }

                }
            }
        }
    }
}
