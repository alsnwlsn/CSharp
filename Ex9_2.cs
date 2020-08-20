using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "허진우", Age = 18 };
            Console.WriteLine("이름 : {0}, 나이:{1}", nameCard.Name, nameCard.Age);

            var complex = new { Real = "뭘써야", Imaginary = "될까요" };
            Console.WriteLine("Real:{0}, Imaginary:{1}", complex.Real, complex.Imaginary);
        }
    }
}
