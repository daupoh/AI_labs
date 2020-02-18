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
        public CSlotAtom(ACSlot.InheriteType eInheriteType, Object rObject, string sName)
            :base(eInheriteType, ACSlot.DataType.ATOM, sName)
        {
            m_rAtom = rObject;
        }
        public override string Show 
        {
            get
            {
                DefaultData();
                return String.Format("{0}: {1}\r\n", Name, m_rAtom.ToString());
            }
        }

        public override string AddData(string sDataText)
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                string sResult = "";
            m_rAtom = sDataText;
            if (IfAdded!=null)
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
                m_rAtom = null;
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
            m_rAtom = sDataText;
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
                if (IfDefault!= null && m_rAtom==null)
            {
                m_rAtom = IfDefault.Invoke();
            }
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
