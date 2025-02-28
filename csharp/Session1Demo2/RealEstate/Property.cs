using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    abstract class Property
    {
        double Area;
        double Price;
        string Location;
    }
     class Flat:Property
    {        
        int NoOfFloors;
        public void Accept() {
            Area = Convert.ToDouble(Console.ReadLine());
        }  
    }
    class House
    {
        double Area;
        double Price;
        string Location;
        int NoOfFloors;
        int HouseNo;
    }
}
