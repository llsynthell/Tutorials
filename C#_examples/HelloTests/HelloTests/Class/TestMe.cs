using System;

namespace HelloTests.Class
{
    public class TestMe
    {
        static string myString;
        static int myInt;

        public TestMe()
        {
            myString = "Hello";
            myInt = 1;
        }

        public string rString()
        {
            return myString;
        }

        public int rInt(){
            return myInt;
        }
    }
}
