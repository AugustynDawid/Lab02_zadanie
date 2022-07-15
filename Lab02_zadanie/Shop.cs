using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_zadanie
{
    class Shop : IThing
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        private Person[] people;

        private Product[] products;

        public Shop (string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            Console.WriteLine($"Shop: {Name}");
            Console.WriteLine("-- People: --");

            foreach(Person p in people)
            {
                p.Print("\t");
            }
            Console.WriteLine("-- Products: --");

            foreach (Product p in products)
            {
                p.Print("\t");
            }
        }
    }

    
}
