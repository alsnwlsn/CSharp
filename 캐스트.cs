using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mammal
    {

        public Mammal()
        {
            Console.WriteLine("Hello Mammal");
        }
        public void Nurse()
        {
            Console.WriteLine("동물을 길러요");
        }
    }
    class Dog : Mammal
    {
        public Dog()
        {
            Console.WriteLine("Hello dog");
        }
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
    class Cat : Mammal
    {
        public Cat()
        {
            Console.WriteLine("Hello Cat");
        }
        public void Meow()
        {
            Console.WriteLine("야옹");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m = new Mammal();
            Dog d = new Dog();
            m.Nurse();
            d.Nurse(); d.Bark();

            Mammal mc = new Cat(); //다운캐스트(위에서 아래로)
            mc.Nurse(); //mc.Meow(); nurse만 가능 

            //Cat cm = new Mammal(); 업캐스트(아래에서 위로) C#은 다운캐스트만 가능
        }
    }
}
