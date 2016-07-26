using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeUnitTest.Types

{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void GradeBookVariableHoldaRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;// pointers pointing to grade book , value types are fast 

            g1.Name = "Your grade book";
            Assert.AreEqual(g1.Name, g2.Name);  
            // variables holds the value, no pointer no reference , value types are immutable , built in primitive int , double , float 


        }
        [TestMethod]
        public void UsingArrays()// arrays , every value type or ref type 
            // use struct to create value type
            // use class to create ref type , string behave like a value type 
            // ,method define behavior , has a return type , void if no value , every method has zero or more parameters , use params keyboard to accept a variable numnber of paramters 
            // every method has a signature which is the name of method and parameters 
        {
            float[] grades;
            grades = new float[3];
            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
         }

        private void AddGrades(float[] grades)
        {
            
            grades[1] = 89.1f;
            
        }

        [TestMethod]
        public void RefrenceTpesPassbyValue()// fields are variable for a class , can be readonly 
            // properties can define a get and or set accessors 
            // often used to expose and control fields 
            // auto implement property only get-set   
        {
        GradeBook book1 = new GradeBook();
        GradeBook book2 = book1;
        GivebookaName(ref book2);// explicit call 
         Assert.AreEqual("A grade book", book2.Name);

        }
        private void GivebookaName(ref GradeBook book)// ref keyboard -book is a pointer to a pointer 
        {
            book = new GradeBook();
            book.Name = "A grade book";
        }

        [TestMethod]
        public void Valuetypepassbyvalue()
        {
            int x = 46;
            Increamentnumber(ref x);
            Assert.AreEqual(47,x);
        }

        private void Increamentnumber (ref int number)
        {
            number += 1;
        }



        [TestMethod]
        public void StringComparison() // enum example 
        {
            // string as  a refrence type
            string name = "hello";
            string name1 = "hello";
            bool result = string.Equals(name, name1, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntvariablesHoldavalue()
        {
            int x1 = 100;// int and int32 are same
            int y = x1;// passing a value type 
            x1 = 4;
            
            Assert.AreNotEqual(x1, y);
        }
        [TestMethod]
        public void AddDaystoDateTime()
        {
            DateTime date = new DateTime(2016, 1, 1);
            date = date.AddDays(20);
            Assert.AreEqual(21, date.Day);
        }
        // immutability - value types are immutable 
        public void UppercaseString() 
        {
            string name = "hello";
            name = name.ToUpper();// assign name to variable 
            Assert.AreEqual("hello", name);
        }

    }
}
