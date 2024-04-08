using Sii.Workshop.ClassLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public class A
    {
        protected int V { get; set; }
    }

    public class B : A { }

    public class C : B { }

    public class D : C {
    
        public int GetV()
        {
            return V;
        }
    }

    static void Main(string[] args)
    {

        /* ~~~~~~~~~~~~~~ KLASY I METODY ~~~~~~~~~~~~~~~*/

        //var calculator = new Calculator();
        //var result = calculator.Add(3, 3); 
        //Console.WriteLine(result);

        //var vehicle = new Vehicle(4, true, 100, 2024, "Opel", 200);


        /* ~~~~~~~~~~~~~~ KOLEKCJE DANYCH ~~~~~~~~~~~~~~~*/

        //var list = new List<int>() { 3, 4, 5, 6 };
        //int index = 0;
        //foreach (var item in list)
        //{
        //    index++;
        //    Console.Write(item);
        //    break;
        //}

        //for (int i = 0; i < list.Count; i++)
        //{
        //    Console.WriteLine(list[i]);
        //}

        //list.Add(7);
        //list.Add(9);

        //foreach (var item in list)
        //{
        //    Console.Write(item);
        //}

        //var numbers = new List<int>();
        //var randomNumbers = new List<int>();

        //const int COUNT = 6;

        //for (int i = 0; i < COUNT; i++)
        //{
        //    var number = int.Parse(Console.ReadLine());
        //    numbers.Add(number);
        //    randomNumbers.Add(new Random().Next(1,49));
        //}

        //foreach (var number in randomNumbers) 
        //{
        //    Console.Write(number + " ");
        //}

        //Console.WriteLine("\nTrafiłes nastepujace liczby:");

        //foreach (var number in numbers)
        //{
        //    foreach (var number2 in randomNumbers)
        //    {
        //        if(number == number2) Console.Write(number + " ");
        //    }
        //}

        //foreach (var item in numbers)
        //{
        //    if(randomNumbers.Any(x => x == item)) Console.Write(item + " ");
        //}

        //var dictionary = new Dictionary<string, string>();
        //dictionary.Add("Monday", "Poniedziałek");
        //Console.WriteLine(dictionary["Monday"]);

        /* ~~~~~~~~~~~~~~ TYPY WYLICZENIOWE ~~~~~~~~~~~~~~~*/

        //Console.WriteLine("Podaj dzień tygodnia po angielsku:");
        //var day = Enum.Parse<Days>(Console.ReadLine());

        //switch (day)
        //{
        //    case Days.Monday:
        //        Console.WriteLine("Poniedziałek");
        //        break;
        //    case Days.Tuesday:
        //        Console.WriteLine("Wtorek");
        //        break;
        //    case Days.Wednesday:
        //        Console.WriteLine("Środa");
        //        break;
        //    case Days.Thursday:
        //        Console.WriteLine("Czwartek");
        //        break;
        //    case Days.Friday:
        //        Console.WriteLine("Piątek");
        //        break;
        //    case Days.Saturday:
        //        Console.WriteLine("Sobota");
        //        break;
        //    case Days.Sunday:
        //        Console.WriteLine("Niedziela");
        //        break;
        //}


        /* ~~~~~~~~~~~~~~ HERMETYZACJA ~~~~~~~~~~~~~~~*/

        //var vehicle = new Vehicle(4, true, 100, 2022, "opel", 200);

        //var square = new Square(4, 4);
        //Console.WriteLine(square.a);
        //square.a = 6;
        //Console.WriteLine(square.a);


        /* ~~~~~~~~~~~~~~ POLIMORFIZM ~~~~~~~~~~~~~~~*/

        //var car = new Car(4, true, 100, 2022, "opel", 200);

        //car.Go();

        //var shapes = new List<Shape>() { new Triangle(2, 2), new Rectangle(3, 3), new Circle(6) };

        //foreach (var shape in shapes) { Console.WriteLine(shape.GetArea()); }

        //var cal = new Calculator();

        //Console.WriteLine(cal.Add(2.2,22.2));
        //Console.WriteLine(cal.Add(2,22));

        //Vehicle veh = new Car(5, true, 2, 2022, "opel", 200);
        //veh.Get();

        //Vehicle2 car = new Car2();
        //car.GetHorn();
        //Vehicle2 truck = new Truck();
        //truck.GetHorn();
        //var veh = new Vehicle2();
        //veh.GetHorn();

        /* ~~~~~~~~~~~~~~ OBSŁUGA WYJĄTKÓW ~~~~~~~~~~~~~~~*/

        //Console.WriteLine("Podaj dzień tygodnia po angielsku:");
        //Days? day = null;
        //do
        //{
        //    try
        //    {
        //        day = Enum.Parse<Days>(Console.ReadLine());
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Podaj prawidłowy dzień tygodnia");
        //    };
        //} while (day == null);

        //switch (day)
        //{
        //    case Days.Monday:
        //        Console.WriteLine("Poniedziałek");
        //        break;
        //    case Days.Tuesday:
        //        Console.WriteLine("Wtorek");
        //        break;
        //    case Days.Wednesday:
        //        Console.WriteLine("Środa");
        //        break;
        //    case Days.Thursday:
        //        Console.WriteLine("Czwartek");
        //        break;
        //    case Days.Friday:
        //        Console.WriteLine("Piątek");
        //        break;
        //    case Days.Saturday:
        //        Console.WriteLine("Sobota");
        //        break;
        //    case Days.Sunday:
        //        Console.WriteLine("Niedziela");
        //        break;
        //}
    }
}
