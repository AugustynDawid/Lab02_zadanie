using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_zadanie
{
    abstract class Product : IThing
    {
        private string name;
        public string Name 
        {
            get => name; 
            set => name = value; 
        }

        public Product(string name)
        {
            this.name = name;
        }

        public abstract void Print(string prefix);
    }
}
