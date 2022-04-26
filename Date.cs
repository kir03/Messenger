using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    internal class Date
    {
        public DateTime time { get; set; }
        public Date()
        {
            time = DateTime.Now;
        }
        public virtual void Print()
        {
            Console.Write($"[{time}] ");
        }
    }
}
