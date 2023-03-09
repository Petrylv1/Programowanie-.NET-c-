using System;

namespace PierwiastekNTegoStopnia
{
    class Zad5 
    {
        static void Main(string[] args)
        {
            // Wczytanie liczby K i stopnia n z klawiatury
            Console.Write("Podaj liczbę K: ");
            double k = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj stopień pierwiastka n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Obliczenie pierwiastka n-tego stopnia z liczby K
            double pierwiastek = Math.Pow(k, 1.0 / n);

            // Wyświetlenie wyniku na ekranie
            Console.WriteLine("Pierwiastek {0}-tego stopnia z liczby {1} wynosi: {2:F2}", n, k, pierwiastek);

            Console.ReadKey();
        }
    }
}
