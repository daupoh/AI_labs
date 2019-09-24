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
        CAnnealing m_rAnnealing;
        double[] m_aDefaultVals = { 8, 100, 0.98, 0.5, 30.0 };
        int m_iMaxLen = 8, m_inSteps=100;
        double m_fAlpha=0.98, m_fInitTemp=30, m_fFinTemp=0.5;        
        public Form1()
        {           
            InitializeComponent();
            m_rAnnealing = new CAnnealing();
            DefaultValues();
        }
        private void BtnAnnealing_Click(object sender, EventArgs e)
        {
            SetAnnealingValues();
            StartAnnealing();
        }
        private void BtnDefault_Click(object sender, EventArgs e)
        {
            DefaultValues();
        }

        private void NumInitTemp_ValueChanged(object sender, EventArgs e)
        {
            CheckTemperatures();
        }

        private void NumFinTemp_ValueChanged(object sender, EventArgs e)
        {
            CheckTemperatures();
        }
        private void StartAnnealing()
        {
            gbxAnnealingParams.Enabled = false;
            bool isBestSolutionFinded = Annealing();
            if (isBestSolutionFinded)
            {
                MessageBox.Show("Найдено лучшее решение!");
            }
            else
            {
                MessageBox.Show("Не удалось найти решение задачи.");
            }
            FilTable();
            gbxAnnealingParams.Enabled = true;
        }
        private bool Annealing()
        {            
            m_rAnnealing.ReInitialize(m_iMaxLen, m_inSteps, m_fInitTemp, m_fFinTemp, m_fAlpha);
            bool isBestSolutionFinded = m_rAnnealing.Annealing();            
            return isBestSolutionFinded;
        }
        private void FilTable()
        {
            string text = m_rAnnealing.GetBoardInText();
            bool isCellWhite = true, isCellBlack = false; ;
            dgvBoardTable.Rows.Clear();
            dgvBoardTable.ColumnCount = m_iMaxLen;
            dgvBoardTable.RowCount = m_iMaxLen;
            for (int i = 0; i < m_iMaxLen; i++)
            {
                for (int j = 0; j < m_iMaxLen; j++)
                {
                    dgvBoardTable.Rows[i].Cells[j].Value = text[i * m_iMaxLen + j];
                    if (!isCellWhite)
                    {
                        dgvBoardTable.Rows[i].Cells[j].Style.BackColor = Color.SandyBrown;
                       
                    }
                    isCellWhite = !isCellWhite;
                }
                isCellWhite = isCellBlack;
                isCellBlack = !isCellBlack;
            }
            tbxBoardInText.Text += m_rAnnealing.GetEvaluateSolution().ToString() + "\r\n";
        }
        private void SetAnnealingValues()
        {
            m_iMaxLen = (int)numSizeBoard.Value;
            m_inSteps = (int)numCountOfSteps.Value;
            m_fAlpha= (double)numAlpha.Value;
            m_fInitTemp= (double)numInitTemp.Value;
            m_fFinTemp= (double)numFinTemp.Value;
        }
        private void DefaultValues()
        {
            numSizeBoard.Value = (int)m_aDefaultVals[0];
            numCountOfSteps.Value = (int)m_aDefaultVals[1];

            numAlpha.Value = (decimal)m_aDefaultVals[2];

            numFinTemp.Value = (decimal)m_aDefaultVals[3];
            numInitTemp.Value = (decimal)m_aDefaultVals[4];

        }        
       
        private void CheckTemperatures()
        {
            double max = (double)numInitTemp.Value,
                    min= (double)numFinTemp.Value;
            if (min > max) {
                numInitTemp.Value = (decimal)min;
                numFinTemp.Value = (decimal)min;
            }
        }
       
    }
}
