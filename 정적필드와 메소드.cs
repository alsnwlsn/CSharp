using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class global
    {
        public static int count = 0;
    }
    class classa
    {
        public classa()
        {
            global.count++;
        }
    }
    class classb
    {
        public classb()
        {
            global.count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"global.count : {global.count}");

            new classa();
            new classb();
            Console.WriteLine($"global.count : {global.count}");
            new classa();
            new classb();

            Console.WriteLine($"global.count : {global.count}");
        }
    }
}
