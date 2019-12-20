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
        
        double m_fPotential, m_fError;
        string m_sName = "";        
     
        public double Potencial
        {
            get
            {
                return m_fPotential;
            }
            private set
            {
                Assert.IsTrue(value >= 0 && value <= 1);
                m_fPotential = value;
            }
        }
        public double Error
        {
            get
            {
                return m_fError;
            }
            set
            {
                m_fError = value;
            }
        }        
        public double Derivative
        {
            get
            {
                return SCActivationFunction.GetDerivativeFunctionValue(m_fPotential);
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
            private set
            {
                Assert.IsTrue(value.Length > 0);
                m_sName = value;
            }
        }       
        public CNeuron(string sName)
        {
            Name = sName;
            Potencial = 0;
            Error = 0;
        }                

        public void Excite(double fExcite)
        {
            Potencial = fExcite;
        }
        public void Cooloff()
        {
            Potencial = 0;
        }
        
    }
}
