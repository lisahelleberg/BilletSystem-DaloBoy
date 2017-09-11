using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class BaseBilTests
    {
        [TestMethod()]
        public void nummerpladeTestMed7()
        {
            //arrange
            var Bil = new Bil();
            //act
            Bil.NummerPlade = "AS69420";
            Bil.nummerpladeLimit();
            //assert
            Assert.AreEqual("AS69420",Bil.NummerPlade);
        }

        // ExpectedException
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void nummerpladeTestMed8()
        {
            //arrange
            var Bil = new Bil();
            //act
            Bil.NummerPlade = "ASS69420";
            Bil.nummerpladeLimit();
            //assert
            Assert.AreEqual("ASS69420", Bil.NummerPlade);

        }
    }
}