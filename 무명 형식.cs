﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "허진우", Age = 18 };
            Console.WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new{Subject = "C#", Scores = new int[] { 90, 80, 70, 60 }};
            Console.Write($"Subject:{b.Subject}, Scores:");
            foreach (var score in b.Scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();
        }
    }
}
