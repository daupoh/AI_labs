using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNode:ACGraphElement
    {
        public CNode(string sName)
        {
            if (sName.Length>0)
            {
                Name = sName;
            }
            else
            {
                throw new FormatException();
            }
        }
       
    }
}
