using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    [TestFixture]
    class TCCrossbreed
    {
        CGenetic m_rGenetic;
        CLaw m_rLaw;
        [SetUp] 
        public void SetUp()
        {
            int iVertexCount = 8;
            CPathGraph rGraph = new CPathGraph(iVertexCount, 20);
            m_rLaw = new CLaw(10, iVertexCount);
            m_rLaw.UpdateParameters(0.5, 0.1);
            m_rGenetic = new CGenetic(m_rLaw,rGraph);            
        }
        [TearDown]
        public void TearDown()
        {
            m_rGenetic = null;
        }
        [Test]
        public void TestCrossBreeding()
        {
            CCombinatoricChromosome rFirst = new CCombinatoricChromosome(m_rLaw),
                rSecond = new CCombinatoricChromosome(m_rLaw),
                rChild=null;
            Console.WriteLine(rFirst.ToString());
            Console.WriteLine(rSecond.ToString());
            rChild=rFirst.Crossbreeding(rSecond);
            Console.WriteLine(rChild.ToString());
            rChild = rSecond.Crossbreeding(rFirst);
            Console.WriteLine(rChild.ToString());
        }
        [Test]
        public void TestMutate()
        {
            CCombinatoricChromosome rFirst = new CCombinatoricChromosome(m_rLaw);            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rFirst.ToString());
                rFirst.Mutate();
                Console.WriteLine(rFirst.ToString());
                Console.WriteLine();
            }
        }
    }
}
