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
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //arrange
            var mc = new MC();
            //act
            int pris = mc.Pris();
            //assert
            Assert.AreEqual(125,pris);
        }

        [TestMethod()]
        public void KøreTøjTest()
        {
            //arrange
            var mc = new MC();
            //act
            string køretøj = mc.KøreTøj();
            //assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}