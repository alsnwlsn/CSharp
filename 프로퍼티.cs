using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Birthdatinfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public int Age 
        {
            get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Birthdatinfo birth = new Birthdatinfo();
            birth.Name = "진우";
            birth.Birthday = new DateTime(2002, 11, 11);
            //birth.Age = 2002; 읽기전용
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday);
            Console.WriteLine(birth.Age);
        }
    }
}
