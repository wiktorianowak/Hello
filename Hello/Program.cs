using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            { 

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
           
        }
    }
}
