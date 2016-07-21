using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook // internal: can be used by only the classes in the same assembly, private : only in the same class 
    {
        public string Name;// pvt class members-small caps public - upper case 
        public GradeBook()// default constructor , no return type for constructor , special instance of a class
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade) // access modifier 
        {
            grades.Add(grade);
        }

        public List<float> grades = new List<float>();// creating a new object with new keyboard , if private then encapsulation 

        // Class is a blueprint for creating objects  
        // static - without creating a instance , they will not change when defined 
        // 
        public GradeStatistics ComputeStatistics()// just before method name define method type example void , 2 variables can point to same object 
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0;

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade); // we can also use the math class math.max() will return the highest grade ,math.min lowest grade
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum = sum + grade;

            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }


      
    

    }
}
