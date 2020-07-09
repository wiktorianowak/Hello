using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        List<float> ratings;

        //konstruktor, można utworzyć wpisując "ctor"
        //inicjalizujemy nowe listy itd w konstruktorze
        //(wtedy dana lista utworzy się dopiero gdy utworzymy obiekt)
        // ^ DOBRA PRAKTYKA
        //należy stosować gdy przekazujemy wartości początkowe/domyślne
        public Diary()
        {
            ratings = new List<float>();
        }

        public void AddNewRating(float rating)
        {
            ratings.Add(rating);
        }
        
        public DiaryStats ComputeStats()
        {
            DiaryStats stats = new DiaryStats();

            float sum = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.avgGrade = sum / ratings.Count;
            stats.maxGrade = ratings.Max();
            stats.minGrade = ratings.Min();

            return stats;
        }
    }
}
