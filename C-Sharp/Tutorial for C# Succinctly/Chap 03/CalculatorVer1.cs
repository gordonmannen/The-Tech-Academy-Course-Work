using System;

class Calculator1
    // Performs a simple addition calculation and then stops running when this operation is complete.
{
    static void Main()
    {
        Console.Write("First Number: ");
        string firstNumberInput = Console.ReadLine();
        double firstNumber = double.Parse(firstNumberInput);

        Console.Write("Second Number: ");
        string secondNumberInput = Console.ReadLine();
        double secondNumber = double.Parse(secondNumberInput);

        double result = firstNumber + secondNumber;

        Console.WriteLine($"\n\tYour result is {result}.");

        Console.ReadKey();
    }
}

// \n in the interepolated string is a newline and \t is a tab.