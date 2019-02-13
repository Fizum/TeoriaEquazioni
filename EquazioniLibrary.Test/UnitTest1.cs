using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDet1()
        {
            double a = 3;
            bool respeq = true;
            bool resp = Equazioni.IsDeterminated(a);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestDet2()
        {
            double a = 0;
            bool respeq = false;
            bool resp = Equazioni.IsDeterminated(a);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestDet3()
        {
            double a = -10;
            bool respeq = true;
            bool resp = Equazioni.IsDeterminated(a);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestIndet1()
        {
            double a = 0;
            bool respeq = true;
            bool resp = Equazioni.IsInconsisted(a);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestIndet2()
        {
            double a = -5;
            bool respeq = false;
            bool resp = Equazioni.IsInconsisted(a);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestIndet3()
        {
            double a = 5;
            bool respeq = false;
            bool resp = Equazioni.IsInconsisted(a);
            Assert.AreEqual(respeq, resp);
        }
    }
}
