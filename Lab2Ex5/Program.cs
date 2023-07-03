using System;

namespace Lab2Ex5
{
    internal class Program
    {
        /*Scrieti o functie care va afisa piramida numerelor pare, intre 2 si n, n fiind citit de la tastatura*/
        static void Main(string[] args)
        {
            Console.Write("Introdu numărul: ");
            int numar = int.Parse(Console.ReadLine());

            AfiseazaPiramidaNumarPar(numar);
        }

        static void AfiseazaPiramidaNumarPar(int numar)
        {
            for (int i = 2; i <= numar; i += 2)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

        }
    }
}
