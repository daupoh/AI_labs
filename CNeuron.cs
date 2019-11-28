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
        const double MINIMUM_WEIGHT = 0.1;
        struct Connection
        {
            CNeuron rNeuron;
            double fWeight;            
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
            public double ConnectionWeight
            {
                get
                {
                    return Math.Round(fWeight,5);
                }
            }
        }

        double m_fPotential;
        string sName = "";
        IList<Connection> m_aDendrites;
        public double Potencial
        {
            get
            {
                return m_fPotential;
            }
        }
        public string Name
        {
            get
            {
                return sName;
            }
        }
        public string ShowConnections()
        {
            string sConnections = "";
            sConnections += "Нейрон " + sName + " зависит от:\r\n";            
            foreach (Connection rDendrit in m_aDendrites)
            {
                sConnections += rDendrit.ConnectedNeuron.Name + " с весом "+rDendrit.ConnectionWeight.ToString()+"\r\n";
            }
            sConnections += "___________________________";
            return sConnections;
        }
        public CNeuron(string sName)
        {
            Assert.IsTrue(sName.Length > 0);
            this.sName = sName;
            m_fPotential = 0;
            m_aDendrites = new List<Connection>();
        }
        public void AddDendrit(CNeuron rNeuron)
        {
            Assert.IsTrue(rNeuron != null);
            m_aDendrites.Add(new Connection(rNeuron, 0));            
        }
    

        public void Excite(double fDirectExciting)
        {
            Assert.IsTrue(fDirectExciting >= 0 && fDirectExciting <= 1);
            foreach(Connection rDendrite in m_aDendrites)
            {
                m_fPotential += rDendrite.ConnectedNeuron.Potencial * rDendrite.ConnectionWeight;
            }
            m_fPotential += fDirectExciting;
            m_fPotential = SCActivationFunction.GetFunctionValue(m_fPotential);
        }
        
    }
}
