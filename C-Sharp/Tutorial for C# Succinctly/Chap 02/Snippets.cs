﻿// These are snippets and notes

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
int val2 = ++val1;
int val3 = 2;
int val4 = val3--;

???????LEFT OFF HERE??????????
decimal priceGain = 2.5m;
string action = priceGain > 2m ? "Buy" : "Sell";

DateTime currentTime = DateTime.Now;
string shortDateString = currentTime.ToShortDateString();
string longDateString = currentTime.ToString();
DateTime tomorrow = currentTime.AddDays(1);

string name = "Joe";
string helloViaConcatenation = "Hello, " + name + "!";
Console.WriteLine(helloViaConcatenation);

string helloViaStringFormat = string.Format("Hello, {0}!", name);
Console.WriteLine(helloViaStringFormat);

Console.WriteLine("Hello, {0}!", name);

string item = "bread";
decimal amount = 2.25m;
Console.WriteLine("{0,-10}{1:C}", item, amount);

Console.WriteLine($"{item}      {amount}");
Console.WriteLine($"{nameof(item)}: {item,-10} {nameof(amount)}: {amount:C}");

string action2 = "Sell";
if (priceGain > 2m)
{
    action2 = "Buy";
}

string action3 = "Do Nothing";
if (priceGain <= 2m)
{
    action3 = "Sell";
}
else
{
    action3 = "Buy";
}

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

int[] oddNumbers = { 1, 3, 5 };
int firstOdd = oddNumbers[0];
int lastOdd = oddNumbers[2];

string[] names = new string[3];
names[1] = "Joe";

List<decimal> stockPrices = new List<decimal>();
stockPrices.Add(56.23m);
stockPrices.Add(72.80m);
decimal secondStockPrice = stockPrices[1];

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