using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "hello", "halo" };
            foreach (string a in array1)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            string[] array2 = new string[] { "안녕", "hello", "halo" };
            foreach (string a in array2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            string[] array3 = { "안녕", "hello", "halo" };
            foreach (string a in array3)
            {
                Console.WriteLine(a);
            }
        }
    }
}
