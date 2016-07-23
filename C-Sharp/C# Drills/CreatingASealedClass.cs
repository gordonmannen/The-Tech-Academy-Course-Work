using System;


// A sealed class cannot be derived from, it is used in some instances
// where it can be used to optimize method invocations and therefore improve
// performance.
// So a sealed class cannot be used as a base class as derivation is prevented.

class A
{
    public void Display()
}


class A : sealed class B
{
    // The sealed class B can derive from class A, but it would not work the other way around, because of the 'sealed' keyword.
}