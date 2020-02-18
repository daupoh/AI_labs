using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    interface IElement
    {
        string Name { get; }
        CFrame Parent { get; set; }
        string Show { get; }

    }
}
