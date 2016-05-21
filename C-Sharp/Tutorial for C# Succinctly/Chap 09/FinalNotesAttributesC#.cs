// Moving Forward and More Things to Know
// Decorating Code with Attirbutes

// Obsolete attribute example

using System;
public class ShoppingCart
{
    [Obsolete("Method planned for deprecation on date – use … instead.")]
    public void Add(string item) { }
    [Obsolete("Method is obsolete and can no longer be used", error: true)]
    public decimal CalculateTax(decimal[] prices) { return 0; }
}

// Essentially allows the C# compiler to recognize that a certain piece of code is no longer allowed
// and will pop up with a message (with a warning or as an error and won't allow compile to complete.
// see second paramter above "...., error:  true", the first parameter is a warning, but this second
// paramter is what stops the compiler if an error is identified.

// Example using attributes for a unit test with MSTest, Microsoft's unit testing software.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

// MSTest executes methods with the TestMethod attribute, it does so with another C# capability -- reflection.

// Reflection gives you the ability to:
// 1) Examine compiled .NET code.
// 2) Build useful tools like MSTest
// 3) Dynamically instantiate types and execute their code
// 4) and more...

// Example using reflection to dynamically instantiate a type and execute one of its methods:
using System.Linq;
using System;
using System.Reflection;
public class FinancialCalculator
{
    public decimal Sum(decimal[] numbers)
    {
        return numbers.Sum();
    }
}
public class Program
{
    public static void Main()
    {
        decimal[] prices = { 1m, 2m, 3m };
        Type calcType = typeof(FinancialCalculator);
        MethodInfo sumMethod = calcType.GetMethod("Sum");
        FinancialCalculator calc =
        (FinancialCalculator)Activator.CreateInstance(calcType);
        decimal sum = (decimal)sumMethod.Invoke(calc, new object[] { prices });
        Console.WriteLine($"Sum: {sum}\nPress any key to continue.");

        Console.ReadKey();
    }
}

// With reflection you can call GetMethods, GetProperties, or GetFields to get an array of
// MethodInfo, PropertyInfo, or FieldInfo respectively.  And so on...

// Workign with Code Dynamically
// Dynamic type > purpose:  to allow you to interoperate with dynamic languages.
// For example:  IronPython, IronRuby, etc., and it makes reflections easier.
// Additionally MS Silverlight or HTML 5 could be used.

// The dynamic type lets you assign a value to a dynamic variable and use any typed members
// on that variable.

// Example using dynamic
using System;
using System.Reflection;
public class Program
{
    public static void Main()
    {
        decimal[] prices = { 1m, 2m, 3m };
        Type calcType = typeof(FinancialCalculator);
        MethodInfo sumMethod = calcType.GetMethod("Sum");
        dynamic calc = Activator.CreateInstance(calcType);
        dynamic sum = calc.Sum(prices);
        Console.WriteLine($"Sum: {sum}\nPress any key to continue.");
        Console.ReadKey();
    }
}

// Pro of dynamic type:  coding flexibility, errors are handled by the CLR at runtime.
// Con of dynamic type:  It offers no indication of type-related errors until runtime.


// Improved algorithm from previous example:
using System;
public class Program
{
    public static void Main()
    {
        decimal[] prices = { 1m, 2m, 3m };
        decimal sum = GetSum<FinancialCalculator, decimal>(prices);
        Console.WriteLine("Sum: {0}\nPress any key to continue.", sum);
        Console.ReadKey();
    }
    public static TValue GetSum<TCalc, TValue>(TValue[] prices)
    where TCalc : new()
    {
        dynamic calc = new TCalc();
        TValue sum = calc.Sum(prices);
        return sum;
    }
}