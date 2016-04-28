using System;

namespace Program1
{
    class Program
    {
        // This is where your program starts.
        static void Main(string[] args)
        {
            // Prompt user to enter a name.
            Console.WriteLine("Enter your name, please:");

            // Now read the name entered.
            string name = Console.ReadLine();

            // Greet the user with the name that was entered.
            Console.WriteLine("Hello, " + name);

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}

//#region Public methods
//... your code
//#endregion Public methods
// for creating your own regions that you can expand and collapse.

// in general // or /// are equivalent and used to comment out text.

// C# Code Snippets > Ctrl + K and then Ctrl + X for a pop-up menu
// of snippets.  Tab once or twice as needed and then enter for your
// selection.  Once  you have some of the shortcuts memorized type
// them (ex cw, for, if, etc. and Tab twice).

// Drag and drop or copy and paste snippets/sections of code to the toolbox
// for use later or in a different program file.
