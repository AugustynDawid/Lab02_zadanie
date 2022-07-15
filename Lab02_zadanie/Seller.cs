using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_zadanie
{
    class Seller : Person
    {
        public Seller(string name, int age)
            :base(name, age)
        { }

        public override void Print(string prefix)
        {
           Console.WriteLine(prefix + $"Seller: {Name} ({Age} y.o.)");
        }
    }
}
