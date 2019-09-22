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
        public Form1()
        {
            InitializeComponent();
            annealing = new CAnnealing();
            tbxBoardInText.Text = annealing.GetBoardInText();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Tweak();
        }
        private void Tweak() {

            annealing.tweakSolution();
            Debug.WriteLine(annealing.GetBoardInText());
            tbxBoardInText.Text  = annealing.GetBoardInText();
            
        }
    }
}
