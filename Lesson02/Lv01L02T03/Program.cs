using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Евгений Хазанов
// Задание 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел

namespace Lv01L02T03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,s;
            a = 1;
            s = 0;
            while(a!=0)
            {
                Console.Write("Введите число:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0 & a % 2 == 0) s = s + a;
            }
            Console.Write("Сумма нечетных положительных чисел: {0}", s);
            Console.ReadLine();
        }
    }
}
