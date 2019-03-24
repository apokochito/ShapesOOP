using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // Every .cs its a different program but all runs on inheritance.cs
    public class Polymrphism : Inheritance
    {
        //This class is like 'static void Main(String[] args)' for Polymrphism class
        public void Program(){
            Derived d = new Derived();
            d.Screen();
            Console.ReadLine();
        }
    }

    //Interface
    public interface Base
    {
        void Screen();
    }

    public class Derived : Base
    {
        public void Screen()
        {
            Console.WriteLine("The interface");
        }
    }
}
