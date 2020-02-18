using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1.Slot
{
    class CSlotFrame: ACSlot
    {
        CFrame m_rFrame;
        public CSlotFrame(ACSlot.InheriteType eInheriteType, CFrame rFrame, CFrame rParent)
            : base(eInheriteType, ACSlot.DataType.FRAME, rParent)
        {
            m_rFrame = rFrame;
        }

        public override string Show => throw new NotImplementedException();
    }
}
