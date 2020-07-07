using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddNewRating(8);
            diary.AddNewRating(5);

            Diary diary2 = diary;
            diary.AddNewRating(5);
      
            //zmienna wskazuje na obiekt!
            //dlatego w powyższym kodzie modyfukujemy w obu przypadkach ten sam obiekt
        }
    }
}
