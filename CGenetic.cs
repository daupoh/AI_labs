using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CGenetic
    {
        CGroup m_rPopulation;
        readonly IGradeUpdater m_rUpdater;
        readonly CLaw m_rLaw;
        int m_iWaitCounter;
        double m_fLastBestGrade;
        public CGenetic(CLaw rLaw, IGradeUpdater rUpdater)
        {
            if (rLaw != null && rUpdater!=null)
            {
                m_rUpdater = rUpdater;
                m_rLaw = rLaw;
                m_iWaitCounter = 100;
            }
            else
            {
                throw new FormatException("Размер группы должен быть больше 0");
            }
        }
       
        public CCombinatoricChromosome Evolution()
        {
            InitializeGroup();
            while (IsNotEndOfEvolution())
            {                
                CGroup rChilds = m_rPopulation.Selection().Crossbreeding();
                rChilds.Mutate();
                m_rPopulation.GenerateNewGroup(rChilds);
            }
            return GetBestChromosome();
        }
       
        private void InitializeGroup()
        {
            m_rPopulation = new CGroup(m_rUpdater, m_rLaw);
            m_rPopulation.GenerateChromosomes(m_rLaw.PopulationSize);
            m_fLastBestGrade = m_rPopulation.GetBestGrade();
        }       
      
        private bool IsNotEndOfEvolution()
        {
            bool bEvolutionNotEnded = true;
            double fCurrentBestGrade = m_rPopulation.GetBestGrade();
            if (m_iWaitCounter > 0)
            {
                if (fCurrentBestGrade < m_fLastBestGrade)
                {
                    m_fLastBestGrade = fCurrentBestGrade;
                }
                else
                {
                    m_iWaitCounter--;
                }

            }
            else
            {
                bEvolutionNotEnded = false;
            }
            return bEvolutionNotEnded;
        }      
      
        private CCombinatoricChromosome GetBestChromosome()
        {
            return m_rPopulation.GetBestChromosome();
        }
        
    }
}
