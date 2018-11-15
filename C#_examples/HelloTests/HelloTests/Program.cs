using System;

using HelloTests.Class;

namespace HelloTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestMe myVariable = new TestMe();

            Console.WriteLine(myVariable.rString());
        }
    }
}
