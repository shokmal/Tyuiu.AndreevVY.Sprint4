using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint4.Task6.V26.Lib;

namespace Tyuiu.AndreevVY.Sprint4.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] city = { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            string[] res = ds.Calculate(city);
            string[] wait = { "Тюмень", "Тамбов" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
