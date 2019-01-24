using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Евгений Хазанов
// Задание 2. Написать программу подсчета количества цифр числа

namespace Lv01L02T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (a > 0) 
            {
                s = s+1;
                a = a / 10;
            }
            Console.Write("Количество цифр в числе: {0}", s);
            Console.ReadLine();
        }
    }
}
