using System;

namespace TestVbCSharpCombi
{
    public class CcoreClass
    {
        public static string getTest()
        {
            string testC;

            var test = VbLibrary1.VbClass.getSelection();
            //testC = VbLibrary1.VbClass.getSelection();
            testC = test;
            return testC;
        }

        public static string getTest2()
        {
            string testC;
                        
            testC = VbLibrary1.VbClass.getSelection2();
        
            return testC;
        }

    }
}