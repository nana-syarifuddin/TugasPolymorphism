using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class PrinterWindows
    {
        public string printer { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("\nShow printer display dimension");
        }

        public virtual void Print()
        {
            Console.WriteLine("Select printer");
        }
    }
}
