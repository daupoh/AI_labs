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
        public void AddRelation(string sRelation,string sPretext, string sFirstNode, string sSecondNode)
        {
            CNode rFirst = NodePresent(sFirstNode),
                rSecond = NodePresent(sSecondNode);
            CRelation rAddedRelation = new CRelation(sRelation, sPretext, rFirst, rSecond);
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
        public string[] SuitableNodes(string[] aText)
        {
            IList<string> aSuitable = new List<string>();
            for (int i = 0; i < aText.Length; i++)
            {
                if (aText[i].Length > 0)
                {
                    foreach (CNode rNode in m_aNodes)
                    {
                        if (rNode.AboutThisProbability(aText[i]) > 0.65)
                        {
                            aSuitable.Add(rNode.Name);
                            break;
                        }
                    }
                }
            }
            return aSuitable.ToArray();
        }
        public string FindSemanticFragment(string[] aNodes, string[] aRelation)
        {
            string sAnswer = "";
            if (aRelation.Length==0)
            {
                if (aNodes.Length==1)
                {
                    sAnswer = FindAllAboutNode(aNodes[0]);
                }
                else
                {
                    sAnswer = FindRelationBetween(aNodes[0], aNodes[1]);
                }
            }
            else
            {
                if (aNodes.Length==0)
                {
                    sAnswer = FindAllAboutRelation(aRelation[0]);
                }
                else if (aNodes.Length==1)
                {
                    sAnswer = FindUncompleteRelation(aNodes[0], aRelation[0]);
                }
                else
                {
                    sAnswer = FindCompleteRelation(aNodes[0], aNodes[1], aRelation[0]);
                    sAnswer += FindCompleteRelation(aNodes[1], aNodes[0], aRelation[0]);
                }
            }
            return sAnswer;
        }
        private string FindAllAboutNode(string sNodeName)
        {
            string sAnswer = "";
            foreach (CNode rNode in m_aNodes)
            {
                if (rNode.Name==sNodeName)
                {
                   
                    CRelation[] aRelations = FindRelationsWithObject(sNodeName);
                    if (aRelations.Length != 0)
                    {
                        for (int i = 0; i < aRelations.Length; i++)
                        {
                            sAnswer += String.Format("{0}\r\n", aRelations[i].Show);
                        }
                    }
                    aRelations = FindRelationsWithSubject(sNodeName);
                    if (aRelations.Length!=0)
                    {
                        for (int i = 0; i < aRelations.Length; i++)
                        {
                            sAnswer+= String.Format("{0}\r\n", aRelations[i].Show);
                        }
                    }
                   
                    break;
                }
            }
            return sAnswer;
        }
        private string FindAllAboutRelation(string sRelName)
        {
            string sAnswer = "";
            foreach (CRelation rRel in m_aRelations)
            {
                if (rRel.Name == sRelName)
                {                    
                    CRelation[] aRelations = FindRelation(sRelName);
                    if (aRelations.Length != 0)
                    {
                        for (int i = 0; i < aRelations.Length; i++)
                        {
                            sAnswer += String.Format("{0}\r\n", aRelations[i].Show);
                        }
                    }
                    break;
                }
            }
            return sAnswer;
        }
        private string FindRelationBetween(string sNodeOne, string sNodeAnother)
        {
            string sAnswer = "";
            CRelation[] aRelSubjectOne = FindRelationsWithSubject(sNodeOne),
                aRelObjectOne = FindRelationsWithObject(sNodeOne);
            if (aRelSubjectOne.Length != 0)
            {
                for (int i = 0; i < aRelSubjectOne.Length; i++)
                {
                    if (aRelSubjectOne[i].Second.Name == sNodeAnother)
                    {
                        sAnswer += String.Format("{0}\r\n", aRelSubjectOne[i].Show);
                    }
                }
            }
            if (aRelObjectOne.Length != 0)
            {
                for (int i = 0; i < aRelObjectOne.Length; i++)
                {
                    if (aRelObjectOne[i].First.Name == sNodeAnother)
                    {
                        sAnswer += String.Format("{0}\r\n", aRelObjectOne[i].Show);
                    }
                }
            }
            return sAnswer;
        }
        private string FindUncompleteRelation(string sNodeName, string sRelName)
        {
            string sAnswer = "";
            CRelation[] aRelSubjectOne = FindRelationsWithSubject(sNodeName),
                aRelObjectOne = FindRelationsWithObject(sNodeName);
            if (aRelSubjectOne.Length != 0)
            {
                for (int i = 0; i < aRelSubjectOne.Length; i++)
                {
                    if (aRelSubjectOne[i].Name == sRelName)
                    {
                        sAnswer += String.Format("{0}\r\n", aRelSubjectOne[i].Show);
                    }
                }
            }
            if (aRelObjectOne.Length != 0)
            {
                for (int i = 0; i < aRelObjectOne.Length; i++)
                {
                    if (aRelObjectOne[i].Name == sRelName)
                    {
                        sAnswer += String.Format("{0}\r\n", aRelObjectOne[i].Show);
                    }
                }
            }
            return sAnswer;
        }
        private string FindCompleteRelation(string sNodeNameOne,string sNodeNameAnother, string sRelName)
        {
            string sAnswer = "";
            CRelation[] aRelSubjectOne = FindRelationsWithSubject(sNodeNameOne),
                aRelObjectOne = FindRelationsWithObject(sNodeNameOne);
            if (aRelSubjectOne.Length != 0)
            {
                for (int i = 0; i < aRelSubjectOne.Length; i++)
                {
                    if (aRelSubjectOne[i].Name == sRelName 
                        && aRelSubjectOne[i].Second.Name==sNodeNameAnother)
                    {
                        sAnswer += String.Format("{0}\r\n", aRelSubjectOne[i].Show);
                    }
                }
            }
            if (aRelObjectOne.Length != 0)
            {
                for (int i = 0; i < aRelObjectOne.Length; i++)
                {
                    if (aRelObjectOne[i].Name == sRelName
                         && aRelObjectOne[i].First.Name == sNodeNameAnother)
                    {
                        sAnswer += String.Format("{0}\r\n", aRelObjectOne[i].Show);
                    }
                }
            }
            return sAnswer;
        }
        private CRelation[] FindRelationsWithSubject(string sNodeName)
        {
            IList<CRelation> aRelation = new List<CRelation>();
            foreach (CRelation rRel in m_aRelations)
            {
                if (rRel.First.Name== sNodeName)
                {
                    aRelation.Add(rRel);
                }
            }
            return aRelation.ToArray();
        }
        private CRelation[] FindRelation(string sRelName)
        {
            IList<CRelation> aRelation = new List<CRelation>();
            foreach (CRelation rRel in m_aRelations)
            {
                if (rRel.Name == sRelName)
                {
                    aRelation.Add(rRel);
                }
            }
            return aRelation.ToArray();
        }
        private CRelation[] FindRelationsWithObject(string sNodeName)
        {
            IList<CRelation> aRelation = new List<CRelation>();
            foreach (CRelation rRel in m_aRelations)
            {
                if (rRel.Second.Name == sNodeName)
                {
                    aRelation.Add(rRel);
                }
            }
            return aRelation.ToArray();
        }
        public string[] SuitableRelations(string[] aText)
        {
            IList<string> aSuitable = new List<string>();
            for (int i = 0; i < aText.Length; i++)
            {
                if (aText[i].Length > 0)
                {
                    foreach (CRelation rRel in m_aRelations)
                    {
                        if (rRel.AboutThisProbability(aText[i]) > 0.65)
                        {
                            aSuitable.Add(rRel.Name);
                            break;
                        }
                    }
                }
            }
            return aSuitable.ToArray();
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
            bool bAdded = true;
            foreach(CNode rNode in m_aNodes)
            {
                if (rNode.Name==sNodeName)
                {
                    bAdded = false;
                    break;
                }
            }
            return bAdded;
        }
        
    }
}
