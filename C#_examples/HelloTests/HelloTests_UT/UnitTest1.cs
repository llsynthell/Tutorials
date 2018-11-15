using System;
using Xunit;

using HelloTests.Class;

namespace HelloTests_UT
{
    public class UnitTest1
    {
        TestMe test = new TestMe();

        // rString Tests
        [Theory]
        [InlineData("Hello")]
        private void rString_True(string s)
        {
            Assert.Equal(s, test.rString());
        }

        [Theory]
        [InlineData("Tests")]
        private void rString_NotEqual(string s)
        {
            Assert.NotEqual(s, test.rString());
        }

        // rInt Tests
        [Theory]
        [InlineData(1)]
        private void rInt_Equals(int i)
        {
            Assert.Equal(i, test.rInt());
        }

        [Theory]
        [InlineData(2)]
        private void rInt_NotEqual(int i)
        {
            Assert.NotEqual(i, test.rInt());
        }
    }
}
