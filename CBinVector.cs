using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab2
{
    class CBinVector
    {
        int m_iLength;
        long m_iBits;
        string m_sCode;
        public string Code
        {
            get
            {
                return m_sCode;
            }
            private set
            {
                CheckStringVector(value);
                m_sCode = value;
            }
        }
        public int Length
        {
            get
            {
                return m_iLength;
            }
            private set
            {
                Assert.IsTrue(value>0);
                m_iLength = value;
            }
        }
        public long Number
        {
            get { return m_iBits; }
            private set
            {
                Assert.IsTrue(value>0);
                m_iBits = value;
            }
        }
        public int Relevance
        {
            get
            {
                int iCountOfOne = 0;
                for (int i = 0; i < m_sCode.Length; i++)
                {
                    if (m_sCode[i] == '1')
                    {
                        iCountOfOne++;
                    }
                }
                return iCountOfOne;
            }
        }
        public CBinVector(string sVector)
        {
            Length = sVector.Length;
            Code = sVector;            
            m_iBits = 0;
            for (int i = 0; i < Length; i++)
            {
                char c = sVector[Length - i - 1];
                if (c == '1')
                {
                    m_iBits += (long)Math.Pow(2, i);
                }
            }
        }
        public CBinVector Clone()
        {
            return new CBinVector(Code);
        }
        public void Copy(CBinVector rCopied)
        {
            Assert.IsTrue(rCopied.Length == Length);
            m_iBits = rCopied.Number;
            m_sCode = rCopied.Code;
        }
        public void MultVector(CBinVector rVector)
        {
            CheckNumberVectorLength(rVector.Number);
            Number &= rVector.Number;
            UpdateCode();
        }
        private void UpdateCode()
        {
            string sVector = "";
            long iIntPart = Number, iRest;
            while (iIntPart != 0)
            {
                iRest = iIntPart % 2;
                iIntPart /= 2;
                sVector = iRest.ToString() + sVector;
            }
            iRest = iIntPart % 2;
            if (iRest == 1)
            {
                sVector = iRest.ToString() + sVector;
            }
            m_sCode = sVector;
        }
        private void CheckStringVector(string sVector)
        {
            foreach(char c in sVector)
            {
                Assert.IsTrue((c == '1') || (c == '0'));
            }
        }
        private void CheckNumberVectorLength(long iNumber)
        {
            int iLength = 1;
            long iIntPart = iNumber / 2;
            while (iIntPart!=0)
            {
                iIntPart /= 2;
                iLength++;
            }
            Assert.IsTrue(iLength==Length);
        }
    }
}
