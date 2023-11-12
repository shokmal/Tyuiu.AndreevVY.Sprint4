using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint4.Task5.V2.Lib;

namespace Tyuiu.AndreevVY.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[3, 3] { { -1, 2, 4 }, { -3, 6, 8 }, { 9, -7, 8 } };
            int res = ds.Calculate(mas2);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
