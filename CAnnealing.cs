using System;

namespace wf_AI_lab1
{
    class CAnnealing
    {
        int m_uiMaxLength = 8, m_uiStepPerChange = 100;

        double m_dbInitialTemperature = 30.0,
                m_dbFinalTemperature = 0.1,
                m_dbAlpha = 0.99;
        CBoard m_rBoard = null;
        TSolution m_rBest;
        Random m_rRand = null;
        public struct TSolution
        {
            int[] solutionByColsNumber;
            int energy;
            int maxLength;
            public int Energy { get { return energy; } set { energy = value; } }
            public int[] Solution { get { return solutionByColsNumber; } }
            public TSolution(int len) {
                energy = 0;
                solutionByColsNumber = new int[len];
                maxLength = len;
            }
            public void CopySolution(int[] sol) {
                if (sol != null && sol.Length == maxLength)
                {                   
                    for (int i = 0; i < maxLength; i++)
                    {
                        solutionByColsNumber[i] = sol[i];
                    }
                }
                else {
                    throw new FormatException("Ошибка при копировании решения.");
                }
            }           
        }

        public CAnnealing()
        {
            InitializeBoard();
        }
        public void ReInitialize(int maxLen, int steps, double initTemp, double finTemp, double alpha)
        {
            ValidateInt(maxLen);
            ValidateInt(steps);
            ValidateTemperatures(initTemp, finTemp);
            ValidateAlpha(alpha);
            m_uiMaxLength = maxLen;
            m_uiStepPerChange = steps;
            m_dbInitialTemperature = initTemp;
            m_dbFinalTemperature = finTemp;
            m_dbAlpha = alpha;
            InitializeBoard();           
        }
        public bool Annealing() {
            TSolution working, current;
            bool isUseNew = false, isBestSolution = false;
            double temperature = m_dbInitialTemperature;
            working = new TSolution(m_uiMaxLength);
            m_rBest = new TSolution(m_uiMaxLength);
            m_rBest.Energy = m_uiMaxLength;

            current = new TSolution(m_uiMaxLength);
            current.CopySolution(GetCurrentSolution());
            current.Energy = GetEvaluateSolution();
            working.CopySolution(current.Solution);
            working.Energy = current.Energy;

            while (temperature>m_dbFinalTemperature)
            {
                for (int i = 0; i < m_uiStepPerChange; i++)
                {
                    isUseNew = false;
                    tweakSolution();
                   working.CopySolution(GetCurrentSolution());
                   working.Energy = GetEvaluateSolution();

                    if (working.Energy <= current.Energy)
                    {
                        isUseNew = true;
                    }
                    else
                    {
                        double random = m_rRand.NextDouble();
                        int delta = working.Energy - current.Energy;
                        double calc = Math.Exp(-delta / temperature);
                        if (calc > random)
                        {
                            isUseNew = true;
                        }
                    }
                    if (isUseNew)
                    {
                        isUseNew = false;
                        current.CopySolution(working.Solution);
                        current.Energy = working.Energy;
                        if (current.Energy < m_rBest.Energy)
                        {
                            m_rBest.CopySolution(current.Solution);
                            m_rBest.Energy = current.Energy;
                            if (m_rBest.Energy == 0)
                            {
                                isBestSolution = true;
                                break;
                            }                            
                        }
                    }
                    else {
                        working.CopySolution(current.Solution);
                        working.Energy = current.Energy;
                    }

                }
                temperature *= m_dbAlpha;
                if (isBestSolution)
                    break;
            }
            m_rBoard.SetSolution(m_rBest.Solution);
           
            return isBestSolution;
        }
        public string GetBoardInText()
        {
            return m_rBoard.GetBoardInText();
        }
        public void tweakSolution() {            
          
            int randFirst = m_rRand.Next(m_uiMaxLength),
            randSecond;
            do
            {               
                randSecond = m_rRand.Next(m_uiMaxLength);
            }
            while (randFirst == randSecond);
            m_rBoard.SwapQueens(randFirst, randSecond);            
        }
        public int GetEvaluateSolution() {
          
            return m_rBoard.GetCountOfConflicts();
        }
        public int[] GetCurrentSolution()
        {
            return m_rBoard.GetSolutionByColsNumber();
        }
        private void InitializeBoard()
        {
            m_rBoard = new CBoard(m_uiMaxLength);
            m_rRand = new Random();
            for (int i = 0; i < m_uiMaxLength; i++)
            {
                tweakSolution();
            }
        }
        private void ValidateInt(int num) {
            ValidateFloat(num);
        }
        private void ValidateFloat(double num)
        {
            if (num <= 0)
            {
                throw new FormatException("Данное число не может быть меньше 0");
            }
        }
        private void ValidateTemperatures(double initT,double finT)
        {
            ValidateFloat(initT);
            ValidateFloat(finT);
            if (finT>initT)
            {
                throw new FormatException("Некорректное отношение температур");
            }
        }
        private void ValidateAlpha(double num)
        {
            if (num <= 0.000 || num>=1.000)
            {
                throw new FormatException("Данное число должно быть в диапазоне от 0 до 1");
            }
        }

    }
}
