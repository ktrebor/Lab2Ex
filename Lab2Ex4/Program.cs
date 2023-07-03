using System;

namespace Lab2Ex4
{
    internal class Program
    {
        /*Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati o si afisati i rezultatul*/
        static void Main(string[] args)
        {
            Console.Write("Introdu numărul: ");
            int numar = int.Parse(Console.ReadLine());

            if (EstePatratPerfect(numar))
            {
                Console.WriteLine("Numărul ESTE pătrat perfect.");
            }
            else
            {
                Console.WriteLine("Numărul NU ESTE pătrat perfect.");
            }
        }

        static bool EstePatratPerfect(int numar)
        {
            double patratulNumarului = Math.Sqrt(numar);

            if (patratulNumarului - Math.Floor(patratulNumarului) == 0)
            {
                return true;
            }
            return false;
        }
    }
}