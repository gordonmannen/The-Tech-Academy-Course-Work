// Creation of a nullable type
// A value type variable cannot be null.
// To accommodate times when you would want a value type to be able
// to hold null, Microsoft added the concept of Nullable type to the CLR.

struct X
{
    public void Display()
    {
        Console.WriteLine("Displaying from Struct X.");
    }
}

static void Main(string[] args)
{
    // To use null with string create a nullabe type if X

    Nullable<X> x1 = null;

    if (x1 == null)
    {
        x1 = new X();
        //use 'x' here
        x1.Value.Display();

        // With struct can assign null since it is nullable
        x1 = null;
    }
}