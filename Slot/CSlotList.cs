using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1.Slot
{
    class CSlotList: ACSlot
    {
        IList<Object> m_aList;
        public CSlotList(ACSlot.InheriteType eInheriteType, Object[] aSequence, CFrame rParent)
            : base(eInheriteType, ACSlot.DataType.LIST, rParent)
        {
            m_aList = new List<Object>();
            for (int i = 0; i < aSequence.Length; i++)
            {
                m_aList.Add(aSequence[i]);
            }
        }

        public override string Show => throw new NotImplementedException();
    }
}
