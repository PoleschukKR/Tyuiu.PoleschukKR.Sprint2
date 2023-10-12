using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PoleschukKR.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((y >= Math.Pow(x, 2) - 2) && y <= -x) || ( y >= Math.Pow(x, 2) - 2 && y <= x))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
            
        }
    }
}
