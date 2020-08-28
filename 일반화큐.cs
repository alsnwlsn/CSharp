using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i + 1);
            }
            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}
