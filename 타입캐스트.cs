using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            Mammal mammal = new Dog();
            Dog dog;
            if(mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mamal2 = new Cat();
            Cat cat = mamal2 as Cat;
            if(cat != null)
            {
                cat.Meow();
            }
            Cat cat2 = mammal as Cat;
            if(cat2 != null)
            {
                cat.Meow();
            }
            else
            {
                Console.WriteLine("cat2 is not cat");
            }
        }
    }
}
