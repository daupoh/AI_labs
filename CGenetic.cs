using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CGenetic
    {
        IList<CCombinatoricChromosome> m_aChromosomesGroup,m_aSelectionGroup,m_aChilds;
        double[] m_aGrades,m_aSelectionPercents;
        IGradeUpdater m_rUpdater;
        const int WAIT = 10;
        double m_fBestGrade = -1;
        int m_iWaitCounter = 0;
        public bool BestIsMinimum { get; set; }
        public int GroupSize { get; private set; }
        public int GensCount { get; private set; }
        public double CrossbreedingChance { get; private set; }
        public double MutateChance { get; private set; }
       
        public CGenetic(int iGroupSize, IGradeUpdater rUpdater)
        {
            if (iGroupSize > 0 && rUpdater!=null)
            {
                GroupSize = iGroupSize;
                m_rUpdater = rUpdater;
                m_aChromosomesGroup = new List<CCombinatoricChromosome>();
                m_aSelectionGroup = new List<CCombinatoricChromosome>();
                m_aChilds = new List<CCombinatoricChromosome>();
                BestIsMinimum = true;
            }
            else
            {
                throw new FormatException("Размер группы должен быть больше 0");
            }
        }
        public void SetGeneticParameters(double fCrossbreedingChance, double fMutateChance, int iGensCount)
        {
            if (IsBetweenZeroOne(fCrossbreedingChance) && IsBetweenZeroOne(fMutateChance) && iGensCount>0)
            {                
                MutateChance = fMutateChance;
                CrossbreedingChance = fCrossbreedingChance;
                GensCount = iGensCount;
            }
            else
            {
                throw new FormatException("Вероятности Скрещиванияи Мутации должны быть больше 0, но меньше 1." +
                    "Количество генов в хромосоме должно быть больше 0.");
            }
        }
        public CCombinatoricChromosome Evolution()
        {
            InitializeGroup();
            UpdateChromosomeGrades();
            while (IsNotEndOfEvolution())
            {
                ChromosomeSelection();
                UseGeneticOperators();
                GenerateNewGroup();
                UpdateChromosomeGrades();
            }
            return GetBestChromosome();
        }
        private void SortGroup()
        {
            CCombinatoricChromosome[] aGradedChromosomes = m_aChromosomesGroup.ToArray();
            if (BestIsMinimum)
            {
                for (int i = 0; i < m_aGrades.Length; i++)
                {
                    for (int j = 0; j < m_aGrades.Length-1; j++)
                    {
                        if (m_aGrades[j]>m_aGrades[j+1])
                        {
                            double fTemp = m_aGrades[j];
                            m_aGrades[j] = m_aGrades[j + 1];
                            m_aGrades[j + 1] = fTemp;
                            CCombinatoricChromosome rTemp = aGradedChromosomes[j];
                            aGradedChromosomes[j] = aGradedChromosomes[j + 1];
                            aGradedChromosomes[j + 1] = rTemp;
                        }
                    }
                }
            }
            m_aChromosomesGroup.Clear();
            for (int i = 0; i < aGradedChromosomes.Length; i++)
            {
                m_aChromosomesGroup.Add(aGradedChromosomes[i]);
            }
        }
        private void InitializeGroup()
        {
            m_fBestGrade = -1;
            m_iWaitCounter = 0;
            m_aChromosomesGroup.Clear();
            m_aGrades = new double[GroupSize];            
            for (int i = 0; i < GroupSize; i++)
            {
                m_aChromosomesGroup.Add(new CCombinatoricChromosome(this));
            }
        }
        private void UpdateChromosomeGrades()
        {
            if (m_fBestGrade == -1)
            {
                m_fBestGrade = InitializeBestGrade();
            }
            
            for (int i = 0; i < GroupSize; i++)
            {
                m_aGrades[i] = m_rUpdater.UpdateGrade(m_aChromosomesGroup[i]);
                UpdateBest(m_aGrades[i]);
            }
            SortGroup();
        }
      
        private bool IsNotEndOfEvolution()
        {
            bool bEvolutionNotEnded = true;
            if (BestIsMinimum)
            {
                if (m_fBestGrade==0)
                {
                    bEvolutionNotEnded = false;
                }
            }
            else
            {
                if (m_fBestGrade==double.MaxValue)
                {
                    bEvolutionNotEnded = false;
                }
            }
            if (m_iWaitCounter==WAIT)
            {
                bEvolutionNotEnded = false;
            }
            if (bEvolutionNotEnded)
            {
                m_iWaitCounter++;
            }
            return bEvolutionNotEnded;
        }
        private void ChromosomeSelection()
        {
            m_aSelectionPercents = new double[m_aGrades.Length];
            m_aSelectionGroup.Clear();
            double fGradesSum = 0;
            for (int i = 0; i < m_aGrades.Length; i++)
            {
                fGradesSum += m_aGrades[i];
            }
            if (BestIsMinimum)
            {
                double fReverseGradesSum = 0;
                for (int i = 0; i < m_aSelectionPercents.Length; i++)
                {
                    m_aSelectionPercents[i] = fGradesSum - m_aGrades[i];
                    fReverseGradesSum += m_aSelectionPercents[i];
                }
                for (int i = 0; i < m_aSelectionPercents.Length; i++)
                {
                    m_aSelectionPercents[i] = m_aSelectionPercents[i] / fReverseGradesSum;
                }
            }
            Roulette();
        }
        private void Roulette()
        {
            for (int i = 0; i < GroupSize; i++)
            {
                double fRandom = SCRandom.Random;
                m_aSelectionGroup.Add(m_aChromosomesGroup[GetNumberInGroup(fRandom)]);
            }
        }
        private int GetNumberInGroup(double fRouletteValue)
        {
            double fRouletteSum = m_aSelectionPercents[0]; 
            int i = 0;
            while (fRouletteSum<fRouletteValue)
            {
                i++;
                fRouletteSum += m_aSelectionPercents[i];
            }
            return i;
        }
        private void UseGeneticOperators()
        {
            m_aChilds.Clear();
            int iFirstCrossing = -1;
            for (int i = 0; i < m_aSelectionGroup.Count; i++)
            {
                double fDecision = SCRandom.Random;
                if (CrossbreedingChance>fDecision)
                {
                    if (iFirstCrossing==-1)
                    {
                        iFirstCrossing = i;
                    }
                    else
                    {
                        m_aChilds.Add(m_aSelectionGroup[iFirstCrossing].Crossbreeding
                            (m_aSelectionGroup[i]));
                        iFirstCrossing = -1;
                    }
                }
            }
            for (int i = 0; i < m_aChilds.Count; i++)
            {
                double fDecision = SCRandom.Random;
                if (MutateChance>fDecision)
                {
                    m_aChilds[i].Mutate();
                }
            }
        }
        private void GenerateNewGroup()
        {
            if (m_aChilds.Count>0)
            {
                if (BestIsMinimum) {
                    for (int i = 0; i < m_aChilds.Count; i++)
                    {
                        double fChildGrade = m_rUpdater.UpdateGrade(m_aChilds[i]);
                        if (fChildGrade < m_aGrades[i])
                        {
                            m_aChromosomesGroup.RemoveAt(m_aChromosomesGroup.Count - 1);
                            m_aChromosomesGroup.Add(m_aChilds[i]);
                        }
                    }
                }
            }
        }
        private CCombinatoricChromosome GetBestChromosome()
        {
            CCombinatoricChromosome rBestChromosome = null;

            return rBestChromosome;
        }
        private bool IsBetweenZeroOne(double fNumber)
        {
            return (fNumber > 0.0 && fNumber < 1.0);
        }
        private double InitializeBestGrade()
        {
            double fBest = 0;
            if (BestIsMinimum)
            {
                fBest = double.MaxValue;
            }
            else
            {
                fBest = 0;
            }
            return fBest;
        }
        private void UpdateBest(double fBest)
        {
            if (BestIsMinimum)
            {
                if (fBest < m_fBestGrade)
                {
                    m_fBestGrade = fBest;
                }
            }
            else
            {
                if (fBest > m_fBestGrade)
                {
                    m_fBestGrade = fBest;
                }
            }
        }
    }
}
