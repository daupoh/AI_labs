using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{    
    class CBoard
    {
        private uint m_uiCountOfRows;
        private char[][] m_aFiguresLocation;
        public CBoard(int countOfRows)
        {
            ValidateCountOfRow(countOfRows);
            m_uiCountOfRows = (uint)countOfRows;
            InitializeBoard();
            PutQueensOnBoard();
        } 
        public void SwapQueens (int numFirst, int numSecond)
        {           
            //Debug.WriteLine("Swap Queens from "+numFirst.ToString() + " to "+numSecond.ToString());
            ValidateNumberOfRow(numFirst);
            ValidateNumberOfRow(numSecond);
            char[] temp = m_aFiguresLocation[numFirst];
            m_aFiguresLocation[numFirst] = m_aFiguresLocation[numSecond];
            m_aFiguresLocation[numSecond] = temp;
        }
        public void SetSolution(int[] Solution)
        {
            ClearBoard();
            for (int i = 0; i < m_uiCountOfRows; i++)
            {
                m_aFiguresLocation[i][Solution[i]] = 'Q';
            }
        }
        public int CountOfDiagonalAtacks(int numAtackingRow) {
            int countAtacks = 0;
            ValidateNumberOfRow(numAtackingRow);
            int numAtackingColumn = GetQueenColumnFromRow(numAtackingRow);
            countAtacks += CountOfAtackOn(numAtackingRow, numAtackingColumn, 1, 1);

            countAtacks += CountOfAtackOn(numAtackingRow, numAtackingColumn, 1, -1);
            countAtacks += CountOfAtackOn(numAtackingRow, numAtackingColumn, -1, 1);
            countAtacks += CountOfAtackOn(numAtackingRow, numAtackingColumn, -1, -1);
            return countAtacks;
        }
        public int[] GetSolutionByColsNumber() {
            int[] solution = new int[m_uiCountOfRows];
            for (int i = 0; i < m_uiCountOfRows; i++)
            {
                solution[i] = GetQueenColumnFromRow(i);            
            }
            return solution;
        }
        public string GetBoardInText() {
            string boardInText = "";
            int count = 0;
            for (int i = 0; i < m_uiCountOfRows; i++)
            {
               
                for (int j = 0; j < m_uiCountOfRows; j++)
                {
                    boardInText += m_aFiguresLocation[i][j];
                }
                boardInText += "\r\n";
               
                for (int j = 0; j < m_uiCountOfRows; j++)
                {
                    count += CountOfDiagonalAtacks(j);
                }
                
            }
            boardInText += count.ToString();
            return boardInText;
        }
        private void ClearBoard()
        {
            for (int i = 0; i < m_uiCountOfRows; i++)
            {
                for (int j = 0; j < m_uiCountOfRows; j++)
                {
                    m_aFiguresLocation[i][j] = '#';
                }
               
            }
        }
        private void ValidateCountOfRow(int countOfRows) {
            if (countOfRows <= 0) {
                throw new FormatException("Число строк шахматной " +
                    "доски не может быть меньше или равно 0");
            }
        }
        private void ValidateNumberOfRow(int numRow)
        {
            if (numRow < 0 || numRow == m_uiCountOfRows)
            {
                throw new FormatException("Номер строки шахматной " +
                    "доски не может быть меньше 0 или больше "+ (m_uiCountOfRows-1).ToString());
            }
        }       

        private int CountOfAtackOn(int numAtackingRow, int numAtackingColumn, int dx, int dy) {
            int countAtacks = 0;          
            int indexRow = numAtackingRow+dy, 
                indexColumn = numAtackingColumn+dx;

            while (indexRow < m_uiCountOfRows && indexColumn < m_uiCountOfRows
                && indexRow>=0 && indexColumn>=0) {
                if (IsQueen(indexRow, indexColumn)) {
                    Debug.WriteLine("Queen on "+ indexRow.ToString()+ " " + indexColumn.ToString());
                    countAtacks++;
                }
                indexRow += dy;
                indexColumn += dx;
            }
           /* Debug.WriteLine("From " + numAtackingRow.ToString() + " and "
                + numAtackingColumn.ToString() + " direction " +
                dx.ToString() + ":" + dy.ToString() + " makes: " + countAtacks.ToString());*/
            return countAtacks;
        }
        private bool IsQueen(int numRow, int numCol) {

            return (m_aFiguresLocation[numRow][numCol] == 'Q');

        }
        private int GetQueenColumnFromRow(int numRow) {
            int numColumn = 0;
            for (int i = 0; i < m_uiCountOfRows; i++)
            {
                if (m_aFiguresLocation[numRow][i] == 'Q') {
                    numColumn = i;
                    break;
                }
            }
            return numColumn;
        }
        private void InitializeBoard() {
            m_aFiguresLocation = new char[m_uiCountOfRows][];
            for (int i = 0; i < m_uiCountOfRows; i++)
            {
                m_aFiguresLocation[i] = new char[m_uiCountOfRows];
                for (int j = 0; j < m_uiCountOfRows; j++)
                {
                    m_aFiguresLocation[i][j] = '#';
                }
            }
        }
        private void PutQueensOnBoard() {
            for (int i = 0; i < m_uiCountOfRows; i++)
            {
                m_aFiguresLocation[i][i] = 'Q';
            }
        }
    }
}
