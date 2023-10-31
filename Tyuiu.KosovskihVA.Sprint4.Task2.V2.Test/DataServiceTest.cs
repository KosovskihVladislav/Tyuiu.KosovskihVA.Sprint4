using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint4.Task2.V2.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[] v = { 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6 };

            int res;
            res = service1.Calculate(v);
            Assert.AreEqual(108045, res);
        }
    }
}
