﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_zadanie
{
     abstract class Person : IThing
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Print(string prefix);
    
    }
}
