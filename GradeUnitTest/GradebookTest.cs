using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grade;

namespace GradeUnitTest
{

    [TestClass]
    public class GradebookTest
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(110);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(110, result.HighestGrade);
        }
        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(60);
            book.AddGrade(80);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(60, result.LowestGrade);



        }
        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(50);
            book.AddGrade(90);
            
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(70, result.AverageGrade);



        }
    }

}