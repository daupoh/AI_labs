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
        CGroup m_rPopulation;
        CPathGraph m_rGraph;
       [SetUp] 
        public void SetUp()
        {
            int iVertexCount = 8;
            m_rGraph = new CPathGraph(iVertexCount, 20);
            m_rLaw = new CLaw(10, iVertexCount);
            m_rLaw.UpdateParameters(0.5, 0.1);
            m_rGenetic = new CGenetic(m_rLaw, m_rGraph);            
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
        [Test]
        public void TestSelection()
        {
            m_rPopulation = new CGroup(m_rGraph, m_rLaw);            
            m_rPopulation.GenerateChromosomes(m_rLaw.PopulationSize);
            Console.WriteLine(m_rPopulation.ToString());
            CGroup rSelection = m_rPopulation.Selection();
            Console.WriteLine(m_rPopulation.m_sSelectionLog);
            Console.WriteLine(rSelection.ToString());

            double fLastBestGrade = m_rPopulation.GetBestGrade();
            Console.WriteLine(fLastBestGrade.ToString());
            fLastBestGrade = rSelection.GetBestGrade();
            Console.WriteLine(fLastBestGrade.ToString());
        }

        [Test]
        public void TestEvolution()
        {
            m_rGenetic.InitializeGroup();
            Console.WriteLine(m_rGenetic.ShowPopulation());

            while (m_rGenetic.IsNotEndOfEvolution())
            {
              m_rGenetic.Evolution();
            }
            CCombinatoricChromosome rBestChromosome = m_rGenetic.GetBestChromosome();

            Console.WriteLine(m_rGraph.ToString());
            Console.WriteLine(rBestChromosome.ToString());
            Console.WriteLine(m_rGraph.UpdateGrade(rBestChromosome));

        }
    }
}
