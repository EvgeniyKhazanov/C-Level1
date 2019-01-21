using System;

namespace Lv1L1T1_Questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя");
            string sName = Console.ReadLine();
            Console.WriteLine("Ваша фамилия");
            string sSurname = Console.ReadLine();
            Console.WriteLine("Ваш возраст");
            string sAge = Console.ReadLine();
            Console.WriteLine("Ваш рост");
            string sGrowth = Console.ReadLine();
            Console.WriteLine("Ваш вес");
            string sWeight = Console.ReadLine();

            Console.WriteLine("Выберите способ вывода: 1 - Склеивание, 2 - Форматирование, 3 - Используя $");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            {
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Имя: " + sName + "  Фамилия: " + sSurname + "  Возраст: " + sAge + "  Вес: " + sGrowth + "  Рост: " + sWeight);
                        Console.ReadLine();
                        break;
                    case 2:
                        string sFormat;
                        sFormat = string.Format("Имя: {0}; Фамилия: {1}; Возраст: {2}; Рост: {3}; Вес: {4}", sName, sSurname, sAge, sGrowth, sWeight);
                        Console.WriteLine(sFormat);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Write($"Имя: {sName}, Фамилия: {sSurname}, Возраст: {sAge}, Рост: {sGrowth}, Вес: {sWeight}");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Ошибка! Осуществлен вывод анкеты по способу 1");
                        goto case 1;
                 }
            }
            
        }
    }
}
