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
        public CSlotLisp(ACSlot.InheriteType eInheriteType, Func<string> rFunc, string sName)
            : base(eInheriteType, ACSlot.DataType.LISP,  sName)
        {
            m_rLisp = rFunc;

        }

        public override string Show 
        {
            get
            {
                return String.Format("{0}: {1}\r\n", Name, m_rLisp.Invoke()); 
            }
        }

        public override string AddData(string sDataText)
        {
            return "";
        }

        public override string DeleteData()
        {
            return "";
        }

        public override string EditData(string sDataText)
        {
            return "";
        }
        public override void DefaultData()
        {
            
        }
    }
}
