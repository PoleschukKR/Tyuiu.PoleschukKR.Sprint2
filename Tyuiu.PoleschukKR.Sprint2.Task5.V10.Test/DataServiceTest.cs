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

            string res = ds.FindDateOfPreviousDay(g,m,n);
            string q = "31.12.22";

            Assert.AreEqual(Convert.ToString(q), res);
        }
    }
}
