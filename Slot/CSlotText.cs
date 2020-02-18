using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1.Slot
{
    class CSlotText: ACSlot
    {
        string m_sText;
        public CSlotText(ACSlot.InheriteType eInheriteType, string sText, CFrame rParent)
            : base(eInheriteType, ACSlot.DataType.TEXT, rParent)
        {
            m_sText = sText;
        }

        public override string Show => throw new NotImplementedException();
    }
}
