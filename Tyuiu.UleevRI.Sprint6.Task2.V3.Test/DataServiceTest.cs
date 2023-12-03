using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint6.Task2.V3.Lib;

namespace Tyuiu.UleevRI.Sprint6.Task2.V3.Test
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
            num[0] = -12.18;
            num[1] = 16.03;
            num[2] = 18.87;
            num[3] = 4.96;
            num[4] = -9.99;
            num[5] = -2.00;
            num[6] = 2.16;
            num[7] = -7.54;
            num[8] = -22.76;
            num[9] = -20.45;
            num[10] = 7.77;
            double[] res = new double[l];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(num, res);
        }
    }
}
