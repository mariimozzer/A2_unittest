using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void IsEquilateral_input222_true()
        {
            //Arrange
            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(2, 2, 2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
