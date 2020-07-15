using System;
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
            Diary d1 = new Diary();
            Diary d2 = d1;
            
            GiveName(ref d2);

            Console.WriteLine(d2.name);
            
            int x1;
            IncrementNumber(out x1);

            Console.WriteLine(x1);
            Console.ReadKey();
        }
    }
}
