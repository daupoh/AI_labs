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
            CSlotText rProjectJiraTask = new CSlotText(InheriteType.Unique, "", "Название проекта"),
                rProjectEpicTask = new CSlotText(InheriteType.Same,"", "Название проекта"),
                rDateEpicTask = new CSlotText(InheriteType.Unique, "02.03.2020", "Дата начала");
            rFunc = () => "Project_1";

            rProjectJiraTask.IfDefault = rFunc;

            CFrame rJiraTask = new CFrame("Задача Jira", null, rNet);
            rJiraTask.AddSlot(rProjectJiraTask);

            CFrame rEpicTask = new CFrame("Задача Epic", rJiraTask, rNet);
            rEpicTask.AddSlot(rProjectEpicTask);
            rEpicTask.AddSlot(rDateEpicTask);

            rNet.AddFrame(rJiraTask);
            rNet.AddFrame(rEpicTask);
            Console.WriteLine(rNet.Request("Дат нача у Задача Epic?"));
        }

    }
}
