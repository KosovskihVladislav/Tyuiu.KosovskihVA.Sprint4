using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint4.Task6.V29.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task6.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task6                                                           *");
            Console.WriteLine("*Вариант #29                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая подсчитает кол-во элементов строкого массива*");
            Console.WriteLine("* длина которых больше 4                                                  *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] v = new string[] { "Весна", "Лето", "Осень", "Зима" };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Исходный массив: ");
            for (int i = 0; i < v.Length - 1; i++)
            {
                Console.WriteLine(v[i]);
            }
            int res = service1.Calculate(v);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Кол-во элементов с длиной больше 4: =  ");

            Console.Write(res);

            Console.ReadKey();
        }
    }
}
