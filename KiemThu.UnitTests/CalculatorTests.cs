using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Xceed.Wpf.Toolkit;

namespace KiemThu.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }
        /// <summary>
        /// Tổng của của 2 toán hạng
        /// </summary>
        /// <param name="x">Toán hạng 1</param>
        /// <param name="y">Toán hạng 2</param>
        /// <param name="expectedResult">Tổng của 2 toán hạng</param>
        [TestCase(1, 3, 4)]
        [TestCase(1, 4, 5)]
        [TestCase(1, -1, 0)]
        [TestCase(1, int.MaxValue, int.MaxValue + (long)1)]
        [TestCase(0, 0, 0)]  
        [TestCase(-5, -2, -7)] 
        [TestCase(100, -100, 0)]
        [TestCase(int.MaxValue, int.MaxValue, long.MaxValue)]

        public void Add_ValidInput_Sum2Digit(int x, int y, long expectedResult)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actualResult = calculator.Add(x, y);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// test case hiệu 2 số nguyên
        /// </summary>
        /// <param name="x">toán hạng 1</param>
        /// <param name="y">toán hạng 2</param>
        /// <param name="expectedResult">hiệu của 2 toán hạng</param>

        [TestCase(1, 3, -2)]
        [TestCase(5, 2, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, -2, -3)]
        [TestCase(10, -5, 15)]  
        [TestCase(100, 100, 0)]
        [TestCase(int.MaxValue, int.MinValue, (long)int.MaxValue + (long)int.MinValue)]
        [TestCase(int.MinValue, int.MaxValue, (long)int.MinValue - (long)int.MaxValue)]

        public void Subtract_ValidInput_Subtract2Numbers(int x, int y, long expectedResult)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actualResult = calculator.Subtract(x, y);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        /// <summary>
        /// Hàm test 2 số nguyên
        /// </summary>
        /// <param name="x">Toán hạng 1</param>
        /// <param name="y">Toáng hạng 2</param>
        /// <param name="expectedResult">Kết quả của 2 toán hạng</param>
        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(0, 5, 0)]
        [TestCase(10, 0, 0)]
        [TestCase(7, -2, -14)]  
        [TestCase(100, 1, 100)]  
        [TestCase(1, 1, 1)]
        [TestCase(int.MaxValue, int.MaxValue, (long)int.MaxValue * (long)int.MaxValue)]
        [TestCase(int.MinValue, int.MinValue, (long)int.MinValue * (long)int.MinValue)]
        public void Multiply_ValidInput_Multiply2Numbers(int x, int y, long expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            var actualResult = calculator.Multiply(x, y);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        /// <summary>
        /// Hàm test nhân 2 toán hạng
        /// </summary>
        /// <param name="x">Toán hạng 1</param>
        /// <param name="y">Toán hạng 2</param>
        /// <param name="expectedResult">Kết quả của 2 toán hạng</param>
        [TestCase(8, 4, 2)]
        [TestCase(10, 2, 5)]
        [TestCase(0, 5, 0)]
        [TestCase(-10, -2, 5)]
        [TestCase(100, 20, 5)]  
        [TestCase(-100, 20, -5)]  
        [TestCase(0, 1, 0)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(int.MinValue, 1, int.MinValue)]
        [TestCase(int.MaxValue, -1, -int.MaxValue)]
        public void Divide_ValidInput_Divide2Numbers(int x, int y, long expectedResult)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actualResult = calculator.Divide(x, y);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// Hàm test các trường hợp chia cho 0
        /// </summary>
        /// <param name="x">Toán hạng 1</param>
        /// <param name="y">Toán hạng 2</param>
        [TestCase(8, 0)]
        [TestCase(10, 0)]
        [TestCase(-100, 0)]
        [TestCase(0, 0)]
        public void DivideByZero_DivideByZero_ThrowsArgumentException(int x, int y)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(x, y));
        }
    }
}
