using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint4.Task0.V7.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int len = 10;
            int[] v;
            v = new int[len];

            v[0] = 9;
            v[1] = 8;
            v[2] = 7;
            v[3] = 9;
            v[4] = 5;
            v[5] = 4;
            v[6] = 3;
            v[7] = 2;
            v[8] = 3;
            v[9] = 7;

            int res;
            res = service1.GetMultOddArrEl(v);
            Assert.AreEqual(178605, res);
        }
    }
}
