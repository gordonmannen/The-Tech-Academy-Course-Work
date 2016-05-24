// Handling Delegates, Events, & Lambdas

// Referencing Methods with Delegates
// delegate capabilities in C#:  referencing methods, dispatching multiple methods,
// asynchronous execution, and event typing.
// note:  multi-cast & asynchronous execution are rarely used and largely replaced
// by other language features, async (C# v5.0), etc.

public delegate double Add(double num1, double num2);

// Looks like an abstract method, but has the delegate type definition keyword.
// delegate = reference type like a class, struct, or interface.
// delegate accessibility can only be public or internal and defaults to internal.
// delegate most practical use:  as event types.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main()
        {
        }
    }
}

// Firing Events
// Events are type members, an extremely common example within the UI would be a button click event.
// 1) A Button class is typically supplied by the UI.
// 2) An event member of the Button class = Clicked.
// 3) UI tracks when the Clicked event should fire.
// 4) The event has a delegate type.
// 5) Code defines a method to be called when that event fires.
// 6) Method written must have a signature that matches the delegate type of the event.  If they don't match
// the compiler won't let you assign that method to the delegate.


// Event
using System;
public class ClickEventArgs : EventArgs
{
    public string Name { get; set; }
}
public delegate void ClickHandler(object sender, ClickEventArgs e);

public class CalculatorButton
{
    public event ClickHandler Clicked;
}


// Example incorporating ClickEventargs/EventArgs
using System;

public class CalculatorButton
{
    public event ClickHandler Clicked;
    public void SimulateClick()
    {
        if (Clicked != null)
        {
            ClickEventArgs args = new ClickEventArgs();
            args.Name = "Add";

            Clicked(this, args);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Program prg = new Program();
        CalculatorButton calcBtn = new CalculatorButton();

        calcBtn.Clicked += new ClickHandler(prg.CalculatorBtnClicked);
        calcBtn.Clicked += prg.CalculatorBtnClicked;

        calcBtn.SimulateClick();

        Console.ReadKey();
    }

    public void CalculatorBtnClicked(object sender, ClickEventArgs e)
    {
        Console.WriteLine(
            $"Caller is a CalculatorButton: {sender is CalculatorButton} and is named {e.Name}");
    }
}

// You instantiate delegates with a method, which becomes the method the delegate refers to.

// External code can't fire an event, an event can only be fired from inside of its containing type.
// Alternatively to assigning named methods, you can instead assign code blocks directly to events.

// Working with Lambdas
// Lambda = a nameless method, also a sophisticated feature that can translate between parse trees & code.
// This is a core feature of LINQ (Language Integrated Query).

// Like methods, lambdas can have parameters, a body, and can return values.

// Lambda example with a single statement
using System;
public class Program
{
    public static void Main()
    {
        Action hello = () => Console.WriteLine("Hello!");
        hello();
        Console.ReadKey();
    }
}


// Lambda example with multiple statements
using System;
public class Program
{
    public static void Main()
    {
        Predicate<string> validator =
        word =>
        {
            int count = word.Length;
            return count > 3;
        };
        ValidateInput(validator);
        ValidateInput(word =>
        {
            int count = word.Length;
            return count > 3;
        });
        Console.ReadKey();
    }
    public static void ValidateInput(Predicate<string> validator)
    {
        string input = "Hello";
        bool isValid = validator(input);
        Console.WriteLine($"Is Valid: {isValid}");
    }
}

// .NET Framework's Predicate delegate (a generic delegage) is designed to return a bool.

// Another way to use lambdas is with events.
// Example using a different way to write the event handler method for the Clicked event.
using System;
public class Program
{
    public static void Main()
    {
        CalculatorButton calcBtn = new CalculatorButton();
        calcBtn.Clicked += (object sender, ClickEventArgs e) =>
        {
            Console.WriteLine(
            $"Caller is a CalculatorButton: {sender is CalculatorButton} and is
           named { e.Name}
            ");
        Console.WriteLine(message);
        };
        calcBtn.SimulateClick();
        Console.ReadKey();
    }
}

// Delegate assignment to the Clicked event is now a lambda.  If you have two or more parameters,
// they must be enclosed in parentheses as a comma-separated list.  If the body of the lambda includes
// two or more lines, they must be terminated with semicolons and enclosed in braces.

// The signature of the lambda matches the ClickEventHandler defined previously.

// More FCL Delegate Types
// Besides Action and Predicate<T>, there are some add'l delecates that you can reuse at will:
// Func<T, TResult> instead of Predicate<T>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    public static void Main()
    {
        Func<string, bool> validator =
        word =>
        {
            int count = word.Length;
            return count > 3;
        };
        ValidateInput(validator);
        ValidateInput(word =>
        {
            int count = word.Length;
            return count > 3;
        });
        Console.ReadKey();
    }
    public static void ValidateInput(Func<string, bool> validator)
    {
        string input = "Hello";
        bool isValid = validator(input);
        Console.WriteLine($"Is Valid: {isValid}");
    }
}

// The Predicate<T> delegate as defined in the FCL:
public delegate bool Predicate<T>(T obj);

// The Func<T, TResult> delegate as defined in the FCL:
public delegate TResult Func<T, TResult>(T arg);

// FCL offers 18 overloads of the Func delegate, allowing between 0 and 16 input parameters & 1 return parameter type.

// Expression-Bodied Members

// Not necessarily lambdas, expression-bodied members offer some shortened syntax for properties and methods.

// Example:
using System;
class Program
{
    public static string Today => DateTime.Now.ToShortDateString();
    public static void Log(string message) => Console.WriteLine(message);
    public static void Main()
    {
        Log($"{Today} is a good day.");
        Console.ReadKey();
    }
}




