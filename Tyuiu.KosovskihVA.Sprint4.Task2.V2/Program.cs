using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint4.Task2.V2.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task2                                                           *");
            Console.WriteLine("*Вариант #2                                                               *");
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

            Random rnd = new Random();
            int len;
            Console.Write("Напишите кол-во элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[len];

            for (int i = 0; i < len; i++)
            {
                v[i] = rnd.Next(1, 8);
            }
            Console.Write("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(v[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = service1.Calculate(v);

            Console.WriteLine("По моим подсчётам " + res);


            Console.ReadKey();
        }
    }
}
