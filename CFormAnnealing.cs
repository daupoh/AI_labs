using System;
using System.Drawing;
using System.Windows.Forms;

namespace wf_AI_lab1
{
    public partial class CFormAnnealing : Form
    {
        readonly CAnnealing m_rAnnealing;
        readonly double[] m_aDefaultVals = { 8, 100, 0.98, 0.5, 30.0 };
        
        public CFormAnnealing()
        {           
            InitializeComponent();
            DefaultValues();
            m_rAnnealing = new CAnnealing((int)m_rNumSizeBoard.Value,(int)m_rNumCountOfSteps.Value,(double)m_rNumInitTemp.Value,
                (double)m_rNumFinTemp.Value, (double)m_rNumAlpha.Value);            
        }
        private void BtnAnnealing_Click(object sender, EventArgs e)
        {
            StartAnnealing();
            m_rTbxBoardInText.Text += "_______________________";
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
            int iMaxLen = (int)m_rNumSizeBoard.Value;
            int inSteps = (int)m_rNumCountOfSteps.Value;
            double fAlpha = (double)m_rNumAlpha.Value;
            double fInitTemp = (double)m_rNumInitTemp.Value;
            double fFinTemp = (double)m_rNumFinTemp.Value;

            m_rAnnealing.ReInitialize(iMaxLen, inSteps, fInitTemp, fFinTemp, fAlpha);
            try
            {
                bool isBestSolutionFinded = m_rAnnealing.Annealing();
                if (isBestSolutionFinded)
                {
                    MessageBox.Show("Найдено лучшее решение!");
                }
                else
                {
                    MessageBox.Show("Не удалось найти решение задачи.");
                }
                FilTable(iMaxLen);
                m_rTbxBoardInText.Text = m_rAnnealing.LogLines;
                gbxAnnealingParams.Enabled = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }        
        private void FilTable(int iMaxLen)
        {
            string sBoard = m_rAnnealing.GetBoardInText();
            bool bIsCellWhite = true, bIsCellBlack = false; ;
            m_rDgvBoardTable.Rows.Clear();
            m_rDgvBoardTable.ColumnCount = iMaxLen;
            m_rDgvBoardTable.RowCount = iMaxLen;
            for (int i = 0; i < iMaxLen; i++)
            {
                for (int j = 0; j < iMaxLen; j++)
                {
                    m_rDgvBoardTable.Rows[i].Cells[j].Value = sBoard[i * iMaxLen + j];
                    if (!bIsCellWhite)
                    {
                        m_rDgvBoardTable.Rows[i].Cells[j].Style.BackColor = Color.SandyBrown;
                       
                    }
                    bIsCellWhite = !bIsCellWhite;
                }
                bIsCellWhite = bIsCellBlack;
                bIsCellBlack = !bIsCellBlack;
            }           
        }        
        private void DefaultValues()
        {
            m_rNumSizeBoard.Value = (int)m_aDefaultVals[0];
            m_rNumCountOfSteps.Value = (int)m_aDefaultVals[1];

            m_rNumAlpha.Value = (decimal)m_aDefaultVals[2];

            m_rNumFinTemp.Value = (decimal)m_aDefaultVals[3];
            m_rNumInitTemp.Value = (decimal)m_aDefaultVals[4];

        }               
        private void CheckTemperatures()
        {
            double max = (double)m_rNumInitTemp.Value,
                    min= (double)m_rNumFinTemp.Value;
            if (min > max) {
                m_rNumInitTemp.Value = (decimal)min;
                m_rNumFinTemp.Value = (decimal)min;
            }
        }
       
    }
}
