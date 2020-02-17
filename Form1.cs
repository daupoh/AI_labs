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
    public partial class FmSemanticNet : Form
    {
        CNetGenerator m_rNetGen;
        public FmSemanticNet()
        {
            InitializeComponent();
            m_rNetGen = new CNetGenerator();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SendRequest();
        }
        private void SendRequest()
        {
            if (TbxRequest.Text == "")
            {
                MessageBox.Show("Запрос не должен быть пустым.");
            }
            else
            {
                string sRequest = TbxRequest.Text,
                    sAnswer = "";
                sAnswer = m_rNetGen.Request(sRequest);
                TbxChat.Text += String.Format("{0}\r\n", sRequest);
                TbxChat.Text += String.Format("{0}\r\n", sAnswer);
                TbxRequest.Text = "";
                TbxChat.SelectionStart = TbxChat.Text.Length;
                TbxChat.ScrollToCaret();
            }
        }        

        private void TbxRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendRequest();
            }
        }
    }
}
