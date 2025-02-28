using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class BookShelf:Furniture
    {
        int noofShelves;
       public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the no of shelves");
            noofShelves = Convert.ToInt32(Console.ReadLine());
        }
      public override void Display()
        {
            base.Display();
            Console.WriteLine(" No of shelves: " + noofShelves);
        }
    }
}
