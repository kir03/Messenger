using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    internal class Car : Date
    {
        private string _model;
        private int _year;
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value != string.Empty)
                    _model = value;
                else
                    _model = "Вы ничего не ввели!";
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 0 || value > 2022)
                {
                    if (value < 0)
                        _year = 0;
                    if (value > 2022)
                        _year = 2022;
                }
                else
                    _year = value;
            }
        }
        public Car()
        {
            Model = "Logan";
            Year = 2000;
        }
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
        public override void Print()
        {
            base.Print();
            Console.Write($"[Car] {Model}, {Year}");
            Console.WriteLine();
        }

    }
}
