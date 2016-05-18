// Writing Abstract Classes
// Modify the existing class to become an abstract class rather than using a base class
// and applying functionality and enabling polymorphism for the 'children' of the base.

public abstract class Calculator
{
    // ...
    public abstract double Add(double num1, double num2);
}

// In an abstract class you can have virtual OR non-virtual members.  And can have abstract methods (lacks
// an implementation).  Abstract methods specifiy an interface that derived classes must implement.
// See example above.
// When an abstract class has abstract methods, all derived classes must <override> the abstract method.

// In C# a class can have only one base class.  And a struct cannot inherit another class or struct.


