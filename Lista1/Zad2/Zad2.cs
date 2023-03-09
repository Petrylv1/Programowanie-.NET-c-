using System;

class Zad2
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź tekst: ");
        string text = Console.ReadLine();

        if (IsPalindrome(text))
        {
            Console.WriteLine("{0} jest palindromem", text);
        }
        else
        {
            Console.WriteLine("{0} nie jest palindromem", text);
        }

        Console.ReadKey();
    }

    static bool IsPalindrome(string text)
    {
        for (int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
