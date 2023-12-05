using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint6.Task1.V29.Lib;

namespace Tyuiu.UleevRI.Sprint6.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int l = stopValue - startValue + 1;
            double[] num = new double[l];
            num[0] = -15.40;
            num[1] = -10.93;
            num[2] = -7.22;
            num[3] = -5.04;
            num[4] = 0.00;
            num[5] = -0.30;
            num[6] = 2.57;
            num[7] = 6.40;
            num[8] = 10.04;
            num[9] = 12.72;
            num[10] = 14.68;
            double[] res = new double[l];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(num, res);
        }
    }
}
