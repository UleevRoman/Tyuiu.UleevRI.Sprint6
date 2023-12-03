using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.UleevRI.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue + 1;
            double[] num = new double[l];
            int r = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double m = Math.Sin(i) / (i + 1.2) + Math.Cos(i) * 7 * i - 2;
                num[r] = Math.Round(m, 2);
                r++;
            }
            return num;
        }
    }
}
