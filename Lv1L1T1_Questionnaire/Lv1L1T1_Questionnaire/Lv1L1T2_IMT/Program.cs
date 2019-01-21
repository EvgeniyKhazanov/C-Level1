// Евгений Хазанов
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах

using System;

namespace Lv1L1T2_IMT
{
    class Program
    {
        static void Main(string[] args)
        {
            double dGrowth;
            double dWeight;
            double dIMT;
            Console.WriteLine("Введите свой рост");
            dGrowth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой вес");
            dWeight = Convert.ToDouble(Console.ReadLine());
            dIMT = dWeight / (dGrowth * dGrowth);
            Console.WriteLine("Ваш индекс массы тела составляет: "+ dIMT);
            Console.ReadLine();
        }
    }
}
