using System;
using System.Collections.Generic;
using System.Text;
using TDD.BusinessLogic;
using Xunit;

namespace TDD.UnitTests
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("Ajac", "Makes");
            Assert.Equal("Ajac Makes", result);
            //ignoreCase: -> vergleich werte in eine nicht case sensitiven weise
            Assert.Equal("Ajac makes", result, true);
            Assert.Contains("Ajac", result);
            Assert.Contains("ajac", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("Aj", result);
            Assert.EndsWith("es", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            Assert.Null(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("Rus", "Lan");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
