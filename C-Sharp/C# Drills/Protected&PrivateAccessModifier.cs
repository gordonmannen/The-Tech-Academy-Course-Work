using System;


// Access Modifiers:  public, protected, internal, private, & protected internal.

class A
{
    // protected variable
    protected int _x;
    private int _y;
}

class B : A
{
    public B()
    {
        // Able to access protected int, but not the private int
        Console.WriteLine(this._x);
    }
}

class Program
{
    static void Main()
    {
        B y = new B();
    }
}
