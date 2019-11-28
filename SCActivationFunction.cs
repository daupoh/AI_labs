using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    static class SCActivationFunction
    {
        public enum FunctionType
        {
            Sigmoidal
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

    }
}
