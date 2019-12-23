using System;
using System.Drawing;
using System.Windows.Forms;

namespace wf_AI_lab1
{
    public partial class FmSimpleNeuroNet : Form
    {
        int[] m_aInputVector;        
        public FmSimpleNeuroNet()
        {
            InitializeComponent();
            ResizeDrawGrid(3);
           
        }
        private void RbnField3_CheckedChanged(object sender, EventArgs e)
        {
            ResizeDrawGrid(3);
        }

        private void RbnField8_CheckedChanged(object sender, EventArgs e)
        {
            ResizeDrawGrid(8);
        }

        private void RbnField15_CheckedChanged(object sender, EventArgs e)
        {
            ResizeDrawGrid(15);
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
          
        }

        private void FmSimpleNeuroNet_Shown(object sender, EventArgs e)
        {
            DgvDraw.ClearSelection();
        }

        private void BtnStartNet_Click(object sender, EventArgs e)
        {

            StartNet();

            TbxInputVector.SelectionStart = TbxInputVector.Text.Length;
            TbxInputVector.ScrollToCaret();
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
        private string GetInputVector()
        {
            string sVector = "{";
            for (int i = 0; i < DgvDraw.RowCount; i++)
            {
                for (int j = 0; j < DgvDraw.ColumnCount; j++)
                {
                    if (DgvDraw[j,i].Style.BackColor==Color.White)
                    {
                        m_aInputVector[i * DgvDraw.ColumnCount + j] = 0;
                    }
                    else
                    {
                        m_aInputVector[i * DgvDraw.ColumnCount + j] = 1;
                    }
                }
            }
            for (int i = 0; i < m_aInputVector.Length-1; i++)
            {
                sVector += m_aInputVector[i].ToString()+',';
            }
            sVector += m_aInputVector[m_aInputVector.Length - 1].ToString() + '}';
            return sVector;
        }
        private void StartNet()
        { 
            TbxInputVector.Text += "_________________________________\r\n";
           
            TbxInputVector.Text +="\r\n";
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
            //
        }
    }
}
