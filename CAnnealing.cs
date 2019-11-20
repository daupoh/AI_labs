using System;

namespace wf_AI_lab1
{
    class CAnnealing:ACAnnealing
    {      
        Random m_rRand = null;
        
        public CAnnealing(int maxLen, int steps, double initTemp, double finTemp, double alpha)
        {
            ReInitialize(maxLen, steps, initTemp, finTemp, alpha);
            m_rRand = new Random();
        }
      
        public void ReInitialize(int maxLen, int steps, double initTemp, double finTemp, double alpha)
        { 
            MaxLen = maxLen;
            StepsPerChange = steps;
            InitializeTemperatures(initTemp, finTemp);
            Alpha = alpha;
            InitializeBoard();
            bAnneal = true;
        }
        private void InitializeTemperatures(double initTemp, double finTemp)
        {
            //order is important
            FinTemperature = finTemp;
            InitTemperature = initTemp;
        }
        private void InitializeBoard()
        {
            Board = new CBoard(MaxLen);
            m_rRand = new Random();
            LogLines = "";
            for (int i = 0; i < MaxLen; i++)
            {
                TweakSolution();
            }
        }
        private void TweakSolution()
        {
            int randFirst = m_rRand.Next(MaxLen),
            randSecond;
            do
            {
                randSecond = m_rRand.Next(MaxLen);
            }
            while (randFirst == randSecond);
            Board.SwapQueens(randFirst, randSecond);
        }
        public bool Annealing()
        {
            CSolution rSolWorking, rSolCurrent, rSolBest;
            int iTimer = 0;
            
            m_iProgress = 0;
            bool bIsUseNew = false, bIsBestSolution = false;
            double fTemperature = InitTemperature;
            rSolWorking = new CSolution(MaxLen, MaxLen * MaxLen);
            rSolBest = new CSolution(MaxLen, MaxLen * MaxLen);
            rSolCurrent = new CSolution(GetCurrentSolution(), GetEvaluateSolution());
            rSolWorking.CopySolution(rSolCurrent);

            while (bAnneal && fTemperature > FinTemperature)
            {
                LogLines += "Температура = " + fTemperature.ToString();
                for (int i = 0; i < StepsPerChange; i++)
                {
                    if (!bAnneal)
                    {
                        break;
                    }
                    TweakSolution();
                    rSolWorking = new CSolution(GetCurrentSolution(), GetEvaluateSolution());
                    if (rSolWorking.Energy <= rSolCurrent.Energy)
                    {
                        bIsUseNew = true;
                    }
                    else
                    {
                        
                        double random = m_rRand.NextDouble();
                        int delta = rSolWorking.Energy - rSolCurrent.Energy;
                        double calc = Math.Exp(-delta / fTemperature);
                        //LogLines += "Вероятность принятия решения: " + Math.Round(calc, 4).ToString() + " против " + Math.Round(random, 4).ToString();
                        if (calc > random)
                        {
                            bIsUseNew = true;
                        }
                    }
                    if (bIsUseNew)
                    {
                        bIsUseNew = false;
                        rSolCurrent.CopySolution(rSolWorking);                        
                        if (rSolCurrent.Energy < rSolBest.Energy)
                        {
                            rSolBest.CopySolution(rSolCurrent);
                            if (rSolBest.Energy == 0)
                            {
                                bIsBestSolution = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        rSolWorking.CopySolution(rSolCurrent);
                    }
                }
                m_iProgress = (int)((InitTemperature - fTemperature) / (InitTemperature - FinTemperature)*100);
                iTimer++;
                LogLines += "Лучшее решение имеет Энергию " + rSolBest.Energy.ToString();
                LogLines += "Счетчик " + iTimer.ToString();
                fTemperature *= Alpha;
                if (bIsBestSolution)
                    break;
                Console.WriteLine(Math.Round(fTemperature, 4));
            }
            m_iProgress = 100;
            Board.SetSolution(rSolBest.Solution);
            SaveLogs();
            return bIsBestSolution;
        }
        public string GetBoardInText()
        {
            return Board.ToString();
        }       
        private int GetEvaluateSolution() {
          
            return Board.GetCountOfConflicts();
        }
        private int[] GetCurrentSolution()
        {
            return Board.GetCurrentSolutionByCols();
        }
    }
}
