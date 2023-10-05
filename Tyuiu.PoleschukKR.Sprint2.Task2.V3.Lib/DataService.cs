using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PoleschukKR.Sprint2.Task2.V3.Lib
{
    public class DataService : ISprint2Task2V3
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            int f = 0;
             if (x >= 3 && x <= 13)
            {
                if (x == 3)
                   {
                    if (y == 3 || y == 4 || y == 5 || y == 11)
                        f = 1;
                    else
                       f = 0;
                   }
                if (x == 4)
                   {
                    if ((y >= 3 && y <= 5) || (y >= 9 && y <= 13))
                        f = 1;
                    else
                        f = 0;
                   }
                if (x == 5)
                {
                    if ((y >= 3 && y <= 5) || y == 9)
                        f = 1;
                    else
                        f = 0;
                }
                if (x == 6)
                {
                    if (y == 5 || y == 9)
                        f = 1;
                    else
                        x = 0;
                }
                if (x == 7)
                {
                    if (y >= 5 && y <= 13)
                        f = 1;
                    else
                        f = 0;
                }
                if (x == 8)
                {
                    if (x >= 5 && x <= 12)
                        f = 1;
                    else
                        f = 0;
                }
                if (x == 9)
                {
                    if (y >= 3 && y <= 8)
                        f = 1;
                    else
                        f = 0;
                }
                if (x == 10)
                {
                    if (y >= 3 && y <= 8)
                        f = 1;
                    else
                        f = 0;
                }
                if (x == 11)
                {
                    if (y == 3 || (y >= 6 && y <= 13))
                        f = 1;
                    else
                        f = 0;
                }
                if (x == 12)
                {
                    if (y == 3 || (y >= 6 && y <= 13))
                        f = 1;
                    else
                        f = 0;
                }
                if (x == 13)
                {
                    if ((y >= 6 && y <= 9) || (y >= 11 && y <= 13))
                        f = 1;
                    else
                        f = 0;
                }

                    

            }
            if (f == 1)
                res = true;
            else
                res = false;

            return res;

        }
    }
}
