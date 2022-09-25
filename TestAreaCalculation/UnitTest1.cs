using NUnit.Framework;
using ClassLibrary;
using System;

namespace TestAreaCalculation
{
    [TestFixture]
    public class Tests
    {

        /// <summary>
        /// ��������� ���������� ������� �����
        /// </summary>
        [Test]
        public void CircleSquareCalculationTest()
        {            
            var circle = new Circle(4);         
            var CircleSquare = circle.GetSquare();
            
            Assert.AreEqual(50.26548245743669, CircleSquare);
        }

        /// <summary>
        /// ��������� ������������� ������ �����
        /// </summary>
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }


        /// <summary>
        /// ��������� ���������� ������� �����������
        /// </summary>
        [Test]
        public void TriangleSquareCalculationTest()
        {
            var Triangle = new Triangle(3,4,5);

            var TriangleSquare = Triangle.GetSquare();

            Assert.AreEqual(6, TriangleSquare);
        }

        /// <summary>
        /// ��������� �������� �� ����������� ������������� 
        /// </summary>
        [Test]
        public void IsRectangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var IsRectangle = triangle.IstRectangle;

            //Assert
            Assert.AreEqual(true, IsRectangle);
        }


        /// <summary>
        /// ��������� �������� �� ����������� �� ������������� 
        /// </summary>
        [Test]
        public void NotRectangleTest()
        {
            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var IsRectangle = triangle.IstRectangle;

            //Assert
            Assert.AreEqual(false, IsRectangle);
        }
    }
}