// Enumeration - a form of syntactic sugar, makes programs cleaner & easier to read.
// Also causes no slowndown at runtime, so it is efficient.

using System;

class Program
{
    enum Rank
    {
        Unranked,
        Novice,
        Apprentice,
        Journeyman,
        Adept,
        Veteran,
        Expert,
        JuniorMaster,
        Master,
        Grandmaster
    };

    static void Main()
    {
        Rank value = Rank.Grandmaster;

        if (value == Rank.Novice)
        {
            Console.WriteLine("False");
        }
        else if (value == Rank.Grandmaster)
        {
            Console.WriteLine("True");
        }
    }
}

