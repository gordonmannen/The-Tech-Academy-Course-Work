using System;

public class Parent
{
    string parentString;
    public Parent()
    {
        Console.WriteLine("Parent Constructor Test.");
    }
    public Parent(string myString)
    {
        parentString = myString;
        Console.WriteLine(parentString);
    }
    public void print()
    {
        Console.WriteLine("Test Parent Class");
    }
}

public class Child : Parent
{
    public Child() : base("Derived Test")
    {
        Console.WriteLine("Child Constructor Test.");
    }
    public new void print()
    {
        base.print();
        Console.WriteLine("Test Child Class");
    }
    public static void Main()
    {
        Child child = new Child();
        child.print();
        ((Parent)child).print();
    }
}

