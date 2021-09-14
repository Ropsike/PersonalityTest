using System;

namespace KasutajaHinne
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?:");
            string UserGrade = Console.ReadLine();

            switch (UserGrade)

            {
                case "sain 5":
                    Console.WriteLine("Selge, suurepärane!");
                    break;

                case "sain 4":
                    Console.WriteLine("Oh, väga hea!");
                    break;

                case "sain 3":
                    Console.WriteLine("Täitsa hästi!");
                    break;

                case "sain 2":
                    Console.WriteLine("Okei, see on rahuldav.");
                    break;

                case "sain 1":
                    Console.WriteLine("See on puudulik.");
                    break;

            }

            

            

        }
    }
}