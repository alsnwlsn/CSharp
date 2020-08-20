using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    interface INamedValue
    {
        string Name
        {
            get; set;
        }
        string Value
        {
            get; set;
        }
    }
    class NameValue : INamedValue
    {
        public string Name
        {
            get; set;
        }
        public string Value
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameValue name = new NameValue() {Name = "이름",Value="허진우" };
            NameValue height = new NameValue() { Name = "키", Value = "999cm" };
            NameValue weight = new NameValue() { Name = "몸무게", Value = "0.000000001KG" };
            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");

        }
    }
}
