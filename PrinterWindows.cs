using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2595
{
    public class PrinterWindows
    {
        public string namamerk { get; set; }

        public virtual void show()
        {
            Console.WriteLine("Printer Windows display dimension : ");
        }

        public virtual void print()
        {
            Console.WriteLine("Printer Windows printing . . . .");

        }
    }
}
