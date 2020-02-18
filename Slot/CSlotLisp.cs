using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1.Slot
{
    class CSlotLisp:ACSlot
    {
        Func<string> m_rLisp;
        public CSlotLisp(ACSlot.InheriteType eInheriteType, Func<string> rFunc, CFrame rParent)
            : base(eInheriteType, ACSlot.DataType.LISP, rParent)
        {
            m_rLisp = rFunc;

        }

        public override string Show 
        {
            get
            {
                return m_rLisp.Invoke();
            }
        }
    }
}
