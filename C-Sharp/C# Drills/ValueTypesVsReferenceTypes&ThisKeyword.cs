// Value Types - struct, enumeration, and primitive types such as int, float, bool, & char.
// Reference Types - Class, string, object, etc.

// Value Type Example
// The struct as a value type can be found in a specific location in memory.
// This can make processing a value type very efficient.


struct ExStruct
{
    private int x, y;                // fields

    public ExStruct (int x, int y)   // constructor
    {
        this.x = x;
        this.y = y;
    }

    public int X                     // property
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }
}

// Reference Type Example
// The reference type provides a reference separate from the object in memory.

class ExClass
{
    private int x, y;                // fields

    public ExClass(int x, int y)   // constructor
    {
        this.x = x;
        this.y = y;
    }

    public int X                     // property
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }
}

// "this" keyword (see above) is a special type of reference variable,
// which is implicitly defined and is the first parameter of the type class
// in which its defined.  It is 'fairly' similar to Python's "self".