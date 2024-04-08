using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sii.Workshop.ClassLibrary
{
    public class Car : Vehicle
    {
        public Car(int wheels, bool isHorn, int capacity, int year, string brand, int vMax) : base(wheels, isHorn, capacity, year, brand, vMax)
        {
        }

        public void Go()
        {
            IsGoing = true;
            Console.WriteLine(IsGoing);
        }

        public new void Get() { Console.WriteLine("car"); }
    }
}
