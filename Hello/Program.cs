using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            ValueTypes();

            for (; ; )
            {
                Greeting();
                CheckAge();
                Settings();
            }

        }

        private static void ValueTypes() 
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia programu
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();      //czekaj na naciśnięcie klawisza
            Console.Clear();        //wyczyszczenie tekstu na ekranie
            Console.ResetColor();   //resetowanie koloru
        }

        /// <summary>
        /// Sprawdzenie wieku uzytkownika
        /// </summary>
        private static void CheckAge()
        {
            Console.Write("Ile masz lat? ");
            int age;
            bool tryAge = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Możesz wypić browara");
            }
            else if (tryAge)
            {
                Console.WriteLine("Pij mleko");
            }
            else
            {
                Console.WriteLine("Niepoprawny wiek");
            }
        }

        /// <summary>
        /// Wyświetlenie odpowiedniego powitania
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
=======
            

                Console.Write("Wpisz imie: ");
                string name = Console.ReadLine();
                Console.WriteLine("Witaj, " + name);

                Console.Write("Ile masz lat? ");
                int age;
                bool tryAge = int.TryParse(Console.ReadLine(), out age);


                if (age >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Możesz wypić browara");
                }
                else if (tryAge)
                {
                    Console.WriteLine("Pij mleko");
                }
                else
                {
                    Console.WriteLine("Niepoprawny wiek");
                }

                Console.ReadKey();
                Console.Clear();
            }
      
        
>>>>>>> Stashed changes
    }
}
