using System;
using Xunit;
using ClassLibrary1;

namespace XUnitTestProject1
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {

            string test;
            test = CFrameworkClass.getTest();
            Assert.Equal("test is x", test);

        }

        [Fact]
        public void Test2()
        {

            string test;
            test = CFrameworkClass.getTest2();
            Assert.Equal("x", test);

        }

        [Fact]
        public void Test3()
        {

            string test;
            test = CFrameworkClass.getTest3();
            Assert.Equal("test is x", test);

        }

        [Fact]
        public void Test4()
        {

            string test;
            test = CFrameworkClass.getTest4();
            Assert.Equal("test is x", test);

        }
    }
}