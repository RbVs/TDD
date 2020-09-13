using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace TDD.UnitTests.BusinessLogic
{
    public class IsOddOrEvenDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {1, true};
            yield return new object[] {2, false};
        }
    }
}