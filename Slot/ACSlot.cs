using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    abstract class ACSlot:IElement,ISlot
    {
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

        public CFrame Parent { get; private set; }

        public string Name { get; protected set; }

        protected ACSlot(InheriteType eInheriteType,DataType eDataType, CFrame rParent)
        {
            TypeOfData = eDataType;
            TypeOfInherite = eInheriteType;
            if (rParent!=null)
            {
                Parent = rParent;
                switch (eInheriteType)
                {
                    case InheriteType.Same:
                        break;
                    case InheriteType.Independent: break;
                    case InheriteType.Unique: break;
                }
            }
        }

    }
}
