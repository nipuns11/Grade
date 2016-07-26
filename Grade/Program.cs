using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {



            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Grade book program");
            GradeBook book = new GradeBook(); //constructor invoked for new instance, special methods to initialize methods 
            book.nameChanged += OnNameChange;
            


            book.AddGrade(66);
            book.AddGrade(90);
            GradeBook book2 = new GradeBook();
            book2.AddGrade(57);// 
            GradeBook book3 = book;// copying a variable from the pointer
            book3.AddGrade(33);
            //the public keyword is an access modifier , default is private is nothing is specified 
            book.ComputeStatistics();
            //encapsulating every grade stats in one methods
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
            WriteResult("Average", stats.AverageGrade);// c sharp compiler will choose the method which has the same value types
            WriteResult("highest:", (int)stats.HighestGrade); // this is a type cast or implicit conversion
            WriteResult("lowest", stats.LowestGrade);// method overloading to take diff parameter type 
            book.Name = "Grade book";
            book.Name = null; // exception handling 
            Console.WriteLine(book.Name);

            /* C# command line compiler 
             file --> .exe --> assembly ( dll files) dynamic link libraries reusable code , like .net framework ,mscorelib that contain core libraries , Global assembly cache()
            build into assembly on run  ,debug directory , grade.exe
            */

            /* assembly reference , you can use object reference , you can use reference manager ,

            Unit test - I can give values and look at output
            */


        }

        static void WriteResult(string decr, int result) // two methods cannot have same signature like ref types
        {
            Console.WriteLine(decr + ":" + result);
        }
        static void WriteResult(string decr, float result) // using static as invoking in static method 
        {
            Console.WriteLine(decr + ":" + result); // we can use arrays to pass parameters so example a param float[] result will pass multiple value and we will have to loop through the array and create 
                                                    // Console.WriteLine("{0}:{1:F2}", decr, result); the first element will pass to decr and second will go to result , take the number and format as a float type (f2), (c) is for currency 
        }

        static void OnNameChange(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.existingName} to {args.newName}");
        }

       
    }
}
