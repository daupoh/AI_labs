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
    public partial class FmGenetic : Form
    {
        CLaw m_rLaw;
        CPathGraph m_rGraph;
        CGenetic m_rGenetic;
        public FmGenetic()
        {
            InitializeComponent();
            UpdateGenetic();
        }
        private void UpdateGenetic()
        {
            m_rLaw = new CLaw((int)NudPopulationSize.Value, (int)NudGensCount.Value);
            m_rLaw.UpdateParameters((double)NudCrossbreedingChance.Value, 
                (double)NudMutateChance.Value, (int)NudWaitCounter.Value);
            m_rGraph = new CPathGraph((int)NudGensCount.Value, (double)NudMaxDistance.Value);
            m_rGenetic = new CGenetic(m_rLaw, m_rGraph);
            m_rGenetic.InitializeGroup();
            TbxLog.Focus();
            TbxLog.Text = "";
            TbxLog.Text += TbxLog.Text += "-------- Граф путей----------- \r\n" +
                m_rGraph.ToString()+"\r\n";
            TbxLog.Text += "-------- Первая популяция----------- \r\n"+
                m_rGenetic.ShowPopulation()+"\r\n";
            TbxLog.SelectionStart = TbxLog.TextLength;
            TbxLog.ScrollToCaret();
        }
        private void Evolution()
        {
            while (m_rGenetic.IsNotEndOfEvolution())
            {
                m_rGenetic.Evolution();
            }
            CCombinatoricChromosome rBestChromosome = m_rGenetic.GetBestChromosome();
         
            TbxLog.Text += "Лучший путь " + rBestChromosome.ToString() + "\r\n";
            TbxLog.Text += "Длина пути " +m_rGraph.UpdateGrade(rBestChromosome) + "\r\n";
            TbxLog.SelectionStart = TbxLog.TextLength;
            TbxLog.ScrollToCaret();
        }
        private void BtnUpdateParameters_Click(object sender, EventArgs e)
        {
            UpdateGenetic();
        }

        private void BtnFindPath_Click(object sender, EventArgs e)
        {
            Evolution();
        }
    }
}
