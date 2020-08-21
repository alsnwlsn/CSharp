using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }
        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach< int > (scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}");

            Console.WriteLine($"Old length of scores : {scores.Length}");
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
        }
    }
}
