// Access Modifiers & Encapsulation

// Sometimes classes will use only public methods, but at times you
// could be working with a class that is internal, and class members will
// default to private under this circumstance.

// Internal means that they can only be accessed by code from within the assembly
// that contains them.  Classes can be internal or public.

// Available access modifiers are:  public, private, internal, internal protected, & protected.
// The public and internal modifiers have the same meaning and impact for class members as for
// the classes themselves.

// Default modifier for class members is private, meaning that code outside the class cannot
// use the member.  This can be helpful for a modularized approach with a primary method which
// has been broken into a number of different supporting methods (but for whatever reason you
// do not want the supporting methods to have meaning/be usable outside of the class).

// protected modifier allows dervied classes inside and outside the assembly to use the
// protected base class member.

// internal protected (only derived classes from within the same assembly).

// Most of these access modifier defaults and behaviors also apply to struct types as well as classes.
// (except for protected/internal protected) 

// Struct:  Another C# type that looks similar to a class, but behaves differently.  A struct cannot derive
// from another class or struct.  Because it is not subject to inheritance, it also doesn't have protected
// or internal protected modifiers.  But it can have interface inheritance (see Exposing Interfaces section
// of chapter).  Another difference is that a struct copies by value while a class copies by reference.

// Many of the built-in types (int, double, char) are value types.



public struct Complex
{
    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public double Real { get; set; }

    public double Imaginary { get; set; }

    public static Complex operator +(Complex complex1, Complex complex2)
    {
        Complex complexSum = new Complex();

        complexSum.Real = complex1.Real + complex2.Real;
        complexSum.Imaginary = complex1.Imaginary + complex2.Imaginary;

        return complexSum;
    }

    public static implicit operator Complex(double dbl)
    {
        Complex cmplx = new Complex();
        cmplx.Real = dbl;

        return cmplx;
    }

    // this is not a safe operation
    public static explicit operator double(Complex cmplx)
    {
        return cmplx.Real;
    }
}