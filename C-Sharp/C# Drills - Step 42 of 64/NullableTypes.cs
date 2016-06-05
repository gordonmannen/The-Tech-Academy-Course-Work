// Creation of a nullable type
// A value type variable cannot be null.
// To accommodate times when you would want a value type to be able
// to hold null, Microsoft added the concept of Nullable type to the CLR.

struct B
{
    public void Display()
    {
        Console.WriteLine("Displaying from String B.");
    }
}

static void Main(string[] args)
{
    // SO to use null with string we need to create a nullabe type if B

    Nullable<B> b2 = null;

    if (b2 == null)
    {
        b2 = new B();
        //use 'b' here
        b2.Value.Display();

        // Now with struct it is also possible to assign null since it is nullable
        b2 = null;
    }
}