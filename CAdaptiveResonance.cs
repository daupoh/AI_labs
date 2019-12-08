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
        int m_iMaxOfClusters=10, m_iVectorLength=11, m_iBeta=1, m_iSignCounter, m_iPrototypeCounter,m_iClusterCounter;
        double m_fAttention=0.9;
        readonly IList<CBinVector> m_aVectorSigns,m_aVectorPrototypes;
        readonly IList<CCluster> m_aClusters;
        string m_sLog="";
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
        public string Log
        {
            get
            {
                return m_sLog;
            }            
            set
            {
                m_sLog = value+ "\r\n";
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
            m_aVectorPrototypes = new List<CBinVector>();
            m_iSignCounter = 0;
            m_iPrototypeCounter = 0;
            m_aClusters = new List<CCluster>();
        }
        public void ClearVectors()
        {
            m_aVectorSigns.Clear();
            m_aVectorPrototypes.Clear();
            m_iSignCounter = 0;
            m_iPrototypeCounter = 0;
           m_sLog = "";
        }
        public void ClearClusters()
        {
            m_aClusters.Clear();
            m_iClusterCounter = 0;
        }
        public CBinVector GetVectorSign(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorSigns.Count);
            return m_aVectorSigns[iVectorIndex];
        }
        public CBinVector GetVectorPrototype(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorPrototypes.Count);
            return m_aVectorPrototypes[iVectorIndex];
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
        public void UpdateVectorSign(int iVectorIndex,string sCode)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorSigns.Count);
            CBinVector rNewVector = new CBinVector(sCode, m_aVectorSigns[iVectorIndex].Name);
            m_aVectorSigns[iVectorIndex].Copy(rNewVector);
        }
        public void DeleteVectorSign(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorSigns.Count);
            m_aVectorSigns.RemoveAt(iVectorIndex);
        }
        public void UpdateVectorPrototype(int iVectorIndex, string sCode)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorPrototypes.Count);
            CBinVector rNewVector = new CBinVector(sCode, m_aVectorPrototypes[iVectorIndex].Name);
            m_aVectorPrototypes[iVectorIndex].Copy(rNewVector);
        }
        public void DeleteVectorPrototype(int iVectorIndex)
        {
            Assert.IsTrue(iVectorIndex > -1 && iVectorIndex < m_aVectorPrototypes.Count);
            m_aVectorPrototypes.RemoveAt(iVectorIndex);
        }
        public void Resonance()
        {
            Assert.IsTrue(m_aVectorSigns.Count > 0,"Количество векторов признаком не может быть равно 0.");
            AddPrototypesToClusters();
            if (m_aClusters.Count == 0)
            {
                string sName = "Кластер #" + m_iClusterCounter++;
                m_aClusters.Add(new CCluster(m_aVectorSigns[0], sName));
            }
            int iSteps = 0;
            foreach (CBinVector rVectorSign in m_aVectorSigns)
            {
                bool bSignAddedToCluster = false;
                Log += "Шаг " + iSteps++.ToString();
                Log += "Проверка вектора признаков "+rVectorSign.Code;
                foreach (CCluster rCluster in m_aClusters)
                {
                    Log += "Тест на схожесть с вектором прототипом " + rCluster.PrototypeVector.Code;
                    if (CheckSimilarity(rVectorSign, rCluster.PrototypeVector))
                    {
                        Log += "Тест на внимательность с вектором прототипом " + rCluster.PrototypeVector.Code;
                        if (CheckAttention(rVectorSign, rCluster.PrototypeVector))
                        {
                            Log += "Кластер " + rCluster.PrototypeVector.Code;
                            rCluster.AddVectorSign(rVectorSign);
                            Log += "обновлен " + rCluster.PrototypeVector.Code;
                            bSignAddedToCluster = true;
                            break;
                        }
                    }
                }
                if (!bSignAddedToCluster)
                {
                    Assert.IsTrue(m_aClusters.Count < MaxClusters,"Достигнуто максимальное количество кластеров. " +
                        "Невозможно создать еще один кластер.");
                    string sName = "Кластер #" + m_iClusterCounter++;
                    m_aClusters.Add(new CCluster(rVectorSign, sName));
                    m_aClusters[m_aClusters.Count - 1].AddVectorSign(rVectorSign);
                    Log += "Вектор признаков " + rVectorSign.Code + " создал новый кластер " + m_aClusters[m_aClusters.Count - 1].PrototypeVector.Code;
                }
            }
            Log += "______________________";
        }
        public void AddVectorSign(string sVector)
        {
            string sName = "Признак #" + m_iSignCounter++;
            m_aVectorSigns.Add(CheckAddedVector(sVector,sName));            
        }
        public void AddVectorPrototype(string sVector)
        {
            string sName = "Прототип #" + m_iPrototypeCounter++;
            m_aVectorPrototypes.Add(CheckAddedVector(sVector, sName));
        }
        private void AddPrototypesToClusters()
        {
            foreach(CBinVector rVector in m_aVectorPrototypes)
            {
                string sName = "Кластер #" + m_iClusterCounter++;
                m_aClusters.Add(new CCluster(rVector, sName));
            }
        }
        
        private bool CheckSimilarity(CBinVector rVectorSign, CBinVector rVectorPrototype)
        {
            CBinVector rTempVector = rVectorPrototype.Clone();
            rTempVector.MultVector(rVectorSign);
            bool bResult = ((double)rTempVector.Relevance / (Beta + rVectorPrototype.Relevance)) > ((double)rVectorSign.Relevance / (Beta + VectorLength));
            Log+=rTempVector.Relevance.ToString()+" / "+(Beta + rVectorPrototype.Relevance).ToString()+
                " > "+rVectorSign.Relevance.ToString()+" / "+(Beta + VectorLength).ToString()+" is "+bResult.ToString();
            return bResult;
        }
        private bool CheckAttention(CBinVector rVectorSign, CBinVector rVectorPrototype)
        {
            CBinVector rTempVector = rVectorPrototype.Clone();
            rTempVector.MultVector(rVectorSign);
            bool bResult = ((double)rTempVector.Relevance / rVectorSign.Relevance) < Attention;
            Log += rTempVector.Relevance.ToString() + " / " + rVectorSign.Relevance.ToString() +
                " < " + Attention.ToString() + " is " + bResult.ToString();
            return bResult;
        }
        private CBinVector CheckAddedVector(string sVector,string sName)
        {
            CBinVector rVector = new CBinVector(sVector, sName);
            Assert.IsTrue(rVector.Length == m_iVectorLength);
            return rVector;
        }
    }
}
