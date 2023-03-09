using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    internal class Car
    {
        private string Mark;
        private string Model;
        private string Color;
        private string Number;
        private string Time;
        private int Index;
        public string mark
        {
            get => Mark;
        }
        public string model
        {
            get => Model;
        }
        public string color
        {
            get => Color;
        }
        public string number
        {
            get => Number;
        }
        public string time
        {
            get => Time;
        }
        public int index
        {
            get => Index;
        }


        public Car(string nmark = "no mark", string nmodel = "model", string ncolor = "no color", string nnumber = "no number", string ntime = "no Time", int nindex = 0)
        {
            this.Mark = nmark;
            this.Model = nmodel;
            this.Color = ncolor;
            this.Number = nnumber;
            this.Time = ntime;
            this.Index = nindex;
        }
        public static void SearchCar(ref Car[] array)
        {
            Console.WriteLine("Нужны данные, чтобы найти интересующую вас бибику:");
            string findcar = Console.ReadLine();
            bool found = false;
            bool flag = false;
            int n = 0;
            foreach (var item in array)
            {
                if (item.Mark == findcar || item.Model == findcar || item.Color == findcar || item.Number == findcar)
                {

                    Console.WriteLine($"1. Марка: {item.Mark}\n2. Модель: {item.Model}\n3. Цвет: {item.Color}\n4. Номер: {item.Number}\n Эта та тачка, которую вы ищете?\n Y - да, любая другая клавиша - нет");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        found = true;
                        n = item.Index;
                        break;
                    }

                    else
                    {
                        flag = true;
                        continue;
                    }
                }
            }

            Console.WriteLine("Я УДАЛЯЮ МАШИНУ ИЛИ НЕТ? ВЫБИРАЙ Y/N");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Menu.DeleteCar(ref array, n);
                Console.WriteLine(" ");
            }

            if (found == false)
            {
                Console.WriteLine("\n Такой бибики не найдено");
                Console.WriteLine(" ");
            }
            if (flag == true)
            {
                Console.WriteLine("\n Не смог найти такую машинку");
            }
        }
    }
}