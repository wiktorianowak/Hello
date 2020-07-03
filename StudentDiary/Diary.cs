﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        List<float> ratings = new List<float>() ;


        public void AddNewRating(float rating)
        {
            ratings.Add(rating);
        }

        public float MaxRating()
        {
            return ratings.Max();
        }

        public float MinRating()
        {
            return ratings.Min();
        }

        public float CalcAvarageRating()
        {

            //float avg;
            //avg = ratings.Average();
            //return avg;

            float sum = 0, avg = 0;

            if (ratings.Count > 0)
            {
                foreach (var rating in ratings)
                {
                    sum += rating;
                }
                avg = sum / ratings.Count;
            }

            return avg;
            
        }


    }
}
