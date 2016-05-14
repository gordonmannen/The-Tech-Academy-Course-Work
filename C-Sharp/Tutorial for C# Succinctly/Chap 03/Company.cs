internal class Company
{
    public Address Address { get; set; }
}

public class Address
{
    public string City { get; set; }
}

// C#'s structured exception handling feature uses a try-catch block.

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