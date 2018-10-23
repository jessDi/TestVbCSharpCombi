using System;
using Xunit;
using TestVbCSharpCombi;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            string test;
            test = CcoreClass.getTest();
            Assert.Equal("test is x", test);

        }

        [Fact]
        public void Test2()
        {

            string test;
            test = CcoreClass.getTest2();
            Assert.Equal("x", test);

        }
    }
}
