// Exposing Interfaces
// If  you only wanted a base class that specified an interface for a common
// set of operations, you could create an abstract class with only abstract methods.
// Better alternative:  an interface.

// Benefit of an interface:  
// 1) Both class and struct types can inherit multiple interfaces.
// 2) Can also implement polymorphism with interfaces.
// 3) No implementation to worry about directly (it must be written in the derived class)


public interface ICalculator
{
    double Add(double num1, double num2);
}

// Example rewriting the previous samples as interfaces

public class ScientificCalculator : ICalculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}
public class ProgrammerCalculator : ICalculator
{
    public double Add(double num1, double num2)
    {
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