using System;

namespace wf_AI_lab1
{
    class CAnnealing:ACAnnealing
    {      
        
        CSolution rSolWorking,rSolBest,rSolCurrent;
        bool bIsUseNew = false;
        int iTimer = 0;
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
            Result = StepResult.NoResult;
          
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
           
            LogLines = "";
            for (int i = 0; i < MaxLen; i++)
            {
                TweakSolution();
            }
        }
        private void TweakSolution()
        {
            int randFirst = (int)(SCValidator.Random* MaxLen),
            randSecond;
            do
            {
                randSecond = (int)(SCValidator.Random * MaxLen);
            }
            while (randFirst == randSecond);
            Board.SwapQueens(randFirst, randSecond);
        }
        public void StopAnnealing()
        {
            Result = StepResult.Break;
        }
        public void AnnealingStep(ref double fTemperature)
        {
            if (fTemperature <= FinTemperature || Result == StepResult.Break)
            {
                LogLines += "Лучшее решение не найдено.";
                m_iProgress = MAX_PROGRESS;
                Result = StepResult.End;
            }
            else
            {
                LogLines += "Температура = " + fTemperature.ToString();
                m_iProgress = (int)((1 - fTemperature / InitTemperature) * MAX_PROGRESS);
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

                        double random = SCValidator.Random;
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
                                LogLines += "Найдено лучшее решение.";
                                Result = StepResult.FindSolution;
                                m_iProgress = MAX_PROGRESS;
                                Board.SetSolution(rSolBest.Solution);
                                SaveLogs();
                                break;
                            }
                        }
                    }
                    else
                    {
                        rSolWorking.CopySolution(rSolCurrent);
                    }
                }
                if (m_iProgress > MAX_PROGRESS)
                {
                    m_iProgress = MAX_PROGRESS;
                }
                iTimer++;                
                LogLines += "Лучшее решение имеет Энергию " + rSolBest.Energy.ToString();
                LogLines += "Счетчик " + iTimer.ToString();
                Board.SetSolution(rSolBest.Solution);
                fTemperature *= Alpha;
            }        
        }
        public void PrepareAnnealing()
        {
            iTimer = 0;
            bIsUseNew = false; 
            rSolWorking = new CSolution(MaxLen, MaxLen * MaxLen);
            rSolBest = new CSolution(MaxLen, MaxLen * MaxLen);
            rSolCurrent = new CSolution(GetCurrentSolution(), GetEvaluateSolution());
            rSolWorking.CopySolution(rSolCurrent);
            Result = StepResult.MayContinue;
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
