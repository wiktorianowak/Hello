using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Members.Diary();
            diary.AddNewRating(9.9f);
            diary.AddNewRating(7.5f);
            diary.AddNewRating(8f);

            DiaryStats stats = diary.ComputeStats();
            Console.WriteLine(stats.maxGrade);
            Console.WriteLine(stats.minGrade);
            Console.WriteLine(stats.avgGrade);


        }
    }
}
