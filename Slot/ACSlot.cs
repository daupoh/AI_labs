using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    abstract class ACSlot:IElement,ISlot
    {
        CFrame m_rParent;
        public enum InheriteType
        {
            Same, Unique, Independent
        }
        public enum DataType
        {
            FRAME,ATOM,TEXT,LIST,LISP
        }
        public DataType TypeOfData { get; private set; }
        public InheriteType TypeOfInherite { get; private set; }
        public Func<string> IfAdded { get ; set ; }
        public Func<string> IfDeleted { get; set; }
        public Func<string> IfEdit { get; set; }
        public Func<string> IfNeeded { get; set; }
        public Func<string> IfDefault { get; set; }

        public abstract string Show { get; }

        public CFrame Parent {
            get
            {
                return m_rParent;
            }
            set
            {
                m_rParent = value;
                CFrame rFrameParent = null;
                ISlot rSlot = null;
                if (Parent != null)
                {
                    rFrameParent = Parent.Parent;
                }
                if (rFrameParent != null)
                {
                    rSlot = rFrameParent.FindSlotByName(Name);
                }
                switch (TypeOfInherite)
                {
                    case InheriteType.Same:
                        if (rSlot == null || !Same(rSlot))
                        {
                            throw new FormatException();
                        }
                        break;
                    case InheriteType.Independent:
                        if (rSlot == null || !Independ(rSlot))
                        {
                            throw new FormatException();
                        }
                        break;
                }
            } }

        public string Name { get; protected set; }
        public bool Same(ISlot rSlot)
        {
            bool bSame = rSlot != null && rSlot.TypeOfData == TypeOfData && rSlot.Name == Name
                && rSlot.Show==Show;
            return bSame;
        }
        public bool Independ(ISlot rSlot)
        {
            bool bIndepend = rSlot != null && rSlot.TypeOfData == TypeOfData && rSlot.Name == Name
                && rSlot.Show != Show;
            return bIndepend;
        }

        protected ACSlot(InheriteType eInheriteType,DataType eDataType, string sName)
        {
            TypeOfData = eDataType;
            TypeOfInherite = eInheriteType;
            if (sName!="")
            {
                Name = sName;                
            }
        }
        public abstract string AddData(string sDataText);
        public abstract string EditData(string sDataText);
        public abstract string DeleteData();
        public abstract void DefaultData();

    }
}
