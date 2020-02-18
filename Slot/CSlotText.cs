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
        public CSlotText(ACSlot.InheriteType eInheriteType, string sText, string sName)
            : base(eInheriteType, ACSlot.DataType.TEXT, sName)
        {
            m_sText = sText;
        }

        public override string Show
        {
            get
            {
                DefaultData();
                return String.Format("{0}: {1}\r\n", Name, m_sText);
            }
        }

        public override string AddData(string sDataText)
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                string sResult = "";
                m_sText = sDataText;
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

        public override string DeleteData()
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                m_sText = null;
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
                string sResult = "";
                m_sText = sDataText;
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
        public override void DefaultData()
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                if (IfDefault != null && m_sText=="")
                {
                    m_sText = IfDefault.Invoke();
                }
            }
            else
            {
                if (Parent.Parent.FindSlotByName(Name).IfDefault != null && m_sText == "")
                {
                    m_sText = Parent.Parent.FindSlotByName(Name).IfDefault.Invoke();
                }
            }
        }
    }
}
