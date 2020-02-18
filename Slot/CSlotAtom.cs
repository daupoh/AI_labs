using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1.Slot
{
    class CSlotAtom : ACSlot
    {
        Object m_rAtom;
        public CSlotAtom(ACSlot.InheriteType eInheriteType, Object rObject, CFrame rParent)
            :base(eInheriteType, ACSlot.DataType.ATOM, rParent)
        {
            m_rAtom = rObject;
        }
        public override string Show 
        { 
            get 
            {
                return m_rAtom.ToString(); ;
            }
        }
    }
}
