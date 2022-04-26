using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    internal class Person : Date
    {
        private string _name, _surname;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != string.Empty)
                    _name = value;
                else
                    _name = "Ivan";
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value != string.Empty)
                    _surname = value;
                else
                    _surname = "Petrov";
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                if (value > 120)
                {
                    _age = 120;
                }
            }
        }
        public Person()
        {
            Name = "Ivan";
            Surname = "Petrov";
            Age = 20;
        }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public override void Print()
        {
            base.Print();
            Console.Write($"[Person] {Name} {Surname}, {Age}");
            Console.WriteLine();
        }
    }
}
