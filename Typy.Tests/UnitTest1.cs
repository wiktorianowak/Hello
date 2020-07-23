using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Typy.Tests
{
    [TestClass]
    public class DiaryTest
    { 
        [TestMethod]
        public void TestCalsMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddNewRating(9f);
            diary.AddNewRating(4f);
            diary.AddNewRating(3.2f);
            diary.AddNewRating(9f);
            diary.AddNewRating(9.8f);

            DiaryStats stats = diary.ComputeStats();

            Assert.AreEqual(9.8f, stats.maxGrade);
            Assert.AreEqual(3.2f, stats.minGrade);
            Assert.AreEqual(7f, stats.avgGrade);
        }

        [TestMethod]
        public void TestPassedByValue()
        {
            Diary diary = new Diary();
            diary.name = "dziennik";

            SetNameToMoj(diary);

            Assert.AreEqual("moj", diary.name);

        }

        private void SetNameToMoj(Diary diary)
        {
            diary.name = "moj";
        }
    }
}
