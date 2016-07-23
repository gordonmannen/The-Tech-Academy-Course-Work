using System;

class OverloadTest
{
        static void Test (int x)
        {
            Console.WriteLine("Test(int x)");
        }
        
        static void Test (string y)
        {
            Console.WriteLine("Test(string y)");
        }

        static void Main()
        {
            Test("text");
        }
}

// This returns string y because there is no implicit string conversion
// for string ("text") to int, so int x is ignored.