using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab2
{
    class CAdaptiveResonance
    {
        int m_iMaxOfClusters=10, m_iVectorLength=11, m_iBeta=1;
        double m_fAttention=0.9;
        readonly IList<CBinVector> m_aVectorSigns;
        readonly IList<CCluster> m_aClusters;

        public int MaxClusters
        {
            get
            {
                return m_iMaxOfClusters;
            }
            set
            {
                Assert.IsTrue(value>0);
                m_iMaxOfClusters = value;
            }
        }
        public int VectorLength
        {
            get
            {
                return m_iVectorLength;
            }
            set
            {
                Assert.IsTrue(value > 1);
                m_iVectorLength = value;
            }
        }
        public int Beta
        {
            get
            {
                return m_iBeta;
            }
            set
            {
                Assert.IsTrue(value > 0 && value<10);
                m_iBeta= value;
            }
        }
        public double Attention
        {
            get
            {
                return m_fAttention;
            }
            set
            {
                Assert.IsTrue(value > 0 && value < 1.0);
                m_fAttention= value;
            }
        }

        public CAdaptiveResonance()
        {            
            m_aVectorSigns = new List<CBinVector>();
            m_aClusters = new List<CCluster>();
        }
        public void ClearVectors()
        {
            m_aVectorSigns.Clear();
            m_aClusters.Clear();
        }
        public CBinVector GetVectorSign(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorSigns.Count);
            return m_aVectorSigns[iVectorIndex];
        }
        public CBinVector[] GetSignsFromCluster(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aClusters.Count);
            return m_aClusters[iVectorIndex].GetSigns();
        }
        public CCluster[] GetClusters()
        {
            return m_aClusters.ToArray();
        }
        public CBinVector GetVectorPrototype(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aClusters.Count);
            return m_aClusters[iVectorIndex].PrototypeVector;
        }
        public void UpdateVectorSign(int iVectorIndex,string sCode)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorSigns.Count);
            CBinVector rNewVector = new CBinVector(sCode);
            m_aVectorSigns[iVectorIndex].Copy(rNewVector);
        }
        public void DeleteVectorSign(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorSigns.Count);
            m_aVectorSigns.RemoveAt(iVectorIndex);
        }
        public void UpdateVectorPrototype(int iVectorIndex, string sCode)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aClusters.Count);
            CBinVector rNewVector = new CBinVector(sCode);
            m_aClusters[iVectorIndex].PrototypeVector.Copy(rNewVector);
        }
        public void DeleteVectorPrototype(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aClusters.Count);
            m_aClusters.RemoveAt(iVectorIndex);
        }
        public void Resonance()
        {
            Assert.IsTrue(m_aVectorSigns.Count > 0);
            if (m_aClusters.Count == 0)
            {
                m_aClusters.Add(new CCluster(m_aVectorSigns[0]));
            }
            foreach (CBinVector rVectorSign in m_aVectorSigns)
            {
                bool bSignAddedToCluster = false;
                foreach (CCluster rCluster in m_aClusters)
                {
                    if (CheckSimilarity(rVectorSign, rCluster.PrototypeVector))
                    {
                        if (CheckAttention(rVectorSign, rCluster.PrototypeVector))
                        {
                            rCluster.AddVectorSign(rVectorSign);
                            bSignAddedToCluster = true;
                            break;
                        }
                    }
                }
                if (!bSignAddedToCluster)
                {
                    Assert.IsTrue(m_aClusters.Count < MaxClusters,"Достигнуто максимальное количество кластеров. " +
                        "Невозможно создать еще один кластер.");
                    m_aClusters.Add(new CCluster(rVectorSign));
                    m_aClusters[m_aClusters.Count - 1].AddVectorSign(rVectorSign);
                }
            }
        }
        public void AddVectorSign(string sVector)
        {            
            m_aVectorSigns.Add(CheckAddedVector(sVector));            
        }
        public void AddVectorPrototype(string sVector)
        {
            m_aClusters.Add(new CCluster(CheckAddedVector(sVector)));
        }
        
        private bool CheckSimilarity(CBinVector rVectorSign, CBinVector rVectorPrototype)
        {
            CBinVector rTempVector = rVectorPrototype.Clone();
            rTempVector.MultVector(rVectorSign);
            bool bResult = ((double)rTempVector.Relevance / (Beta + rVectorPrototype.Relevance)) > ((double)rVectorSign.Relevance / (Beta + VectorLength));
            Console.WriteLine(rTempVector.Relevance.ToString()+" / "+(Beta + rVectorPrototype.Relevance).ToString()+
                " > "+rVectorSign.Relevance.ToString()+" / "+(Beta + VectorLength).ToString()+" is "+bResult.ToString());
            return bResult;
        }
        private bool CheckAttention(CBinVector rVectorSign, CBinVector rVectorPrototype)
        {
            CBinVector rTempVector = rVectorPrototype.Clone();
            rTempVector.MultVector(rVectorSign);
            bool bResult = ((double)rTempVector.Relevance / rVectorSign.Relevance) < Attention;
            Console.WriteLine(rTempVector.Relevance.ToString() + " / " + rVectorSign.Relevance.ToString() +
                " < " + Attention.ToString() + " is " + bResult.ToString());
            return bResult;
        }
        private CBinVector CheckAddedVector(string sVector)
        {
            CBinVector rVector = new CBinVector(sVector);
            Assert.IsTrue(rVector.Length == m_iVectorLength);
            return rVector;
        }
    }
}
