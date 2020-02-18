using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    [TestFixture]
    class TCNetGen
    {
        CNetGenerator m_rNetGen;
        [SetUp]
        public void SetUp()
        {
            m_rNetGen = new CNetGenerator();
        }
        [TearDown]
        public void TearDown()
        {
            m_rNetGen = null;
        }
        [Test]
        public void TestRequests()
        {
            string sReq = "Что такое Отклик?";
            Console.WriteLine(sReq);
            Console.WriteLine(m_rNetGen.Request(sReq));

            sReq = "Кто что заказал?";
            Console.WriteLine(sReq);
            Console.WriteLine(m_rNetGen.Request(sReq));

            sReq = "Кто исполняет заказ по Отклику?";
            Console.WriteLine(sReq);
            Console.WriteLine(m_rNetGen.Request(sReq));

            sReq = "ФИТ связан с Аптекой?";
            Console.WriteLine(sReq);
            Console.WriteLine(m_rNetGen.Request(sReq));

            sReq = "Что спроектировано Фитом?";
            Console.WriteLine(sReq);
            Console.WriteLine(m_rNetGen.Request(sReq));
        }
        [Test]
        public void TestSingleRequest()
        {
            string sReq = "Срок Отклика 12.11.2020?";
            Console.WriteLine(sReq);
            Console.WriteLine(m_rNetGen.Request(sReq));
        }
    }
}
