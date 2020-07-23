using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    public class Diary
    {
        private List<float> ratings;

        public static float minGrade = 0;
        public static float maxGrade = 10;
        public static long count = 0;
        public string name;

        //konstruktor, można utworzyć wpisując "ctor"
        //inicjalizujemy nowe listy itd w konstruktorze
        //(wtedy dana lista utworzy się dopiero gdy utworzymy obiekt)
        // ^ DOBRA PRAKTYKA
        //należy stosować gdy przekazujemy wartości początkowe/domyślne
        public Diary()
        {
            ratings = new List<float>();
            //zliczanie liczby słowników danej klasy
            count++;
        }

        public void AddNewRating(float rating)
        {
            if (rating>=0 && rating<=10)
            {
                ratings.Add(rating);
            }
            
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
