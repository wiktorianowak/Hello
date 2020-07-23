using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {
        /// <summary>
        /// użycie słowa kluczowego ref powoduje, że zmiany które wprowadzamy na zmiennej diary 
        /// są też wprowadzane na tej zmiennej
        /// JEŚLI PRZYPISUJEMY DO diary NOWY DZIENNICZEK JEST ON WTEDY RÓWNIEŻ PRZYPISYWANY DO d2
        /// </summary>
        /// <param name="diary"></param>
        static void GiveName(ref Diary diary)
        {
            //poniżej tworzymy nowy obiekt
            //w innym przypadku działamy na kopii referencji wskazującej ciągle na ten sam obiekt
            diary = new Diary();
            diary.name = "dzienniczek - givename";
        }

        /// <summary>
        /// jeśli wybierzemy przekazanie przez referecje zmiana zostanie wprowadzonarównież na zmiennej
        /// x1, bo przekazujemy referencje do tej zmiennej
        /// ___
        /// jeśli wybieramy 'out' zmienna musi być wcześniej zainicjalizowana, ale 
        /// zmienna x1 nie musi być inicjalizowana, a jedynie deklarowana
        /// </summary>
        /// <param name="number"></param>
        static void IncrementNumber(out int number)
        {
            number = 9;
        }

       

        static void Main(string[] args)
        {
            //PassingByValAndRef();

            //Immutable();

            Arrays();

            WriteAsByte(43);

            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Speak("Bip bop, przepraszam");

            Console.ReadKey();
        }

        private static void WriteAsByte(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            foreach (byte b in bytes)
            {
                Console.WriteLine("0x{0:x2}", b);
            }
        }

        private static void Arrays()
        {
            float[] ratings = new float[5];

            AddRatings(ratings);

            foreach (var rating in ratings)
            {
                Console.WriteLine(rating);
            }
        }

        private static void AddRatings(float[] ratings)
        {
            if (ratings.Length >= 5)
            {
                ratings[0] = 4.6f;
                ratings[1] = 8.5f;
                ratings[2] = 8.6f;
                ratings[3] = 9.9f;
                ratings[4] = 7.7f;
            }
            else
            {
                Console.WriteLine("niepoprawna długość tablicy");
            }
        }

        private static void PassingByValAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);

            Console.WriteLine(d2.name);

            int x1;
            IncrementNumber(out x1);

            Console.WriteLine(x1);

            string name1 = "Marcin";
            string name2 = "marcin";

            bool areEqual = name1.Equals(name2, StringComparison.CurrentCulture);

            Console.WriteLine(areEqual);
        }

        private static void Immutable()
        {
            string name = " MMa ";
            name = name.Trim();
            Console.WriteLine(name);

            DateTime date = new DateTime(2020, 11, 30);
            DayOfWeek dayOfWeek = date.DayOfWeek;
            String dayName = dayOfWeek.ToString();
            date = date.AddDays(9);
            Console.WriteLine(dayName + ", " + date);
        }
    }
}
