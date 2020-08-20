using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }
        abstract public DateTime ProductDate
        {
            get;set;
        }
    }
    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new MyProduct() { ProductDate = new DateTime(2010, 11, 11) };
            Console.WriteLine("Product:{0}, Product Date: {1}", product1.SerialID, product1.ProductDate);
        }
    }
}
