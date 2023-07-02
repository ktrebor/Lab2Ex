using System;

namespace Lab2Ex3
{
    internal class Program
    {
        /*Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati rezultatul*/
        static void Main(string[] args)
        {
            Console.Write("Introdu numărul: ");
            int numar = int.Parse(Console.ReadLine());

            if (EstePrim(numar))
            {
                Console.WriteLine("Numărul ESTE prim.");
            }
            else
            {
                Console.WriteLine("Numărul NU ESTE prim.");
            }
        }

        static bool EstePrim(int numar)
        {
            if (numar <= 1)
            {
                return false;
            }

            if (numar == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(numar); i++)
            {
                if (numar % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
