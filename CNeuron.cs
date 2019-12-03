using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNeuron
    {
        const double MINIMUM_WEIGHT = 0.3;
        struct Connection
        {
            CNeuron rNeuron;
            double fWeight;
            public double ConnectionWeight
            {
                get
                {
                    return Math.Round(fWeight, 5);
                }
            }
            public Connection(CNeuron rNeuron, double fWeight)
            {               
                this.fWeight = fWeight;
                this.rNeuron = rNeuron;
            }
            public CNeuron ConnectedNeuron
            {
                get
                {
                    return rNeuron;
                }
            }
           
            public Connection Learn(double fWeight)
            {
                this.fWeight = fWeight;
                return this;
            }
        }

        double m_fPotential;
        string m_sName = "";
        double[] m_aErrors;
        IList<Connection> m_aDendrites;
        public double Potencial
        {
            get
            {
                return m_fPotential;
            }
        }
        public double Active
        {
            get
            {
                return SCActivationFunction.GetFunctionValue(m_fPotential);
            }
        }
        public string Name
        {
            get
            {
                return m_sName;
            }
        }
        public string NetConnections
        {
            get
            {
                string sConnections = "";
                sConnections += "Нейрон " + Name + " зависит от:\r\n";
                foreach (Connection rDendrit in m_aDendrites)
                {
                    sConnections += rDendrit.ConnectedNeuron.Name + " с весом " + rDendrit.ConnectionWeight.ToString() + "\r\n";
                }
                sConnections += "___________________________";
                return sConnections;
            }
        }
        public CNeuron(string sName)
        {
            Assert.IsTrue(sName.Length > 0);
            this.m_sName = sName;
            m_fPotential = 0;
            m_aDendrites = new List<Connection>();
        }
        public void AddDendrit(CNeuron rNeuron)
        {
            Assert.IsTrue(rNeuron != null);
            m_aDendrites.Add(new Connection(rNeuron, 0));            
        }
        public void RandomizeWeights()
        {
            for (int i = 0; i < m_aDendrites.Count; i++)
            {
                double fRandWeight = SCActivationFunction.GetRandom * MINIMUM_WEIGHT;                
                if (SCActivationFunction.GetRandom>0.5)
                {
                    fRandWeight *= -1;
                }
                m_aDendrites[i]= m_aDendrites[i].Learn(fRandWeight);
                m_aDendrites[i].ConnectedNeuron.RandomizeWeights();
            }
        }
        public void UpdateWeights(double fNewWeight)
        {
            for (int i = 0; i < m_aDendrites.Count; i++)
            {
                fNewWeight = fNewWeight * m_aDendrites[i].ConnectedNeuron.Potencial + m_aDendrites[i].ConnectionWeight;
                m_aDendrites[i] = m_aDendrites[i].Learn(fNewWeight);                
            }
        }

        public void Excite(double fDirectExciting)
        {
            m_fPotential = 0;
            Assert.IsTrue(fDirectExciting >= 0 && fDirectExciting <= 1);            
            for (int i = 0; i < m_aDendrites.Count; i++)
            {
                m_fPotential += m_aDendrites[i].ConnectedNeuron.Potencial * m_aDendrites[i].ConnectionWeight;
            }
            m_fPotential += fDirectExciting;
        }
        public void Cooloff()
        {
            m_fPotential = 0;
        }
      
        public double SynapseWeights(CNeuron rSynapse)
        {
            double fWeight = 0;
            for (int i = 0; i < m_aDendrites.Count; i++)
            {
                if (m_aDendrites[i].ConnectedNeuron.Name == rSynapse.Name)
                {
                    fWeight = m_aDendrites[i].ConnectionWeight;
                    break;
                }
            }
            return fWeight;
        }
        
    }
}
