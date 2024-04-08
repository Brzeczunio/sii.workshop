namespace Sii.Workshop.ClassLibrary
{
    public class Calculator
    {
        public const double PI = 3.14d;

        public int Add(int a, int b) {return a + b;}
        public double Add(double a, double b) {return a + b; }
        public decimal Add(decimal a, decimal b) {return a + b; }
        public int Subtract(int a, int b) { return a - b;}
        public double Subtract(double a, double b) { return a - b; }
        public decimal Subtract(decimal a, decimal b) { return a - b; }
        public int Multiply(int a, int b) { return a * b;}
        public double Multiply(double a, double b) { return a * b; }
        public decimal Multiply(decimal a, decimal b) { return a * b; }
        public int Divide(int a, int b) { return a / b;}
        public double Divide(double a, double b) { return a / b; }
        public decimal Divide(decimal a, decimal b) { return a / b; }
        public double CircleArea(double r) {  return PI * Math.Sqrt(r); }
    }
}
