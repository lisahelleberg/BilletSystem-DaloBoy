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
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //arrange
            var bil = new Bil();
            //act
            int pris = bil.Pris();
            //assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void køretøjTest()
        {
            //arrange
            var bil = new Bil();
            //act
            string køretøj = bil.KøreTøj();
            //assert
            Assert.AreEqual("Bil", køretøj);
        }
    }
}