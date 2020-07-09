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


            //float avg = diary.CalcAvarageRating();
            //float max = diary.MaxRating();
            //float min = diary.MinRating();

            //for ( ; ; )
            //{
            //    Console.WriteLine("Podaj ocenę 1-10: ");

            //    float rating;
            //    bool result = float.TryParse(Console.ReadLine(), out rating);

            //    if (rating == 11)
            //    {
            //        break;
            //    }

            //    if (result)
            //    {
            //        if (rating >= 0 && rating <= 10)
            //        {
            //            diary.AddNewRating(rating);
            //        }
            //        else
            //            Console.WriteLine("Niepoprawna ocena");
            //    }
            //}

            //Console.WriteLine("Średnia: "  + diary.CalcAvarageRating() + ", maksymalna: " + diary.MaxRating() + ", minimalna: " + diary.MinRating());
            //Console.ReadKey();


            diary.AddNewRating(9);
            diary.AddNewRating(5);
            diary.AddNewRating(6.7f);
            diary.AddNewRating(7.6f);
            diary.AddNewRating(9.6f);

            Diary diary2 = new Diary();
            diary2.AddNewRating(9.8f);
            diary2.AddNewRating(5);
            diary2.AddNewRating(6);
            diary2.AddNewRating(7);
            diary2.AddNewRating(9.6f);

            DiaryStats stats = diary.ComputeStats();
            DiaryStats stats2 = diary2.ComputeStats();
            

        }
    }
}
