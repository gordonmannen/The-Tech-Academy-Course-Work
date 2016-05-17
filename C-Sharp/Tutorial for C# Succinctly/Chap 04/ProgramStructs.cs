// Example of using Complex

using System;

class Program
{
    static void Main()
    {
        Complex complex1 = new Complex();
        complex1.Real = 3;
        complex1.Imaginary = 1;

        Complex complex2 = new Complex(7, 5);

        Complex complexSum = complex1 + complex2;

        Console.WriteLine(
            $"Complex sum - Real: {complexSum.Real}, " +
            $"Imaginary: {complexSum.Imaginary}");

        Complex complex3 = 9;

        // Complex to double is an explicit conversion operator in the Complex type.
        // Any time you have an explicit conversion, you must use a cast operator
        // (double)complex3 in this case.
        double realPart = (double)complex3;

        Console.ReadKey();
    }
}

// When working with value types there is a concept called boxing/unboxing.
// Boxing - occurs any time you assign a value type to an object.
// Unboxing - occurs when you assign object to a value type.


// Example
ArrayList intCollection = new ArrayList();
intCollection.Add(7);
int number = (int)intCollection[0];

// ArrayList is an old collection class and is no longer used in modern
// development (C# v2.0 introduced generics, which use new collection classes
// that are strongly typed and avoid the boxing/unboxing penalty/issues.

// Another difference between class(reference type) and struct(value types) is equality evaluation.
// Structs are considered equal if their values match, while classes are considered equal if they
// reference the same object in memory.