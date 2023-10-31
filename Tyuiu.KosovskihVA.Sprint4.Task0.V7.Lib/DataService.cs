using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KosovskihVA.Sprint4.Task0.V7.Lib
{
    public class DataService : ISprint4Task0V7
    {
        public int GetMultOddArrEl(int[] array)
        {
            int y = 1;
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                if (array[i] % 2 != 0)
                {
                    y *= array[i];
                }
            }
            return y;
        }
    }
}
