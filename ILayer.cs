﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    interface ILayer
    {
        int NeuronsCount { get; }
        void Excite(double[] aInputVector);
        double[] GetResultVector();
        CNeuron GetNeuronByIndex(int i);
    }
}
