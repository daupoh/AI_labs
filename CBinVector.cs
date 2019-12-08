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
        string m_sCode, m_sName;
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
        public string Name
        {
            get
            {
                return m_sName+'('+Code+')';
            }
            private set
            {
                Assert.IsTrue(value.Length > 0);
                m_sName = value;
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
                Assert.IsTrue(value>=0);
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
        public CBinVector(string sVector, string sName)
        {
            Length = sVector.Length;
            Code = sVector;
            Name = sName;
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
            return new CBinVector(Code,Name);
        }
        public void Copy(CBinVector rCopied)
        {
            Assert.IsTrue(rCopied.Length == Length);
            m_iBits = rCopied.Number;
            m_sCode = rCopied.Code;
        }
        public void MultVector(CBinVector rVector)
        {
            Assert.IsTrue(rVector.Length == Length);
            string sNewCode = "";
            for (int i = 0; i < Length; i++)
            {
                if (Code[i]=='1' && rVector.Code[i]=='1')
                {
                    sNewCode += '1';
                }
                else
                {
                    sNewCode += '0';
                }
            }
            m_sCode = sNewCode;
            Number &= rVector.Number;
        }       
        private void CheckStringVector(string sVector)
        {
            foreach(char c in sVector)
            {
                Assert.IsTrue((c == '1') || (c == '0'));
            }
        }
    }
}
