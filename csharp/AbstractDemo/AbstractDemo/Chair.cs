using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Chair:Furniture
    {
        int nooflegs;
        internal void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the no of legs");
            nooflegs = Convert.ToInt32(Console.ReadLine());
        }
        internal void Display()
        {
            base.Display();
            Console.WriteLine(" No of legs: " + nooflegs);
        }
    }
}
