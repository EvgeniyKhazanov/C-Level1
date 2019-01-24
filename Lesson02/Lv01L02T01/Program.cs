using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Евгений Хазанов
// Задание 1. Написать программу, возвращающую минимальное из трех чисел
namespace Lv01L02T01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min;            
            Console.WriteLine("Введите три целых числа");
            Console.Write("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());
            min = a;
            Console.Write("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b & a < c) min = a;
            if (b < a & b < c) min = b;
            if (c < a & c < b) min = c;
            Console.WriteLine("Наименьшее число {0}", min);
            Console.ReadLine();

        }
    }
}
