using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Mis hinde sa said?:");
            string UserGrade = Console.ReadLine().ToLower();


            if (UserGrade == "5")

            {
                Console.WriteLine("Suurepärane tulemus.");
            }

            else if (UserGrade == "4")
            {
                Console.WriteLine("Väga hea tulemus");

            }

            else if (UserGrade == "3")
            {
                Console.WriteLine("See on hea");

            }

            else if (UserGrade == "2")
            {
                Console.WriteLine("See on rahuldav tulemus");

            }

            else if (UserGrade == "1")
            {
                Console.WriteLine("Tulemus on puudulik");

            }

          

            
        }
    }
}
