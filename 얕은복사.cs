using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class myclass
    {
        public int myfield1;
        public int myfield2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass source = new myclass();
            source.myfield1 = 10; Console.WriteLine(source.myfield1);
            source.myfield2 = 20; Console.WriteLine(source.myfield2);

            myclass target = source;
            target.myfield2 = 30; Console.WriteLine($"{target.myfield1} { target.myfield2}");
                
        }
    }
}
