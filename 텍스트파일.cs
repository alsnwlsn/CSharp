using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.Write(int.MaxValue);
            sw.Write("good morning");
            sw.Write(uint.MaxValue);
            sw.Write("안녕하세요");
            sw.Write(double.MaxValue);
            sw.Close();

            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");
            while (sr.EndOfStream == false)
                Console.WriteLine(sr.ReadLine());
            sr.Close();
        }
    }
}
