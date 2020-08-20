using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Birthdayinfo
    {
        public string Name
        {
            get;
            set;
        } = "unknown";
        public DateTime Birthday
        {
            get;
            set;
        } = new DateTime(2000, 11, 11);
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Birthdayinfo birth = new Birthdayinfo();
                Console.WriteLine(birth.Name);
                Console.WriteLine(birth.Birthday);
                Console.WriteLine(birth.Age);
                birth.Name = "진우";
                birth.Birthday = new DateTime(2020, 11, 11);
                Console.WriteLine(birth.Name);
                Console.WriteLine(birth.Birthday);
            }
        }
    }
}
