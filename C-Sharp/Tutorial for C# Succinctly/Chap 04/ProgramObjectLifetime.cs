﻿
// A program that instantiates the classes from CalculatorObjectLifetime.cs

using System;

class Program
{
    static void Main()
    {
        var calc1 = new ScientificCalculator();

        var calc2 = new ScientificCalculator(0, "x")
        {
            EndAngle = 360
        };

        ScientificCalculator calc3 = null;
        try
        {
            calc3 = new ScientificCalculator();
            // do stuff
        }
        finally
        {
            if (calc3 != null)
                calc3.Dispose();
        }

        using (var calc4 = new ScientificCalculator())
        {
            // do stuff
        }

        Console.ReadKey();
    }
}

// The program's output:

/*
static ScientificCalculator()
static Calculator()
public Calculator()
public ScientificCalculator(int)
public ScientificCalculator()
public Calculator(int)
public ScientificCalculator(int, string)
*/

// Order of exection

    /*
     * 1) Static constructors execute before instance constructors.
     * 2) Static consturctors only execute once for the life of the program.
     * 3) this operator causes an overloaded constructor that matches the this parameter list to execute first.
     * 4) Typically base class default constructor executes first unless the derived class uses base to
     * explicitly select a different base class constructor overload.
     * 5) Auto-implemented property initializers initialize at the same time as fields.
     * 6) Properties in object initialization syntax execute last.
     * 
     * Note - can set break points in the code in VS to inspect field values and gain a better feel for the
     * initialization sequence.
    */

// Of all the lifecycle events GC (garbage collection) is the least predictable.
// Ties into the 'Dispose Pattern'.  Which relies on the IDisposable interface.

using System;
public class Calculator : IDisposable
{
    static Calculator()
    {
        // Initialize log file stream.
    }
    #region IDisposable Support
    private bool disposedValue = false; // To detect redundant calls.
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
                // Close log file stream.
            }
            // TODO: free unmanaged resources (unmanaged objects) and override a
            finalizer below.
 // TODO: set large fields to null.
 disposedValue = true;
        }
    }
    // TODO: override a finalizer only if Dispose(bool disposing) above has code to
    free unmanaged resources.
 // ~Calculator() {
 // // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
 // Dispose(false);
 // }
 // This code added to correctly implement the disposable pattern.
 public void Dispose()
    {
        // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        Dispose(true);
        // TODO: uncomment the following line if the finalizer is overridden above.
        // GC.SuppressFinalize(this);
    }
    #endregion
}

// The code between #region and #endregion is automatically generated by VS.
// See Quick Action Menu in VS.

    // example using Dispose


ScientificCalculator calc3 = null;

try
 {
 calc3 = new ScientificCalculator();
 // Do stuff.
 }
 finally
 {
 if (calc3 != null)
 calc3.Dispose();
 }

    // simplified

using (var calc4 = new ScientificCalculator())
 {
 /