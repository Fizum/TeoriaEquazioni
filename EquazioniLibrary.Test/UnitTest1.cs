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
            double b = 5;
            bool respeq = true;
            bool resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestIndet2()
        {
            double a = -5;
            double b = 3;
            bool respeq = false;
            bool resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestIndet3()
        {
            double a = 5;
            double b = 0;
            bool respeq = false;
            bool resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestDegree1()
        {
            double a = 5;
            bool respeq = true;
            bool resp = Equazioni.IsDegree2(a);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestDegree2()
        {
            double a = 0;
            bool respeq = false;
            bool resp = Equazioni.IsDegree2(a);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestDegree3()
        {
            double a = -9;
            bool respeq = true;
            bool resp = Equazioni.IsDegree2(a);
            Assert.AreEqual(respeq, resp);
        }

        [TestMethod]
        public void TestDelta1()
        {
            double a = -9;
            double b = 3;
            double c = 3;
        }

    }
}
