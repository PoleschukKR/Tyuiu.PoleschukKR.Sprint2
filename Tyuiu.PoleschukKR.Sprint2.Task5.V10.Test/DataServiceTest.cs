using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint2.Task5.V10.Lib;

namespace Tyuiu.PoleschukKR.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int g = 23;
            int m = 1;
            int n = 1;

            int res = ds.FindDateOfPreviousDay(g, m, n);
            string q = "221231";

            Assert.AreEqual(Convert.ToDouble(q), res);
        }
    }
}
