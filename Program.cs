using System;

namespace Messanger // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum Menu
        {
            Printdata = 1,
            Additem = 2,
            Removeitem = 3,
            Exit = 4
        }
        enum Addmenu
        {
            Message = 1,
            Person = 2,
            Car = 3
        }
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int count;
            Console.WriteLine("Menu:");
            Console.WriteLine($"{(int)Menu.Printdata}. Print data");
            Console.WriteLine($"{(int)Menu.Additem}. Add item");
            Console.WriteLine($"{(int)Menu.Removeitem}. Remove item");
            Console.WriteLine($"{(int)Menu.Exit}. Exit");
            while (Console.ReadKey(true).Key != ConsoleKey.NumPad4)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine("Message menu:");
                    Console.WriteLine($"{(int)Addmenu.Message}. {Addmenu.Message}");
                    Console.WriteLine($"{(int)Addmenu.Person}. {Addmenu.Person}");
                    Console.WriteLine($"{(int)Addmenu.Car}. {Addmenu.Car}");
                    if (Console.ReadKey(true).Key == ConsoleKey.NumPad1)
                        string texting = Console.ReadLine();
                    list.Add(new Message(texting));

                }

            }

        }
    }
}