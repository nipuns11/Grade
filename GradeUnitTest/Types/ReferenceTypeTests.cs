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
        public void VariableHoldaRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Your grade book";
            Assert.AreEqual(g1.Name, g2.Name);  
        }
    
    }
}
