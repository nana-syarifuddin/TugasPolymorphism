using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nCanon display dimension : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
}
