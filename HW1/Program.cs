using System;
using Domain;

namespace HW1
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
            Console.Write("Кошку с каким возрастом вы предпочитаете купить?: "); 
            string age = Console.ReadLine();
            CatColor color = new CatColor();
            Cat cat = new Cat(color, age);
            int choice = 0;
            while (true)
            {
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
                        cat.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Введите цвет здоровой кошки:\n");
                        color.HealthyColor = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Введите цвет больной кошки:\n");
                        color.SickColor = Console.ReadLine();
                        break;
                    case 4:
                        cat.Feed();
                        break;
                    case 5:
                        cat.Punish(); 
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}