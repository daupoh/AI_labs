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
        public string[] FindAllFrameNames()
        {
            IList<string> aFrameNames = new List<string>();
            for (int i = 0; i < m_aFrames.Count; i++)
            {
                aFrameNames.Add(m_aFrames[i].Name);
            }
            return aFrameNames.ToArray();
        }
        public string[] FindAllSlotNamesByFrameName(string sFrameName)
        {
            IList<string> aSlotNames = new List<string>();
            CFrame rFrame = FindFrameByName(sFrameName);
            return rFrame.AllSlotNames();
        }
        public string Request(string sText)
        {
            string sAnswer = "";
            string[] aFrameNames = FindAllFrameNames();
            string sFrameAbout = "";
            int iFrameCounter = 0;
            for (int i = 0; i < aFrameNames.Length; i++)
            {
                if (sText.ToLower().Contains(aFrameNames[i].ToLower()))
                {
                    if (iFrameCounter < 1)
                    {
                        sFrameAbout = aFrameNames[i];
                        iFrameCounter++;
                    }
                    else
                    {
                        sAnswer = "Попробуйте сузить запрос до одного фрейма.";
                        break;
                    }
                }
            }
            if (sAnswer == "")
            {
                string[] aSlotNames = FindAllSlotNamesByFrameName(sFrameAbout);
                for (int i = 0; i < aSlotNames.Length; i++)
                {
                    if (sText.ToLower().Contains(aSlotNames[i].ToLower()))
                    {
                        sAnswer += FindFrameByName(sFrameAbout).FindSlotByName(aSlotNames[i]).Show;
                    }
                }
            }
            if (sAnswer == "")
            {
                sAnswer = "Не удалось найти во фрейме ни одного из указанных слотов. Проверьте фрейм.\r\n"
                    +FindFrameByName(sFrameAbout).Show;
            }
            return sAnswer;
        }

    }
}
