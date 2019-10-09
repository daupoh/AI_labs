using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_AI_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                CBinVector rVector = new CBinVector("1010101010011");
                Console.WriteLine(rVector.Number);
                Console.WriteLine(rVector.ToString());

                CBinVector rAnotherVector = new CBinVector("1001000010101");
                Console.WriteLine(rAnotherVector.Number);

                rVector.MultVector(rAnotherVector);
                Console.WriteLine(rVector.Number);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
