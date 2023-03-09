using System;

class Zad3
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź liczbę: ");
        int number = int.Parse(Console.ReadLine());

        if (IsTriangular(number))
        {
            Console.WriteLine("{0} jest liczbą trójkątną", number);
        }
        else
        {
            Console.WriteLine("{0} nie jest liczbą trójkątną", number);
        }

        Console.ReadKey();
    }

    static bool IsTriangular(int number)
    {
        int i = 1;
        while (number > 0)
        {
            number -= i;
            i++;
        }

        return number == 0;
    }
}
