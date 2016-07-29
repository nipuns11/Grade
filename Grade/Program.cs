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

            try // for handling exceptions
            {
                Console.WriteLine("Enter a name");
                    book.Name = Console.ReadLine();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Null exception");
            }
            finally//
            {

            }



            book.AddGrade(66);
            book.AddGrade(90);
            book.AddGrade(77.4f);
            book.WriteGrades(Console.Out);// out is a reserved keyword , using iterations 

            
            
            
            //the public keyword is an access modifier , default is private is nothing is specified 
            book.ComputeStatistics();
            //encapsulating every grade stats in one methods
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);// c sharp compiler will choose the method which has the same value types
            WriteResult("highest:", (int)stats.HighestGrade); // this is a type cast or implicit conversion
            WriteResult("lowest", stats.LowestGrade);// method overloading to take diff parameter type 
                 
            
            WriteResult("Grade is "+ stats.Description, stats.LetterGrade);// using method for letter 
            /* C# command line compiler 
             file --> .exe --> assembly ( dll files) dynamic link libraries reusable code , like .net framework ,mscorelib that contain core libraries , Global assembly cache()
            build into assembly on run  ,debug directory , grade.exe
            */

            /* assembly reference , you can use object reference , you can use reference manager ,

            Unit test - I can give values and look at output
            */


        }

        static void WriteResult(string decr, string result) // two methods cannot have same signature like ref types
        {
            Console.WriteLine($"{decr}: {result}",decr,result );
        }

        static void WriteResult(string decr, float result) // two methods cannot have same signature like ref types
        {
            Console.WriteLine(decr + ":" + result);
        }


    }
}
