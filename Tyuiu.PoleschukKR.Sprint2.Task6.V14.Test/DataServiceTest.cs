using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint2.Task6.V14.Lib;

namespace Tyuiu.PoleschukKR.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            int k = 14;
            int d = 7;

            int t = (d + k - 2) % 7;

            string res = ds.FindDayName(t);

            string wait = "суббота";

            Assert.AreEqual(wait, res);
        }
    }
}
