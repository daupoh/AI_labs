using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNetGenerator
    {
        CSemanticGraph m_rGraph;
        string[] m_aRequestNodeKeyWords = new string[] { "какой", "кто", "что", "кого", "какие" };
     
        public CNetGenerator()
        {
            m_rGraph = new CSemanticGraph();
            m_rGraph.AddNode("Проект");
            m_rGraph.AddNode("Аптека");
            m_rGraph.AddNode("Отклик");
            m_rGraph.AddNode("Фирма");
            m_rGraph.AddNode("ТН");
            m_rGraph.AddNode("ФИТ");
            m_rGraph.AddNode("HCB");
            m_rGraph.AddNode("Срок");
            m_rGraph.AddNode("2020");
            m_rGraph.AddNode("2021");

            m_rGraph.AddRelation("например", "Проект", "Отклик");
            m_rGraph.AddRelation("например", "Проект", "Аптека");
            m_rGraph.AddRelation("например", "Фирма", "ТН");
            m_rGraph.AddRelation("например", "Фирма", "ФИТ");
            m_rGraph.AddRelation("например", "Фирма", "HCB");
            m_rGraph.AddRelation("например", "Срок", "2020");
            m_rGraph.AddRelation("например", "Срок", "2021");
            m_rGraph.AddRelation("срок", "Отклик", "2020");
            m_rGraph.AddRelation("срок", "Аптека", "2021");
            m_rGraph.AddRelation("заказала", "ФИТ", "Аптека");
            m_rGraph.AddRelation("заказала", "HCB", "Отклик");
            m_rGraph.AddRelation("исполняет", "ТН", "Аптека");
            m_rGraph.AddRelation("исполняет", "ТН", "Отклик");

        }
        public string Request(string sRequest)
        {
            string sAnswer = "";
            string[] aTags = sRequest.Split(new char[] { ' ', '-' });
            int iTagsCount = aTags.Length;
            string[] aSuitableNodes =  m_rGraph.SuitableNodes(aTags),
                aSuitableRelations = m_rGraph.SuitableRelations(aTags);
            if (aSuitableNodes.Length>2 || aSuitableRelations.Length>1 || 
                (iTagsCount - aSuitableNodes.Length - aSuitableRelations.Length) >3)
            {
                throw new FormatException();
            }
            else if (aSuitableNodes.Length == 2 && aSuitableRelations.Length == 1)
            {
                throw new FormatException();
            }
            else
            {
                m_rGraph.FindSemanticFragment(aSuitableNodes, aSuitableRelations);
            }

            return sAnswer;
        }
    }
}
