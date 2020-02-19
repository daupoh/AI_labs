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
        public CSlotList(ACSlot.InheriteType eInheriteType, Object[] aSequence,string sName)
            : base(eInheriteType, ACSlot.DataType.LIST,  sName)
        {
            m_aList = new List<Object>();
            if (aSequence != null)
            {
                for (int i = 0; i < aSequence.Length; i++)
                {
                    m_aList.Add(aSequence[i]);
                }
            }
        }

        public override string Show
        {
            get
            {
                DefaultData();
                string sList = "{";
                for (int i = 0; i < m_aList.Count-1; i++)
                {
                    sList += m_aList[i].ToString() + ',';
                }
                sList += m_aList[m_aList.Count-1].ToString() + '}';
                return String.Format("{0}: {1}\r\n", Name, sList);
            }
        }
       

        public override string AddData(string sDataText)
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                string sResult = "";
                string[] aElements = sDataText.Split(' ');
                m_aList.Clear();
                for (int i = 0; i < aElements.Length; i++)
                {
                    m_aList.Add(aElements[i]);
                }                
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
                m_aList.Clear();
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
                string[] aElements = sDataText.Split(' ');
                if (aElements.Length == m_aList.Count)
                {
                    m_aList.Clear();
                    for (int i = 0; i < aElements.Length; i++)
                    {
                        m_aList.Add(aElements[i]);
                    }
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
            else
            {
                throw new FormatException();
            }
        }
        public override void DefaultData()
        {
            if (TypeOfInherite != ACSlot.InheriteType.Same)
            {
                if (IfDefault != null && m_aList.Count==0)
                {
                    AddData(IfDefault.Invoke());
                }
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
