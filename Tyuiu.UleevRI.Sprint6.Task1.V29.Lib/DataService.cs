using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.UleevRI.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue + 1;
            double[] num = new double[l];
            double m; int r = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == -1) m = 0;
                else m = Math.Round(Math.Cos(i) / (i + 1) - Math.Cos(i) * 1.3 + 3 * i, 2);
                num[r] = m;
                r++;
            }
            return num;
        }
    }
}
