using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class myclass
    {
        int a, b, c;

        public myclass()
        {
            this.a = 5424;
            Console.WriteLine("myclass()");
        }

        public myclass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"myclass({b})");
        }

        public myclass(int b,int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"myclass({b}, {c})");
        }

        public void printfields()
        {
            Console.WriteLine($"a:{a} b:{b} c:{c}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass a = new myclass();
            a.printfields();
            Console.WriteLine();

            myclass b = new myclass(1);
            b.printfields();
            Console.WriteLine();

            myclass c = new myclass(10, 20);
            c.printfields();
        }
    }
}
