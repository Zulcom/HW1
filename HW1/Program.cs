using System;
using Domain;

namespace HW1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Кошка для программиста by Zulcom";
            Console.Write("Кошку с каким возрастом вы предпочитаете купить?: "); 

            var age = Console.ReadLine();
            Console.Clear();
            var color = new CatColor();
            var cat = new Cat(color, age);
            var choice = 0;
            var result = "";
            var resultColor = false; // true = DarkRed, false = DarkGreen
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor =
                    ( !resultColor ? ConsoleColor.DarkRed : ConsoleColor.DarkGreen);
                Console.WriteLine(result);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Возраст кошки: " + cat.Age +
                                  "\nЦвет кошки: " + cat.CurrentColor);
                Console.Write("Имя кошки: ");
                Console.WriteLine(choice != 0 ? cat.Name : "Ещё не названа");
                Console.Write("\n\nМеню \n"
                              + "1.Назвать кошку \n"
                              + "2.Выбрать цвет здоровой кошки. \n"
                              + "3.Выбрать цвет больной кошки. \n"
                              + "4.Покормить кошку. \n"
                              + "5.Наказать кошку. \n"
                              + "6.Выход \n"
                              + "Выберите действие(1-6): "); 
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите имя кошки:");
                        try
                        {
                            cat.Name = Console.ReadLine();
                            result = "Кошка успешно названа. Новое имя кошки: " + cat.Name;
                            resultColor = true;
                        }
                        catch (Exception e)
                        {
                            resultColor = false;
                            result = e.Message;
                        }
                        break;
                    case 2:
                        Console.Write("Введите цвет здоровой кошки:\n");
                        color.HealthyColor = Console.ReadLine();
                        resultColor = true;
                        result = "Цвет здоровой кошки успешно изменён на " + color.HealthyColor;
                        break;
                    case 3:
                        Console.Write("Введите цвет больной кошки:\n");
                        color.SickColor = Console.ReadLine();
                        resultColor = true;
                        result = "Цвет больной кошки успешно изменён на " + color.SickColor;
                        break;
                    case 4:
                        cat.Feed();
                        resultColor = true;
                        result = "Кошка успешно покормлена";
                        break;
                    case 5:
                        cat.Punish();
                        resultColor = true;
                        result = "Кошка успешно наказана";
                        break;
                    default:
                        Console.Write("Программа успешно завершена");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}