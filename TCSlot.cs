using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_AI_lab1.Frame;
using wf_AI_lab1.Slot;
using static wf_AI_lab1.ACSlot;

namespace wf_AI_lab1
{
    [TestFixture]
    class TCSlot
    {
        Func<string> rFunc;
        
        [Test]
        public void TestGenFrameNet()
        {
            CFrameNet rNet = new CFrameNet();
            rNet.BuildProject(new string[] { "Проект Jira-1222", "Отклик", "Система по обслуживанию обращений и жалоб клиентов банка." });
            rNet.BuildEmployee(new string[] { "Сотрудник №1226", "Стоялов", "Евгений", "Андреевич", "Тестировщик", "Проект Jira-1222" });
            rNet.BuildEpic(new string[] { "Эпик №3","Избавление от Excel", 
                "Проект Jira-1222", "Избавиться от загрузок и выгрузок xls файлов" });
            rNet.BuildTask(new string[] {"Задача №809", "Новый интерфейс Массовое удаление вложений", "Корневая задача", "Высокий",
                "Проект Jira-1222", "Эпик №3", "Сотрудник №1226", });

            Console.WriteLine(rNet.Request("Найти||Должность|Тестировщик"));
        }

    }
}
