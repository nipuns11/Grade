using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook // internal: can be used by only the classes in the same assembly, private : only in the same class 
    {

        public GradeBook()// default constructor , no return type for constructor , special instance of a class
        {
            _name = "Grades";
            grades = new List<float>();
        }

        public string Name // auto implement property  
            // one method calls another method calls another method builds a stack 
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))// throw 


                {
                    throw new ArgumentException("Name cannot be null or empty");
                }  


                    if (_name != value && nameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.existingName = _name;
                        args.newName = value;

                        nameChanged(this, args);
                    }
                    _name = value;
                }
            }
        

        public void WriteGrades(TextWriter destination) // you can use return in void method
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        private string _name;
        public void AddGrade(float grade) // access modifier 
        {
            grades.Add(grade);
        }

        public List<float> grades;// creating a new object with new keyboard , if private then encapsulation 

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

        public NameChnagedDelegate nameChanged;

    }
}
// the throw is used to raise a exception 