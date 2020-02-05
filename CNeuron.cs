﻿using NUnit.Framework;
using System;

namespace wf_AI_lab1
{
    class CNeuron
    {        
        
        double m_fPotential;
        string m_sName = "";        
     
        public double Potencial
        {
            get
            {
                return m_fPotential;
            }
            private set
            {               
                m_fPotential = value;
            }
        }
        public double Error { get; set; }
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
            Error = 0;
        }
        public bool Equal(CNeuron rCompared)
        {            
            return rCompared.Potencial == Potencial && rCompared.Name == Name && rCompared.Error == Error;
        }
    }
}
