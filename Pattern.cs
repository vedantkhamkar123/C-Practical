using System;

public class PatternPrinter
{
    public void PrintPattern(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

public class Pattern
{
    public static void Main()
    {
        PatternPrinter printer = new PatternPrinter();
        printer.PrintPattern(5);
    }
}