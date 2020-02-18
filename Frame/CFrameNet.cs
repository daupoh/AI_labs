using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1.Frame
{
    class CFrameNet
    {
        IList<CFrame> m_aFrames;
        public CFrameNet()
        {
            m_aFrames = new List<CFrame>();
        }
        public void AddFrame(CFrame rFrame)
        {
            if (rFrame!=null)
            {
                m_aFrames.Add(rFrame);
            }
            else
            {
                throw new FormatException();
            }
        }
        public CFrame FindFrameByName(string sName)
        {
            CFrame rFindedFrame = null;
            foreach (CFrame rFrame in m_aFrames)
            {
                if (rFrame.Name == sName)
                {
                    rFindedFrame = rFrame;
                    break;
                }
            }
            return rFindedFrame;
        }
    }
}
