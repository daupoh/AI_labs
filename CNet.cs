using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNet
    {
        int m_iCountOfVertex;
        struct Rib
        {
            double fDistance;
            double fFerment;            
            public double Distance
            {
                get
                {
                    return fDistance;
                }
                set
                {
                    Assert.IsTrue(value > 0, "Значение расстояния между вершинами не может быть меньше или равно 0.");
                    fDistance = value;
                }
            }
            public double Ferment
            {
                get
                {
                    return fFerment;
                }
                set
                {
                    Assert.IsTrue(value >= 0, "Значение расстояния между вершинами не может быть меньше 0.");
                    fFerment = value;
                }
            }
            public Rib(double fDistance, double fFerment)
            {
                this.fDistance = fDistance;
                this.fFerment = fFerment;
            }
        }
        Rib[][] m_aGraph;

        public int CountOfVertex
        {
            get
            {
                return m_iCountOfVertex;
            }
            private set
            {

            }
        }
    }
}
