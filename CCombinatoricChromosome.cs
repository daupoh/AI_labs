using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CCombinatoricChromosome
    {
        readonly CLaw m_rLaw;        
        readonly int[] m_aGens;
        public CCombinatoricChromosome(CLaw rLaw)
        {
            if (rLaw != null)
            {
                m_rLaw = rLaw;                
                m_aGens = new int[rLaw.GensCount];
                for (int i = 0; i < m_aGens.Length; i++)
                {
                    m_aGens[i] = i;
                }
                MixGens();
            }
            else
            {
                throw new FormatException("Законы генетики для хромосомы не могут быть равны null.");
            }
        }
        public int[] Gens
        {
            get
            {
                return m_aGens;
            }
            set
            {
                for (int i = 0; i < m_aGens.Length; i++)
                {
                    m_aGens[i] = value[i];
                }
            }
        }
        public override string ToString()
        {
            string sGens = "";
            for (int i = 0; i < m_aGens.Length-1; i++)
            {
                sGens += m_aGens[i].ToString() + ",";
            }
            sGens += m_aGens[m_aGens.Length - 1].ToString();
            return sGens;
        }
        public CCombinatoricChromosome Crossbreeding(CCombinatoricChromosome rChromosomePartner)
        {
            CCombinatoricChromosome rChild = new CCombinatoricChromosome(m_rLaw);
            IList<int> aGensToChange = new List<int>();
            for (int i = 0; i < m_aGens.Length; i++)
            {
                double fDecision = SCRandom.Random;
                if ((0.5* m_rLaw.CrossbreedingChance) > fDecision)
                {
                    aGensToChange.Add(m_aGens[i]);
                }
            }
            int[] aSelectedLocuses = FindLocusesWithValues(aGensToChange.ToArray()),
                aSelectedLocusesPartner = rChromosomePartner.FindLocusesWithValues(aGensToChange.ToArray()),
                aNotSelectedLocuses = NotSelectedLocuses(aSelectedLocuses),
                aNotSelectedLocusesPartner = rChromosomePartner.NotSelectedLocuses(aSelectedLocusesPartner),
                aChildGens = new int[m_rLaw.GensCount];
            int iNonSelectedIndex = 0;
            for (int i = 0; i < aChildGens.Length; i++)
            {
                if (IsNotPresentInSequence(i,aNotSelectedLocusesPartner))
                {
                    aChildGens[i] = rChromosomePartner.m_aGens[i];
                }
                else
                {
                    aChildGens[i] = m_aGens[aNotSelectedLocuses[iNonSelectedIndex]];
                    iNonSelectedIndex++;
                }
            }
            rChild.Gens = aChildGens;
            return rChild;
        }
        public void Mutate()
        {
            int iFirstMutantLocus = -1;
            for (int i = 0; i < m_aGens.Length;  i++)
            {
                double fDecision = SCRandom.Random;
                if (m_rLaw.MutateChance > fDecision)
                {
                    if (iFirstMutantLocus == -1)
                    {
                        iFirstMutantLocus = i;
                    }
                    else 
                    {
                        int iTemp = m_aGens[i];
                        m_aGens[i] = m_aGens[iFirstMutantLocus];
                        m_aGens[iFirstMutantLocus] = iTemp;
                        iFirstMutantLocus = -1;
                    }
                }
            }
        }
       
        private int[] FindLocusesWithValues(int[] aValues)
        {
            IList<int> aLocuses = new List<int>();

            for (int i = 0; i < aValues.Length; i++)
            {
                for (int j = 0; j < m_aGens.Length; j++)
                {
                    if (m_aGens[j] == aValues[i])
                    {
                        aLocuses.Add(j);
                        break;
                    }
                }
            }
            return aLocuses.ToArray();
        }
        private int[] NotSelectedLocuses(int[] aSelectedLocus)
        {
            IList<int> aNotSelectedLocuses = new List<int>();
            for (int i = 0; i < m_aGens.Length; i++)
            {
                if (IsNotPresentInSequence(i,aSelectedLocus))
                {
                    aNotSelectedLocuses.Add(i);
                }
            }
            return aNotSelectedLocuses.ToArray();
        }
        private void MixGens()
        {
            int iSwapCount = (int)Math.Round(m_rLaw.GensCount * SCRandom.Random),
                iFirstSwaped = (int)Math.Round((m_rLaw.GensCount-1) * SCRandom.Random),
                iSecondSwaped = (int)Math.Round((m_rLaw.GensCount - 1) * SCRandom.Random);
            for (int i = 0; i < iSwapCount; i++)
            {
                while (iFirstSwaped == iSecondSwaped)
                {
                    iSecondSwaped = (int)Math.Round((m_rLaw.GensCount - 1) * SCRandom.Random);
                }
                int iTemp = m_aGens[iFirstSwaped];
                m_aGens[iFirstSwaped] = m_aGens[iSecondSwaped];
                m_aGens[iSecondSwaped] = iTemp;
                iFirstSwaped = (int)Math.Round((m_rLaw.GensCount - 1) * SCRandom.Random);
                iSecondSwaped = (int)Math.Round((m_rLaw.GensCount - 1) * SCRandom.Random);
            }
        }
        private bool IsNotPresentInSequence(int iNumber, int[] aSequence)
        {
            bool bNotPresented = true;
            for (int i = 0; i < aSequence.Length; i++)
            {
                if (aSequence[i]==iNumber)
                {
                    bNotPresented = false;
                    break;
                }
            }
            return bNotPresented;

        }
    }
}
