using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint4.Task0.V7.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task0                                                           *");
            Console.WriteLine("*Вариант #7                                                               *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая подсчитает произведение нечетных             ");
            Console.WriteLine("* элементов массива                                                       *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] x = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = service1.GetMultOddArrEl(x);

            Console.WriteLine("По моим подсчётам " + res);


            Console.ReadKey();
        }
    }
}
