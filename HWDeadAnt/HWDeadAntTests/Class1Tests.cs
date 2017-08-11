using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWDeadAnt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWDeadAnt.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void noDeadAntTest()
        {
            Assert.AreEqual(0, DeadAntClass.deadAntCount("ant ant ant ant"));
            Assert.AreEqual(0, DeadAntClass.deadAntCount(null));
            Assert.AreEqual(0, DeadAntClass.deadAntCount("fgkjhidke"));
            
        }


        [TestMethod()]
        public void OneDeadAntTest()
        {
            Assert.AreEqual(1, DeadAntClass.deadAntCount("ant ant .... a nt"));
        }

        [TestMethod()]
        public void TwoDeadAntTest()
        {
            Assert.AreEqual(2, DeadAntClass.deadAntCount("ant anantt aantnt"));
            Assert.AreEqual(2, DeadAntClass.deadAntCount("ant ant .... a nntt"));
        }

        [TestMethod()]
        public void ThreeDeadAntTest()
        {
            Assert.AreEqual(3, DeadAntClass.deadAntCount("ant ant .... a nnttt"));
        }



    }
}
