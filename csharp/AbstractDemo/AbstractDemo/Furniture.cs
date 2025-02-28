using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
   abstract class Furniture
    {
        string Color;
        int Width;
        int Height;
        protected void Accept()
        {
            Console.WriteLine("Enter the Color");
            Color = Console.ReadLine();
            Console.WriteLine("Enter the Width");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height");
            Height = Convert.ToInt32(Console.ReadLine());
        }
        protected void Display()
        {
            Console.Write($" Color:{Color} Width:{Width} Height{Height}");
        }
    }
}
