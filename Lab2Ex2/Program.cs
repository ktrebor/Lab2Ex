using System;

namespace Lab2Ex2
{
    internal class Program
    {
        /*Scrieti o functie care va determina daca un numar este sau nu palindrom*/
        static void Main(string[] args)
        {
            Console.Write("Introdu numărul: ");
            int numar = int.Parse(Console.ReadLine());

            if (IsPalindrome(numar))
            {
                Console.WriteLine("Numărul ESTE un palindrom.");
            }
            else
            {
                Console.WriteLine("Numărul NU ESTE un palindrom.");
            }
        }

        static bool IsPalindrome(int numar)
        {
            int numarIntial = numar;
            int numarInvers = 0;

            while (numar > 0)
            {
                int ultimaCifra = numar % 10; //obtine ultima cifra din numar
                numarInvers = numarInvers * 10 + ultimaCifra; //constructia inversa a numarului
                numar = numar / 10; //taie ultima cifra
            }

            if (numarIntial == numarInvers)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
