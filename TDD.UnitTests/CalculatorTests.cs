using System;
using TDD.BusinessLogic;
using Xunit;

namespace TDD.UnitTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        public void Add_SimpleNumbers_ReturnsPass(double num1, double num2, double expected)
        {
            // Arrange
            var calc = new Calculator();
            // Act
            var actual = calc.Add(num1, num2);
            // Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-5, 3, -8)]
        public void Subtract_SimpleNumbers_ReturnsPass(double num1, double num2, double expected)
        {
            var calc = new Calculator();
            var actual = calc.Substract(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(2, 0, 0)]
        [InlineData(0, 3, 0)]
        public void Multiply_SimpleNumbers_ReturnsPass(double num1, double num2, double expected)
        {
            var calc = new Calculator();
            var actual = calc.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,2)]
        [InlineData(0,5,0)]
        [InlineData(2,10,0.2)]
        public void Divide_SimpleNumbers_ReturnsPass(double num1, double num2, double expected)
        {
            var calc = new Calculator();
            var actual = calc.Divide(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,0)]
        public void Divide_ByZero_ReturnInvalidArgumentException(double num1, double num2)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            //Action action = () => calc.Divide(num1, num2);

            //Assert
            Assert.Throws<ArgumentException>(() => calc.Divide(num1, num2));
            //Assert.Throws<ArgumentException>(action);
        }
    }
}