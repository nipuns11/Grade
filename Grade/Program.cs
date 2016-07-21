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

            /* C# command line compiler 
             file --> .exe --> assembly ( dll files) dynamic link libraries reusable code , like .net framework ,mscorelib that contain core libraries , Global assembly cache()
            build into assembly on run  ,debug directory , grade.exe
            */

            /* assembly reference , you can use object reference , you can use reference manager ,

            Unit test - I can give values and look at output



            */

        }
    }
}
