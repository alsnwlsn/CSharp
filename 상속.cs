﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Base
    {
        protected string name;
        public Base(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}.Base()");
        }
        ~Base()
        {
            Console.WriteLine($"{this.name}.~Base()");
        }
        public void BaseMethod()
        {
            Console.WriteLine($"{name}.BaseMethod");
        }
    }
    class Derived : Base
    {
        public Derived(string name) : base(name)
        {
            Console.WriteLine($"{this.name}.Derived()");
        }
        ~Derived()
        {
            Console.WriteLine($"{this.name}.~Derived()");
        }
        public void DerivedMethod()
        {
            Console.WriteLine($"{name}.DerivedMethod()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
