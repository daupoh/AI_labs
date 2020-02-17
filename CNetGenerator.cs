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
            m_rGraph.AddNode("Человек");
            m_rGraph.AddNode("Задача");
            m_rGraph.AddNode("Проект");
            m_rGraph.AddNode("Аптека");
            m_rGraph.AddNode("Отклик");

            m_rGraph.AddNode("Фирма");
            m_rGraph.AddNode("ТН");
            m_rGraph.AddNode("ФИТ");
            m_rGraph.AddNode("HCB");

            m_rGraph.AddNode("Команда");
            m_rGraph.AddNode("Отклик-тим");
            m_rGraph.AddNode("Аптека-тим");

            m_rGraph.AddNode("Тестировщик");
            m_rGraph.AddNode("Аналитик");
            m_rGraph.AddNode("Разработчик");
            m_rGraph.AddNode("Заказчик");
            m_rGraph.AddNode("Тим-лид");
            m_rGraph.AddNode("Фичи");
            m_rGraph.AddNode("Спецификации");
            m_rGraph.AddNode("Тест-кейсы");
            m_rGraph.AddNode("Концепции");
            m_rGraph.AddNode("Спринт");

            m_rGraph.AddNode("Дата");
            m_rGraph.AddNode("12.11.2020");
            m_rGraph.AddNode("01.03.2021");

            m_rGraph.AddRelation("например", "", "Человек", "Тестировщик");
            m_rGraph.AddRelation("например", "", "Человек", "Аналитик");
            m_rGraph.AddRelation("например", "", "Человек", "Заказчик");
            m_rGraph.AddRelation("например", "", "Человек", "Разработчик");
            m_rGraph.AddRelation("например", "", "Человек", "Тим-лид");

            m_rGraph.AddRelation("например", "", "Задача", "Спринт");
            m_rGraph.AddRelation("например", "", "Задача", "Тест-кейсы");
            m_rGraph.AddRelation("например", "", "Задача", "Спецификации");
            m_rGraph.AddRelation("например", "", "Задача", "Фичи");
            m_rGraph.AddRelation("например", "", "Задача", "Концепции");

            m_rGraph.AddRelation("например", "", "Проект", "Отклик");
            m_rGraph.AddRelation("например", "", "Проект", "Аптека");
            m_rGraph.AddRelation("например", "", "Команда", "Отклик-тим");
            m_rGraph.AddRelation("например", "", "Команда", "Аптека-тим");

            m_rGraph.AddRelation("состоит", "из", "Проект", "Концепции");
            m_rGraph.AddRelation("состоит", "из", "Проект", "Команда");
            m_rGraph.AddRelation("состоит", "из", "Команда", "Заказчик");
            m_rGraph.AddRelation("состоит", "из", "Команда", "Тестировщик");
            m_rGraph.AddRelation("состоит", "из", "Команда", "Разработчик");
            m_rGraph.AddRelation("состоит", "из", "Команда", "Аналитик");
            m_rGraph.AddRelation("состоит", "из", "Команда", "Тим-лид");

            m_rGraph.AddRelation("создает", "", "Тим-лид", "Спринт");
            m_rGraph.AddRelation("создает", "", "Аналитик", "Спецификации");
            m_rGraph.AddRelation("создает", "", "Заказчик", "Концепции");
            m_rGraph.AddRelation("создает", "", "Тестировщик", "Тест-кейсы");
            m_rGraph.AddRelation("создает", "", "Разработчик", "Фичи");

            m_rGraph.AddRelation("нуждается", "в", "Аналитик", "Концепции");
            m_rGraph.AddRelation("нуждается", "в", "Тестировщик", "Спецификации");
            m_rGraph.AddRelation("нуждается", "в", "Разработчик", "Спецификации");
            m_rGraph.AddRelation("нуждается", "в", "Тим-лид", "Концепции");
            m_rGraph.AddRelation("нуждается", "в", "Заказчик", "Команда");

            m_rGraph.AddRelation("поддерживает", "", "Отклик-тим", "Отклик");
            m_rGraph.AddRelation("поддерживает", "", "Аптека-тим", "Аптека");

            m_rGraph.AddRelation("например", "", "Фирма", "ТН");
            m_rGraph.AddRelation("например", "", "Фирма", "ФИТ");
            m_rGraph.AddRelation("например", "", "Фирма", "HCB");
            m_rGraph.AddRelation("например", "", "Дата", "12.11.2020");
            m_rGraph.AddRelation("например", "", "Дата", "01.03.2021");
            m_rGraph.AddRelation("срок", "до", "Отклик", "12.11.2020");
            m_rGraph.AddRelation("срок", "до", "Аптека", "01.03.2021");
            m_rGraph.AddRelation("заказала", "", "ФИТ", "Аптека");
            m_rGraph.AddRelation("заказала", "", "HCB", "Отклик");
            m_rGraph.AddRelation("исполняет", "", "ТН", "Аптека");
            m_rGraph.AddRelation("исполняет","", "ТН", "Отклик");

        }
        public string Request(string sRequest)
        {
            string sAnswer = "";
            string[] aTags = sRequest.Split(new char[] { ' ','?' });
            
            string[] aSuitableNodes =  m_rGraph.SuitableNodes(aTags),
                aSuitableRelations = m_rGraph.SuitableRelations(aTags);
            int iOtherTagsCount = aTags.Length - CountEmptyTags(aTags) - CountQuestionTags(aTags)
                - aSuitableNodes.Length - aSuitableRelations.Length;
            if (aSuitableNodes.Length>2 || aSuitableRelations.Length>1 || 
                iOtherTagsCount > 3 || CountQuestionTags(aTags)>2)
            {
                sAnswer = "Попробуйте уточнить запрос.\r\n";
            }
            else if (aSuitableNodes.Length == 0 && aSuitableRelations.Length == 0)
            {
                sAnswer = "По запросу не удалось ничего найти.\r\n";
            }
            else if (aSuitableNodes.Length == 2 && aSuitableRelations.Length == 1)
            {
                sAnswer = m_rGraph.FindSemanticFragment(aSuitableNodes, aSuitableRelations);
                if (sAnswer == "")
                {
                    sAnswer = "Это утверждение ложное.\r\n";
                }
                else
                {
                    sAnswer = "Это утверждение истинное.\r\n";
                }
            }
            else
            {
                sAnswer = m_rGraph.FindSemanticFragment(aSuitableNodes, aSuitableRelations);
                if (sAnswer=="")
                {
                    sAnswer = String.Format("Не удалось найти связей, попробуйте разбить запрос на части.\r\n");
                }
            }

            return sAnswer;
        }
        private int CountEmptyTags(string[] aTags)
        {
            int iCounter = 0;
            for (int i = 0; i < aTags.Length; i++)
            {
                if (aTags[i]=="")
                {
                    iCounter++;
                }
            }
            return iCounter;
        }
        private int CountQuestionTags(string[] aTags)
        {
            int iCounter = 0;
            for (int i = 0; i < aTags.Length; i++)
            {
                if (IsQuestion(aTags[i]))
                {
                    iCounter++;
                }
            }
            return iCounter;
        }
        private bool IsQuestion(string sText)
        {
            bool bQuestion = false;
            for (int i = 0; i < m_aRequestNodeKeyWords.Length; i++)
            {
                if (sText==m_aRequestNodeKeyWords[i])
                {
                    bQuestion = true;
                    break;
                }
            }
            return bQuestion;
        }
    }
}
