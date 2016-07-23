// Abstract class

// An abstract class is a special type of class that cannot be instantiated.
// However, it should be inherited by its subclasses.  Can be partially
// implemented or not at all.  Can have functionality, the methods can be both
// abstract and concrete.  Can have constructors (this is a major difference
// between abstract class and interface.

// Abstract class can contain method definitions, fields, and
// also constructors.

using System;

namespace AbstractClass
{
    public abstract class AbstracTest
    {

        // fields and properties

        protected String account;

        // proerties

        public abstract String ACCOUNT
        {
            get;
            set;
        }

        // completed methods

        public String Update()
        {
            return "Account " + " " + " updated";
        }

        public String Add()
        {
            return "Account " + " " + " added";
        }

        public String Delete()
        {
            return "Account " + " " + " deleted";
        }

        public String Query()
        {
            return "Account " + " " + " located";
        }

        public abstract String CalculateDailySales();

    }
}

// ----------------------------------------------------------
// Interface

// Interface is essentially a contract, it doesn't have any implementation.
// Can contain only method declaration, cannot contain method definition.
// It cannot contain any member data.  It can include declaration of events,
// methods, and properties.  Like abstract class, an interface cannot be
// instantiated.

// Methods declared should be implemented by the classes that implement the
// interface.  

using System;

namespace Interface
{
    public interface IInterface
    {

        // cannot have fields, just signature of the properties & methods

        String ACCOUNT
        {
            get;
            set;
        }

        // cannot have implementation

        String Update();

        String Add();

        String Delete();

        String Query();

        String CalculateDailySales();

    }
}