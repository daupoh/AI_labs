using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_AI_lab1.Slot;

namespace wf_AI_lab1
{
    [TestFixture]
    class TCSlot
    {
        [Test]
        public void TestAtomSlot()
        {
            CSlotAtom rAtomSlot = new CSlotAtom(ACSlot.InheriteType.Independent,32);
            Console.WriteLine(rAtomSlot.Show);
        }

    }
}
