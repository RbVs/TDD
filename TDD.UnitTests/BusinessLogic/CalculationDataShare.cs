using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TDD.UnitTests.BusinessLogic
{
    public static class CalculationDataShare
    {
        public static IEnumerable<object[]> IssOddOrEvenData
        {
            get
            {
                yield return new object[] {1, true};
                yield return new object[] {2, false};
            }
        }

        public static IEnumerable<object[]> IsOddOrEvenExternalData
        {
            get
            {
                var allLines = File.ReadAllLines("IsOddOrEvenTestDataExtern.txt");
                return allLines.Select(x =>
                {
                    var lineSplit = x.Split(",");
                    return new object[] {int.Parse(lineSplit[0]), bool.Parse(lineSplit[1])};
                });
            }
        }
    }
}