using System;

class Zad4
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź wartość a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Wprowadź wartość b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Wprowadź wartość c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Pierwiastki równania to: x1 = {0:F2}, x2 = {1:F2}", x1, x2);

            //":F2" to format specyfikacji, który mówi, że liczba zmiennoprzecinkowa ma być wyświetlona z dokładnością do dwóch miejsc po przecinku.
            //"F" oznacza floating-point (liczby zmiennoprzecinkowe), a "2" oznacza liczbę miejsc po przecinku.
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Równanie ma jeden pierwiastek: x = {0:F2}", x);
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }

        Console.ReadKey();
    }
}

