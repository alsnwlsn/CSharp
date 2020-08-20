using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Birthdayinfo
    {
        public string Name
        {
            get;
            set;
        } 
        public DateTime Birthday
        {
            get;
            set;
        } 
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Birthdayinfo birth = new Birthdayinfo()
                {
                    Name = "진우",
                    Birthday = new DateTime(2002, 11, 11)
                };
                Console.WriteLine(birth.Name);
                Console.WriteLine(birth.Birthday);
                Console.WriteLine(birth.Age);
            }
        }
    }
}

