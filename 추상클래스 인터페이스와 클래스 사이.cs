using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()"); 
        }
        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
    /*    public void PrivateMethodA()
        {
            Console.WriteLine("PrivateMethod()");
        } */
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
            // obj.PrivateMethodA(); private 라서안댐
        }
    }
}
