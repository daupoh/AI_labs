using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_AI_lab1
{
    public partial class Form1 : Form
    {
        CAnnealing annealing;
        int maxLen = 12;
        // CBoard board;
        public Form1()
        {
           
            InitializeComponent();
            annealing = new CAnnealing();
          //  board = new CBoard(8);
            dgvBoardTable.ColumnCount = maxLen;
            dgvBoardTable.RowCount = maxLen;
            
            annealing.Annealing();
            FilTable();
        }
        private void FilTable()
        {
            /*string text = board.GetBoardInText();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    dgvBoardTable.Rows[i].Cells[j].Value = text[i * 8 + j];
                    Debug.WriteLine(text[i * 8 + j]);
                }
            }
            tbxBoardInText.Text += board.GetCountOfConflicts().ToString() + "\r\n";*/
            string text = annealing.GetBoardInText();
            bool isCellWhite = true;
            for (int i = 0; i < maxLen; i++)
            {
                for (int j = 0; j < maxLen; j++)
                {
                    dgvBoardTable.Rows[i].Cells[j].Value = text[i * maxLen + j];
                    if (!isCellWhite)
                    {
                        dgvBoardTable.Rows[i].Cells[j].Style.BackColor = Color.SandyBrown;
                       
                    }
                    isCellWhite = !isCellWhite;
                }
                isCellWhite = !isCellWhite;
            }
            tbxBoardInText.Text += annealing.GetEvaluateSolution().ToString() + "\r\n";
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Annealing();
            
        }    
        private void Annealing()
        {
            annealing.Annealing();
            FilTable();
        }
    }
}
