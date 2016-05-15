internal class Company
{
    public Address Address { get; set; }
}

public class Address
{
    public string City { get; set; }
}

    // Inside of a class...
    static void ThrowException()
    {
        try
        {
            ValidateInput("something", new Company());
        }
        catch (ArgumentNullException ex) when (ex.ParamName == "inputString")
        {
            Console.WriteLine("From ArgumentNullException: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("From ArgumentException: " + ex.Message);
        }
    }
    static void ValidateInput(string inputString, Company cmp)
    {
        if (inputString == null)
            throw new ArgumentNullException(nameof(inputString));
        if (cmp?.Address?.City == null)
            throw new ArgumentNullException(nameof(cmp));
    }

// The when clause is called an exception filter.

// C#'s structured exception handling feature uses a try-catch block.
// All the code to be monitored for exceptions goes in the try block.
// And the code that handles a potential exception goes in a catch block.

//Example

static void HandleNullReference()
        {
            Program prog = null;

                try
                {
                Console.WriteLine(prog.ToString());
                }
                catch (NullReferenceException ex)
                {


                Console.WriteLine(ex.Message);
                }
         }

// In C# if  you try and use a member of a null object, you'll get a NullReferenceException.
// To fix this assign a varlue to the variable.
// The body of the catch block is where you perform any exception handling.
// This can be customized to include multiple catch blocks.