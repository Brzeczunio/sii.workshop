namespace sii.workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////JEDNOLINIJKOWY KOMENTARZE

            ///* asdsa
            //  asdasd
            //  asdasd
            //  dsad */
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("");

            /* ~~~~~~~~~~~~~~~~~~ ZMIENNE ~~~~~~~~~~~~~~ */
            //Deklaracja zmienny i przypisanie wartości
            //bool isOpen = true;
            //char sign = 'A';
            //decimal number = 10.0m;
            //double number2 = 0.0;
            //float number3 = 1.0f;
            //int number4 = 8;
            //long number5 = 8;

            //Dodajemy znak zapytania aby wartość mogła być nullowalna
            //int? numberWithNull = null;

            //Wypisanie na konsoli
            //Console.WriteLine(isOpen);
            //Console.WriteLine(sign);
            //Console.WriteLine(number);
            //Console.WriteLine(number2);
            //Console.WriteLine(number3);
            //Console.WriteLine(number4);
            //Console.WriteLine(number5);
            //Console.WriteLine(isTrue);


            /* ~~~~~~~~~~~~~~~~~~ ŁAŃCUCH ZNAKÓW ~~~~~~~~~~~~~~ */
            //var text = Console.ReadLine();
            //string? text2 = Console.ReadLine();

            ////Wypisanie na kosnoli
            //Console.WriteLine(text);
            //Console.WriteLine(text2);

            ////text -> toUpper, text2 -> toLower
            //var upperText = text.ToUpper();
            //var lowerText = text2.ToLower();

            ////wypisanie na konsoli
            //Console.WriteLine(upperText);
            //Console.WriteLine(lowerText);

            ////pobranie dlugosci znakow dla text i text2
            ////przez wykorzystanie właściwości Length
            //var textLength = upperText.Length;
            //var textLength2 = lowerText.Length;

            ////Wypisanie na kosnoli
            //Console.WriteLine(textLength);
            //Console.WriteLine(textLength2);

            /* ~~~~~~~~~~~~~~~~~~ STAŁE ~~~~~~~~~~~~~~ */

            //const decimal PI = 3.14m;

            //camelCase -> zmienne -> private _camelCase; bool -> isPascalCase
            //PascalCase -> klasy, metody -> public PascalCase
            //UPPER -> stałe (const)

            /* ~~~~~~~~~~~~~~~~~~ KONWERSJA TYPÓW - RZUTOWANIE NIEJAWNE ~~~~~~~~~~~~~~ */
            //int number1 = 0;
            //byte number2 = 15;
            //Console.WriteLine(number1);
            //number1 = number2;
            //Console.WriteLine(number1);

            //Console.WriteLine(34 + 34.5);

            /* ~~~~~~~~~~~~~~~~~~ KONWERSJA TYPÓW - RZUTOWANIE JAWNE ~~~~~~~~~~~~~~ */
            //var liczba = 3765.47;
            //int i;

            //i = (int)liczba;

            //Console.WriteLine(i);

            /* ~~~~~~~~~~~~~~~~~~ KONWERSJA TYPÓW - PARSOWANIE ~~~~~~~~~~~~~~ */

            //Można też korzystać z tej klasy, natomiast pod spodem i tak wywołuje podstawowe mechanizmy
            //Convert.ToByte();

            //string number = "341";
            //int castToInt = number;

            //var parseToInt = int.Parse(number);
            //var parse = int.TryParse(number, out parseToInt);

            //var parse2 = Convert.ToInt32(number);

            //Console.WriteLine(parseToInt);
            //Console.WriteLine(parse);
            //Console.WriteLine(parse2);

            //POBRAĆ DWIE LICZBY OD UZYTKOWNIKA I PRZYPISAĆ DO ZMIENNYCH

            //var number1 = int.Parse(Console.ReadLine());
            //var number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);

            /* ~~~~~~~~~~~~~~~~~~ OPERATORY ~~~~~~~~~~~~~~ */
            //var number1 = decimal.Parse(Console.ReadLine());
            //var number2 = decimal.Parse(Console.ReadLine());

            ////UŻYJ WSZYSTKICH OPERATORÓW ARYTMETYCZNYCH ORAZ
            ////PRZYPISANIA I WYPISZ ICH WYNIKI NA KONSOLI
            //// +, -, *, /, %, ++, --
            //// +=, -=, *=, /=,%=

            //Console.WriteLine("Operatory arytmetyczne:");
            //var result = number1 + number2;
            //Console.WriteLine(result);
            //result = number1 - number2;
            //Console.WriteLine(result);
            //result = number1 * number2;
            //Console.WriteLine(result);
            //result = number2 / number1;
            //Console.WriteLine(result);
            //result = number2 % number1;
            //Console.WriteLine(result);
            //result++;
            //Console.WriteLine(result);
            //result--;
            //Console.WriteLine(result);

            //Console.WriteLine("Operatory przypisania:");
            //result = number1;
            //result += number2;
            //Console.WriteLine(result);
            //result = number1;
            //result -= number2;
            //Console.WriteLine(result);
            //result = number1;
            //result *= number2;
            //Console.WriteLine(result);
            //result = number1;
            //result /= number2;
            //Console.WriteLine(result);
            //result = number1;
            //result %= number2;
            //Console.WriteLine(result);

            /* ~~~~~~~~~~~~~~~~~~ INSTRUKCJE WARUNKOWE ~~~~~~~~~~~~~~ */

            //ZAPYTAJ O WIEK UŻYTKOWNIKA I JEŻLI MA 18 I WIĘCEJ LAT
            //TO WYŚWIETL NA KONSOLI, ŻE MOŻE KUPIĆ ALKOHOL JAK NIE TO NIE

            //Console.Write("Podaj swój wiek: ");
            //var age = decimal.Parse(Console.ReadLine());

            //if (age >= 18) 
            //{
            //    Console.WriteLine("Może kupić alkohol");
            //}
            //else
            //{
            //    Console.WriteLine("Nie może kupić alkoholu");
            //}

            //NAPISANIE KALKULATORA -> WYPISANIE MENU Z OPCJAMI
            //OD 1-4 (+, -, *, /) I WYŚWIETLENIU WYNIKU Z WYKORZYSTANIEM
            //INSTRUKCJI WYBORU

            //Console.WriteLine("1. Dodawanie");
            //Console.WriteLine("2. Odejmowanie");
            //Console.WriteLine("3. Mnożenie");
            //Console.WriteLine("4. Dzielenie");

            //var option = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj pierwszą liczbę: ");
            //var number1 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj drugą liczbę: ");
            //var number2 = decimal.Parse(Console.ReadLine());

            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine(number1 + number2);
            //        break;
            //    case 2:
            //        Console.WriteLine(number1 - number2);
            //        break;
            //    case 3:
            //        Console.WriteLine(number1 * number2);
            //        break;
            //    case 4:
            //        Console.WriteLine(number1 / number2);
            //        break;
            //}

            //SPRAWDZ CZY PODANA LICZBA PRZEZ UŻYTKOWNIKA JEST LICZBA PARZYSTA I WYSWIETLIĆ WYNIK/NAPIS NA KONSOLI
            //Console.WriteLine("Podaj liczbę: ");
            //var number = decimal.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Jest parzysta");
            //}
            //else
            //{
            //    Console.WriteLine("Nie jest parzysta");
            //}

            //Console.WriteLine(number % 2 == 0 ? "Jest parzysta" : "Nie jest parzysta");

            //if (number % 2 == 0) Console.WriteLine("Jest parzysta");
            //if (number % 2 == 1) Console.WriteLine("Nie jest parzysta");

            //var result = number % 2;

            //switch (result)
            //{
            //    case 1:
            //        Console.WriteLine("Nie jest parzysta");
            //        break;
            //    case 0:
            //        Console.WriteLine("Jest parzysta");
            //        break;
            //}

            /* ~~~~~~~~~~~~~~~~~~ PĘTLE ~~~~~~~~~~~~~~ */

            //DEKLARUJEMY ZMIENNA I KTORA WYKORZYSTUJEMY W PĘTLACH I WYPISUJEMY JEJ WARTOŚĆ NA EKRANIE (ZWIĘKSZAMY I o 1 Z KAŻDĄ PĘTLĄ)
            //KAŻDA Z PĘTLI POWINNA SIĘ WYKONAĆ CONAMNIEJ 10 RAZY - Z CZEGO ILOŚĆ PĘTLI JEST PRZECHOWYWANA W ZMIENNEJ STAŁEJ

            //const int ROUNDS = 10;

            //for (var i = 0; i < ROUNDS; i++) Console.WriteLine(i);

            //var x = 0;

            //do {
            //    Console.WriteLine(x);
            //    x++;
            //} while (x < ROUNDS);

            //x = 0;

            //while (x < ROUNDS)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //WYRYSOWANIE NA KONSOLI POŁOWY CHOINKI, UZYTKOWNIK PODAJE WYSOKOSC CHOINKI
            //U ZYTKOWNIK PODAJE WYSOKOŚĆ: 5
            //POL CHOINKI POWINNO WYGLADAC:
            //*
            //**
            //***
            //****
            //*****

            //Console.WriteLine("Podaj wysokość choinki: ");
            //var height = decimal.Parse(Console.ReadLine());

            //for (var y = 0; y <= height; y++)
            //{
            //    for (var x = 0; x <= y; x++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////choinka

            //Console.WriteLine("Podaj wyskokość choinki ");
            //var x = int.Parse(Console.ReadLine());

            //var b = "";

            //for (var i = 0; i <= x; i++)
            //{
            //    b = b + "*";
            //    Console.WriteLine(b);
            //}

            //CAŁĄ CHOINKE -> poda wysokosc 3 to choinka wyglada nastepujaco:
            //  *  
            // ***
            //*****


            //Console.WriteLine("Podaj wyskokość choinki ");
            //var x = int.Parse(Console.ReadLine());

            //for (var h = 1; h <= x; h++) 
            //{ 
            //    for (var a = 0; a < x - h; a++) 
            //    { 
            //        Console.Write(" ");
            //    } 
            //    for (var b = 0; b < (h * 2) - 1; b++) 
            //    { 
            //        Console.Write("*"); 
            //    } 
            //    Console.WriteLine("\n"); 
            //}

            //// cała choinka
            //Console.WriteLine("Podaj wysokość choinki");
            //var Height = int.Parse(Console.ReadLine());
            //for (int h = 0; h < Height; h++)
            //{
            //    Console.Write(new string(' ', Height - h));
            //    Console.Write(new string('*', h * 2 + 1));
            //    Console.WriteLine();
            //}


            /* ~~~~~~~~~~~~~~~~~~ POLECENIA BREAK I CONTINUE ~~~~~~~~~~~~~~ */

            //PĘTLA FOR DO 10, DLA 5 UŻYJ POLECENIA CONTINUE DLA 7 BREAK

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5) continue;
            //    if (i == 7) break;
            //    Console.WriteLine(i);
            //}

            /* ~~~~~~~~~~~~~~~~~~ TABLICE ~~~~~~~~~~~~~~ */


            //STWORZYĆ WSZYSTKIE 3 TABLICE WYPEŁNIĆ ZNAKIEM '*' I WYRYSOWAĆ NA KONSOLI

            //char[] jednowymiarowa = new char[100];

            //char[,] dwuwymiarowa = new char[10, 20];

            //for (int i = 0; i < jednowymiarowa.Length; i++)
            //{
            //    jednowymiarowa[i] = '*';
            //}

            //for (int i = 0; i < jednowymiarowa.Length; i++)
            //{
            //    Console.Write(jednowymiarowa[i]);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        dwuwymiarowa[i,j] = '*';
            //    }
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        Console.Write(dwuwymiarowa[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //char[][] dwuSzarpana = new char[10][];
            //for (int i = 0; i < dwuSzarpana.Length; i++)
            //{
            //    dwuSzarpana[i] = new char[i + 1];
            //    for (int j = 0; j < i+1; j++)
            //    {
            //        dwuSzarpana[i][j] = '*';
            //    }
            //}

            //for (int i = 0; i < dwuSzarpana.Length; i++)
            //{
            //    for (int j = 0; j < dwuSzarpana[i].Length; j++)
            //    {
            //        Console.Write(dwuSzarpana[i][j]);
            //    }
            //    Console.WriteLine();
            //}


            //var a = new Tuple<int, int>(1, 2);
            //Console.WriteLine(a.Item1);
            //Console.WriteLine(a.Item2);

            //SPRAWDZ CZY PODANY SLOWE PRZEZ UŻYTKOWNIKA JEST POLINDROMEM
            Console.WriteLine("Podaj tekst:");
            var text = Console.ReadLine();

            bool isPalindrom = false;

            for (var i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    isPalindrom = false;
                    break;
                }
                else isPalindrom = true;
            }

            Console.WriteLine(isPalindrom ? "Jest palindromem" : "Nie jest plindromem");

        }
    }
}
