using System;

class Zad1
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź liczbę: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine("{0} jest liczbą pierwszą", number);
        }
        else
        {
            Console.WriteLine("{0} nie jest liczbą pierwszą", number);
        }
       
        Console.ReadKey();
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    //Funkcja rozpoczyna sprawdzanie, czy liczba jest mniejsza niż 2, ponieważ 0 i 1 nie są uważane za liczby pierwsze.
    //Jeśli podana liczba jest mniejsza niż 2, funkcja zwraca wartość false.

    //Jeśli liczba jest większa lub równa 2, funkcja wykonuje pętlę for od 2 do pierwiastka kwadratowego z podanej liczby.
    //Pętla sprawdza, czy liczba jest podzielna przez każdą liczbę całkowitą z zakresu od 2 do pierwiastka kwadratowego z tej liczby.
    //Jeśli liczba jest podzielna przez którąś z tych liczb, to nie jest to liczba pierwsza i funkcja zwraca wartość false.

    //Jeśli funkcja wykonuje pętlę bez przerwania i nie znalazła żadnej liczby, przez którą podana liczba byłaby podzielna, to oznacza to,
    //że podana liczba jest liczbą pierwszą i funkcja zwraca wartość true.
}
