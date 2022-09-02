using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lib_figure;
using static System.Math;

namespace TestProject1
{
    [TestClass]
    public class UnitTest_Figure
    {
        [TestMethod]
        public void GetAreaCirlce()
        {
            //Arrange
            double radius = 13.0;
            Circle circle = new Circle(radius);
            double expectedArea = PI * Pow(radius, 2);
            //Act
            double area = circle.Get_Area();
            //Assert
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void GetAreaCir()
        {
            //Arrange
            double radius = 10.0;
            Circle circle = new Circle(radius);
            double expectedArea = PI * Pow(radius, 2);
            //Act
            double area = circle.Get_Area();
            //Assert
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void CreateTriangleBad()
        {
            //Arrange
            double a = 20;
            double b = 40;
            double c = 80;
            //Act and Assert
            try
            {
                new Triangle(a, b, c);
                Assert.Fail("The sides of the triangle are set incorrectly");
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        [TestMethod]
        public void GetAreaTriangle()
        {
            //Arrange
            double a = 10;
            double b = 20;
            double c = 25;
            Triangle triangle = new Triangle(a, b, c);

            //Act
            double area = triangle.Get_Area();
            //Assert
            Assert.IsTrue(area <= 95.0 && area > 94.99);
        }

        [TestMethod]
        public void Check_Right_Triangle()
        {
            //Arrange
            double a = 6.0;
            double b = 8.0;
            double c = 10.0;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            bool testResult = triangle.Check_Right_Triangle();
            //Assert
            Assert.IsTrue(testResult);
        }
    }
}

