using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class cat
    {
        public cat()
        {
            name = "";
            color = "";
        }

        public cat(string _name, string _color)
        {
            name = _name;
            color = _color;
        }

        ~cat()
        {
            Console.WriteLine($"{name} : 잘가 ");
        }

        public string name;
        public string color;

        public void meow()
        {
            Console.WriteLine($"{name} : 야옹~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cat kitty = new cat();
            kitty.color = "하얀색";
            kitty.name = "키티";
            kitty.meow();
            Console.WriteLine($"{kitty.name} : {kitty.color}");

            cat nero = new cat("네로","검은색");
            //nero.color = "검은색";
            //nero.name = "네로";
            nero.meow();
            Console.WriteLine($"{nero.name} : {nero.color}");


        }
    }
}
