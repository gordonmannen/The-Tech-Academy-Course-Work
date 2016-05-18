using System;
using static MathOperation;

class Program
{
    static void Main()
    {
        string[] possibleOperations = Enum.GetNames(typeof(MathOperation));

        Console.Write($"Please select ({string.Join(", ", possibleOperations)}): ");

        string operationString = Console.ReadLine();

        MathOperation selectedOperation;

        if (!Enum.TryParse<MathOperation>(operationString, out selectedOperation))
            selectedOperation = MathOperation.Add;

        switch (selectedOperation)
        {
            case MathOperation.Add:
                Console.WriteLine($"You selected {nameof(Add)}");
                break;
            case MathOperation.Subtract:
                Console.WriteLine($"You selected {nameof(Subtract)}");
                break;
            case MathOperation.Multiply:
                Console.WriteLine($"You selected {nameof(Multiply)}");
                break;
            case MathOperation.Divide:
                Console.WriteLine($"You selected {nameof(Divide)}");
                break;
        }

        Console.ReadKey();
    }
}

// Enum - a value type that lets you create a set of strongly typed mnemonic values.
// Useful when you have a finite set of values and want an alternative to representing
// those as strings or numbers.

// enum is the keyword for this type definition.  For this example, there were four members
// (Add, Subtract, Multiply, & Divide).

// Some example Enum class methods:  Enum.GetNames (returns a string array), string.Join,
// Enum.TryParse, etc.  Also, switch statements can operate on numbers, strings, or enums.