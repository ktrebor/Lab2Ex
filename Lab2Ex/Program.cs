using System;

namespace Lab2Ex
{
    internal class Program
    {
        /*Scrieti o functie care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra*/
        static void Main(string[] args)
        {
            Console.Write("Introduce numărul de elemente din șir: ");
            int n = int.Parse(Console.ReadLine());

            int[] numere = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceți numărul {i + 1}: ");
                numere[i] = int.Parse(Console.ReadLine());
            }

            double mediaAritmeticaPare = CalculeazaMediaPare(numere);

            Console.WriteLine($"Media aritmetică a numerelor pare este: {mediaAritmeticaPare}");
        }

        static double CalculeazaMediaPare(int[] numere)
        {
            double sumaPare = 0;
            int elementePare = 0;

            for (int i = 0; i < numere.Length; i++)
            {
                if (numere[i] % 2 == 0)
                {
                    sumaPare += numere[i];
                    elementePare++;
                }
            }

            if (elementePare == 0)
            {
                return 0;
            }

            double mediaAritmeticaPare = sumaPare / elementePare;
            return mediaAritmeticaPare;
        }
    }
}
