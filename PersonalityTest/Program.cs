using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Mis on su lemmikvärv:");
            string UserColor = Console.ReadLine().ToLower();


            if (UserColor == "Punane")

            {
                Console.WriteLine("Oled romantiline.");
            }

            else if (UserColor == "Sinine")
            {
                Console.WriteLine("Oled töökas");

            }

            else if (UserColor == "Roheline")
            {
                Console.WriteLine("Oled looduslik");

            }

            else

            {
                Console.WriteLine($"Oled {UserColor} ükssarvik!");

            }
        }
    }
}
