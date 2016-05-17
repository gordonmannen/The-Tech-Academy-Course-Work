// C# is an OOP language that supports in heritance, encapsulation,
// polymorphism, & abstraction.

// With C#, inheritance defines a relationship between two classes where
// a derived class can reuse members of a base class.

// the colon suffix is the inheritance operator to the derived class and
// what follows is the base class (parent).



using System;

public class Calculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}

public class ScientificCalculator : Calculator
{
    public double Power(double num, double power)
    {
        return Math.Pow(num, power);
    }
}

public class ProgrammerCalculator : Calculator
{
    public int Or(int num1, int num2)
    {
        return num1 | num2;
    }
}