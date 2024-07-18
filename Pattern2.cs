using System;

public class PatternPrinter
{
    public void PrintPattern(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            // Print the leading spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print the numbers
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}

public class Pattern2
{
    public static void Main()
    {
        PatternPrinter printer = new PatternPrinter();
        printer.PrintPattern(5);
    }
}