interface ITest

// An interface can be a member of a namespace or class and can contain signatures
// of methods, properties, indexers, and events.  An interface can also inherit from
// one or more base interfaces.

{
    // Property signatures
    int x
    {
        get;
        set;
    }

    int y
    {
        get;
        set;
    }
}

class Test : ITest
{
    // Fields
    private int _x;
    private int _y;

    // Constructor
    public Test(int x, int y)
    {
        _x = x;
        _y = y;
    }

    // Property implementation:
    public int x
    {
        get
        {
            return _x;
        }

        set
        {
            _x = value;
        }
    }

    public int y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
        }
    }
}

class MainClass
{
    static void PrintTest(ITest p)
    {
        Console.WriteLine("x={0}, y={1}", p.x, p.y);
    }

    static void Main()
    {
        Test p = new Test(10, 100);
        Console.Write("My Interface Test: ");
        PrintTest(p);
        Console.Read();
    }
}
