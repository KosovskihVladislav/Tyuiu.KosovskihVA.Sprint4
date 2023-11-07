using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint4.Task4.V15.Lib;

namespace Tyuiu.KosovskihVA.Sprint4.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task4                                                           *");
            Console.WriteLine("*Вариант #15                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая подсчитает сумму нечетных                    ");
            Console.WriteLine("* элементов массива                                                       *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите кол-во колонн в массиве: ");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int[,] v = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($" Введите {i}, {j} элементы массива \t");
                    v[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив: ");
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
