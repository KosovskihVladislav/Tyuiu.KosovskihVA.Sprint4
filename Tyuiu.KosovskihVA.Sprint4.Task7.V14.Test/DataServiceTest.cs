using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint4.Task7.V14.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            string v = "458712659137";

            int res = service1.Calculate(3, 4, v);
            Assert.AreEqual(8, res);
        }
    }
}
