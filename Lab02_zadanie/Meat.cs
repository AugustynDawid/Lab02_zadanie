using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_zadanie
{
    class Meat : Product
    {
        private double weight;

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public Meat(string name, double weight)
            :base(name)
        {
            this.weight = weight;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + $"{Name} ({Weight} kg)");

        }
    }
}
