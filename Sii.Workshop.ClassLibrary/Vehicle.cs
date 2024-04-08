namespace Sii.Workshop.ClassLibrary
{
    public class Vehicle
    {
        public int Wheels;
        public bool IsHorn;
        public int Capacity;
        public int Year;
        public string Brand;
        public int VMax;
        protected bool IsGoing { get; set; }

        public Vehicle(int wheels, bool isHorn, int capacity, int year, string brand, int vMax)
        {
            Wheels = wheels;
            IsHorn = isHorn;
            Capacity = capacity;
            Year = year;
            Brand = brand;
            VMax = vMax;
        }

        public virtual void Get() { Console.WriteLine("vehicle"); }
    }
}
