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

        [Test]
        public void IsIsosceles_input232_true()
        {
            //Arrange
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(2, 3, 2);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void IsIsosceles_input223_true()
        {
            //Arrange
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(2, 2, 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsIsosceles_input322_true()
        {
            //Arrange
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(3, 2, 2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
