using System;

public class ProgrammerCalculator : Calculator
{
    public override double Add(double num1, double num2)
    {
        Console.WriteLine("ProgrammerCalculator Add called.");
        return MyMathLib.Add(num1, num2);
    }
}

public class MyMathLib
{
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}

public class ScientificCalculator : Calculator
{
    public override double Add(double num1, double num2)
    {
        Console.WriteLine("ScientificCalculator Add called.");
        return base.Add(num1, num2);
    }
}

// Enabling Polymorphism
// Polymorphism - lets derived classes specialize a base class implementation.

// The mechanism for polymorphism:  virtual modifier/override modifier.
// Polymorphism is 'opt-in' for C#.
// See above, use of base keyword.