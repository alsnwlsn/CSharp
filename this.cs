using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        class employee
        {
            private string name;
            private string position;

            public void setname(string name)
            {
                this.name = name;
            }

            public string getname()
            {
                return name;
            }

            public void setposition(string position)
            {
                this.position = position;
            }

            public string getposition()
            {
                return this.position;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
