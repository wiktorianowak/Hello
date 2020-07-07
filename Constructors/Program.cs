using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(1, "Jan");
            Person person3 = new Person(2, "Maciej", "Kowalski");
            Person person4 = new Person(3, "Michal", "Nowicki", "Wrocław", 22, "mezczyzna");

            Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}
