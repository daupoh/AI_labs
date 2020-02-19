using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_AI_lab1.Slot;
using static wf_AI_lab1.ACSlot;

namespace wf_AI_lab1.Frame
{
    class CFrameNet
    {
        IList<CFrame> m_aFrames;
        string[] m_aKeyWords =new string[] { "Изменить","Удалить","Добавить","Найти"};
        public CFrameNet()
        {
            m_aFrames = new List<CFrame>();
            TemplateFrames();
        }

        private void TemplateFrames()
        {
            string sEmp = "Сотрудник", sProj = "Проект", sEpic = "Epic", sTask = "Задача";
            AddFrame(new CFrame(sEmp, null, this));
            AddFrame(new CFrame(sProj, null, this));
            AddFrame(new CFrame(sEpic, null, this));
            AddFrame(new CFrame(sTask, null, this));

            FindFrameByName(sProj).AddSlot(new CSlotText(InheriteType.Unique, "", "Название"));
            FindFrameByName(sProj).AddSlot(new CSlotText(InheriteType.Unique, "", "Описание"));

            FindFrameByName(sEmp).AddSlot(new CSlotText(InheriteType.Unique, "", "Фамилия"));
            FindFrameByName(sEmp).AddSlot(new CSlotText(InheriteType.Unique, "", "Имя"));
            FindFrameByName(sEmp).AddSlot(new CSlotText(InheriteType.Unique, "", "Отчество"));
            FindFrameByName(sEmp).AddSlot(new CSlotText(InheriteType.Unique, "", "Должность"));
            FindFrameByName(sEmp).AddSlot(new CSlotFrame(InheriteType.Unique, FindFrameByName(sProj), "Проект",this));            

            FindFrameByName(sEpic).AddSlot(new CSlotText(InheriteType.Unique, "", "Название Epic"));
            FindFrameByName(sEpic).AddSlot(new CSlotFrame(InheriteType.Unique, FindFrameByName(sProj), "Проект", this));            
            FindFrameByName(sEpic).AddSlot(new CSlotText(InheriteType.Unique, "", "Описание"));

            FindFrameByName(sTask).AddSlot(new CSlotText(InheriteType.Unique, "", "Название"));
            FindFrameByName(sTask).AddSlot(new CSlotText(InheriteType.Unique, "", "Тип"));
            FindFrameByName(sTask).AddSlot(new CSlotText(InheriteType.Unique, "", "Приоритет"));
            FindFrameByName(sTask).AddSlot(new CSlotFrame(InheriteType.Unique, FindFrameByName(sProj), "Проект", this));
            FindFrameByName(sTask).AddSlot(new CSlotText(InheriteType.Unique, "", "Название Epic"));
            FindFrameByName(sTask).AddSlot(new CSlotFrame(InheriteType.Unique, FindFrameByName(sEmp), "Исполнитель", this));

            BuildProject(new string[] { "Проект Jira-1222", "Отклик", "Система по обслуживанию обращений и жалоб клиентов банка." });
            BuildEmployee(new string[] { "Сотрудник №1226", "Стоялов", "Евгений", "Андреевич", "Тестировщик", "Проект Jira-1222" });
            BuildEmployee(new string[] { "Сотрудник №1225", "Хохлов", "Алексей", "Сергеевич", "Тестировщик", "Проект Jira-1222" });
            BuildEmployee(new string[] { "Сотрудник №1224", "Андреева", "Юлия", "Олеговна", "Аналитик", "Проект Jira-1222" });
            BuildEmployee(new string[] { "Сотрудник №1223", "Ткаченко", "Александр", "Юрьевич", "Разработчик", "Проект Jira-1222" });
            BuildEmployee(new string[] { "Сотрудник №1222", "Торопчин", "Дмитрий", "Анатольевич", "Разработчик", "Проект Jira-1222" });
            BuildEpic(new string[] { "Эпик №3","Избавление от Excel",
                "Проект Jira-1222", "Избавиться от загрузок и выгрузок xls файлов" });
            BuildTask(new string[] {"Задача №809", "Новый интерфейс Массовое удаление вложений", "Main", "Высокий",
                "Проект Jira-1222", "Эпик №3", "Сотрудник №1222", });
            BuildTask(new string[] {"Задача №810", "Аналитика: Новый интерфейс Массовое удаление вложений", "SA", "Высокий",
                "Проект Jira-1222", "Эпик №3", "Сотрудник №1224", });
            BuildTask(new string[] {"Задача №811", "Тест-кейсы: Новый интерфейс Массовое удаление вложений", "QA", "Высокий",
                "Проект Jira-1222", "Эпик №3", "Сотрудник №1226", });
            BuildTask(new string[] {"Задача №812", "Разработка: Новый интерфейс Массовое удаление вложений", "DEV", "Высокий",
                "Проект Jira-1222", "Эпик №3", "Сотрудник №1223", });
            BuildTask(new string[] {"Задача №813", "Тестирование: Новый интерфейс Массовое удаление вложений", "QA", "Высокий",
                "Проект Jira-1222", "Эпик №3", "Сотрудник №1225", });
        }

        public void AddFrame(CFrame rFrame)
        {
            if (rFrame!=null)
            {
                m_aFrames.Add(rFrame);
            }
            else
            {
                throw new FormatException();
            }
        }
        
        public CFrame FindFrameByName(string sName)
        {
            CFrame rFindedFrame = null;
            foreach (CFrame rFrame in m_aFrames)
            {
                if (rFrame.Name == sName)
                {
                    rFindedFrame = rFrame;
                    break;
                }
            }
            return rFindedFrame;
        }
        public string[] FindAllFrameNames()
        {
            IList<string> aFrameNames = new List<string>();
            for (int i = 0; i < m_aFrames.Count; i++)
            {
                aFrameNames.Add(m_aFrames[i].Name);
            }
            return aFrameNames.ToArray();
        }
        public string[] FindAllSlotNamesByFrameName(string sFrameName)
        {
            IList<string> aSlotNames = new List<string>();
            CFrame rFrame = FindFrameByName(sFrameName);
            return rFrame.AllSlotNames();
        }
        private string AllFrames()
        {
            string sAnswer = "";
            for (int i = 0; i < m_aFrames.Count; i++)
            {
                sAnswer += m_aFrames[i].Show+"-------------------\r\n";
            }
            return sAnswer;
        }
        private string ParseCommand(string sCommand, string sKey)
        {
            string sResult = "";
            string[] aTags = sCommand.Split('|');
            if (aTags.Length==4)
            {
                switch (sKey)
                {
                    case "Изменить":
                        if (FindFrameByName(aTags[1]) != null && FindFrameByName(aTags[1]).FindSlotByName(aTags[2]) != null)
                        {
                            sResult += FindFrameByName(aTags[1]).FindSlotByName(aTags[2]).EditData(aTags[3]);
                        }
                        break;
                    case "Удалить":
                        if (FindFrameByName(aTags[1]) != null && FindFrameByName(aTags[1]).FindSlotByName(aTags[2]) != null)
                        {
                            sResult += FindFrameByName(aTags[1]).FindSlotByName(aTags[2]).DeleteData();
                        }
                        break;
                    case "Добавить":
                        if (FindFrameByName(aTags[1]) != null && FindFrameByName(aTags[1]).FindSlotByName(aTags[2]) != null)
                        {
                            sResult += FindFrameByName(aTags[1]).FindSlotByName(aTags[2]).AddData(aTags[3]);
                        }
                        break;
                    case "Найти":
                        for (int i = 0; i < m_aFrames.Count; i++)
                        {
                            ISlot rSlot = m_aFrames[i].FindSlotByName(aTags[2]);
                            if (rSlot!=null && rSlot.Show.ToLower().Contains(aTags[3].ToLower()))
                            {
                                sResult += m_aFrames[i].Show;
                            }
                        }
                        break;
                }
            }
            else
            {
                sResult = "Команда не соответствует формату.";
            }
            return sResult;
        }
        public string Request(string sText)
        {
            string sAnswer = "";
            if (sText.ToLower().Contains("Все".ToLower()))
            {
                sAnswer = AllFrames();
            }
            else
            {
                int iKeysCount = 0; string sKey = "";
                for (int i = 0; i < m_aKeyWords.Length; i++)
                {
                    if (sText.ToLower().Contains(m_aKeyWords[i].ToLower()))
                    {
                        if (iKeysCount < 1)
                        {
                            sKey = m_aKeyWords[i];
                        }
                        else
                        {
                            sAnswer = "Указывайте не больше одной ключевой команды.";
                            sKey = "";
                            break;
                        }
                    }
                }
                if (sKey != "")
                {
                    sAnswer = ParseCommand(sText, sKey);
                }
                else
                {
                    string[] aFrameNames = FindAllFrameNames();
                    string sFrameAbout = "";
                    int iFrameCounter = 0;
                    for (int i = 0; i < aFrameNames.Length; i++)
                    {
                        if (sText.ToLower().Contains(aFrameNames[i].ToLower()))
                        {
                            if (iFrameCounter < 1)
                            {
                                sFrameAbout = aFrameNames[i];
                                iFrameCounter++;
                            }
                            else
                            {
                                sAnswer = "Попробуйте сузить запрос до одного фрейма.";
                                break;
                            }
                        }
                    }
                    if (sAnswer == "")
                    {
                        string[] aSlotNames = FindAllSlotNamesByFrameName(sFrameAbout);
                        for (int i = 0; i < aSlotNames.Length; i++)
                        {
                            if (sText.ToLower().Contains(aSlotNames[i].ToLower()))
                            {
                                sAnswer += FindFrameByName(sFrameAbout).FindSlotByName(aSlotNames[i]).Show;
                            }
                        }
                    }
                    if (sAnswer == "")
                    {
                        sAnswer = "Не удалось найти во фрейме ни одного из указанных слотов. Проверьте фрейм.\r\n"
                            + FindFrameByName(sFrameAbout).Show;
                    }
                }
            }
            return sAnswer;

        }
        
        public CFrame BuildEmployee(string[] aParameters)
        {
            CFrame rFrame = new CFrame(aParameters[0],FindFrameByName("Сотрудник"),this);
            this.AddFrame(rFrame);
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[1], "Фамилия"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[2], "Имя"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[3], "Отчество"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[4], "Должность"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotFrame(InheriteType.Independent, FindFrameByName(aParameters[5]), "Проект", this));
            return rFrame;
        }
        public CFrame BuildProject(string[] aParameters)
        {
            CFrame rFrame = new CFrame(aParameters[0], FindFrameByName("Проект"), this);
            this.AddFrame(rFrame);
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[1], "Название"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[2], "Описание"));
            return rFrame;
        }
        public CFrame BuildEpic(string[] aParameters)
        {
            CFrame rFrame = new CFrame(aParameters[0], FindFrameByName("Epic"), this);
            this.AddFrame(rFrame);
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[1], "Название Epic"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotFrame(InheriteType.Independent, FindFrameByName(aParameters[2]), "Проект", this));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[3], "Описание"));

            return rFrame;
        }
        public CFrame BuildTask (string[] aParameters)
        {
            CFrame rFrame = new CFrame(aParameters[0], FindFrameByName("Задача"), this);
            this.AddFrame(rFrame);
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[1], "Название"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[2], "Тип"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[3], "Приоритет"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotFrame(InheriteType.Independent, FindFrameByName(aParameters[4]), "Проект", this));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotText(InheriteType.Independent, aParameters[5], "Название Epic"));
            FindFrameByName(aParameters[0]).AddSlot(new CSlotFrame(InheriteType.Independent, FindFrameByName(aParameters[6]), "Исполнитель", this));
            return rFrame;
        }
    }
}
