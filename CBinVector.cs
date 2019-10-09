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
        Int64 m_iBits;
        public int Length
        {
            get
            {
                return m_iLength;
            }
            private set
            {
                Assert.IsTrue(value.CompareTo(0).Equals(1));
                m_iLength = value;
            }
        }
        public long Number
        {
            get { return m_iBits; }
            private set
            {
                Assert.IsTrue(value.CompareTo(0).Equals(1));
                m_iBits = value;
            }
        }
        public CBinVector(string sVector)
        {
            int iLength = sVector.Length;
            Length = iLength;
            CheckStringVector(sVector);
            m_iBits = 0;
            for (int i = 0; i < iLength; i++)
            {
                char c = sVector[iLength - i - 1];
                if (c == '1')
                {
                    m_iBits += (long)Math.Pow(2, i);
                }
            }
        }
        public void MultVector(CBinVector rVector)
        {
            CheckNumberVectorLength(rVector.Number);
            Number &= rVector.Number;
        }
        public override string ToString()
        {
            string sVector = "";
            long iIntPart = Number, iRest;           
            while (iIntPart != 0)
            {
                iRest = iIntPart % 2;
                iIntPart /= 2;                
                sVector = iRest.ToString()+ sVector;
            }
            iRest = iIntPart % 2;
            if (iRest.Equals(1))
            {
                sVector = iRest.ToString() + sVector;
            }
            return sVector;
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
            Assert.IsTrue(iLength.Equals(Length));
        }
    }
}
