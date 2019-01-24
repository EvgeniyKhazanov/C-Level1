using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Евгений Хазанов
// Задание 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, 
// и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: 
// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
// С помощью цикла do while ограничить ввод пароля тремя попытками

namespace Lv01L02T04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string sLoginTemp = "";
            string sPasswordTemp="";
            string sLogin = "root";
            string sPassword = "GeekBrains";
            do
            {
                Console.Write("Введите логин: ");
                sLoginTemp = Console.ReadLine();
                Console.Write("Введите пароль: ");
                sPasswordTemp = Console.ReadLine();
                if (sLoginTemp == sLogin & sPasswordTemp == sPassword)
                {
                    Console.WriteLine("Добро пожаловать!");
                    Console.ReadLine();
                    break;
                }
                else
                { 
                    Console.WriteLine("Ошибка! Количество оставшихся попыток " + (3 - i));
                    if (i == 3) 
                    {
                        Console.WriteLine("До свиданья. Будем прощаться");
                        Console.ReadLine();
                        break;
                    }
                        else
                        i++;
                    
                }
            }
            while (i <= 3);
        }
    }
}
