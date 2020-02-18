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
        public CSlotFrame(ACSlot.InheriteType eInheriteType, CFrame rFrame, string sName)
            : base(eInheriteType, ACSlot.DataType.FRAME,  sName)
        {
            if (rFrame ==null || rFrame != null && Parent.Net.FindFrameByName(rFrame.Name)!=null)
            {
                m_rFrame = rFrame;
            }           
            else
            {
                throw new FormatException();
            }            
        }

        public override string Show {
            get
            {
                DefaultData();
                return String.Format("{0}: {1}\r\n", Name, m_rFrame.Show);
            }
        }

        public override string AddData(string sDataText)
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                CFrame rFrame = Parent.Net.FindFrameByName(sDataText);
                if (rFrame != null)
                {
                    m_rFrame = rFrame;
                }
                else
                {
                    throw new FormatException();
                }
                string sResult = "";
                if (IfAdded != null)
                {
                    sResult = IfAdded.Invoke();
                }
                return sResult;
            }
            else
            {
                throw new FormatException();
            }
        }

        public override void DefaultData()
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                if (IfDefault != null && m_rFrame==null)
            {
                AddData(IfDefault.Invoke());
            }
            }
            else
            {
                throw new FormatException();
            }
        }

        public override string DeleteData()
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                m_rFrame = null;
            string sResult = "";            
            if (IfDeleted != null)
            {
                sResult = IfDeleted.Invoke();
            }
            return sResult;
            }
            else
            {
                throw new FormatException();
            }
        }

        public override string EditData(string sDataText)
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                CFrame rFrame = Parent.Net.FindFrameByName(sDataText);
                if (rFrame != null)
                {
                    m_rFrame = rFrame;
                }
                else
                {
                    throw new FormatException();
                }
                string sResult = "";
                if (IfEdit != null)
                {
                    sResult = IfEdit.Invoke();
                }
                return sResult;
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
