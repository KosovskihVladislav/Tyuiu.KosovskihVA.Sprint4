using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint4.Task4.V15.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[,] v = new int[5, 5] { { 4, 2, 5, 5, 3 },
            { 4, 2, 5, 2, 2 },
            { 3, 2, 4, 2, 4 },
            { 3, 6, 4, 5, 4 },
            { 2, 4, 6, 4, 2 }
            };

            int res;
            res = service1.Calculate(v);
            Assert.AreEqual(29, res);
        }
    }
}
