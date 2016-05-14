// What if we wanted to reuse the calculator functions in that class and wanted
// the new class to hold its own values, or state?  Move the calculator methods
// into a separate Calculator class.

// To get to the state of the class (read the result from the Calculator class):

// 1) Use a method named GetResult that returns the value.
// 2) Another option with C# is to use a property.  Like a field, but it works like a method.


using System;

public class Calculator4
{

    double[] numbers = new double[2];

    public double First
    {
        get
        {
            return numbers[0];
        }
    }

    public double Second
    {
        get
        {
            return numbers[1];
        }
    }

    //double result;

    //public double Result
    //{
    //    get { return result; }
    //    set { result = value; }
    //}

    public double Result { get; set; }

    public void GetNumber(string whichNumber)
    {
        Console.Write($"{whichNumber} Number: ");
        string numberInput = Console.ReadLine();
        double number = double.Parse(numberInput);

        if (whichNumber == "First")
            numbers[0] = number;
        else
            numbers[1] = number;
    }

    public void AddNumbers()
    {
        Result = First + Second;
    }

    public void PrintResult()
    {
        Console.WriteLine($"\nYour result is {Result}.");
    }
}

// First, Second, & Result are properties.  AddNumbers & PrintResults are the Methods.
// AddNumbers reads the values of First and Second and adds those values together
// writes to Result.

// Result is a typical R/W property with get and set accessors.  When read the
// get accessor executes, when written the set accessor executes.

// This pattern of R/W from a single backing store is so common that C# has a
// shortcut syntax:

    // public double Result { get; set; }
