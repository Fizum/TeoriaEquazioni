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
        public void TestDet2()
        {
            double a = 3;
            double b = 0;
            bool respeq = true;
            bool resp = Equazioni.IsDeterminated(a);

            Assert.AreEqual(respeq, resp);

        }
    }
}
