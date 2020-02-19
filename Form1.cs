using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf_AI_lab1.Frame;

namespace wf_AI_lab1
{
    public partial class FmSemanticNet : Form
    {
        CFrameNet m_rNetGen;
        string sLastRequest = "Все";
        public FmSemanticNet()
        {
            InitializeComponent();
            m_rNetGen = new CFrameNet();
            
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
                sLastRequest = sRequest;
                sAnswer = m_rNetGen.Request(sRequest);
                TbxChat.Text += String.Format("*** НОВЫЙ ЗАПРОС ***\r\n{0}\r\n*** ОТВЕТ ***\r\n", sRequest);
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
            if (e.KeyCode ==Keys.Up)
            {
                TbxRequest.Text = sLastRequest;
            }
        }

        private void TbxChat_Enter(object sender, EventArgs e)
        {
            TbxChat.SelectionStart = 0;
            
        }
    }
}
