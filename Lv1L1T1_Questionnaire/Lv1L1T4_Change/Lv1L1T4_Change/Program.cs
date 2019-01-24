using System;

namespace Lv1L1T4_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int iVariable1;
            int iVariable2;
            int iVariableTemp;
            Console.WriteLine("Введите значение переменной 1 (целое число)");
            iVariable1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной 2 (целое число)");
            iVariable2 = Convert.ToInt32(Console.ReadLine());
            iVariableTemp = iVariable1;
            iVariable1 = iVariable2;
            iVariable2 = iVariableTemp;
            Console.WriteLine("Переменная 1 - " + iVariable1 + ", Переменная 2 - " + iVariable2);
            Console.ReadKey();

        }
    }
}
