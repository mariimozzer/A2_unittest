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
        //EQUILATERAL TESTING

        [Test]
        public void IsEquilateral_input2_2_2_true()
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

        //ISOSCELES TESTING

        [Test]
        public void IsIsosceles_input2_3_2_true()
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
        public void IsIsosceles_input2_2_3_true()
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
        public void IsIsosceles_input3_2_2_true()
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

        //SCALENE TESTING

        [Test]
        public void IsScalene_input7_4_5_true()
        {
            //Arrange
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(7,4,5);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsScalene_input100_140_120_true()
        {
            //Arrange
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(100,140,120);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsScalene_input4_5_6_true()
        {
            //Arrange
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(4,5,6);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsScalene_input8_7_10_true()
        {
            //Arrange
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(8,7,10);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsScalene_input6_5_4_true()
        {
            //Arrange
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual;

            //Act
            Triangle tri = new Triangle();
            actual = tri.AnalyzeTriangle(6,5,4);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
