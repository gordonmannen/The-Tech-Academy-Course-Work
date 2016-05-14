// This is an example of refactoring - changing the design of the code
// without changing its functionality with the purpose of improving the program.
// He's a first draft of the process of refactoring the previous program into methods.

using System;

class Calculator2
{
    static void Main()
    {
        double firstNumber = GetFirstNumber();

        double secondNumber = GetSecondNumber();

        double result = AddNumbers(firstNumber, secondNumber);

        PrintResult(result);

        Console.ReadKey();
    }

    static double GetFirstNumber()
    {
        Console.Write("First Number: ");
        string firstNumberInput = Console.ReadLine();
        double firstNumber = double.Parse(firstNumberInput);
        return firstNumber;
    }

    static double GetSecondNumber()
    {
        Console.Write("Second Number: ");
        string secondNumberInput = Console.ReadLine();
        double secondNumber = double.Parse(secondNumberInput);
        return secondNumber;
    }

    static double AddNumbers(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }

    static void PrintResult(double result)
    {
        Console.WriteLine($"\nYour result is {result}.");
    }
}

// Three methods > GetFirstNumber, GetSecondNumber, & AddNumbers each 
// return values that are assigned to variables, and the fourth method
// PrintResult performs an action without returning a result.
// static >void<, this is the keyword that indicates it does not have a return type.