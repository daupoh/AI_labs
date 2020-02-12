using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CGroup
    {
        readonly IGradeUpdater m_rUpdater;
        readonly CLaw m_rLaw;
        readonly IList<CCombinatoricChromosome> m_aChromosomes;
        public string m_sSelectionLog;
        public int GroupSize { get; private set; }
        
        public CGroup(IGradeUpdater rUpdater, CLaw rLaw)
        {
            if (rUpdater!=null && rLaw!=null)
            {                
                m_rUpdater = rUpdater;
                m_rLaw = rLaw;
                m_aChromosomes = new List<CCombinatoricChromosome>();
                GroupSize = 0;
            }
            else
            {
                throw new FormatException();
            }
        }
        public override string ToString()
        {
            string sGroup = "";
            for (int i = 0; i < GroupSize; i++)
            {
                sGroup += m_aChromosomes[i].ToString()+" with grade: "+
                    Math.Round(GetGradeAtChromosome(i),4).ToString()+ "\r\n";
            }
            return sGroup;
        }
        public void GenerateChromosomes(int iGroupSize)
        {
            if (iGroupSize > 0)
            {
                GroupSize = iGroupSize;

                for (int i = 0; i < GroupSize; i++)
                {
                    m_aChromosomes.Add(new CCombinatoricChromosome(m_rLaw));
                }
            }
            else
            {
                throw new FormatException();
            }
        }
        public CGroup Selection()
        {
            CGroup rSelectedGroup = new CGroup(m_rUpdater, m_rLaw);
            m_sSelectionLog = "";
            double[] aSelectionPercents = new double[GroupSize];
            double fGradesSum = 0;
            for (int i = 0; i < GroupSize; i++)
            {
                fGradesSum += GetGradeAtChromosome(i);
            }
            double fAvgGrade = fGradesSum / GroupSize;
            double fReverseGradesSum = 0;
            for (int i = 0; i < GroupSize; i++)
            {
                //aSelectionPercents[i] = fGradesSum - GetGradeAtChromosome(i);
                //fReverseGradesSum += aSelectionPercents[i];
                aSelectionPercents[i] = fAvgGrade / GetGradeAtChromosome(i);
                fReverseGradesSum += aSelectionPercents[i];
            }
            for (int i = 0; i < GroupSize; i++)
            {
                aSelectionPercents[i] = aSelectionPercents[i] / fReverseGradesSum;
            }
            UpdateSelectionLog(aSelectionPercents);
            for (int i = 0; i < GroupSize; i++)
            {
                double fRandom = SCRandom.Random;
                rSelectedGroup.AddChromosome(m_aChromosomes[GetNumberInGroup(fRandom,aSelectionPercents)]);
            }
            return rSelectedGroup;
        }
        public CGroup Crossbreeding()
        {
            CGroup rChilds = new CGroup(m_rUpdater, m_rLaw);
            int iFirstCrossing = -1;
            for (int i = 0; i < GroupSize; i++)
            {
                double fDecision = SCRandom.Random;
                if (m_rLaw.CrossbreedingChance > fDecision)
                {
                    if (iFirstCrossing == -1)
                    {
                        iFirstCrossing = i;
                    }
                    else
                    {
                        rChilds.AddChromosome(m_aChromosomes[iFirstCrossing].Crossbreeding
                            (m_aChromosomes[i]));
                        iFirstCrossing = -1;
                    }
                }
            }
            return rChilds;
        }
        public void Mutate()
        {            
            for (int i = 0; i < GroupSize; i++)
            {
                double fDecision = SCRandom.Random;
                if (m_rLaw.MutateChance > fDecision)
                {
                    m_aChromosomes[i].Mutate();
                }
            }
        }
        public void GenerateNewGroup(CGroup rNewbies)
        {            
            for (int i = 0; i < rNewbies.GroupSize; i++)
            {
                CCombinatoricChromosome rNewChromosome = rNewbies.m_aChromosomes[i];
                int iWorstChromosomeIndex = GetWorst();
                double fWorstGrade = GetGradeAtChromosome(iWorstChromosomeIndex);
                double fNewChromosomeGrade = rNewbies.GetGradeAtChromosome(i);
                if (fNewChromosomeGrade<fWorstGrade)
                {
                    m_aChromosomes.Remove(m_aChromosomes[iWorstChromosomeIndex]);
                    m_aChromosomes.Add(rNewChromosome);
                }
            }
        }
        public double GetBestGrade()
        {           
            return GetGradeAtChromosome(GetBestGradeIndex());
        }
        public CCombinatoricChromosome GetBestChromosome()
        {
            return m_aChromosomes[GetBestGradeIndex()];
        }
        private int GetBestGradeIndex()
        {
            double fBestGrade = double.MaxValue;
            int iBestGradeIndex = -1;
            for (int i = 0; i < GroupSize; i++)
            {
                double fCurrentChromosomeGrade = GetGradeAtChromosome(i);
                if (fCurrentChromosomeGrade < fBestGrade)
                {
                    fBestGrade = fCurrentChromosomeGrade;
                    iBestGradeIndex = i;
                }
            }
            return iBestGradeIndex;
        }
        private int GetNumberInGroup(double fRouletteValue,double[] aSelectionPercents)
        {
            double fRouletteSum = aSelectionPercents[0];
            int i = 0;
            while (fRouletteSum < fRouletteValue)
            {
                i++;
                fRouletteSum += aSelectionPercents[i];
            }
            return i;
        }
        private void AddChromosome(CCombinatoricChromosome rChromosome)
        {
            m_aChromosomes.Add(rChromosome);
            GroupSize++;
        }       
        private int GetWorst()
        {
            double fWorstGrade = 0;
            int iWorstGradeIndex = -1;
            for (int i = 0; i < GroupSize; i++)
            {
                double fCurrentChromosomeGrade = GetGradeAtChromosome(i);
                if (fCurrentChromosomeGrade>fWorstGrade)
                {
                    fWorstGrade = fCurrentChromosomeGrade;
                    iWorstGradeIndex = i;
                }
            }
            return iWorstGradeIndex;
        }
        private double GetGradeAtChromosome(int iNumber)
        {
            return m_rUpdater.UpdateGrade(m_aChromosomes[iNumber]);
        }
        private void UpdateSelectionLog(double[] aSelectionPercents)
        {
            for (int i = 0; i < aSelectionPercents.Length; i++)
            {
                m_sSelectionLog += Math.Round(aSelectionPercents[i], 4).ToString() + "\r\n";
            }
        }
     
    }
}
