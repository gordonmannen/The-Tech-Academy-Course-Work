// These are snippets and notes

int count = 7;
char keyPressed = 'Q';
string title = "Weekly Report";


// Above the variable is declared & assigned simultaneously, but alternatively
// it can be declared & assigned separately, but the declaration must come first.
string title;
title = "Weekly Report";

// C# is case sensitive, so "title" and "Title" are two separate variable names.

// C# is a strongly typed language, so the compiler won't implicitly convert
// between incompatible types.
    

// This wouldn't compile    
int total = "359";
string message = 7;


// But this would
int total = int.Parse("359");
string message = 7.ToString();

double preciseLength = 5.61;
int roundedLength = (int)preciseLength;

decimal price = 9.95m;
// the m suffix ensures the 9.95 literal is treated as a decimal number.

// Assigns Unicode values directly to the char.  Assign a carriage return.
char cr = '\u0013';

// Alternatively, can obtain the Unicode value of a char with a cast operator.
int crUnicode = (int)cr;


// Prefix operators change the value of the variable before assignment, and postfix
// operators change a variable after assignment.
int val1 = 5;
int val2 = ++val1; // val1 & val2 are now 6
int val3 = 2;
int val4 = val3--; // val3 is now 1, val4 is 2


// The ternary operator offers simple syntax for if-then-else logic.
decimal priceGain = 2.5m;
string action = priceGain > 2m ? "Buy" : "Sell";
// In this case "Buy" gets assigned to string action.

// There are also built-in types in the FCL, such as DateTime.
DateTime currentTime = DateTime.Now;
string shortDateString = currentTime.ToShortDateString();
string longDateString = currentTime.ToString();
DateTime tomorrow = currentTime.AddDays(1);
// Before creating your own library, search the FCL as many common types
// have already been created.

int result1 = 2 + 3 * 5; // 17
int result2 = (2 + 3) * 5; // 25
// Operator precedence & associativity
// assignment and conditional operators are right-associative and all others
// are left-associative.

// Different ways to build and format strings in C#:
// concatenation, numeric format strings, or string interpolation.
string name = "Joe";
string helloViaConcatenation = "Hello, " + name + "!";
Console.WriteLine(helloViaConcatenation); // Prints "Hello, Joe!" to the console.

string helloViaStringFormat = string.Format("Hello, {0}!", name);
Console.WriteLine(helloViaStringFormat);  // as above, but using string.Format.

Console.WriteLine("Hello, {0}!", name); // an alternative way to do it.

// String formatting is more powerful, it also allows you to specify column lengths, alignment,
// and value formatting.
string item = "bread";
decimal amount = 2.25m;
Console.WriteLine("{0,-10}{1:C}", item, amount);
// The placeholder consumes 10 chars in length.  The default alignment is right, but the
// minus sign changes that to align to the left.  On the second placeholder, the C is a
// currency format string.

// Example of string interpolation, which was a introduced with C# as a new means of
// formatting strings.  It is a shorthand syntax that lets you replace numeric placeholders
// with expressions:
Console.WriteLine($"{item}      {amount}");
// The $ prefix is required.  Here, the value from the item variable replaces {item} and the
// value from the amount variable replaces {amount}.  Like numeric placeholders you can include
// additional formatting.
Console.WriteLine($"{nameof(item)}: {item,-10} {nameof(amount)}: {amount:C}");

// Branching Statements - Use either an if-else OR switch statement for branching logic.
// If the true condition is the only path that needs to be covered by the code, use something
// like the first example below.
string action2 = "Sell";
if (priceGain > 2m)
{
    action2 = "Buy";
}

// The curly braces are optional when there is only one statement to execute if priceGain > 2m.
// However, the curly braces are required for multiple statements.  This applies to all branching
// and logic statements.
string action3 = "Do Nothing";
if (priceGain <= 2m)
{
    action3 = "Sell";
}
else
{
    action3 = "Buy";
}

// Multiple conditions with more else if clauses.
string action4 = null;
if (priceGain <= 2m)
{
    action4 = "Sell";
}
else if (priceGain > 2m && priceGain <= 3m)
{
    action4 = "Do Nothing";
}
else
{
    action4 = "Sell";
}

// When you have multiple caes and all expressions are constant values, such as an int or string,
// you might prefer to use a switch statement.
string currentWeather = "rain";
string equipment = null;
switch (currentWeather)
{
    case "sunny":
        equipment = "sunglasses";
        break;
    case "rain":
        equipment = "umbrella";
        break;
    case "cold":
    default:
        equipment = "jacket";
        break;
}

// Arrays & Collections
int[] oddNumbers = { 1, 3, 5 };
int firstOdd = oddNumbers[0];
int lastOdd = oddNumbers[2];

// Declaring an array with three values and initialized the second value as "Joe".
string[] names = new string[3];
names[1] = "Joe";


List<decimal> stockPrices = new List<decimal>();
stockPrices.Add(56.23m);
stockPrices.Add(72.80m);
decimal secondStockPrice = stockPrices[1];

// Looping Statements
// C# supports a number of different loops including for, foreach, while, and do.
double[] temperatures = { 72.3, 73.8, 75.1, 74.9 };
for (int i = 0; i < temperatures.Length; i++)
{
    Console.WriteLine(i);
}

foreach (int temperature in temperatures)
{
    Console.WriteLine(temperature);
}

int tempCount = 0;
while (tempCount < temperatures.Length)
{
    Console.WriteLine(tempCount);
    tempCount++;
}

int tempCount2 = 0;

do
{
    Console.WriteLine(tempCount2++);
}
while (tempCount2 <= temperatures.Length);