namespace Sii.Workshop.ClassLibrary
{
    public class Square : Shape
    {
        private double A { get; set; }
        private double B { get; set; }

        public Square(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double GetArea()
        {
            return A * B;
        }
    }
}
