using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoleschukKR.Sprint2.Task6.V14.Lib;

namespace Tyuiu.PoleschukKR.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Полещук К.Р. | ИИПб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющей структуры. Получение результата Switch    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Полещук Кирилл Романович | ИИПб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует упрощенный оператор switch и     *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("*Условие:Дано целое число k (1 <= k <= 365). Определить, каким днем недели*");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января d-й день      *");
            Console.WriteLine("* недели (если 1 января — понедельник, то d = 1 , если вторник — d = 2 .. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня в году (1 - 365):");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня недели 1 января");
            int d = Convert.ToInt32(Console.ReadLine());

            int t = (d + k - 2) % 7;



            string res;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if ((k > 365) || (k < 1) || (d > 7) || (d < 1))
            {
                Console.WriteLine("Недопустимые значения!");
            }
            else
            {
                res = ds.FindDayName(d,k);
                Console.WriteLine(res);
            }
            Console.ReadLine();





        }
    }
}
