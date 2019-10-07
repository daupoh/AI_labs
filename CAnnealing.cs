using System;

namespace wf_AI_lab1
{
    class CAnnealing:ACAnnealing
    {      
        Random m_rRand = null;        
        public CAnnealing(int maxLen, int steps, double initTemp, double finTemp, double alpha)
        {
            ReInitialize(maxLen, steps, initTemp, finTemp, alpha);           
        }
      
        public void ReInitialize(int maxLen, int steps, double initTemp, double finTemp, double alpha)
        { 
            MaxLen = maxLen;
            StepsPerChange = steps;
            InitializeTemperatures(initTemp, finTemp);
            Alpha = alpha;
            InitializeBoard();           
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
            bool bIsUseNew = false, bIsBestSolution = false;
            double fTemperature = InitTemperature;
            rSolWorking = new CSolution(MaxLen, MaxLen * MaxLen);
            rSolBest = new CSolution(MaxLen, MaxLen * MaxLen);
            rSolCurrent = new CSolution(GetCurrentSolution(), GetEvaluateSolution());
            rSolWorking.CopySolution(rSolCurrent);

            while (fTemperature > FinTemperature)
            {
                LogLines += "Температура = " + fTemperature.ToString();
                for (int i = 0; i < StepsPerChange; i++)
                {
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
                iTimer++;
                LogLines += "Лучшее решение имеет Энергию " + rSolBest.Energy.ToString();
                LogLines += "Счетчик " + iTimer.ToString();
                fTemperature *= Alpha;
                if (bIsBestSolution)
                    break;
            }
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
