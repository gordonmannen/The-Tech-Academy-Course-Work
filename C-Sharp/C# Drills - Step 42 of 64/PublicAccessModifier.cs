using System;


// Access Modifiers:  public, protected, internal, private, & protected internal.


// Illustration of public access modifier
class PublicClassTest
{
    string parentString;
    public void PublicMethodTest()
    {
        // definition of PublicMethodTest
    }
}

// To access PublicMethodTest
class Program
{
    static void Main(strong[] args)
    {
        PublicClassTest objPublicClassTest = new PublicClassTest();

        objPublicClassTest.PublicMethodTest(); // no restrictions, should be able to access
    }
}

