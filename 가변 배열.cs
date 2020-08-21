using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jegged = new int[3][];
            jegged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jegged[1] = new int[] { 6, 7, 8 };
            jegged[2] = new int[] { 9 };
            foreach(int[] arr in jegged)
            {
                Console.Write($"Length : {arr.Length} Number : ");
                foreach(int a in arr)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }
        }
    }
}
