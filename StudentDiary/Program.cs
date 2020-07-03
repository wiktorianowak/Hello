using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            //utworzenie nowego obiektu typu Diary dodany przez konstruktor domyślny ()
            Diary diary = new Diary();

            //diary.AddNewRating(9.0f);
            //diary.AddNewRating(5);
            //diary.AddNewRating(6.7f);
            //diary.AddNewRating(7.6f);
            //diary.AddNewRating(9.6f);

            //float avg = diary.CalcAvarageRating();
            //float max = diary.MaxRating();
            //float min = diary.MinRating();

            for ( ; ; )
            {
                Console.WriteLine("Podaj ocenę 1-10: ");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);
                
                if (rating == 11)
                {
                    break;
                }

                if (result)
                {
                    if (rating >= 0 && rating <= 10)
                    {
                        diary.AddNewRating(rating);
                    }
                    else
                        Console.WriteLine("Niepoprawna ocena");
                }
            }

            Console.WriteLine("Średnia: "  + diary.CalcAvarageRating() + ", maksymalna: " + diary.MaxRating() + ", minimalna: " + diary.MinRating());
            Console.ReadKey();
        }
    }
}
