using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    static class SCActivationFunction
    {
        static Random m_fRandom = new Random();
        public enum FunctionType
        {
            Sigmoidal
        }
        public static double GetRandom
        {
            get
            {
                return m_fRandom.NextDouble();
            }
        }
        public static FunctionType m_eFunctionType= FunctionType.Sigmoidal;

        public static double GetFunctionValue(double fPotential)
        {
            double fResult = 0;
            switch (m_eFunctionType)
            {
                case FunctionType.Sigmoidal:
                    fResult = 1.0 / (1 + Math.Exp(-fPotential));
                    break;
            }
            return fResult;
        }
        public static double GetReverseFunctionValue(double fPotential)
        {
            double fResult = 0;
            switch (m_eFunctionType)
            {
                case FunctionType.Sigmoidal:
                    fResult = fPotential * (1 - fPotential);
                    break;
            }
            return fResult;
        }

    }
}
