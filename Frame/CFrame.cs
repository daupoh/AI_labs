using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_AI_lab1.Frame;

namespace wf_AI_lab1
{
    class CFrame:IElement
    {
        public string Name { get; protected set; }
        public CFrame Parent { get; set; }
        public CFrameNet Net { get; private set; }
        IList<ISlot> m_aSlots;
        public CFrame(string sName, CFrame rParent,CFrameNet rFrameNet)
        {
            if (sName!="" && rFrameNet!=null)
            {
                Name = sName;
                Net = rFrameNet;
            }
            else
            {
                throw new FormatException();
            }
            Parent = rParent;
            m_aSlots = new List<ISlot>();
        }
        public string Show
        {
            get
            {
                string sResult = "";
                for (int i = 0; i < m_aSlots.Count; i++)
                {
                    sResult += m_aSlots[i].Show;
                }
                return String.Format("{0}:\r\n {1}\r\n", Name, sResult);
            }
        }
        public void AddSlot(ISlot rSlot)
        {
            if (rSlot!=null && NotUsedSlotName(rSlot.Name))
            {
                m_aSlots.Add(rSlot);
                rSlot.Parent=this;
            }
            else
            {
                throw new FormatException();
            }
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
        public bool NotUsedSlotName(string sName)
        {
            bool bNotUsed = true;
            foreach(ISlot rSlot in m_aSlots)
            {
                if (rSlot.Name==sName)
                {
                    bNotUsed = false;
                    break;
                }
            }
            return bNotUsed;
        }
        public string[] AllSlotNames()
        {
            IList<string> aSlotNames = new List<string>();
            for (int i = 0; i < m_aSlots.Count; i++)
            {
                aSlotNames.Add(m_aSlots[i].Name);
            }
            return aSlotNames.ToArray();
        }
       
    }
}
