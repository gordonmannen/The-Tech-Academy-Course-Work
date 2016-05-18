﻿using System;

public class Program
{
    public static void Main()
    {
        Calculator sciCalc = new ScientificCalculator();
        double sciCalcResult = sciCalc.Add(2, 5);
        Console.WriteLine($"Scientific Calculator 2 + 5: {sciCalcResult}");

        Calculator prgCalc = new ProgrammerCalculator();
        double prgCalcResult = prgCalc.Add(5, 10);
        Console.WriteLine($"Programmer Calculator 5 + 10: {prgCalcResult}");

        Console.ReadKey();
    }
}

/*The output will look like this:
 * ScientificCalculator Add called.
 * Calculator Add called.
 * Scientific Calculator 2 + 5: 7
 * ProgrammerCalculator Add called.
 * Programmer Calculator 5 + 10: 15*/