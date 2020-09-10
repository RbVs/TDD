using System.Collections.Generic;
using TDD.BusinessLogic;
using Xunit;

namespace TDD.UnitTests
{
    public class CalculationTests
    {
        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var calc = new Calculations();
            //Collection testing, action : Assert
            Assert.All(calc.FiboNumbers, number => Assert.NotEqual(0, number));
        }

        [Fact]
        public void FiboIncludes13()
        {
            var calc = new Calculations();
            //Contains, use to search in collection
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        public void FiboDoesNotInclude4()
        {
            var calc = new Calculations();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        public void CheckCollection()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = new Calculations();
            //compare 2 collections
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }
    }
}