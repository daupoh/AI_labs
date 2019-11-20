using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab2
{
    class CCluster
    {
        CBinVector rVectorPrototype;
        readonly IList<CBinVector> aClusteredVectorSigns;

        public CBinVector PrototypeVector
        {
            get
            {
                return rVectorPrototype;
            }
            private set
            {
                Assert.IsTrue(value != null,"Прототип-вектор не может быть пустым.");
                rVectorPrototype = value;
            }
        }

        public CCluster(CBinVector rVector)
        {
            PrototypeVector = rVector;
            aClusteredVectorSigns = new List<CBinVector>();
        }
        public void AddVectorSign(CBinVector rVector)
        {            
            PrototypeVector.MultVector(rVector);
            aClusteredVectorSigns.Add(rVector);
        }
        public CBinVector[] GetSigns()
        {
            return aClusteredVectorSigns.ToArray();
        }
            

    }
}
