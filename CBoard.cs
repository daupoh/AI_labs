using System;

namespace wf_AI_lab1
{    
    class CBoard
    {
        private int m_iCountOfRows;
        private char[][] m_aFiguresLocation;
        public CBoard(int iCountOfRows)
        {
           
            CountOfRows = iCountOfRows;
            InitializeBoard();          
        } 
        public int CountOfRows
        {
            get
            {
                return m_iCountOfRows;
            }
            private set
            {             
                value.CompareTo(0).Equals(1);
                m_iCountOfRows = value;
            }
        }
        public void SwapQueens (int numFirst, int numSecond)
        {
            numFirst.CompareTo(-1).Equals(1);
            numSecond.CompareTo(-1).Equals(1);
            numFirst.CompareTo(CountOfRows).Equals(-1);
            numSecond.CompareTo(CountOfRows).Equals(-1);            
            char[] temp = m_aFiguresLocation[numFirst];
            m_aFiguresLocation[numFirst] = m_aFiguresLocation[numSecond];
            m_aFiguresLocation[numSecond] = temp;
        }
        public void SetSolution(int[] Solution)
        {
            ClearBoard();
            for (int i = 0; i < m_iCountOfRows; i++)
            {
                m_aFiguresLocation[i][Solution[i]] = 'Q';
            }
        }
        public int GetCountOfConflicts ()
        {
            int count = 0;
            for (int i = 0; i < m_iCountOfRows; i++)
            {
                count += CountOfDiagonalAtacks(i);
            }
            return count;
        }
        
        public int[] GetCurrentSolutionByCols() {
            int[] aSolution = new int[m_iCountOfRows];
            for (int i = 0; i < m_iCountOfRows; i++)
            {
                aSolution[i] = GetQueenColumnFromRow(i);            
            }
            return aSolution;
        }
        public override string ToString() {
            string boardInText = "";           
            for (int i = 0; i < m_iCountOfRows; i++)
            {               
                for (int j = 0; j < m_iCountOfRows; j++)
                {
                    boardInText += m_aFiguresLocation[i][j];
                } 
            }
            return boardInText;
        }
        private void ClearBoard()
        {
            for (int i = 0; i < m_iCountOfRows; i++)
            {
                for (int j = 0; j < m_iCountOfRows; j++)
                {
                    m_aFiguresLocation[i][j] = ' ';
                }               
            }
        }     
        private int CountOfDiagonalAtacks(int iAtackingRow)
        {
            int iCountAtacks = 0;        
            iAtackingRow.CompareTo(CountOfRows).Equals(1);
            iAtackingRow.CompareTo(CountOfRows).Equals(-1);
            int iAtackingColumn = GetQueenColumnFromRow(iAtackingRow);
            iCountAtacks += CountOfAtackOn(iAtackingRow, iAtackingColumn, 1, 1);
            iCountAtacks += CountOfAtackOn(iAtackingRow, iAtackingColumn, 1, -1);
            iCountAtacks += CountOfAtackOn(iAtackingRow, iAtackingColumn, -1, 1);
            iCountAtacks += CountOfAtackOn(iAtackingRow, iAtackingColumn, -1, -1);
            return iCountAtacks;
        }
        private int CountOfAtackOn(int iAtackingRow, int iAtackingColumn, int iDx, int iDy) {
            int iCountAtacks = 0;          
            int iRow = iAtackingRow+iDy, 
                iColumn = iAtackingColumn+iDx;

            while (iRow < m_iCountOfRows && iColumn < m_iCountOfRows
                && iRow>=0 && iColumn>=0) {
                if (IsQueen(iRow, iColumn)) {                   
                    iCountAtacks++;
                }
                iRow += iDy;
                iColumn += iDx;
            }
            return iCountAtacks;
        }
        private bool IsQueen(int numRow, int numCol) {
            return (m_aFiguresLocation[numRow][numCol] == 'Q');
        }
        private int GetQueenColumnFromRow(int numRow) {
            int numColumn = 0;
            for (int i = 0; i < m_iCountOfRows; i++)
            {
                if (IsQueen(numRow,i)) {
                    numColumn = i;
                    break;
                }
            }
            return numColumn;
        }
        private void InitializeBoard() {
            m_aFiguresLocation = new char[m_iCountOfRows][];
            for (int i = 0; i < m_iCountOfRows; i++)
            {
                m_aFiguresLocation[i] = new char[m_iCountOfRows];
                for (int j = 0; j < m_iCountOfRows; j++)
                {
                    m_aFiguresLocation[i][j] = ' ';                    
                }
                m_aFiguresLocation[i][i] = 'Q';
            }
        }       
    }
}