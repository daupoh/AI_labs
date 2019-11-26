using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_AI_lab1
{
    public partial class FmAntAlg : Form
    {
        readonly CNet m_rNet;
        readonly IList<CAnt> m_aAnts;
        readonly Random m_rRand;
        public FmAntAlg()
        {
            InitializeComponent();
            m_aAnts = new List<CAnt>();
            m_rNet = new CNet();
            m_rRand = new Random();
        }

        private void BtnCreateNet_Click(object sender, EventArgs e)
        {
            CreateNet();
            ReadyToSTart();
        }
        private void BtnRandomNet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvNet.RowCount; i++)
            {
                for (int j = i; j < DgvNet.ColumnCount; j++)
                {
                    if (i != j)
                    {
                        double fVal = 0;
                        while (fVal==0)
                        {
                            fVal = Math.Truncate(m_rRand.NextDouble() * 100);
                        }
                        DgvNet.Rows[i].Cells[j].Value = fVal;
                        DgvNet.Rows[j].Cells[i].Value = DgvNet.Rows[i].Cells[j].Value;
                    }
                    else
                    {
                        DgvNet.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
            for (int i = 0; i < DgvAnts.RowCount; i++)
            {
                DgvAnts.Rows[i].Cells[0].Value = Math.Truncate(m_rRand.NextDouble() * ((m_rNet.CountOfVertex-1)*100)/100);
            }
            ReadyToSTart();
        }
        private void CreateNet()
        {
            double fEvaporation = (double)NudEvaporation.Value,
                    fDistancePower = (double)NudDistancePower.Value,
                    fPheromonePower = (double)NudPheromonePower.Value;
            int iVertexCount = (int)NudVertexCount.Value,
                iAntCount = (int)NudAntCount.Value,
                iAttractive = (int)NudAttractive.Value;

            m_rNet.Attraction = iAttractive;
            m_rNet.CountOfVertex = iVertexCount;
            m_rNet.DistancePower = fDistancePower;
            m_rNet.PheromonePower = fPheromonePower;
            m_rNet.Evaporation = fEvaporation;
            m_aAnts.Clear();
            for (int i = 0; i < iAntCount; i++)
            {
                m_aAnts.Add(new CAnt(m_rNet));
            }
            CreateNetTable();
            CreateAntsTable();
        }
        private void CreateNetTable()
        {
            GbxNet.Enabled = true;
            DgvNet.Rows.Clear();
            DgvNet.ColumnCount = m_rNet.CountOfVertex;
            DgvNet.RowCount = m_rNet.CountOfVertex;
            for (int i = 0; i < m_rNet.CountOfVertex; i++)
            {
                DgvNet.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                DgvNet.Columns[i].HeaderText = "Вершина " + i.ToString();
                DgvNet.Rows[i].HeaderCell.Value = "Вершина " + i.ToString();
                for (int j = 0; j < m_rNet.CountOfVertex; j++)
                {
                    DgvNet.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void CreateAntsTable()
        {
            GbxAnts.Enabled = true;
            DgvAnts.Rows.Clear();
            DgvAnts.ColumnCount = 2;            
            DgvAnts.Columns[0].HeaderText = "Стартовая вершина";
            DgvAnts.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvAnts.Columns[1].HeaderText = "Путь";
            DgvAnts.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DgvAnts.Columns[1].ReadOnly = true;
            DgvAnts.RowCount = m_aAnts.Count();
            for (int i = 0; i < m_aAnts.Count(); i++)
            {
                
                DgvAnts.Rows[i].HeaderCell.Value = "Муравей " + i.ToString();
                DgvAnts.Rows[i].Cells[0].Value = 0;
            }

        }

        private void DgvNet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {            
            DgvNet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = OnlyNumbers((string)DgvNet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,0);
            ReadyToSTart();
        }
        private void DgvAnts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DgvAnts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = OnlyNumbers((string)DgvAnts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,1);
                if (Convert.ToInt32(DgvAnts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)>m_rNet.CountOfVertex) 
                {
                    DgvAnts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = m_rNet.CountOfVertex;
                }
            }
            ReadyToSTart();
        }
        private string OnlyNumbers(string sSomeStr, int iBorder)
        {
            string sNumbers = "";
            int iCounter = 0;
            bool bRealNumber = true;
            for (int i = 0; i < sSomeStr.Length; i++)
            {
                if (Char.IsNumber(sSomeStr[i]))
                {
                    sNumbers += sSomeStr[i];
                    if (iBorder > 0)
                    {
                        if (iCounter == iBorder)
                        {
                            break;
                        }
                        iCounter++;
                    }
                }
                else if (sSomeStr[i]==',' && bRealNumber && i>0)
                {
                    sNumbers += sSomeStr[i];
                    bRealNumber = false;
                }
            }
            if ((sNumbers.Length>0 && sNumbers[sNumbers.Length-1]==',') || sNumbers.Length == 0)
            {
                sNumbers += '0';
            }
            return sNumbers;
        }
        private void ReadyToSTart()
        {
            bool bIsReady = true;
            for (int i = 0; i < DgvNet.RowCount; i++)
            {
                for (int j = i; j < DgvNet.ColumnCount; j++)
                {
                    if (i != j)
                    {
                        bIsReady = bIsReady && (Convert.ToDouble(DgvNet.Rows[i].Cells[j].Value) > 0);
                        bIsReady = bIsReady && DgvNet.Rows[j].Cells[i].Value.Equals(DgvNet.Rows[i].Cells[j].Value);
                    }
                    else
                    {
                        bIsReady = bIsReady && DgvNet.Rows[j].Cells[i].Value.Equals(0);
                    }
                }
            }
            for (int i = 0; i < DgvAnts.RowCount; i++)
            {
                bIsReady = bIsReady && Convert.ToDouble(DgvAnts.Rows[i].Cells[0].Value)>=0;
            }
            if (bIsReady)
            {
                BtnStart.Enabled = true;
            }
            else
            {
                BtnStart.Enabled = false;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            double[][] aDistanceMatrix = new double[m_rNet.CountOfVertex][];
            for (int i = 0; i < m_rNet.CountOfVertex; i++)
            {
                aDistanceMatrix[i] = new double[m_rNet.CountOfVertex];
                for (int j = 0; j < m_rNet.CountOfVertex; j++)
                {
                    aDistanceMatrix[i][j] = Convert.ToDouble(DgvNet.Rows[i].Cells[j].Value);
                }
            }
            m_rNet.SetRibs(aDistanceMatrix);
            for (int i = 0; i < m_aAnts.Count; i++)
            {
                m_aAnts[i].StartPos = Convert.ToInt32(DgvAnts.Rows[i].Cells[0].Value);
                m_aAnts[i].PrepareToRun();
                m_aAnts[i].Run(m_rNet.PheromonePower,m_rNet.DistancePower);
                int[] aPath = m_aAnts[i].Path;
                m_rNet.UpdatePheromones(aPath);
                string sPath = "{";
                for (int j = 0; j < aPath.Length-1; j++)
                {
                    sPath += aPath[j].ToString() + ',';
                }
                sPath += aPath[aPath.Length - 1].ToString() + '}';
                DgvAnts.Rows[i].Cells[1].Value = sPath;
            }
        }
    }
}
