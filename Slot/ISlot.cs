using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static wf_AI_lab1.ACSlot;

namespace wf_AI_lab1
{
    interface ISlot:IElement
    {
        DataType TypeOfData { get; }
        InheriteType TypeOfInherite { get;}
        CFrame Parent { get; }

        Func<string> IfAdded { get; set; }
        Func<string> IfDeleted { get; set; }
        Func<string> IfEdit { get; set; }
        Func<string> IfNeeded{ get; set; }
        Func<string> IfDefault { get; set; }
        string Show { get; }
    }
}
