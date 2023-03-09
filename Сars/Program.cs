using System;
using System.Runtime.ConstrainedExecution;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] array = new Car[0];
            int n = 0;
            bool a = true;
            while (a)
            {
                Console.WriteLine("Меню: \n 1 - добавить тачку \n 2 - поиск машин в базе \n 3 - показать все респектабельные тачки \n 4 - ливнуть с проги");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        Menu.AddCar(ref array, n);
                        n++;
                        break;
                    case ConsoleKey.D2:
                        Car.SearchCar(ref array);
                        break;
                    case ConsoleKey.D3:
                        Menu.PrintInfo(ref array);
                        break;
                    case ConsoleKey.D4:
                        a = false;
                        Console.WriteLine("Лив с проги");
                        break;

                    default:
                        Console.WriteLine("Ты ввел неверную клавишу, baka");
                        break;
                }
            }
        }
    }
}