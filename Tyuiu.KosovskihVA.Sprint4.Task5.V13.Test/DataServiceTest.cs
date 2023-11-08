using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint4.Task5.V13.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[,] v = new int[5, 5] { { 4, -2, 4, -1, 3 },
            { 4, 2, 4, 2, 2 },
            { 3, 1, 4, 2, 4 },
            { 3, -2, 0, -1, 4 },
            { 2, 4, 0, 4, 2 }
            };

            int[,] vr = new int[5, 5] { { 4, 0, 4, 0, 3 },
            { 4, 2, 4, 2, 2 },
            { 3, 1, 4, 2, 4 },
            { 3, 0, 0, 0, 4 },
            { 2, 4, 0, 4, 2 }
            };
            int[,] res = service1.Calculate(v);
            CollectionAssert.AreEqual(vr, res);
        }
    }
}
