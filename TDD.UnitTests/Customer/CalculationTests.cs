using System;
using System.Collections.Generic;
using TDD.BusinessLogic;
using TDD.UnitTests.BusinessLogic;
using Xunit;

namespace TDD.UnitTests.Customer
{
    public class CalculatorFixture : IDisposable
    {
        public Calculations Calc => new Calculations();

        public void Dispose()
        {
            //Clean
        }
    }

    public class CalculationTests : IClassFixture<CalculatorFixture> // -> IClassFixture -> Markup class for initialize values, Singelton class
    {
        private readonly CalculatorFixture _calculatorFixture;

        // ohne DI wird der Constructor jedes mal neu erstellt
        public CalculationTests(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            //var calc = new Calculations(); //-> Singleton instead of new Object.
            var calc = _calculatorFixture.Calc;
            //Collection testing, action : Assert
            Assert.All(calc.FiboNumbers, number => Assert.NotEqual(0, number));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = _calculatorFixture.Calc;
            //Contains, use to search in collection
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            var calc = _calculatorFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _calculatorFixture.Calc;
            //compare 2 collections
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculations();
            var result = calc.IsOdd(value);
            Assert.Equal(result, expected);
        }

        [Theory]
        [MemberData(nameof(CalculationDataShare.IssOddOrEvenData), MemberType = typeof(CalculationDataShare))]
        public void IsOdd_TestOddAndEven_WithSharedClassData(int value, bool expected)
        {
            var calc = new Calculations();
            var result = calc.IsOdd(value);
            Assert.Equal(result, expected);
        }
        [Theory]
        [MemberData(nameof(CalculationDataShare.IsOddOrEvenExternalData), MemberType = typeof(CalculationDataShare))]
        public void IsOdd_TestOddAndEven_WithExternalData(int value, bool expected)
        {
            var calc = new Calculations();
            var result = calc.IsOdd(value);
            Assert.Equal(result, expected);
        }

        [Theory]
        [IsOddOrEvenData]
        public void IsOdd_TestOddAndEven_WithCustomAttribute(int value, bool expected)
        {
            var calc = new Calculations();
            var result = calc.IsOdd(value);
            Assert.Equal(result, expected);
        }
    }
}