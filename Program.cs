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
            int choisemenu,choiseadd,Age,Year,Delete;
            string Name,Surname,Model;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine($"{(int)Menu.Printdata}. Print data");
                Console.WriteLine($"{(int)Menu.Additem}. Add item");
                Console.WriteLine($"{(int)Menu.Removeitem}. Remove item");
                Console.WriteLine($"{(int)Menu.Exit}. Exit");
                int.TryParse(Console.ReadLine(),out choisemenu) ;
                if (choisemenu == 1)
                {
                    Console.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {list[i]}");
                    }
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                if (choisemenu == 2)
                {
                    Console.WriteLine("Message menu:");
                    Console.WriteLine($"{(int)Addmenu.Message}. {Addmenu.Message}");
                    Console.WriteLine($"{(int)Addmenu.Person}. {Addmenu.Person}");
                    Console.WriteLine($"{(int)Addmenu.Car}. {Addmenu.Car}");
                    int.TryParse(Console.ReadLine(), out choiseadd);
                    if (choiseadd == 1)
                    {
                        
                        Console.WriteLine("Enter a message:");
                        Message message = new Message(Console.ReadLine());
                        list.Add($"[{message.time}] " + "[Message] " + message.Messag);
                        
                    }
                    if (choiseadd == 2)
                    {

                        Console.WriteLine("Enter a Name:");
                        Name = Console.ReadLine();
                        Console.WriteLine("Enter your Last Name:");
                        Surname = Console.ReadLine();
                        Console.WriteLine("Enter the Age:");
                        int.TryParse(Console.ReadLine(), out Age);
                        Person person = new Person(Name,Surname,Age);
                        list.Add($"[{person.time}] " + "[Person] " + person.Name + " " + person.Surname + ", " + person.Age);

                    }
                    if (choiseadd == 3)
                    {

                        Console.WriteLine("Enter the Model:");
                        Model = Console.ReadLine();
                        Console.WriteLine("Enter the Year of release:");
                        int.TryParse(Console.ReadLine(), out Year);
                        Car car = new Car(Model,Year);
                        list.Add($"[{car.time}] " + "[Car] " + car.Model + ", " + car.Year);

                    }



                }
                if (choisemenu == 3)
                {
                    Console.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {list[i]}");
                    }
                    Console.WriteLine("Which element do you want to delete?");
                    int.TryParse(Console.ReadLine(), out Delete);
                    list.RemoveAt(Delete - 1);
                    Console.Clear();
                    Console.WriteLine("Your modified list:");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {list[i]}");
                    }
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                Console.Clear();
            }
            while (choisemenu != 4);

        }
    }
}