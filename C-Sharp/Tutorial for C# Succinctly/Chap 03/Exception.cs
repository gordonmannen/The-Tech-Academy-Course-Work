static void HandleUncaughtException()
{
    Program prog = null;
    try
    {
        Console.WriteLine(prog.ToString());
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine("From ArgumentNullException: " + ex.Message);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("From ArgumentException: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("From Exception: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("Finally always executes.");
    }
}

// The method is HandleCaughtException because there is not a dedicated catch
// block to handle a NullReferenceException > the exception will be handled instead
// by the catch block for the Exception type.

    // List exceptions by their inheritance hierarchy, with top-level exception in the
    // list of catch blocks.

    // the exception runs down the list until it finds a match.
    // If no catch block can handle the exception type, the call stack is unable to handle
    // the exception, and the program will terminate.
    // Alternatively a finally block can be used.