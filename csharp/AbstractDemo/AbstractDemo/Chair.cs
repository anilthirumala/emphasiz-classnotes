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
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the no of legs");
            nooflegs = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" No of legs: " + nooflegs);
        }
    }
}
