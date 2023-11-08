using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint4.Task6.V29.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            string[] v = new string[] { "Весна", "Лето", "Осень", "Зима"};

            int res = service1.Calculate(v);
            Assert.AreEqual(2, res);
        }
    }
}
