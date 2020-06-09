using System;

namespace MidlleNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            int att = 0;
            while(login != "Nick")
            {
                att++;
                Console.WriteLine("Неправильный логин!");
                login = Console.ReadLine();

                if(att >= 3)
                {
                    Console.WriteLine("Попытки кончились!");
                    break;
                }
            }
            Console.WriteLine("Пароль: ");
            string pass = Console.ReadLine();
            while (pass != "12345")
            {
                att++;
                Console.WriteLine("Неправильный пароль");
                pass = Console.ReadLine();
                if (att >= 3)
                {
                    Console.WriteLine("Попытки кончились!");
                    break;
                }
            }
            Console.WriteLine("Успешно!");
            
        }
    }
}
