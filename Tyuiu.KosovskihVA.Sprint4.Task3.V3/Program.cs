using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint4.Task3.V3.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task3                                                           *");
            Console.WriteLine("*Вариант #3                                                               *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая подсчитает кол-во нечетных                   ");
            Console.WriteLine("* элементов массива                                                       *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] v = new int[5, 5] { { 9, 4, 5, 4, 8 },
            { 7, 6, 7, 7, 4 },
            { 4, 4, 3, 5, 6 },
            { 6, 5, 9, 4, 9 },
            { 9, 7, 8, 7, 7 }
            };
            int rows = v.GetUpperBound(0) + 1;
            int colums = v.Length / rows;


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив: ");
            int y = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{v[i, j]} \t");
                }
            }
            int res = service1.Calculate(v);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("По моим подсчётам " + res);


            Console.ReadKey();
        }
    }
}
