using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CSemanticGraph
    {
        IList<CNode> m_aNodes;
        IList<CRelation> m_aRelations;
        public CSemanticGraph()
        {
            m_aRelations = new List<CRelation>();
            m_aNodes = new List<CNode>();
        }
        public void AddRelation(string sRelation, string sFirstNode, string sSecondNode)
        {
            CNode rFirst = NodePresent(sFirstNode),
                rSecond = NodePresent(sSecondNode);
            CRelation rAddedRelation = new CRelation(sRelation, rFirst, rSecond);
            m_aRelations.Add(rAddedRelation);

        }
        public void AddNode(string sNodeName)
        {
            if (IsNodeNotAdded(sNodeName))
            {
                CNode rAddedNode = new CNode(sNodeName);
                m_aNodes.Add(rAddedNode);
            }
            else
            {
                throw new FormatException();
            }
            
        }
        private CNode NodePresent(string sNodeName)
        {
            CNode rPresented = null;
            foreach(CNode rNode in m_aNodes)
            {
                if (rNode.Name==sNodeName)
                {
                    rPresented = rNode;
                    break;
                }
            }
            return rPresented;
        }
        private bool IsNodeNotAdded(string sNodeName)
        {
            bool bAdded = false;
            foreach(CNode rNode in m_aNodes)
            {
                if (rNode.Name==sNodeName)
                {
                    bAdded = true;
                    break;
                }
            }
            return bAdded;
        }
        
    }
}
