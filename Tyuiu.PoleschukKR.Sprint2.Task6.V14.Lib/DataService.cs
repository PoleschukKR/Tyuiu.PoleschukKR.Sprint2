using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PoleschukKR.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            string res;
            int t = (d + k - 2) % 7;
            switch (t)
            {
                case 0:
                    res = "понедельник";
                    break;

                case 1:
                    res = "вторник";
                    break;

                case 2:
                    res = "среда";
                    break;

                case 3:
                    res = "четверг";
                    break;

                case 4:
                    res = "пятница";
                    break;

                case 5:
                    res = "суббота";
                    break;

                case 6:
                    res = "воскресенье";
                    break;

                default: throw new ArgumentException(res = "недопустимый день недели!");


            }

            return res;
        }
    }
}
