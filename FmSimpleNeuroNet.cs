using System;
using System.Drawing;
using System.Windows.Forms;

namespace wf_AI_lab1
{
    public partial class FmSimpleNeuroNet : Form
    {
        const int GRID_SIZE = 4, RESULTS_COUNT = 6;
        int[] m_aInputVector;
        double[] m_aResultVector;
        double m_fAges;
        int m_iProgresStep;
        CNetHandler m_rNetHandler;
        public FmSimpleNeuroNet()
        {
            InitializeComponent();
            ResizeDrawGrid(GRID_SIZE);
            m_aResultVector = new double[RESULTS_COUNT];
            SetResultVector(0);
        }
        private void DgvDraw_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseDrawing(e.Button, e.RowIndex, e.ColumnIndex);
        }

        private void DgvDraw_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseDrawing(e.Button, e.RowIndex, e.ColumnIndex);
        }      
        private void BtnClearDraw_Click(object sender, EventArgs e)
        {
            ClearDrawPanel();
        }
        private void ClearDrawPanel()
        {
            for (int i = 0; i < DgvDraw.RowCount; i++)
            {
                for (int j = 0; j < DgvDraw.ColumnCount; j++)
                {
                    DgvDraw[i, j].Style.BackColor = Color.White;
                }
            }
        }
        private void BtnToVector_Click(object sender, EventArgs e)
        {
            TbxInputVector.Text = GetInputVector();
            double[] aResults = m_rNetHandler.GetResult(m_aInputVector);
            string sResult = "{";
            for (int i = 0; i < aResults.Length-1; i++)
            {
                sResult+=Math.Round(aResults[i],4).ToString()+",";
            }
            sResult+= Math.Round(aResults[aResults.Length-1], 4).ToString() + "}";
            TbxInputVector.Text += "\r\n" + sResult + "\r\n";
        }

        private void FmSimpleNeuroNet_Shown(object sender, EventArgs e)
        {
            DgvDraw.ClearSelection();
        }

        private void BtnStartNet_Click(object sender, EventArgs e)
        {            
            StartNet();
            RbtnAnd.Checked = true;
            SetResultVector(0);
            ClearTetsCounts();
            BtnAnalyse.Enabled = true;
        }
        private void ClearTetsCounts()
        {
            NudAnd.Value = 0;
            NudOr.Value = 0;
            NudXor.Value = 0;
            NudNot.Value = 0;
            NudProp.Value = 0;
            NudEq.Value = 0;

        }
        private void StartNet()
        {
            string[] aTextNumbers = TbxLevelNeuronCounts.Text.Split(',');
            int[] aNumbers = new int[aTextNumbers.Length];
            try
            {
                for (int i = 0; i < aNumbers.Length; i++)
                {
                    aNumbers[i] = Convert.ToInt32(aTextNumbers[i]);
                }
                m_rNetHandler = new CNetHandler();
                m_rNetHandler.SimpleNet(GRID_SIZE* GRID_SIZE, RESULTS_COUNT, aNumbers);
                GbxTest.Enabled = true;

                TbxInputVector.Text += "_________________________________\r\n";
                TbxInputVector.Text += m_rNetHandler.State;
                TbxInputVector.Text += "\r\n";
                TbxInputVector.SelectionStart = TbxInputVector.Text.Length;
                TbxInputVector.ScrollToCaret();
            }
            catch
            {
                MessageBox.Show("Список количества нейронов в скрытых уровнях " +
                    "должен представлять собой набор целых чисел, разделенных запятой, например:\"8,4,4\"");
            }
        }
        private void ResizeDrawGrid(int iSize)
        {
            DgvDraw.RowCount = iSize;
            DgvDraw.ColumnCount = iSize;
            int iCellWidth = DgvDraw.Width / iSize,
                iCellHeight = DgvDraw.Height / iSize;
            m_aInputVector = new int[iSize * iSize];
            for (int i = 0; i < iSize; i++)
            {
                DgvDraw.Columns[i].Width = iCellWidth;
                DgvDraw.Rows[i].Height = iCellHeight;
                for (int j = 0; j < iSize; j++)
                {
                    DgvDraw[i,j].Style.BackColor = Color.White;
                    m_aInputVector[i * j + j] = 0;
                }
            }
        }
        private void UpdateInputVector()
        {
            for (int i = 0; i < DgvDraw.RowCount; i++)
            {
                for (int j = 0; j < DgvDraw.ColumnCount; j++)
                {
                    if (DgvDraw[j, i].Style.BackColor == Color.White)
                    {
                        m_aInputVector[i * DgvDraw.ColumnCount + j] = 0;
                    }
                    else
                    {
                        m_aInputVector[i * DgvDraw.ColumnCount + j] = 1;
                    }
                }
            }
        }
        private void DrawFromInputVector()
        {
            for (int i = 0; i < DgvDraw.RowCount; i++)
            {
                for (int j = 0; j < DgvDraw.ColumnCount; j++)
                {
                    if (m_aInputVector[i * DgvDraw.ColumnCount + j]==0)
                    {
                        DgvDraw[j, i].Style.BackColor = Color.White;
                    }
                    else
                    {
                        DgvDraw[j, i].Style.BackColor = Color.Black;
                    }
                }
            }
        }
        private string GetInputVector()
        {
            string sVector = "{";
            UpdateInputVector();
            for (int i = 0; i < m_aInputVector.Length-1; i++)
            {
                sVector += m_aInputVector[i].ToString()+',';
            }
            sVector += m_aInputVector[m_aInputVector.Length - 1].ToString() + '}';
            return sVector;
        }
      
        private void MouseDrawing(MouseButtons rMouseBtn, int iRowIndex, int iColumnIndex)
        {
            if (rMouseBtn == MouseButtons.Left)
            {
                DgvDraw[iColumnIndex, iRowIndex].Style.BackColor = Color.Black;
            }
            else if (rMouseBtn == MouseButtons.Right)
            {
                DgvDraw[iColumnIndex, iRowIndex].Style.BackColor = Color.White;
            }
            else
            {
                DgvDraw.ClearSelection();
            }
        }

        private void BtnLearnNet_Click(object sender, EventArgs e)
        {            
            PrbLearning.Value = 0;
            m_fAges = (double)NudAges.Value;
            m_iProgresStep = (int)Math.Round(m_fAges / 100);
            GbxDraw.Enabled = false;
            GbxSetting.Enabled = false;
            GbxTest.Enabled = false;
            NudAges.Enabled = false;
            BtnLearnNet.Enabled = false;
            TmrLearning.Start();
        }
        private void SetResultVector(int iIndex)
        {
            for (int i = 0; i < m_aResultVector.Length; i++)
            {
                m_aResultVector[i] = 0;
            }
            m_aResultVector[iIndex] = 1;
        }
        private void RbtnAnd_CheckedChanged(object sender, EventArgs e)
        {
            SetResultVector(0);
        }

        private void RbtOr_CheckedChanged(object sender, EventArgs e)
        {
            SetResultVector(1);
        }

        private void RbtXor_CheckedChanged(object sender, EventArgs e)
        {
            SetResultVector(2);
        }

        private void RbtNot_CheckedChanged(object sender, EventArgs e)
        {
            SetResultVector(3);
        }

        private void RbtProp_CheckedChanged(object sender, EventArgs e)
        {
            SetResultVector(4);
        }

        private void RbtEq_CheckedChanged(object sender, EventArgs e)
        {
            SetResultVector(5);
        }

        private void BtnAddTest_Click(object sender, EventArgs e)
        {
            if (m_aResultVector[0]==1)
            {
                NudAnd.Value++;
            }
            else if (m_aResultVector[1]==1){
                NudOr.Value++;
            }
            else if (m_aResultVector[2] == 1)
            {
                NudXor.Value++;
            }
            else if (m_aResultVector[3] == 1)
            {
                NudNot.Value++;
            }
            else if (m_aResultVector[4] == 1)
            {
                NudProp.Value++;
            }
            else if (m_aResultVector[5] == 1)
            {
                NudEq.Value++;
            }
            GetInputVector();
            m_rNetHandler.AddTest(m_aInputVector, m_aResultVector);
        }
        private void CopyToInputVector(int[] aNewVector)
        {
            for (int i = 0; i < aNewVector.Length; i++)
            {
                m_aInputVector[i] = aNewVector[i];
            }
        }
        private void BtnSymAnd_Click(object sender, EventArgs e)
        {
            int[] aSym = new int[64] { 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0,
                0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 1, 
                0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1 };
            CopyToInputVector(aSym);
            ClearDrawPanel();
            DrawFromInputVector();
        }

        private void BtnSymOr_Click(object sender, EventArgs e)
        {
            int[] aSym = new int[64] { 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 
                1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1,
                1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0 };
            CopyToInputVector(aSym);
            ClearDrawPanel();
            DrawFromInputVector();
        }

        private void BtnSymXor_Click(object sender, EventArgs e)
        {
            int[] aSym = new int[64] {0,0,1,1,1,1,0,0,0,1,0,1,1,0,1,0,1,0,0,1,1,0,0,
                                    1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,0,0,
                                    1,0,1,0,1,1,0,1,0,0,0,1,1,1,1,0,0};
            CopyToInputVector(aSym);
            ClearDrawPanel();
            DrawFromInputVector();
        }

        private void BtnSymNot_Click(object sender, EventArgs e)
        {
            int[] aSym = new int[64] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,
                1,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            CopyToInputVector(aSym);
            ClearDrawPanel();
            DrawFromInputVector();
        }

        private void BtnSymProp_Click(object sender, EventArgs e)
        {
            int[] aSym = new int[64] {0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,
                1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,
                1,1,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0};
            CopyToInputVector(aSym);
            ClearDrawPanel();
            DrawFromInputVector();
        }

        private void BtnSymEq_Click(object sender, EventArgs e)
        {
            int[] aSym = new int[64] {0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,
                1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
                1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0};
            CopyToInputVector(aSym);
            ClearDrawPanel();
            DrawFromInputVector();
        }

        private void TmrLearning_Tick(object sender, EventArgs e)
        {
            if (PrbLearning.Value<100)
            {
                for (int i = 0; i < m_iProgresStep; i++)
                {
                    m_rNetHandler.Learn(0.1);
                }                
                PrbLearning.Value += 100 / m_iProgresStep;
            }
            else
            {
                TmrLearning.Stop();
                PrbLearning.Value = 100;
                GbxDraw.Enabled = true;
                GbxSetting.Enabled = true;
                GbxTest.Enabled = true;
                NudAges.Enabled = true;
                BtnLearnNet.Enabled = true;
                TbxInputVector.Text += "_________________________________\r\n";
                TbxInputVector.Text += "_________LEARNING_______\r\n";
                TbxInputVector.Text += "_________________________________\r\n";
                TbxInputVector.Text += m_rNetHandler.State;
                TbxInputVector.Text += "\r\n";

                TbxInputVector.SelectionStart = TbxInputVector.Text.Length;
                TbxInputVector.ScrollToCaret();
            }
            
        }
    }
}
