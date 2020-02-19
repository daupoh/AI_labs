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
    public partial class FmAnts : Form
    {
        CLaw m_rLaw;
        CPathGraph m_rGraph;
        IList<CRunningAnt> m_aAnts = new List<CRunningAnt>();

        public FmAnts()
        {
            InitializeComponent();
            UpdateParameters();
        }
        private void UpdateParameters()
        {
            if (m_rLaw == null || m_rLaw.NetSize != NudVertexCount.Value)
            {
                m_rLaw = new CLaw((int)NudVertexCount.Value);
                m_rLaw.UpdateParameters((double)NudEsporation.Value, (double)NudDistancePower.Value,
                  (double)NudPheromonePower.Value, (int)NudAttractive.Value, (int)NudAntsCount.Value);
                m_rGraph = new CPathGraph(m_rLaw, (double)NudMaxDistance.Value);
            }
            m_rLaw.UpdateParameters((double)NudEsporation.Value, (double)NudDistancePower.Value,
                   (double)NudPheromonePower.Value, (int)NudAttractive.Value, (int)NudAntsCount.Value);
            m_rGraph.FlushPheromone();
            m_aAnts.Clear();
            int iStartPos = 0;
            for (int i = 0; i < m_rLaw.AntsCount; i++)
            {
                m_aAnts.Add(new CRunningAnt(m_rLaw, iStartPos, m_rGraph));
                iStartPos = (iStartPos + 1) % m_rLaw.NetSize;
            }

            TbxLog.Text = "";
            TbxLog.Text += TbxLog.Text += "-------- Граф путей----------- \r\n" +
                m_rGraph.ToString() + "\r\n";
            TbxLog.Text += "-------- Муравьи ----------- \r\n";
            for (int i = 0; i < m_rLaw.AntsCount; i++)
            {
                TbxLog.Text += String.Format("Муравей №{0} начинает с вершины {1}\r\n", i, m_aAnts[i].StartPos);
            }
            TbxLog.SelectionStart = TbxLog.TextLength;
            TbxLog.ScrollToCaret();
        }
        
        private void Run()
        {
            double fMin = double.MaxValue;
            string sMinPath = "";
            for (int i = 0; i < m_rLaw.AntsCount; i++)
            {
                m_aAnts[i].FirstRun();
                if (m_aAnts[i].CyclePath < fMin)
                {
                    fMin = m_aAnts[i].CyclePath;
                    sMinPath = m_aAnts[i].ToString();
                }
            }
            TbxLog.Text += "-------- Случайный выбор ----------- \r\n";
            ShowAntsPath( sMinPath);
            fMin = double.MaxValue;
            sMinPath = "";
            for (int j = 0; j < NudRepeatRun.Value; j++)
            {
                for (int i = 0; i < m_rLaw.AntsCount; i++)
                {
                    m_aAnts[i].SmartRun();
                    if (m_aAnts[i].CyclePath<fMin)
                    {
                        fMin = m_aAnts[i].CyclePath;
                        sMinPath = m_aAnts[i].ToString();
                    }
                }
            }
            TbxLog.Text += "-------- Выбор по феромонам ----------- \r\n";
            ShowAntsPath(sMinPath);

            TbxLog.SelectionStart = TbxLog.TextLength;
            TbxLog.ScrollToCaret();
        }       
        private void ShowAntsPath(string sMinPath)
        {
            for (int i = 0; i < m_rLaw.AntsCount; i++)
            {
                TbxLog.Text += m_aAnts[i].ToString();
            }
            TbxLog.Text += String.Format("Минимальный путь в забеге: {0}",sMinPath);
        }
        private void BtnFindPath_Click(object sender, EventArgs e)
        {
            UpdateParameters();
            Run();
        }
    }
}
