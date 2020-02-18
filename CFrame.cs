using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CFrame:IElement
    {
        public string Name { get; protected set; }
        CFrame m_rParent;
        IList<ISlot> m_aSlots;
        public CFrame(string sName, CFrame rParent)
        {

       
        }
        public ISlot FindSlotByName(string sName)
        {
            ISlot rFindedSlot = null;
            foreach(ISlot rSlot in m_aSlots)
            {
                if (rSlot.Name==sName)
                {
                    rFindedSlot = rSlot;
                    break;
                }
            }
            return rFindedSlot;
        }

       
    }
}
