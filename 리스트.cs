using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(); //int[] array = new int[5]
         /* list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4); */
            for(int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Insert(2, 200);
            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");
            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();
        }
    }
}
