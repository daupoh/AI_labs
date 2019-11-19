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
        int iMaxOfClusters=10, iVectorLength=11, iBeta=1;
        double fAttention=0.9;
        readonly IList<CBinVector> aVectorSigns;
        readonly IList<CCluster> aClusters;

        public int MaxClusters
        {
            get
            {
                return iMaxOfClusters;
            }
            set
            {
                Assert.IsTrue(value>0);
                iMaxOfClusters = value;
            }
        }
        public int VectorLength
        {
            get
            {
                return iVectorLength;
            }
            set
            {
                Assert.IsTrue(value > 1);
                iVectorLength = value;
            }
        }
        public int Beta
        {
            get
            {
                return iBeta;
            }
            set
            {
                Assert.IsTrue(value > 0 && value<10);
                iBeta= value;
            }
        }
        public double Attention
        {
            get
            {
                return fAttention;
            }
            set
            {
                Assert.IsTrue(value > 0 && value < 1.0);
                fAttention= value;
            }
        }

        public CAdaptiveResonance()
        {            
            aVectorSigns = new List<CBinVector>();
            aClusters = new List<CCluster>();
        }
        public void Resonance()
        {
            Assert.IsTrue(aVectorSigns.Count > 0);
            if (aClusters.Count == 0)
            {
                aClusters.Add(new CCluster(aVectorSigns[0]));
            }
            foreach (CBinVector rVectorSign in aVectorSigns)
            {
                bool bSignAddedToCluster = false;
                foreach (CCluster rCluster in aClusters)
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
                    if (aClusters.Count < MaxClusters)
                    {
                        aClusters.Add(new CCluster(rVectorSign));
                        aClusters[aClusters.Count - 1].AddVectorSign(rVectorSign);
                    }
                }
            }
        }
        public void AddVectorSign(string sVector)
        {            
            aVectorSigns.Add(CheckAddedVector(sVector));            
        }
        public void AddVectorPrototype(string sVector)
        {
            aClusters.Add(new CCluster(CheckAddedVector(sVector)));
        }
        
        private bool CheckSimilarity(CBinVector rVectorSign, CBinVector rVectorPrototype)
        {
            CBinVector rTempVector = rVectorPrototype.Clone();
            rTempVector.MultVector(rVectorSign);           
            return (rTempVector.Number / (Beta + rVectorPrototype.Number)) > (rVectorSign.Number / (Beta + VectorLength));
        }
        private bool CheckAttention(CBinVector rVectorSign, CBinVector rVectorPrototype)
        {
            CBinVector rTempVector = rVectorPrototype.Clone();
            rTempVector.MultVector(rVectorSign);
            return (rTempVector.Number / rVectorSign.Number) < Attention;
        }
        private CBinVector CheckAddedVector(string sVector)
        {
            CBinVector rVector = new CBinVector(sVector);
            Assert.IsTrue(rVector.Length == iVectorLength);
            return rVector;
        }
    }
}
