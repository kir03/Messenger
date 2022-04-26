using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    internal class Message : Date
    {
        private string _messag;
        public string Messag
        {
            get
            {
                return _messag;
            }
            set
            {
                if (value != string.Empty)
                    _messag = value;
                else
                    _messag = "Пустое сообщение.";
            }
        }
        public Message()
        {
            Messag = "HI!";
        }
        public Message(string messang)
        {
            Messag = messang;
        }
        public override void Print()
        {
            base.Print();
            Console.Write($"[Message] {Messag}");
            Console.WriteLine();
        }
    }
}