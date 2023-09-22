using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.GorbunovAA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 3;
            int z = 2;
            var res = ds.Calc(x, y, z);
            Assert.AreEqual(res, 50);
        }
    }
}
