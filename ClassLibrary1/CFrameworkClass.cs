using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CFrameworkClass
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

        public static string getTest3()
        {
            string testC = "x";

            testC = (string)IIf(testC == "x", "test is x", "test is not x");

            return testC;
        }

        private static object IIf(bool Expression, object TruePart, object FalsePart)
        {
            object ReturnValue = Expression == true ? TruePart : FalsePart;

            return ReturnValue;
        }

        public static string getTest4()
        {
            string testC = "x";

            testC = (string)Microsoft.VisualBasic.Interaction.IIf(testC == "x", "test is x", "test is not x");

            return testC;
        }

    }

}


